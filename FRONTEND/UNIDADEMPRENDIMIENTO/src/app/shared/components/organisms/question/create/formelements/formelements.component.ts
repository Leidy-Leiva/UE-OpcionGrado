import {Component,ComponentRef,EventEmitter,inject,Input,OnChanges,OnInit,Output,SimpleChanges,ViewChild,ViewContainerRef} from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelwithinputComponent } from '../../../../molecules/labelwithinput/labelwithinput.component';
import { ElementtypeService } from 'src/app/core/services/element-type.service';
import { LabelwithdropdownComponent } from '../../../../molecules/labelwithdropdown/labelwithdropdown.component';
import { QuestionElementMapper } from 'src/app/shared/mappers/question/question-elements.mapper';

@Component({
  selector: 'app-form-elements',
  standalone: true,
  imports: [CommonModule, LabelwithdropdownComponent, LabelwithinputComponent],
  templateUrl: './formelements.component.html',
  styleUrls: ['./formelements.component.scss'],
})
export class FormElementsComponent implements OnInit, OnChanges {
  @Input() initialData?: {
    tipo: string;
    pregunta: string;
    options?: string[];
  };

  private questionService = inject(ElementtypeService);

  questionOptions: { value: string; label: string }[] = [];
  selectedType: string = '';
  questionText: string = '';
  currentComponentRef: ComponentRef<any> | null = null;
  currentOptions: string[] = [];

  @Output() questionCreated = new EventEmitter<{
    type: string;
    questionText: string;
    options?: string[];
    selected?: string | string[];
  }>();

  @ViewChild('dynamicComponentContainer', { read: ViewContainerRef })
  dynamicComponentContainer!: ViewContainerRef;

  ngOnInit() {
    this.loadQuestionOptions();
  }

  private loadQuestionOptions() {
    this.questionService.getTipoElementos().subscribe({
      next: (data: any[]) => {
        this.questionOptions = data.map((item) => ({
          value: item.tpeF_NOMBRE,
          label: item.tpeF_NOMBRE,
        }));
        console.log('Opciones construidas:', this.questionOptions);
      },
      error: (err) =>
        console.error(
          'Error cargando las opciones de elemento formulario:',
          err
        ),
    });
  }
  ngOnChanges(changes: SimpleChanges) {
    if (changes['initialData'] && this.initialData) {
      this.selectedType = this.initialData.tipo;
      this.questionText = this.initialData.pregunta;
      // carga el selector adecuado
      this.loadQuestionComponent(this.selectedType).then(() => {
        // si tenía opciones, asígnalas
        const inst: any = this.currentComponentRef!.instance;
        if (this.initialData!.options && inst.options !== undefined) {
          inst.options = [...this.initialData!.options];
        }
        // emite el estado inicial
        this.emitQuestionData();
      });
    }
  }

  onSelectionChange(selected: string) {
    console.log('Tipo seleccionado:', selected);
    this.selectedType = selected;
    this.loadQuestionComponent(selected);
    this.emitQuestionData();
  }

  onQuestionChange(newValue: string) {
    console.log('Pregunta ingresada:', newValue);
    this.questionText = newValue;
    this.emitQuestionData();
  }

  emitQuestionData() {
    this.questionCreated.emit({
      type: this.selectedType,
      questionText: this.questionText,
      options: this.currentOptions || [],
      selected: this.selectedType === 'Multiple' ? [] : '',
    });
  }

  async loadQuestionComponent(type: string) {
    this.dynamicComponentContainer.clear();

    const loader = QuestionElementMapper[type];

    if (!loader) {
      console.warn(`Tipo de componente no soportado: ${type}`);
      return;
    }

    try {
      const componentType = await loader();
      const cmpRef =
        this.dynamicComponentContainer.createComponent(componentType);
      this.currentComponentRef = cmpRef;

      const inst: any = cmpRef.instance;

      if (inst.optionsChange?.subscribe) {
        inst.optionsChange.subscribe((opts: string[]) => {
          this.currentOptions = opts; // ahora el padre tiene siempre lo último
          this.emitQuestionData();
        });
      }

      if (inst.selectedChange?.subscribe) {
        inst.selectedChange.subscribe((sel: string[]) => {
          inst.selected = sel; // actualiza la selección del hijo
          this.emitQuestionData();
        });
      }

      // Emitimos estado inicial tras cargar el componente
      this.emitQuestionData();
    } catch (error) {
      console.error('Error al cargar componente dinámico:', error);
    }
  }
}

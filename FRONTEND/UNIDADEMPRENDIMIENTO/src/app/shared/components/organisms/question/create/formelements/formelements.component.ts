import { Component, ComponentRef, EventEmitter, inject, OnInit,Output,ViewChild, ViewContainerRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelwithinputComponent } from '../../../../molecules/labelwithinput/labelwithinput.component';
import { ElementtypeService } from 'src/app/core/services/element-type.service';
import { LabelwithdropdownComponent } from '../../../../molecules/labelwithdropdown/labelwithdropdown.component';
import { QuestionElementMapper } from 'src/app/shared/mappers/question/question-elements.mapper';
import { LabelComponent } from "src/app/shared/components/atoms/label/label.component";

@Component({
  selector: 'app-form-elements',
  standalone: true,
  imports: [CommonModule, LabelwithdropdownComponent, LabelwithinputComponent],
  templateUrl: './formelements.component.html',
  styleUrls: ['./formelements.component.scss']
})
export class FormElementsComponent implements OnInit {

 private questionService= inject (ElementtypeService);
  questionOptions: { value: string; label: string }[] = [];
  selectedType: string = '';
  questionText: string = '';
  currentComponentRef: ComponentRef<any> | null = null;

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

 private loadQuestionOptions(){
  this.questionService.getTipoElementos().subscribe({
    next:(data: any[]) => {
      this.questionOptions = data.map(item => ({
        value: item.tpeF_NOMBRE,
        label: item.tpeF_NOMBRE
      }));
      console.log("Opciones construidas:", this.questionOptions);
    },
    error:(err)=>console.error("Error cargando las opciones de elemento formulario:", err)
  });
}


  onSelectionChange(selected: string) {
    console.log("Tipo seleccionado:", selected);
    this.selectedType = selected;
    this.loadQuestionComponent(selected);
    this.emitQuestionData();
  }

  onQuestionChange(newValue: string) {
    console.log('Pregunta ingresada:', newValue);
    this.questionText = newValue;
    this.emitQuestionData();
  }

  emitQuestionData(){
    const inst: any = this.currentComponentRef?.instance;
    const options  = Array.isArray(inst?.options)  ? inst.options  : [];

    this.questionCreated.emit({
      type:this.selectedType,
      questionText:this.questionText,
      options:options,
      selected:this.selectedType==='Multiple'?[]:'',
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
      const cmpRef = this.dynamicComponentContainer.createComponent(componentType);
      this.currentComponentRef = cmpRef;

      const inst: any = cmpRef.instance;

      // Suscripción a changes de opciones
      if (inst.optionsChange?.subscribe) {
        inst.optionsChange.subscribe(() => this.emitQuestionData());
      }
      // Suscripción a changes de selección
      if (inst.selectedChange?.subscribe) {
        inst.selectedChange.subscribe(() => this.emitQuestionData());
      }

      // Emitimos estado inicial tras cargar el componente
      this.emitQuestionData();

    } catch (error) {
      console.error('Error al cargar componente dinámico:', error);
    }
  }
}

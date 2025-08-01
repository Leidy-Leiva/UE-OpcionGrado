import {Component,Input,Output,EventEmitter,ViewChild,ViewContainerRef,ComponentRef,OnChanges,SimpleChanges,} from '@angular/core';
import { CommonModule, provideCloudinaryLoader } from '@angular/common';
import { ButtonwithicongroupComponent } from '../../../../shared/components/organisms/buttonwithicongroup/buttonwithicongroup.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { ButtonsFormService } from '../../Services/buttons-form.service';
import { WrapperComponent } from 'src/app/shared/components/organisms/wrapper/wrapper.component';
import { ElementsFormMapper } from 'src/app/shared/mappers/generate-forms.mapper';
import { GetTableformComponent } from '../Table/get-tableform/get-tableform.component';
import { TableFormBuilderComponent } from '../Table/table-form-builder/table-form-builder.component';
import { GetSectionComponent } from '../Section/get-section/get-section.component';
import { SectionComponent } from '../Section/create-section/create-section.component';
import { ElementsViewMapper } from 'src/app/shared/mappers/elements-view.mapper';
import { FormElement } from 'src/app/shared/models/FormElement-config';
import { FormElementsComponent } from 'src/app/shared/components/organisms/question/create/formelements/formelements.component';
import { GetFormElements } from 'src/app/Features/generateElements/get/page/get-form-elements/get-form-elements.page';
import { GetFormElementsComponent } from 'src/app/shared/components/organisms/question/view/get-form-elements/get-form-elements.component';

@Component({
  selector: 'app-formbuilder',
  standalone: true,
  imports: [CommonModule, ButtonwithicongroupComponent],
  templateUrl: './formbuilder.component.html',
  styleUrls: ['./formbuilder.component.scss'],
})
export class FormbuilderComponent implements  OnChanges {
  @Input() typeForm: string = '';
  @Input() questions: FormElement[] = []; 
  typeDefault:string="";
  definitionByType: Record<string, any> = {};
  @Output() btnClick = new EventEmitter<string>();

  private lastWrapperRef: ComponentRef<WrapperComponent> | null = null;
  private lastType: string | null = null;

  @ViewChild('wrappersContainer', { read: ViewContainerRef, static: true })
  wrappersContainer!: ViewContainerRef;

  buttonOptionForm: ButtonWithIconConfig[] = [];

  constructor(private buttonsFormService: ButtonsFormService) {}

  async ngOnChanges(changes: SimpleChanges) {
    if (changes['typeForm'] && this.typeForm) {
      this.loadButton();
    }

     if (changes['questions'] && this.questions?.length > 0) {
    for (const pregunta of this.questions) {
      // 1) crear wrapper
      const wr = this.wrappersContainer.createComponent(WrapperComponent);
      wr.instance.delete.subscribe(() => wr.destroy());
      // 2) renderizar en modo view pasándole la pregunta
      await this.renderMode(wr, 'Crear_Pregunta', 'view', pregunta);
    }
    // opcional: limpia para no duplicar
    this.questions = [];
  }
}

  private loadButton(): void {
    this.buttonOptionForm = this.buttonsFormService.getButtonsTypeForm(
      this.typeForm
    );
  }

  async Action(type: string) {
    this.btnClick.emit(type);

    if (this.lastWrapperRef && this.lastType) {
      await new Promise((resolve) => setTimeout(resolve, 100));
      await this.renderMode(this.lastWrapperRef, this.lastType, 'view');
    }

    const newWrapper = this.wrappersContainer.createComponent(WrapperComponent);
    this.lastWrapperRef = newWrapper;
    this.lastType = type;

    newWrapper.instance.delete.subscribe(() => {
      newWrapper.destroy();
      if (this.lastWrapperRef === newWrapper) {
        this.lastWrapperRef = null;
        this.lastType = null;
      }
    });

    await this.renderMode(newWrapper, type, 'create');
  }

  private async renderMode(
    wrapperRef: ComponentRef<WrapperComponent>,
    type: string,
    mode: 'create' | 'view' | 'edit',
    tpreguntas?:FormElement
  ) {
    console.log(`[Formbuilder] renderMode: type='${type}' mode='${mode}'`);

    wrapperRef.instance.mode = mode;
    wrapperRef.instance.viewContainer.clear();

    const mapper = mode === 'create' ? ElementsFormMapper : ElementsViewMapper;
    const loader = mapper[type];
    if (!loader) return;
    const compType = await loader();
    const compRef = wrapperRef.instance.viewContainer.createComponent(compType);

    if (type === 'Tabla') {
      const createCmp = compRef.instance as TableFormBuilderComponent;
      const viewCmp = compRef.instance as GetTableformComponent;

      if (mode === 'create') {
        createCmp.formDefinition.subscribe((def) => {
          this.definitionByType['Tabla'] = {
            ...this.definitionByType['Tabla'],
            columns: def.columns,
            rows: def.rows,
          };
        });
        createCmp.questionChange.subscribe((enunciado) => {
          this.definitionByType['Tabla'] = {
            ...this.definitionByType['Tabla'],
            enunciado,
          };
        });
      } else {
        const def = this.definitionByType['Tabla'] ?? {
          enunciado: '',
          columns: [{ key: 'col1', label: 'Columna 1' }],
          rows: [{ label: 'Fila 1' }],
        };
        viewCmp.enunciado = def.enunciado;
        viewCmp.columns = def.columns;
        viewCmp.rows = def.rows;
      }
    } else if (type === 'Seccion') {
      const createCmp = compRef.instance as SectionComponent;
      const viewCmp = compRef.instance as GetSectionComponent;

      if (mode === 'create') {
        createCmp.titleChange.subscribe((t) => {
          this.definitionByType['Seccion'] = {
            ...this.definitionByType['Seccion'],
            title: t,
          };
        });
        createCmp.descriptionChange.subscribe((d) => {
          this.definitionByType['Seccion'] = {
            ...this.definitionByType['Seccion'],
            description: d,
          };
        });
      } else {
        const def = this.definitionByType['Seccion'] ?? {
          title: 'Sin título',
          description: 'Sin descripción',
        };
        viewCmp.title = def.title;
        viewCmp.description = def.description;
      }
    } else if (type === 'Crear_Pregunta') {
      const createCmp = compRef.instance as FormElementsComponent;
      const viewCmp=compRef.instance as GetFormElementsComponent;
       if (mode === 'create') {
        createCmp.questionCreated.subscribe((p)=>{
          this.definitionByType['Crear_Pregunta']={
            ...p,
          };
        });
      } else {
        const def=tpreguntas?{
          type:tpreguntas.tipo,
          questionText:tpreguntas.pregunta,
          options:tpreguntas.options ?? [],
          selected:tpreguntas.selected??(tpreguntas.tipo==='Multiple'?[]:'')
        }
        : this.definitionByType['Crear_Pregunta'] ?? {
          type: 'Abierta',
          questionText: 'Sin pregunta',
          options: [],
          selected: []
        };
        viewCmp.question = def.questionText;
        viewCmp.typeQuestion = def.type;
        viewCmp.options = def.options ?? [];
        viewCmp.selected = def.selected ?? (def.type === 'Multiple' ? [] : '');
      }
    }
  }
}

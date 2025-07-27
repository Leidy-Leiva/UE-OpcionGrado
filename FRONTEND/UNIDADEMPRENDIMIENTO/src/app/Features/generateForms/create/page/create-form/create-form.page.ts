import {
  Component,
  ComponentRef,
  ViewChild,
  ViewContainerRef,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';
import { ButtonwithiconComponent } from '../../../../../shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { ButtonComponent } from '../../../../../shared/components/atoms/button/button.component';
import { buttonconfig } from 'src/app/shared/models/button-config';
import { FormComponent } from '../../../../../shared/components/molecules/form/form.component';
import { createForm } from '../../../models/createForm.config';
import { DropdownComponent } from '../../../../../shared/components/atoms/dropdown/dropdown.component';
import { FormbuilderComponent } from '../../../components/formbuilder/formbuilder.component';
import { ElementsFormMapper } from 'src/app/shared/mappers/generate-forms.mapper';
import { FormElement } from 'src/app/shared/models/FormElement-config';
import { ColumnDef } from 'src/app/shared/models/ColumnDef-config';

@Component({
  selector: 'app-create-form',
  standalone: true,
  imports: [
    CommonModule,
    HeaderComponent,
    ButtonwithiconComponent,
    ButtonComponent,
    FormComponent,
    DropdownComponent,
    FormbuilderComponent,
  ],
  templateUrl: './create-form.page.html',
  styleUrls: ['./create-form.page.scss'],
})
export class CreateForm {

  
  typeForm: { value: string; label: string }[] = [
    { value: 'Formulario',        label: 'Formulario' },
    { value: 'Modelo Financiero', label: 'Modelo Financiero' }
  ];

 selectedType: string = this.typeForm[0].value;

  

  form: createForm = {
    tipo: '',
    titulo: '',
    descripcion: '',
  };

  buttonvisualize: ButtonWithIconConfig = {
    title: 'Visualizar',
    icon: 'eye',
    typeButton: 'button',
    disabled: false,
    iconColor: 'white',
    action: '',
    typeIcon: 'fontawesome',
    showText: false,
  };

  buttonSave: buttonconfig = {
    title: 'Guardar',
    typeButton: 'button',
    disabled: true,
  };

  onVisualize(): void {}

  save(): void {}

  onSelectionChange(selected: string) {
    this.selectedType = selected;
  }
  columns: ColumnDef<FormElement>[] = [
    { key: 'tipo', label: 'Tipo de pregunta' },
    { key: 'pregunta', label: 'Pregunta' },
  ];

  preguntas: FormElement[] = [
    { tipo: 'Cerrada', pregunta: '¿Está Libre?' },
    { tipo: 'Abierta', pregunta: 'Describa su experiencia' },
    { tipo: 'Opción Múltiple', pregunta: 'Elija su color favorito' },
    { tipo: 'Cerrada', pregunta: '¿Aprueba el cambio?' },
    { tipo: 'Abierta', pregunta: 'Comentarios adicionales' },
  ];
  total = 0;
  pageSize = 10;

  @ViewChild('modalContainer', { read: ViewContainerRef, static: true })
  private modalHost!: ViewContainerRef;
  private activeModalRef?: ComponentRef<any>;

  async openModal(action: string): Promise<void> {
    this.modalHost.clear();
    this.activeModalRef = undefined;

    try {
      const loadFn = ElementsFormMapper[action];
      if (!loadFn) {
        console.warn(`Acción desconocida: ${action}`);
        return;
      }
      const compType = await loadFn();
      this.activeModalRef = this.modalHost.createComponent(compType);
      const instance = this.activeModalRef.instance as {
        isModalOpen?: boolean;
        element?: FormElement;
        closeModal?: any;
      };

      instance.isModalOpen = true;

      instance.closeModal?.subscribe(() => this.modalHost.clear());
    } catch (err) {
      console.error('Error al abrir modal:', err);
    }
  }

  handleFormAction(action: string): void {
    if (action === 'Traer_Preguntas') {
      this.openModal(action);
    }
  }
}

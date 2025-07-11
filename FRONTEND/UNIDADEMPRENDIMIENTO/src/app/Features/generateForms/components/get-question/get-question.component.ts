import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModalComponent } from 'src/app/shared/components/organisms/modal/modal.component';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';
import { IconComponent } from 'src/app/shared/components/atoms/icon/icon.component';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { CheckBoxComponent } from 'src/app/shared/components/atoms/check-box/check-box.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { TableComponent } from 'src/app/shared/components/molecules/table/table.component';
import { ButtonwithicongroupComponent } from 'src/app/shared/components/organisms/buttonwithicongroup/buttonwithicongroup.component';
import { Sort } from '@angular/material/sort';
import { PageEvent } from '@angular/material/paginator';
import { ColumnDef } from 'src/app/shared/models/ColumnDef-config';
import { FormElement } from 'src/app/shared/models/FormElement-config';
import { buttonconfig } from 'src/app/shared/models/button-config';
import { ButtonComponent } from 'src/app/shared/components/atoms/button/button.component';
import { ButtongroupComponent } from 'src/app/shared/components/organisms/buttongroup/buttongroup.component';

@Component({
  selector: 'app-get-question',
  standalone: true,
  imports: [
    CommonModule,
    ModalComponent,
    HeaderComponent,
    IconComponent,
    LabelComponent,
    ButtonwithiconComponent,
    CheckBoxComponent,
    TableComponent,
    ButtongroupComponent,
  ],
  templateUrl: './get-question.component.html',
  styleUrls: ['./get-question.component.css'],
})
export class GetQuestionComponent {
  @Input() isModalOpen = false;
  @Output() closeModal = new EventEmitter<void>();

  columns: ColumnDef<FormElement>[] = [
    { key: 'tipo', label: 'Tipo de pregunta' },
    { key: 'pregunta', label: 'Pregunta' },
  ];

  // Datos y paginación
  preguntas: FormElement[] = [
    { tipo: 'Cerrada', pregunta: '¿Está Libre?' },
    { tipo: 'Abierta', pregunta: 'Describa su experiencia' },
    { tipo: 'Opción Múltiple', pregunta: 'Elija su color favorito' },
    { tipo: 'Cerrada', pregunta: '¿Aprueba el cambio?' },
    { tipo: 'Abierta', pregunta: 'Comentarios adicionales' },
  ]; // aquí llenas con tu servicio
  total = 0; // total de registros para paginador
  pageSize = 10; // filas por página

  buttons: buttonconfig[] = [
    {
      title: 'Cancelar',
      typeButton: 'button',
      classList: 'btn-cancel',
      disabled: false,
      action: 'cancelar',
    },
    {
      title: 'Guardar',
      typeButton: 'submit',
      classList: 'btn-save',
      disabled: false,
      action: 'guardar',
    },
  ];

  btnclose: ButtonWithIconConfig = {
    icon: 'close',
    classList: 'btn-success main-header__button',
    typeButton: 'button',
    disabled: false,
    iconColor: '#264390',
  };


  onSort(sort: Sort): void {
    // this.loadData(sort, undefined);
  }

  onPage(page: PageEvent): void {
    // this.loadData(undefined, page);
  }

  handleAction(action: string) {
    switch (action) {
      case 'closeModal':
      case 'cancelar':
        this.closeModal.emit();
        break;

      case 'guardar':
        this.handleGuardar();
        break;

      default:
        console.warn('Acción no reconocida:', action);
    }
  }

  handleGuardar() {
    // Lógica para guardar
    console.log('Guardar');
  }
}

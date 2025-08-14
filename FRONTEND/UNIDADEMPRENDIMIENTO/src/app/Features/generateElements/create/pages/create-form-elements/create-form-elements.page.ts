import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';
import { ModalComponent } from 'src/app/shared/components/organisms/modal/modal.component';
import { FormElementsComponent } from '../../../../../shared/components/organisms/question/create/formelements/formelements.component';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';
import { ButtonwithiconComponent } from '../../../../../shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { ButtongroupComponent } from '../../../../../shared/components/organisms/buttongroup/buttongroup.component';
import { buttonconfig } from 'src/app/shared/models/button-config';
import { IconComponent } from '../../../../../shared/components/atoms/icon/icon.component';
import { BancoElementoService } from 'src/app/core/services/banco-elemento.service';
import { PostBEFormularioDTO } from 'src/app/core/models/ELEMENTSFORM/PostBEFormularioDTO';

@Component({
  selector: 'app-create-form-elements',
  standalone: true,
  imports: [
    CommonModule,
    HeaderComponent,
    ModalComponent,
    FormElementsComponent,
    LabelComponent,
    ButtonwithiconComponent,
    ButtongroupComponent,
    IconComponent,
  ],
  templateUrl: './create-form-elements.page.html',
  styleUrls: ['./create-form-elements.page.scss'],
})
export class CreateFormElements implements OnInit {

  @Input() isModalOpen = false;
  @Output() closeModal = new EventEmitter<void>();

  private formData!: PostBEFormularioDTO;

  constructor(private bancoElementoService: BancoElementoService) {}

  btnclose: ButtonWithIconConfig = {
    icon: 'close',
    classList: 'btn-success main-header__button',
    typeButton: 'button',
    disabled: false,
    iconColor: '#264390',
    action: 'closeModal',
  };

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

  ngOnInit(): void {
    
  }


  onQuestionCreated(data: { type: string; questionText: string; options?: string[] }) {
  if (!this.formData) {
    this.formData = { BEFO_ENUNCIADO: '', TEFO_CODIGO: 0, BANCOOPCRESELEMENTOS: [] };
  }

  this.formData.BEFO_ENUNCIADO = data.questionText;
  this.formData.TEFO_CODIGO = this.mapTipoElemento(data.type);
  this.formData.BANCOOPCRESELEMENTOS = data.options?.map(opt => ({ BORE_VALOR: opt })) || [];
  
  console.log('FormData actualizado en tiempo real:', this.formData);
}


 private mapTipoElemento(nombre: string): number {
    const map: Record<string, number> = {
      'Abierta': 1,
      'Cerrada': 2,
      'Multiple': 3,
      'Seccion': 10,
      'Cronograma': 11,
      'Tabla': 12
    };
    return map[nombre] || 0;
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
    if (!this.formData) {
      console.warn('No hay datos para guardar');
      return;
    }

    this.bancoElementoService.create(this.formData).subscribe({
      next: () => {
        console.log('Pregunta guardada con éxito');
        this.closeModal.emit();
      },
      error: (err) => console.error('Error guardando la pregunta', err)
    });
  }
}

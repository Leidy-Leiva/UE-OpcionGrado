import { Component,Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';
import { ModalComponent } from 'src/app/shared/components/organisms/modal/modal.component';
import { ButtongroupComponent } from 'src/app/shared/components/organisms/buttongroup/buttongroup.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { buttonconfig } from 'src/app/shared/models/button-config';
import { FormElementsComponent } from 'src/app/shared/components/organisms/formelements/formelements.component';
import { IconComponent } from 'src/app/shared/components/atoms/icon/icon.component';

@Component({
  selector: 'app-update-form-elements',
  standalone: true,
  imports: [CommonModule,LabelComponent,ButtonwithiconComponent,HeaderComponent,ModalComponent,ButtongroupComponent,FormElementsComponent,IconComponent],
  templateUrl: './update-form-elements.page.html',
  styleUrls: ['./update-form-elements.page.scss']
})
export class UpdateFormElements {
  @Input() isModalOpen = false;
  @Output() closeModal = new EventEmitter<void>();

  btnclose:ButtonWithIconConfig=
  {
    icon: 'close',
    classList: 'btn-success main-header__button', 
    typeButton: 'button', disabled: false, iconColor:'#264390', action: 'closeModal'
  }

   buttons: buttonconfig[] = [
    {
      title: 'Cancelar',
      typeButton: 'button',classList: 'btn-cancel',disabled: false,action: 'cancelar'
    },
    {
      title: 'Guardar',
      typeButton: 'submit',classList: 'btn-save',disabled: false,action: 'guardar'
    }
  ];



  
 handleAction(action: string) {

  switch(action) {

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

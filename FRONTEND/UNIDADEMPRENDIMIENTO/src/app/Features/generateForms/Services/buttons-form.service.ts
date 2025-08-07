import { Injectable } from '@angular/core';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';

@Injectable({
  providedIn: 'root',
})
export class ButtonsFormService {
  constructor() {}

  getButtonsTypeForm(typeForm: string): ButtonWithIconConfig[] {
    const buttons: ButtonWithIconConfig[] = [];

    if (typeForm.includes('Formulario')) {
      buttons.push(
        {
          title:"Crear Pregunta",
          icon: 'plus',
          classList: 'btn btn-add',
          typeButton: 'button',
          disabled: false,
          iconColor: '#ffffff ',
          typeIcon:'fontawesome',
          action: 'Crear_Pregunta',
          showText: false     
        },
        {
          title:"Traer Pregunta",
          icon: 'file-import',
          iconStyle:'regular',
          classList: 'btn btn-get',
          typeButton: 'button',
          disabled: false,
          typeIcon: 'fontawesome',
          iconColor: '#ffffff ',
          action: 'Traer_Preguntas',
          showText: false     
        },
        {
          title:'Crear Cronograma',
          icon: 'clock',
          iconStyle:'regular',
          classList: '',
          typeButton: 'button',
          disabled: false,
          iconColor: '#ffffff ',
          typeIcon:'fontawesome',
          action: 'Cronograma',
          showText: false     
        },
        {
           title:'Crear Tabla',
          icon: 'table',
          iconStyle:'regular',
          classList: '',
          typeButton: 'button',
          disabled: false,
          iconColor: '#ffffff ',
          typeIcon:'fontawesome',
          action: 'Tabla',
          showText: false     
        },
        {
          title:'Crear Secciones',
          icon: 'grip',
          iconStyle:'regular',
          classList: '',
          typeButton: 'button',
          disabled: false,
          typeIcon: 'fontawesome',
          iconColor: '#ffffff ',
          action: 'Seccion',
          showText: false    
        }
      );
    }
    if (typeForm.includes('Modelo Financiero')) {
      buttons.push({
  
           title:'Crear Tabla',
          icon: 'table',
          iconStyle:'regular',
          classList: '',
          typeButton: 'button',
          disabled: false,
          iconColor: '#ffffff ',
          typeIcon:'fontawesome',
          action: 'Tabla',
          showText: false     
        
      });
    }

    return buttons;
  }
}

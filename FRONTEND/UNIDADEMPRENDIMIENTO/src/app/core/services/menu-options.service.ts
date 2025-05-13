import { Injectable } from '@angular/core';
import { buttonconfig } from '../../shared/models/button-config';

@Injectable({
  providedIn: 'root'
})

export class MenuOptionsService {
  constructor() {}

  getButtonsByRoles(roles: string[]): buttonconfig[] {
    const buttons: buttonconfig[] = [];

    if (roles.includes('coordinador')) {
      buttons.push(
        { title: 'Propuesta', classList: 'reload-btn', typeButton: 'button', disabled: false},
        { title: 'Elementos de Fromulario', classList: 'settings-btn', typeButton: 'button', disabled: false, action:'Elementos' },
        { title: 'Convocatoria', classList: 'settings-btn', typeButton: 'button', disabled: false},
        { title: 'Formulario', classList: 'settings-btn', typeButton: 'button', disabled: false},
        { title: 'Evaluación', classList: 'settings-btn', typeButton: 'button', disabled: false}
      );
      console.log('[MenuOptionsService] salió:', buttons);
      return buttons;
    }

    if (roles.includes('user')) {
      buttons.push(
        {title: 'Ayuda', classList: 'help-btn', typeButton: 'button', disabled: false }
      );
    }

    if (roles.includes('admin')) {
      buttons.push(
        { title: 'Ayuda', classList: 'help-btn', typeButton: 'button', disabled: false}
      );
    }
    return buttons;
  }
}

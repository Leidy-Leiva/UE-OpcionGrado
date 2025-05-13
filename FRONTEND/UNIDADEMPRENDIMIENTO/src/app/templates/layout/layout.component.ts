import { Component,Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../../shared/components/organisms/header/header.component';
import { PanelinfoComponent } from '../../shared/components/organisms/panelinfo/panelinfo.component';
import { Router, RouterModule } from '@angular/router';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';
import { IconComponent } from 'src/app/shared/components/atoms/icon/icon.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { ButtonwithicongroupComponent } from 'src/app/shared/components/organisms/buttonwithicongroup/buttonwithicongroup.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { MenuoptionsComponent } from '../../shared/components/organisms/menuoptions/menuoptions.component';
@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [CommonModule, HeaderComponent, PanelinfoComponent, MenuoptionsComponent, RouterModule, LabelComponent, IconComponent, ButtonwithicongroupComponent, ButtonwithiconComponent],
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent {
@Input() pageTitle?:string;
isCollapsed:boolean=false;
constructor(private router: Router) {}

mainHeaderButtons:ButtonWithIconConfig[]= [
  { icon: 'remove', classList: 'btn-success main-header__button', typeButton: 'button', disabled: false, iconColor:'#264390', action: 'minimize' },
  { icon: 'crop_square', classList: 'btn-success main-header__button', typeButton: 'button', disabled: false, iconColor:'#264390', action: 'maximize'},
  { icon: 'close', classList: 'btn-success main-header__button', typeButton: 'button', disabled: false, iconColor:'#264390', action: 'close' }
];

secondaryHeaderButtons:ButtonWithIconConfig[]= [
  { icon: 'sync', title:'Recargar página', classList: 'reload-btn', typeButton: 'button', disabled: false, iconColor:'#91CA8A'},
  { icon: 'help', title:'Ayuda', classList: 'help-btn', typeButton: 'button', disabled: false, iconColor: '#6995C3' }
];

buttonPanelInfoHeader:ButtonWithIconConfig={
  icon: 'arrow-right', classList: 'btn-success', typeButton: 'button', disabled: false, iconColor:'#ffffff', action:'toggle-sidebar',typeIcon:"fontawesome"
}


onMenuButtonClick(action: string) {

  console.log('Accion del menú',action);

  switch(action)
  {
    case 'Elementos' :
      console.log('Acabe de darle clic');
      this.router.navigate(['/generate-elements-form/listar']);
    break;
  }
  // Por ejemplo, si recibes "elementos", navegas a /elementos
  
}


handleAction(action: string) {
  console.log('Acción del menú:', action);

  switch(action) {
    case 'toggle-sidebar':
      console.log("Acabo de dar click");
      this.isCollapsed = !this.isCollapsed;
      break;

    case 'BancoElementos':
      break;

    case 'convocatoria':
      break;

    case 'banco':
      break;

    case 'recargar':
      break;

    case 'ayuda':
      break;
      
    default:
      console.warn('Acción no reconocida:', action);
  }
}
  

  closeWindow() {
    console.log('Cerrar ventana');
    // Aquí puedes agregar lógica real si estás en Electron, por ejemplo
  }
  
  minimizeWindow() {
    console.log('Minimizar ventana');
  }
  
  maximizeWindow() {
    console.log('Maximizar ventana');
  }
}


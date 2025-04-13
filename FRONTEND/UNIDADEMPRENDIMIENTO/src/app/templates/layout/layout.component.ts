import { Component,Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../../shared/components/organisms/header/header.component';
import { PanelinfoComponent } from '../../shared/components/organisms/panelinfo/panelinfo.component';
import { MenuoptionsComponent } from "../../shared/components/organisms/menuoptions/menuoptions.component";
import { ListaPreguntasComponent } from "../../shared/components/organisms/lista-preguntas/lista-preguntas.component";
import { RouterModule } from '@angular/router';
import { BquestionEditComponent } from "../../Features/Bquestions/bquestion-edit/bquestion-edit.component";
import { ListaFormularioComponent } from 'src/app/shared/components/organisms/lista-formulario/lista-formulario.component';

@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [CommonModule, HeaderComponent, PanelinfoComponent, MenuoptionsComponent, ListaPreguntasComponent, RouterModule, BquestionEditComponent,ListaFormularioComponent],
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent {
@Input() pageTitle?:string;
showEditModal = false;  // Modal para edición
showUpdateModal = false; // Modal para actualización

isCollapsed:boolean=false;

toggleSidebar(){
  this.isCollapsed=!this.isCollapsed;
  console.log("Estado del panel:", this.isCollapsed ? "Colapsado" : "Expandido");
}

onRemoveClick() {
  console.log('Remove button clicked');
}

onCropClick() {
  console.log('Crop button clicked');
}

onCloseClick() {
  console.log('Close button clicked');
}

// openEditView() {
//   this.showEditModal = true;
//   this.showUpdateModal = false;
// }

  // Función para manejar la acción del menú
  handleMenuAction(action: string) {
    console.log('Acción del menú:', action);
    // Por ejemplo, si la acción es 'convocatorias' podrías abrir otra vista
    if (action === 'convocatorias') {
      // Realiza la acción correspondiente, por ejemplo:
      this.showEditModal = true;
      this.showUpdateModal = false;
    } else if (action === 'banco') {
      // Otra acción, por ejemplo, abrir el modal de banco de preguntas
      this.showUpdateModal = true;
      this.showEditModal = false;
    } else if (action === 'formularios') {
      // Otra acción
      // ...
    }
  }

}

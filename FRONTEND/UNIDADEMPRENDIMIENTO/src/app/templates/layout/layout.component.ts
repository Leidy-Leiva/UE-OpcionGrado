import { Component,Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../../shared/components/molecules/header/header.component';
import { PanelinfoComponent } from '../../shared/components/organisms/panelinfo/panelinfo.component';
import { MenuoptionsComponent } from "../../shared/components/organisms/menuoptions/menuoptions.component";

@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [CommonModule, HeaderComponent, PanelinfoComponent, MenuoptionsComponent],
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent {
@Input() pageTitle?:string;

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

}

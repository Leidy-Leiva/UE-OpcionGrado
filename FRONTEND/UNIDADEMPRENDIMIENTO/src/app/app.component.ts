import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
<<<<<<< HEAD
import { ButtonwithiconComponent } from './shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { ButtonComponent } from './shared/components/atoms/button/button.component';
import { LabelComponent } from './shared/components/atoms/label/label.component';
import { HeaderComponent } from "./shared/components/molecules/header/header.component";
import { RadioButtonComponent } from './shared/components/atoms/radio-button/radio-button.component';
import { CheckBoxComponent } from './shared/components/atoms/check-box/check-box.component';
import { ModelComponent } from './shared/components/atoms/model/model.component';
import { ComboBoxComponent } from './shared/components/atoms/combo-box/combo-box.component';
import { BquestionEditComponent } from './Features/Bquestions/bquestion-edit/bquestion-edit.component';
import { SeekerComponent } from './shared/components/molecules/seeker/seeker.component';
import { TableComponent } from './shared/components/molecules/table/table.component';
=======
import { LayoutComponent } from './templates/layout/layout.component';
>>>>>>> a483e393794e99a925fe7b707ccdcaa9e03383cb

@Component({
  selector: 'app-root',
  standalone: true,
<<<<<<< HEAD
  imports: [CommonModule,HeaderComponent,RadioButtonComponent,CheckBoxComponent,ComboBoxComponent,BquestionEditComponent,RouterOutlet,SeekerComponent,TableComponent],
=======
  imports: [CommonModule,RouterOutlet,LayoutComponent],
>>>>>>> a483e393794e99a925fe7b707ccdcaa9e03383cb
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title = 'UNIDADEMPRENDIMIENTO';
  
  isChecked = false; // ✅ Agrega esta línea
  isDisabled = false; // Opcional: para controlar si el checkbox está deshabilitado
  isModalVisible = false; // Controla si el modal está visible

  onRadioChange(value: string) {
    console.log('Selección cambiada:', value);
  }
  onCheckboxChange(checked: boolean) {
    this.isChecked = checked; // Actualiza el estado del checkbox
    console.log('Estado del checkbox:', this.isChecked);
  }
  showModal() {
    this.isModalVisible = true;
  }

  closeModal() {
    this.isModalVisible = false;
  }
   optionsList = ['Opción 1', 'Opción 2', 'Opción 3', 'Opción 4'];

   handleUpdate(updatedQuestion: any) {
    console.log('Pregunta actualizada:', updatedQuestion);
    this.closeModal(); // Cierra el modal después de guardar cambios
  }
  
  tableHeaders = ['Nombre', 'Apellido', 'Usuario']; 
tableData = [
  { Nombre: 'Mark', Apellido: 'Otto', Usuario: '@mdo' },
  { Nombre: 'Jacob', Apellido: 'Thornton', Usuario: '@fat' },
  { Nombre: 'Larry', Apellido: 'Bird', Usuario: '@twitter' }
];

  
  
}

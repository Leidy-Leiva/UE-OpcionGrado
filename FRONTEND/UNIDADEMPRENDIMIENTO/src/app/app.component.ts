import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './templates/layout/layout.component';
import { RouterModule } from '@angular/router';
import { BquestionEditComponent } from './Features/Bquestions/bquestion-edit/bquestion-edit.component';
import { BquestionActualizarComponent } from './Features/bquestion-actualizar/bquestion-actualizar.component';
import { BoardComponent } from "./shared/components/atoms/board/board.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, LayoutComponent, RouterModule, BquestionEditComponent, BquestionActualizarComponent, BoardComponent],
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

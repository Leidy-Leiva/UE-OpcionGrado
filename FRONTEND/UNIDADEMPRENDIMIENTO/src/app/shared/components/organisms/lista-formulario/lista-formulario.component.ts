import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../../molecules/header/header.component';
import { SeekerComponent } from '../../molecules/seeker/seeker.component';
import { TableComponent } from '../../molecules/table/table.component';

@Component({
  selector: 'app-lista-formulario',
  standalone: true,
  imports: [CommonModule, HeaderComponent,TableComponent,SeekerComponent],
  templateUrl: './lista-formulario.component.html',
  styleUrls: ['./lista-formulario.component.css']
})

export class ListaFormularioComponent {
// Variables para controlar los modales
showEditModal = false;   // Modal para edición
showUpdateModal = false; // Modal para actualización
selectedFormulario: any = null; // Formulario seleccionado


 topData: any[] = [
   { 'Columna A': 'Dato 3', 'Columna B': 'Dato 4' }
 ];

// Define las cabeceras y datos (ajusta según lo que necesites)
headers: string[] = ['ID', 'Formulario', 'estado'];
data: any[] = [
  { ID: 1, Formulario: 'Formulario A' },
  { ID: 2, Formulario: 'Formulario B' }
];

// Abre el modal de edición
openEditView() {
  this.showEditModal = true;
  this.showUpdateModal = false;
}

// Abre el modal de actualización
openUpdateView() {
  this.showUpdateModal = true;
  this.showEditModal = false;
}

// Cierra ambos modales
closeModal() {
  this.showEditModal = false;
  this.showUpdateModal = false;
}

// Función para eliminar (o cualquier otra acción)
deleteFormulario(row: any) {
  console.log('Eliminar formulario:', row);
}

}

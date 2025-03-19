import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../../molecules/header/header.component';
import { SeekerComponent } from '../../molecules/seeker/seeker.component';
import { TableComponent } from '../../molecules/table/table.component';
import { BquestionEditComponent } from 'src/app/Features/Bquestions/bquestion-edit/bquestion-edit.component';
import { ButtonwithiconComponent } from '../../molecules/buttonwithicon/buttonwithicon.component';
import { BquestionActualizarComponent } from 'src/app/Features/bquestion-actualizar/bquestion-actualizar.component';

@Component({
  selector: 'app-lista-preguntas',
  standalone: true,
  imports: [CommonModule, HeaderComponent, SeekerComponent, TableComponent, BquestionEditComponent,BquestionActualizarComponent],
  templateUrl: './lista-preguntas.component.html',
  styleUrls: ['./lista-preguntas.component.css']
})
export class ListaPreguntasComponent {
    showEditModal = false;  // Modal para edición
    showUpdateModal = false; // Modal para actualización
    selectedQuestion: any = null; // Pregunta seleccionada
  
    headers: string[] = ['ID', 'Pregunta']; 
    data: any[] = [
      { ID: 1, Pregunta: '¿Qué es Angular?' },
      { ID: 2, Pregunta: '¿Cómo funciona TypeScript?' }
    ];

    openEditView() {
      this.showEditModal = true;
      this.showUpdateModal = false;
    }
  
    openUpdateView() {
      console.log ("Hola")
      this.showUpdateModal = true;
      this.showEditModal = false;
    }
  
    closeModal() {
      this.showEditModal = false;
      this.showUpdateModal = false;
    }
  
    deleteQuestion(row: any) {
      console.log('Eliminar:', row);
    }
  }
  
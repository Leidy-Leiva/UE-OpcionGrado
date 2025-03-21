import { Component, EventEmitter, Output, OnInit, ViewEncapsulation, Input } from '@angular/core';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router'; // <-- Importa RouterModule
import { ModelComponent } from 'src/app/shared/components/atoms/model/model.component';
import { FormsModule } from '@angular/forms';
import { ButtonComponent } from 'src/app/shared/components/atoms/button/button.component';
import { LabelwithcomboboxComponent } from 'src/app/shared/components/molecules/labelwithcombobox/labelwithcombobox.component';
import { LabelwithinputComponent } from 'src/app/shared/components/molecules/labelwithinput/labelwithinput.component';
import { HeaderComponent } from 'src/app/shared/components/molecules/header/header.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { BquestionEditService } from 'src/app/shared/components/Services/bquestion-edit.service';


@Component({
  selector: 'app-bquestion-edit',
  standalone: true,
  encapsulation: ViewEncapsulation.None,
  imports: [
    CommonModule,
    RouterModule, 
    ModelComponent,
    FormsModule,
    ButtonComponent,
    LabelwithcomboboxComponent,
    LabelwithinputComponent,
    HeaderComponent,
    ButtonwithiconComponent
  ],
  templateUrl: './bquestion-edit.component.html',
  styleUrls: ['./bquestion-edit.component.css']
})
export class BquestionEditComponent implements OnInit {
  
  @Input() isVisible: boolean = true;
  @Input() title: string = 'Gestionar Pregunta';
  @Input() questionOptions: string[] = ['Abierta', 'Opcional'];
  @Input() showCloseButton: boolean = false;
  @Input() question: any;
  @Output() close = new EventEmitter<void>();
  @Output() onUpdate = new EventEmitter<any>();
  @Input() showMinimal: boolean = false;

  // constructor(private editService: BquestionEditService) {}


  isVisibleLocal = this.isVisible;
  questionText: string = '';
  updatedQuestion = { description: '' };

  // Propiedad para almacenar las opciones ingresadas
  options: string[] = [];

  // Propiedad para controlar si se deben mostrar los campos de opciones
  showOptionsField: boolean = false;

  ngOnInit() {}

  closeModal() {
    this.isVisibleLocal = false;
    this.close.emit();
  }

  onSelectionChange(selectedValue: string) {
    console.log('Tipo de cuestionario seleccionado:', selectedValue);
    this.showOptionsField = selectedValue === 'Opcional';
  }

  onQuestionChange(newValue: string) {
    console.log('Pregunta ingresada:', newValue);
    this.questionText = newValue;
  }

  onOptionsChange(newValue: string) {
    console.log('Opción ingresada:', newValue);
    this.updatedQuestion.description = newValue;
  }

  // Agrega la opción actual al array y limpia el campo
  addOption() {
    const option = this.updatedQuestion.description.trim();
    if (option) {
      this.options.push(option);
      console.log('Opción agregada:', option);
      // Limpia el input para que se pueda ingresar una nueva opción
      this.updatedQuestion.description = '';
    }
  }

  saveChanges() {

  this.onUpdate.emit({
   pregunta: this.questionText,
    opciones: this.options
   });
   this.closeModal();
  }

  // saveChanges() {
  //   const payload = { pregunta: this.questionText, opciones: this.options };
  
  //   this.editService.saveQuestion(payload).subscribe({
  //     next: response => {
  //       console.log('Pregunta guardada con éxito', response);
  //       this.onUpdate.emit(payload);
  //       this.closeModal();
  //     },
  //     error: error => {
  //       console.error('Error al guardar la pregunta', error);
  //     }
  //   });
  // }
  
}
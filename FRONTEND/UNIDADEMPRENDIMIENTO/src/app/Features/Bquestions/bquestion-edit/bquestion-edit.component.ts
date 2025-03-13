import { Component, EventEmitter, Output, OnInit, ViewEncapsulation } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModelComponent } from 'src/app/shared/components/atoms/model/model.component';
import { FormsModule } from '@angular/forms';
import { ButtonComponent } from 'src/app/shared/components/atoms/button/button.component';
import { LabelwithcomboboxComponent } from 'src/app/shared/components/molecules/labelwithcombobox/labelwithcombobox.component';
import { LabelwithinputComponent } from 'src/app/shared/components/molecules/labelwithinput/labelwithinput.component';
import { HeaderComponent } from 'src/app/shared/components/molecules/header/header.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';

@Component({
  selector: 'app-bquestion-edit',
  standalone: true,
  encapsulation: ViewEncapsulation.Emulated, // ✅ Evita conflictos con estilos globales
  imports: [CommonModule, ModelComponent, FormsModule, ButtonComponent, LabelwithcomboboxComponent, LabelwithinputComponent, HeaderComponent, ButtonwithiconComponent],
  templateUrl: './bquestion-edit.component.html',
  styleUrls: ['./bquestion-edit.component.css']
})
export class BquestionEditComponent implements OnInit {
  @Output() onUpdate = new EventEmitter<any>();

  isVisible = true;
  questionOptions: string[] = ['Abierta', 'Opcional'];
  questionText: string = '';  
  updatedQuestion = {
    description: ''
  };
  showOptionsField = false; // Inicialmente oculto


  ngOnInit() {
    this.isVisible = true;
  }

  closeModal() {
    this.isVisible = false;
  }

  /** ✅ Manejar la selección de tipo de cuestionario */
  onSelectionChange(selectedValue: string) {  
    console.log('Tipo de cuestionario seleccionado:', selectedValue);
    this.showOptionsField = selectedValue === 'Opcional'; // Muestra solo si es "Opcional"
  }
  

  /** ✅ Capturar cambios en la pregunta */
  onQuestionChange(newValue: string) {
    console.log('Pregunta ingresada:', newValue);
    this.questionText = newValue;
  }
  
  /** ✅ Capturar cambios en las opciones de respuesta */
  onOptionsChange(newValue: string) {
    console.log('Opción ingresada:', newValue);
    this.updatedQuestion.description = newValue;
  }
  
  /** ✅ Guardar cambios */
  saveChanges() {
    console.log('Guardando datos:', {
      pregunta: this.questionText,
      opciones: this.updatedQuestion.description
    });

    this.onUpdate.emit({
      pregunta: this.questionText,
      opciones: this.updatedQuestion.description
    });

    this.closeModal();
  }
}

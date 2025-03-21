import { Component ,Input,Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';
import { BquestionEditComponent } from '../Bquestions/bquestion-edit/bquestion-edit.component';
import { RouterModule } from '@angular/router';
import { ModelComponent } from 'src/app/shared/components/atoms/model/model.component';
import { FormsModule } from '@angular/forms';
import { ButtonComponent } from 'src/app/shared/components/atoms/button/button.component';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';
import { LabelwithcomboboxComponent } from 'src/app/shared/components/molecules/labelwithcombobox/labelwithcombobox.component';
import { LabelwithinputComponent } from 'src/app/shared/components/molecules/labelwithinput/labelwithinput.component';
import { HeaderComponent } from 'src/app/shared/components/molecules/header/header.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { LabelwithlistgroupComponent } from 'src/app/shared/components/molecules/labelwithlistgroup/labelwithlistgroup.component';

@Component({
  selector: 'app-bquestion-actualizar',
  standalone: true,
  imports: [CommonModule,BquestionEditComponent,RouterModule,ModelComponent,FormsModule,ButtonComponent,LabelwithcomboboxComponent,LabelwithinputComponent,HeaderComponent,ButtonwithiconComponent, LabelwithlistgroupComponent],
  templateUrl: './bquestion-actualizar.component.html',
  styleUrls: ['./bquestion-actualizar.component.css']
})
export class BquestionActualizarComponent {
    @Input() question: any;  
    @Output() close = new EventEmitter<void>();  
    @Input() isVisible: boolean = true;  
    @Input() title: string = 'Gestionar Pregunta';
    @Input() showCloseButton: boolean = false; 
    @Output() onUpdate = new EventEmitter<any>();
    @Input() showMinimal: boolean = false;
   
    isVisibleLocal = this.isVisible;
    questionText: string = '';
    updatedQuestion = { description: '' };
    showOptionsField = false;
  
    // Arreglo para el list group
    listGroupItems: string[] = ['Opción 1', 'Opción 2', 'Opción 3'];
  
    // NUEVAS propiedades para el modo edición del título
    editingQuestion: boolean = false;
    originalQuestionText: string = '';
  
    closeModal() {
      this.isVisibleLocal = false;
      this.close.emit();
    }
  
    onQuestionUpdate(updatedData: any) {
      console.log('Pregunta actualizada:', updatedData);
    }
  
    onClose() {
      console.log('Modal cerrado');
    }
  
    onQuestionChange(newValue: string) {
      console.log('Pregunta ingresada:', newValue);
      this.questionText = newValue;
    }
  
    onOptionsChange(newValue: string) {
      console.log('Opción ingresada:', newValue);
      this.updatedQuestion.description = newValue;
    }
  
    // Métodos para el modo edición del título
    startEditing() {
      this.editingQuestion = true;
      this.originalQuestionText = this.questionText;
    }
  
    finishEditing() {
      this.editingQuestion = false;
      // Aquí podrías disparar algún evento o lógica de guardado, si es necesario
    }
  
    cancelEditing() {
      this.editingQuestion = false;
      this.questionText = this.originalQuestionText;
    }
  
    saveChanges() {
      this.onUpdate.emit({
        pregunta: this.questionText,
        opciones: this.updatedQuestion.description
      });
      this.closeModal();
    }
  }
  
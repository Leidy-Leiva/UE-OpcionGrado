import { Component, EventEmitter, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelwithinputComponent } from "src/app/shared/components/molecules/labelwithinput/labelwithinput.component";
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';

@Component({
  selector: 'app-create-schedule',
  standalone: true,
  imports: [CommonModule, LabelwithinputComponent],
  templateUrl: './create-schedule.component.html',
  styleUrls: ['./create-schedule.component.scss']
})
export class CreateScheduleComponent {
@Input() title:string='';
@Input() enunciado:string='';

@Output() titleChange = new EventEmitter<string>();
@Output() questionChange = new EventEmitter<string>();


// Configuración del botón "Añadir fila".
  btnadd: ButtonWithIconConfig = {
    icon: 'plus',
    typeButton: 'button',
    disabled: false,
    iconColor: '#fff',
    typeIcon: 'fontawesome',
    action: 'add',
  };
  // Configuración del botón "Eliminar fila".
  btndelete: ButtonWithIconConfig = {
    icon: 'trash',
    typeButton: 'button',
    disabled: false,
    iconColor: '#E43C3F',
    typeIcon: 'fontawesome',
    action: 'remove',
  };
  
  onTitleChange(newValue: string) {
    this.title = newValue;
    this.titleChange.emit(newValue);
  }

  onQuestionChange(newValue: string) {
    this.enunciado = newValue;
    this.questionChange.emit(newValue);
  }

}

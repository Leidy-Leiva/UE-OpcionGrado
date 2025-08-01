import { Component, Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelwithinputComponent } from '../../../../molecules/labelwithinput/labelwithinput.component';
import { LabelComponent } from '../../../../atoms/label/label.component';
import { InputComponent } from '../../../../atoms/input/input.component';

@Component({
  selector: 'app-openquestion',
  standalone: true,
  imports: [CommonModule,LabelComponent,InputComponent],
  templateUrl: './openquestion.component.html',
  styleUrls: ['./openquestion.component.scss']
})
export class OpenquestionComponent {
  placeholder: string = 'Escribe tu respuesta...';
  @Input() answer: string = '';
  @Output() answerChange = new EventEmitter<string>();

  onChange(value: string) {
    this.answer = value;
    this.answerChange.emit(value);
  }
}

import { Component,Input, Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../../../atoms/label/label.component';
import { InputComponent } from '../../../../atoms/input/input.component';

@Component({
  selector: 'app-view-open-question',
  standalone: true,
  imports: [CommonModule,InputComponent],
  templateUrl: './view-open-question.component.html',
  styleUrls: ['./view-open-question.component.scss']
})
export class ViewOpenQuestionComponent {
  placeholder: string = 'Escribe tu respuesta...';
  @Input() question:string='';
  @Input() answer:string='';
   @Output() answerChange = new EventEmitter<string>();
  
    onChange(value: string) {
      this.answer = value;
      this.answerChange.emit(value);
    }

}

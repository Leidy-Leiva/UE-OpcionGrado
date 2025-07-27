import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../atoms/label/label.component';

@Component({
  selector: 'app-view-multiple-choice-question',
  standalone: true,
  imports: [CommonModule,LabelComponent],
  templateUrl: './view-multiple-choice-question.component.html',
  styleUrls: ['./view-multiple-choice-question.component.scss']
})
export class ViewMultipleChoiceQuestionComponent {
@Input() question:string='';
}

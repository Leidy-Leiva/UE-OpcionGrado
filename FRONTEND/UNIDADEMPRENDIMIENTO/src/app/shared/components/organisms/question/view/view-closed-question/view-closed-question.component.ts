import { Component,EventEmitter,Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RadioButtonComponent } from "src/app/shared/components/atoms/radio-button/radio-button.component";
import { LabelComponent } from "src/app/shared/components/atoms/label/label.component";

@Component({
  selector: 'app-view-closed-question',
  standalone: true,
  imports: [CommonModule, RadioButtonComponent, LabelComponent],
  templateUrl: './view-closed-question.component.html',
  styleUrls: ['./view-closed-question.component.scss']
})
export class ViewClosedQuestionComponent {
@Input() options: string[] = [];
 selected: string | null = null;
@Input() nameGroup = `closed-question-${Math.random().toString(36).substr(2, 5)}`;
@Output() selectedChange = new EventEmitter<string>();

trackByIndex(index: number, _item: any) {
  return index;
}

selectOption(value: string) {
  this.selected = value;
  this.selectedChange.emit(value);
}

get groupedOption():string[][]{
    const groupSize=5;
    const groups:string[][]=[];
    for (let i = 0; i <this.options.length; i+=groupSize) {
      groups.push(this.options.slice(i,i+groupSize));
      
    }
    return groups;
  }
}

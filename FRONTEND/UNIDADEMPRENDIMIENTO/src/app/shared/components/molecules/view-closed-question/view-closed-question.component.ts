import { Component,Input } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-view-closed-question',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './view-closed-question.component.html',
  styleUrls: ['./view-closed-question.component.scss']
})
export class ViewClosedQuestionComponent {
@Input() options: string[] = [];

trackByIndex(index: number, _item: any) {
  return index;
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

import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../../../atoms/label/label.component';
import { CheckBoxComponent } from "src/app/shared/components/atoms/check-box/check-box.component";

@Component({
  selector: 'app-view-multiple-choice-question',
  standalone: true,
  imports: [CommonModule,CheckBoxComponent],
  templateUrl: './view-multiple-choice-question.component.html',
  styleUrls: ['./view-multiple-choice-question.component.scss']
})
export class ViewMultipleChoiceQuestionComponent implements OnChanges {
  @Input() options: string[] = [];
  @Input() selected: string[] = [];
  selectedIndices: number[] = [];
  @Output() selectedChange = new EventEmitter<string[]>();

   ngOnChanges(changes: SimpleChanges) {
    if (changes['selected'] || changes['options']) {
      // recalcula los índices de los elementos que vienen en `selected`
      this.selectedIndices = this.selected
        .map(opt => this.options.indexOf(opt))
        .filter(idx => idx >= 0);
    }
  }

   toggleSelection(index: number, checked: boolean) {
  if (checked) {
    this.selectedIndices = [...this.selectedIndices, index];
  } else {
    this.selectedIndices = this.selectedIndices.filter(i => i !== index);
  }
  this.selected = this.selectedIndices.map(i => this.options[i]);
  this.selectedChange.emit(this.selected);
}

  trackByIndex(index: number, _item: any) {
    return index;
  }
    readonly groupSize = 5;

  get groupedOptions():string[][] {
    const groups: string[][] = [];
    for (let i = 0; i < this.options.length; i += this.groupSize) {
      groups.push(this.options.slice(i, i + this.groupSize));
    }
    return groups;
  }

}

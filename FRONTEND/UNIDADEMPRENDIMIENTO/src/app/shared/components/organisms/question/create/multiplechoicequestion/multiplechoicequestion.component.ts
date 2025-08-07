import { Component,Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CheckBoxComponent } from '../../../../atoms/check-box/check-box.component';
import { InputComponent } from '../../../../atoms/input/input.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { ButtonwithiconComponent } from '../../../../molecules/buttonwithicon/buttonwithicon.component';
import { LabelComponent } from '../../../../atoms/label/label.component';

@Component({
  selector: 'app-multiplechoicequestion',
  standalone: true,
  imports: [CommonModule,CheckBoxComponent,InputComponent,ButtonwithiconComponent,LabelComponent],
  templateUrl: './multiplechoicequestion.component.html',
  styleUrls: ['./multiplechoicequestion.component.scss']
})
export class MultiplechoicequestionComponent {
  @Input() options: string[] = [];
  @Input() selected: string[] = [];
  selectedIndices: number[] = [];
  @Input() optionSelected?:string;

  @Output() optionsChange = new EventEmitter<string[]>();
  @Output() selectedChange = new EventEmitter<string[]>();


  btndelete:ButtonWithIconConfig={
      icon: 'xmark', typeButton: 'button', disabled: false, iconColor:'#E43C3F',action:'removeOption',typeIcon:"fontawesome"}

  btnadd:ButtonWithIconConfig={
      icon: 'plus', typeButton: 'button', disabled: false, iconColor:'#ffffff', action:'AddOption',typeIcon:"fontawesome"}

      
  ngOnInit() {
  if (this.options.length === 0) {
    this.addOption();
  }
}

  
  toggleSelection(index: number, checked: boolean) {
  if (checked) {
    this.selectedIndices = [...this.selectedIndices, index];
  } else {
    this.selectedIndices = this.selectedIndices.filter(i => i !== index);
  }
  // Opcional: actualizas `selected` con los textos
  this.selected = this.selectedIndices.map(i => this.options[i]);
  this.selectedChange.emit(this.selected);
}

  addOption() {
    this.options.push('');
    this.optionsChange.emit(this.options);
  }

  updateOption(index: number, value: string) {
    this.options[index] = value;
    this.optionsChange.emit(this.options);
  }

  removeOption(index: number) {
    this.options.splice(index, 1);
    this.optionsChange.emit(this.options);
  }
  
  trackByIndex(index: number, _item: any) {
    return index;
  }

  get groupedOptions():string[][] {
    const groupSize = 5;
    const groups: string[][] = [];
    for (let i = 0; i < this.options.length; i += groupSize) {
      groups.push(this.options.slice(i, i + groupSize));
    }
    return groups;
  }
}

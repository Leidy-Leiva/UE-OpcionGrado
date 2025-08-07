import { Component,Output,EventEmitter,Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RadioButtonComponent } from '../../../../atoms/radio-button/radio-button.component';
import { InputComponent } from '../../../../atoms/input/input.component';
import { ButtonwithiconComponent } from "../../../../molecules/buttonwithicon/buttonwithicon.component";
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { LabelComponent } from '../../../../atoms/label/label.component';

@Component({
  selector: 'app-closedquestion',
  standalone: true,
  imports: [CommonModule, RadioButtonComponent, InputComponent, ButtonwithiconComponent,LabelComponent],
  templateUrl: './closedquestion.component.html',
  styleUrls: ['./closedquestion.component.scss']
})
export class ClosedquestionComponent {
  @Input() options: string[] = [];
  @Input() permitirOtro: boolean = false;
 selected: string | null = null;
  @Input() nameGroup = `closed-question-${Math.random().toString(36).substr(2, 5)}`;
  @Output() optionsChange = new EventEmitter<string[]>();
  @Output() selectedChange = new EventEmitter<string>();


  buttondelete:ButtonWithIconConfig={
      icon: 'xmark', classList: 'btn-success', typeButton: 'button', disabled: false, iconColor:'#E43C3F', action:'removeOption',typeIcon:"fontawesome"}

  btnadd:ButtonWithIconConfig={
     icon: 'plus', classList: 'btn-success', typeButton: 'button', disabled: false, iconColor:'#ffffff', action:'removeOption',typeIcon:"fontawesome"}
  

  ngOnInit() {
    if (this.options.length === 0) {
      this.addOption();
    }
  }

  addOption() {
    this.options.push('');
    console.log(this.options, 'Mis posibles respuestas')
    this.optionsChange.emit(this.options);
    console.log('Lo que debo enviar',this.optionsChange.toString)
   
  }

  updateOption(index: number, value: string) {
    this.options[index] = value;
    this.optionsChange.emit(this.options);
  }

  removeOption(index: number) {
    this.options.splice(index, 1);
    this.optionsChange.emit(this.options);
  }

selectOption(value: string) {
  this.selected = value;
  this.selectedChange.emit(value);
}

trackByIndex(index: number, _item: any) {
  return index;
}
  readonly groupSize=5;
  get groupedOption():string[][]{
  
    const groups:string[][]=[];
    for (let i = 0; i <this.options.length; i+=this.groupSize) {
      groups.push(this.options.slice(i,i+this.groupSize));
      
    }
    return groups;
  }
}

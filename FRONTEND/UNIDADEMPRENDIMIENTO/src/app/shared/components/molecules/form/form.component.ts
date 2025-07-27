import { Component, Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from "../card/card.component";
import { InlineComponent } from '../../atoms/inline/inline.component';

@Component({
  selector: 'app-form',
  standalone: true,
  imports: [CommonModule, CardComponent,InlineComponent],
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent {
@Input() title:string='Formulario Sin título';
@Input() description:string='';
@Output() titleChange = new EventEmitter<string>();
@Output() descriptionChange = new EventEmitter<string>();


onTitleChange(newTitle:string)
{
  this.title=newTitle;
  this.titleChange.emit(newTitle);
}

onDescriptionChange(newDescription:string)
{
  this.description=newDescription;
  this.descriptionChange.emit(newDescription);
}

}

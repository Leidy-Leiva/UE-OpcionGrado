import { Component,Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InlineComponent } from 'src/app/shared/components/atoms/inline/inline.component';

@Component({
  selector: 'app-seccion',
  standalone: true,
  imports: [CommonModule,InlineComponent],
  templateUrl: './create-section.component.html',
  styleUrls: ['./create-section.component.scss']
})
export class SectionComponent {
@Input() title: string='' ;
@Input() description: string='' ;
@Output() titleChange = new EventEmitter<string>();
@Output() descriptionChange = new EventEmitter<string>();


onTitleChange(newTitle:string)
{
  this.title=newTitle;
  console.log("Este es mi title seccion:", this.title)
  this.titleChange.emit(newTitle);
}

onDescriptionChange(newDescription:string)
{
  this.description=newDescription;
  console.log("Este es mi descripcion seccion:", this.description)
  this.descriptionChange.emit(newDescription);
}
}

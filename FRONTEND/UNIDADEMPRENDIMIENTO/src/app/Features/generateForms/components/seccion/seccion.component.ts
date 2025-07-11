import { Component,Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InlineComponent } from 'src/app/shared/components/atoms/inline/inline.component';

@Component({
  selector: 'app-seccion',
  standalone: true,
  imports: [CommonModule,InlineComponent],
  templateUrl: './seccion.component.html',
  styleUrls: ['./seccion.component.css']
})
export class SeccionComponent {
@Input() title: string = '';
@Input() description: string = '';
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

import { Component,Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IconComponent } from '../../atoms/icon/icon.component';

@Component({
  selector: 'app-buttonwithicon',
  standalone: true,
  imports: [CommonModule,IconComponent],
  templateUrl: './buttonwithicon.component.html',
  styleUrls: ['./buttonwithicon.component.css']
})
export class ButtonwithiconComponent {
@Input() label:string='';
@Input() icon:string='';
@Input() classList:string='';

@Output() buttonClick = new EventEmitter<Event>();
}

import { Component,Input,Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';
import { IconComponent } from '../../atoms/icon/icon.component';
import { ButtonComponent } from "../../atoms/button/button.component";

@Component({
  selector: 'app-buttonwithicon',
  standalone: true,
  imports: [CommonModule, IconComponent, ButtonComponent],
  templateUrl: './buttonwithicon.component.html',
  styleUrls: ['./buttonwithicon.component.css']
})
export class ButtonwithiconComponent {
@Input() title?:string;
@Input() icon:string='';
@Input() classList:string='';
@Input() typeButton: 'button'|'submit'|'reset'='button';
@Input() disabled=false;
@Input() iconColor?: string='';  // Nuevo input para el color del icono
 
}
 
import { Component,Input } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-icon',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './icon.component.html',
  styleUrls: ['./icon.component.css']
})
export class IconComponent {
  @Input() name:string='';
  @Input() typeIcon:'material' | 'fontawesome' | 'bootstrap' = 'material'; 
  @Input() classList:string='';
  @Input() iconColor: string = '';  // Permite personalizar el color del icono
}

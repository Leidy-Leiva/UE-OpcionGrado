<<<<<<< HEAD
import { Component , Input} from '@angular/core';
=======
import { Component, Input,Output,EventEmitter} from '@angular/core';
>>>>>>> a483e393794e99a925fe7b707ccdcaa9e03383cb
import { CommonModule } from '@angular/common';
import { IconComponent } from '../../atoms/icon/icon.component';
import { LabelComponent } from '../../atoms/label/label.component';
import { ButtonwithiconComponent } from '../buttonwithicon/buttonwithicon.component';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [CommonModule,LabelComponent,ButtonwithiconComponent,IconComponent],
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
<<<<<<< HEAD
  @Input() title: string = 'Gestionar Emprendimientos'; // Título por defecto
=======
@Input() title?:string="";
@Input() icon?:string;
@Input() classList:string='';
@Input() typeIcon:'material' | 'fontawesome' | 'bootstrap' = 'material'; 
@Input() buttons?: ButtonwithiconComponent[];



@Output() btnClick = new EventEmitter<void>();  // 🔹 Agregamos el Output para el evento de clic

handleButtonClick() {
  this.btnClick.emit();  // 🔹 Enviar solo el índice
}
>>>>>>> a483e393794e99a925fe7b707ccdcaa9e03383cb
}

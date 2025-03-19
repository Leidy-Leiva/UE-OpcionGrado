import { Component,Input , Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from "../../molecules/card/card.component";
import { ButtonwithiconComponent } from '../../molecules/buttonwithicon/buttonwithicon.component';
import { HeaderComponent } from '../../molecules/header/header.component';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-menuoptions',
  standalone: true,
  imports: [CommonModule, ButtonwithiconComponent, CardComponent,HeaderComponent,FormsModule],
  templateUrl: './menuoptions.component.html',
  styleUrls: ['./menuoptions.component.css']
})
export class MenuoptionsComponent {
// @Input() buttons?: ButtonwithiconComponent[];
  @Output() btnClick = new EventEmitter<void>();  // 🔹 Agregamos el Output para el evento de clic

buttons = [
  { title: 'Opción 1', icon: 'home', classList: 'btn-primary', typeButton: 'button', disabled: false, iconColor: '' },
  { title: 'Opción 2', icon: 'settings', classList: 'btn-secondary', typeButton: 'button', disabled: false, iconColor: '' },
  { title: 'Opción 3', icon: 'info', classList: 'btn-info', typeButton: 'button', disabled: false, iconColor: '' }
];



}

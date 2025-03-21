import { Component,Input , Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from "../../molecules/card/card.component";
import { ButtonwithiconComponent } from '../../molecules/buttonwithicon/buttonwithicon.component';
import { HeaderComponent } from '../../molecules/header/header.component';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-menuoptions',
  standalone: true,
  imports: [CommonModule, ButtonwithiconComponent, CardComponent,FormsModule],
  templateUrl: './menuoptions.component.html',
  styleUrls: ['./menuoptions.component.css']
})
export class MenuoptionsComponent {
  @Input() buttons?: any[];
  @Output() btnClick = new EventEmitter<string>();  // 🔹 Agregamos el Output para el evento de clic

  onButtonClick(action: string) {
    this.btnClick.emit(action);
  }
}

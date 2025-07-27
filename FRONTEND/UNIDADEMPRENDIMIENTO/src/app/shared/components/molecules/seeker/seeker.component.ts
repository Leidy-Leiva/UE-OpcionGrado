import { Component,Output,EventEmitter,Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InputComponent } from '../../atoms/input/input.component';
import { ButtonwithiconComponent } from '../buttonwithicon/buttonwithicon.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
@Component({
  selector: 'app-seeker',
  standalone: true,
  imports: [CommonModule,InputComponent,ButtonwithiconComponent],
  templateUrl: './seeker.component.html',
  styleUrls: ['./seeker.component.scss'],
})
 export class SeekerComponent{
  @Input() placeholder: string = 'Buscar...';
  @Input() query: string = '';
  @Input() showButton: boolean = true;
  @Input() searchButtonConfig: ButtonWithIconConfig={
    icon: 'search',              // nombre del ícono
    typeButton: 'button',
    disabled: false,
    iconColor: '#428bca',
    action: 'buscar',
    typeIcon:'material'
  }

  @Output() queryChange = new EventEmitter<string>();
  @Output() searchClick = new EventEmitter<string>(); // envía el término

  onSearchClick() {
    this.searchClick.emit(this.query); // buena práctica: enviar el término
  }

  onQueryChange(value: string) {
    this.query = value;
    this.queryChange.emit(value);
  }
}

import { Component, Input,Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
@Input() buttons?: ButtonWithIconConfig[];
@Input() showSearch = false;


@Output() btnClick = new EventEmitter<string>(); 
@Output() searchChange = new EventEmitter<string>();

  OnButtonCkick(button: ButtonWithIconConfig) {
    if (button.action) {
      this.btnClick.emit(button.action); 
    }
  }

  onSearchChange(value: string) {
    this.searchChange.emit(value);
  }

}
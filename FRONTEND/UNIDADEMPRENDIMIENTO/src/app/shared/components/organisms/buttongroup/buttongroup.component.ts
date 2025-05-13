import { Component ,Input,Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';
import { buttonconfig } from 'src/app/shared/models/button-config';
import { ButtonComponent } from '../../atoms/button/button.component';

@Component({
  selector: 'app-buttongroup',
  standalone: true,
  imports: [CommonModule,ButtonComponent],
  templateUrl: './buttongroup.component.html',
  styleUrls: ['./buttongroup.component.css']
})
export class ButtongroupComponent {
  @Input() buttons: buttonconfig[] = [];
  @Output() btnClick = new EventEmitter<string>();

  onClick(action: string | undefined) {
    if (action) this.btnClick.emit(action);
  }
}

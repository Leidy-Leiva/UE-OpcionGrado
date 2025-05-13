import { Component,Input,Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonwithiconComponent } from '../../molecules/buttonwithicon/buttonwithicon.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';

@Component({
  selector: 'app-buttonwithicongroup',
  standalone: true,
  imports: [CommonModule,ButtonwithiconComponent],
  templateUrl: './buttonwithicongroup.component.html',
  styleUrls: ['./buttonwithicongroup.component.css']
})
export class ButtonwithicongroupComponent {
  @Input() buttons: ButtonWithIconConfig[] = [];
  @Output() btnClick = new EventEmitter<string>();

  get processedButtons(): ButtonWithIconConfig[] {
    return this.buttons.map(btn => ({
      ...btn,
      typeIcon: btn.typeIcon ?? 'material'
    }));
  }
  
}

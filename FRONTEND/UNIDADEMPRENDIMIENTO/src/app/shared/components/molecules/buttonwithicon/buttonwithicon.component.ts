import {
  Component,
  Input,
  Output,
  EventEmitter,
  HostBinding,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { IconComponent } from '../../atoms/icon/icon.component';
import { ButtonComponent } from '../../atoms/button/button.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';

@Component({
  selector: 'app-buttonwithicon',
  standalone: true,
  imports: [CommonModule, IconComponent, ButtonComponent],
  templateUrl: './buttonwithicon.component.html',
  styleUrls: ['./buttonwithicon.component.scss'],
})
export class ButtonwithiconComponent {
  @Input() buttonConfig!: ButtonWithIconConfig;
  @Output() btnClick = new EventEmitter<string>();

  get iconType(): 'material' | 'fontawesome' | 'bootstrap' {
    return this.buttonConfig.typeIcon ?? 'material';
  }

}

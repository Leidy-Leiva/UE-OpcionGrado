import { Component, EventEmitter, HostBinding, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { buttonconfig } from 'src/app/shared/models/button-config';

@Component({
  selector: 'app-button',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.scss']
})
export class ButtonComponent {
  @Input() buttonConfig!: buttonconfig;  // Recibe la configuración completa del botón
  @Output() btnClick = new EventEmitter<string>();  // Emite la acción del botón
  
  onClick(): void {
    if (!this.buttonConfig.disabled && this.buttonConfig.action) {
      this.btnClick.emit(this.buttonConfig.action);
    }
  }
}
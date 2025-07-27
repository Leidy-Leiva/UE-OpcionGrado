import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-radio-button',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './radio-button.component.html',
  styleUrls: ['./radio-button.component.scss']
})
export class RadioButtonComponent {

  @Input() name: string = ''; // ✅ Define los inputs correctamente
  @Input() value: string = '';
  @Input() label: string = '';
  @Input() checked: boolean = false;
  @Input() disabled: boolean = false;

  @Output() selectionChange = new EventEmitter<string>();

  onChecked() {
    this.selectionChange.emit(this.value);
  }

}

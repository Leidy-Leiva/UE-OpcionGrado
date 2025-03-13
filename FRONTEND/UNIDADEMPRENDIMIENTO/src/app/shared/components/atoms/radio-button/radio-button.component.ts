import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-radio-button',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './radio-button.component.html',
  styleUrls: ['./radio-button.component.css']
})
export class RadioButtonComponent {

  @Input() name: string = ''; // ✅ Define los inputs correctamente
  @Input() value: string = '';
  @Input() label: string = '';
  @Input() checked: boolean = false;
  @Input() disabled: boolean = false;
  @Input() classList: string = '';

  @Output() selectionChange = new EventEmitter<string>();

  onSelectionChange() {
    this.selectionChange.emit(this.value);
  }

}

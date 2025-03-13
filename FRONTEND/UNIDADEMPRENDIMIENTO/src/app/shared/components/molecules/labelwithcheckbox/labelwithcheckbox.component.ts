import { Component,Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../atoms/label/label.component';
import { CheckBoxComponent } from '../../atoms/check-box/check-box.component';

@Component({
  selector: 'app-labelwithcheckbox',
  standalone: true,
  imports: [CommonModule,LabelComponent,CheckBoxComponent],
  templateUrl: './labelwithcheckbox.component.html',
  styleUrls: ['./labelwithcheckbox.component.css']
})
export class LabelwithcheckboxComponent {
  @Input() label: string = 'Selecciona una opción'; // Define correctamente esta propiedad
  @Input() checked: boolean = false;  // Define correctamente esta propiedad
  @Input() disabled: boolean = false;
  @Output() checkedChange = new EventEmitter<boolean>();

  checkboxId: string = 'checkbox-' + Math.random().toString(36).substring(2, 9);

  onToggleChange(newChecked: boolean) {
    this.checked = newChecked;
    this.checkedChange.emit(newChecked);
  }
}

import { Component, Input, Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../atoms/label/label.component';
import { ComboBoxComponent } from '../../atoms/combo-box/combo-box.component';

@Component({
  selector: 'app-labelwithcombobox',
  standalone: true,
  imports: [CommonModule, LabelComponent,ComboBoxComponent],
  templateUrl: './labelwithcombobox.component.html',
  styleUrls: ['./labelwithcombobox.component.css']
})
export class LabelwithcomboboxComponent {
  @Input() label: string = 'Seleccione una opción';
  @Input() options: any[] = [];
  @Input() displayField: string = '';

  @Output() selectionChange = new EventEmitter<any>();
  onSelectionChange(selectedValue: string) {
    this.selectionChange.emit(selectedValue);
  }
}

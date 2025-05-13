import { Component,Input,Output,EventEmitter,signal} from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { LabelComponent } from "../label/label.component";

@Component({
  selector: 'app-dropdown',
  standalone: true,
  imports: [CommonModule, MatSelectModule, MatFormFieldModule],
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.css']
})
export class DropdownComponent {
  @Input() options: { value: any; label: string }[] = [];
  @Input() label: string = '';
  @Input() selectedValue: any = null;
  @Input() id: string = ''; // para conectar con label
  @Output() valueChange = new EventEmitter<any>();

  OnSelectionChange(value: any) {
    this.selectedValue = value;
    this.valueChange.emit(value);
  }
}

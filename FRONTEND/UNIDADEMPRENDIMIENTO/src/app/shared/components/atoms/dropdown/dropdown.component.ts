import {
  Component,
  Input,
  Output,
  EventEmitter,
  HostListener,
  OnInit,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-dropdown',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.scss'],
})
export class DropdownComponent implements OnInit {
  @Input() options: { label: string; value: any }[] = [];
  @Input() selectedValue: any = null;
  @Input() placeholder: string = 'Seleccione una opción';
  @Output() valueChange = new EventEmitter<any>();

  onChange() {
    this.valueChange.emit(this.selectedValue);
  }

  ngOnInit() {
    this.OptionDefault();
  }

  OptionDefault() {
    if (!this.selectedValue && this.options.length > 0) {
      this.selectedValue = this.options[0].value;
    }
  }
}

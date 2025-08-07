import { Component ,Input,Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../atoms/label/label.component';
import { InputComponent } from '../../atoms/input/input.component';

@Component({
  selector: 'app-labelwithinput',
  standalone: true,
  imports: [CommonModule,LabelComponent,InputComponent],
  templateUrl: './labelwithinput.component.html',
  styleUrls: ['./labelwithinput.component.scss']
})
export class LabelwithinputComponent {
  @Input() label: string = 'Ingrese un valor';
  @Input() typeInput: string = 'text';
  @Input() placeholder: string = 'Escriba aquí...';
  @Input() value: string = '';
  @Input() disabled: boolean = false;
  @Output() valueChange = new EventEmitter<string>();

  // Genera un ID único para asociar el label con el input
  inputId: string = 'input-' + Math.random().toString(36).substring(2, 9);

  onInputChange(newValue: string) {
    this.valueChange.emit(newValue);
  }
}

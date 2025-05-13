import { Component,Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../atoms/label/label.component';
import { DropdownComponent } from '../../atoms/dropdown/dropdown.component';

@Component({
  selector: 'app-labelwithdropdown',
  standalone: true,
  imports: [CommonModule,LabelComponent,DropdownComponent],
  templateUrl: './labelwithdropdown.component.html',
  styleUrls: ['./labelwithdropdown.component.css']
})
export class LabelwithdropdownComponent {
 @Input() label: string = '';
  @Input() id: string = '';
  @Input() options: { value: any; label: string }[] = [];
  @Input() selectedValue: any;
  @Output() valueChange = new EventEmitter<any>();
}

import { Component, Input, Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-check-box',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './check-box.component.html',
  styleUrls: ['./check-box.component.scss']
})
export class CheckBoxComponent {
  @Input() label!: string;
  @Input() checked = false;
  @Input() disabled = false;
  @Input() classList = '';
  @Output() toggleChange = new EventEmitter<boolean>();

  toggleChecked(event: Event) {
    const checked = (event.target as HTMLInputElement).checked;
    this.toggleChange.emit(checked);
  }
  
}

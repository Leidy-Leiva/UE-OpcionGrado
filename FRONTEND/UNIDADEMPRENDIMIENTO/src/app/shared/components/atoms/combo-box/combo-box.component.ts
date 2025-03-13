import { Component, Input, Output, EventEmitter, HostListener, ElementRef } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-combo-box',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './combo-box.component.html',
  styleUrls: ['./combo-box.component.css']
})
export class ComboBoxComponent {
  isComboBoxVisible = false;
  selectedOption: string | null = null;
  @Input() options: string[] = [];
  @Output() selectionChange = new EventEmitter<string>();

  constructor(private eRef: ElementRef) {}

  toggleComboBox(event: Event) {
    event.stopPropagation(); // Evita que el evento de cierre se active inmediatamente
    this.isComboBoxVisible = !this.isComboBoxVisible;
  }

  selectOption(option: string) {
    this.selectedOption = option;
    this.selectionChange.emit(option);
    this.isComboBoxVisible = false;
  }

  @HostListener('document:click', ['$event'])
  clickOutside(event: Event) {
    if (!this.eRef.nativeElement.contains(event.target)) {
      this.isComboBoxVisible = false;
    }
  }

  closeComboBox() {
    this.isComboBoxVisible = false;
  }
  
}

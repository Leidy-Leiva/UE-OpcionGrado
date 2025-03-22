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
  selectedOption:{ [key: string]: any } | null = null;
  @Input() options: Array<{ [key: string]: any }> = [];
  @Input() displayField: string = '';

  @Output() selectionChange = new EventEmitter<any>();

  constructor(private eRef: ElementRef) {}

  toggleComboBox(event: Event) {
    event.stopPropagation(); // Evita que el evento de cierre se active inmediatamente
    this.isComboBoxVisible = !this.isComboBoxVisible;
  }

  selectOption(option: any) {
    this.selectedOption = option; 
    this.selectionChange.emit(option[this.displayField]); // Emitimos solo el valor necesario
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

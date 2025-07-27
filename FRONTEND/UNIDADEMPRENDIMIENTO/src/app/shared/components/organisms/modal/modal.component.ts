import { Component,Input,Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-modal',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.scss']
})
export class ModalComponent {
  @Input() isVisible: boolean = false;
  @Input() showModal: boolean = true;  // Para controlar si la "X" aparece

  @Output() close = new EventEmitter<void>();

  closeModal() {
    this.close.emit();
  }
    
    

}

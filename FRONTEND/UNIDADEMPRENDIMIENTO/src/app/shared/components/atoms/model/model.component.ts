import { Component,Input,Output,EventEmitter} from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-model',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './model.component.html',
  styleUrls: ['./model.component.css']
})
export class ModelComponent {
  
  @Input() isVisible: boolean = false;
  @Input() title: string = '';  // Si title es 'hidden', no se mostrará
  @Input() showCloseButton: boolean = true;  // Para controlar si la "X" aparece

  @Output() close = new EventEmitter<void>();

  closeModal() {
    this.close.emit();
  }
    
    

}

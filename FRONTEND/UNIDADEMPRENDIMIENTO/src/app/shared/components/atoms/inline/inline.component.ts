import { Component,Input,EventEmitter,Output } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-inline',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './inline.component.html',
  styleUrls: ['./inline.component.css']
})
export class InlineComponent {
 @Input() placeholder = '';
  @Input() value = '';
  @Input() variant: 'titulo' | 'subtitulo' = 'titulo';
  @Output() valueChange = new EventEmitter<string>();

  onInput(event: Event) {
    const text = (event.target as HTMLElement).innerText.trim();
    this.value = text;
    this.valueChange.emit(text);
  }

    
  onFocus() {
    // opcional: cambia estilos al enfocar
  }
  
  onBlur() {
    if ((this.value || '').trim() === '') {
      this.value = '';
      this.valueChange.emit(this.value);
    }
  }

}

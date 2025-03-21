import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms'; // Necesario para [(ngModel)]

@Component({
  selector: 'app-list-group',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './list-group.component.html',
  styleUrls: ['./list-group.component.css']
})
export class ListGroupComponent {
  @Input() items: string[] = []; // Recibe la lista desde el componente padre

  // Índice del item en modo edición
  editIndex: number | null = null;
  // Texto que se está editando
  editingText: string = '';

  // Activa el modo edición para un ítem
  editItem(index: number) {
    this.editIndex = index;
    this.editingText = this.items[index];
  }

  // Actualiza el item con el nuevo valor
  updateItem(index: number) {
    if (this.editingText.trim() !== '') {
      this.items[index] = this.editingText;
    }
    this.cancelEditing();
  }

  // Cancela el modo edición sin guardar cambios
  cancelEditing() {
    this.editIndex = null;
    this.editingText = '';
  }
}

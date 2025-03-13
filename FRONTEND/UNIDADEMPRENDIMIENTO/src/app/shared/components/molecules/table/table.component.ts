import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-table',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent {
  @Input() headers: string[] = []; // 🔹 Recibe los títulos de las columnas
  @Input() data: any[] = []; // 🔹 Recibe las filas de datos
}

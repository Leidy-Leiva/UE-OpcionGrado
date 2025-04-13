import { Component, Input, Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonwithiconComponent } from '../../molecules/buttonwithicon/buttonwithicon.component';

@Component({
  selector: 'app-table',
  standalone: true,
  imports: [CommonModule,ButtonwithiconComponent],
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
  
export class TableComponent {
  @Input() headers: string[] = []; // Encabezados de las columnas
  @Input() data: any[] = []; // Datos de las filas
  @Input() buttons?: ButtonwithiconComponent[];  // Define los botones y sus propiedades
  @Output() btnClick = new EventEmitter<void>();  // 🔹 Agregamos el Output para el evento de clic

}

   
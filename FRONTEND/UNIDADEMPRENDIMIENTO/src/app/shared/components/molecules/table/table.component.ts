import { Component, Input, Output,EventEmitter, OnChanges, SimpleChanges, Injector, inject, TemplateRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { ButtonwithicongroupComponent } from '../../organisms/buttonwithicongroup/buttonwithicongroup.component';
import { LabelComponent } from '../../atoms/label/label.component';
import { MatTableModule } from '@angular/material/table';
import { MatSortModule, Sort } from '@angular/material/sort';
import { MatPaginatorModule, PageEvent } from '@angular/material/paginator';
import { ColumnDef } from 'src/app/shared/models/ColumnDef-config';

@Component({
  selector: 'app-table',
  standalone: true,
  imports: [CommonModule,ButtonwithicongroupComponent, LabelComponent,
    MatTableModule,MatSortModule,MatPaginatorModule],
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
  
export class TableComponent<T> implements OnChanges {
  @Input() columns!: ColumnDef<T>[];
  @Input() data: T[] = [];
  @Input() total = 0;
  @Input() pageSize = 10;

  /**
   * Plantilla para la columna de acciones (botones, checkboxes, etc.)
   * Debe recibir un contexto `$implicit` con la fila
   */
  @Input() actionsTemplate?: TemplateRef<any>;

  @Output() sortChange = new EventEmitter<Sort>();
  @Output() pageChange = new EventEmitter<PageEvent>();
  @Output() edit = new EventEmitter<T>();
  @Output() delete = new EventEmitter<T>();

  displayedKeys: string[] = [];

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['columns']) {
      this.displayedKeys = this.columns.map((c) => c.key.toString()).concat('actions');
    }
  }

  /**
   * Crea un injector para pasar inputs dinámicos al componente embebido
   */
  createInjector(col: ColumnDef<T>, row: T): Injector {
    const parent = inject(Injector);
    return Injector.create({
      providers: [
        {
          provide: 'inputs',
          useValue: col.componentInputs ? col.componentInputs(row) : {},
        },
      ],
      parent,
    });
  }

  /**
   * Emite eventos de acción desde la plantilla de acciones
   */
  onAction(row: T, action: string): void {
    if (action === 'edit') this.edit.emit(row);
    if (action === 'delete') this.delete.emit(row);
  }
}

 


  
import { Component, Input, Output,EventEmitter, OnChanges, SimpleChanges } from '@angular/core';
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

  @Output() sortChange = new EventEmitter<Sort>();
  @Output() pageChange = new EventEmitter<PageEvent>();
  @Output() edit = new EventEmitter<T>();
  @Output() delete = new EventEmitter<T>();
  displayedKeys: (string)[] = [];


  buttontable:ButtonWithIconConfig[]=[
    {icon: 'edit', classList: 'btn-success main-header__button', typeButton: 'button', disabled: false, iconColor:'#FBBE39', action: 'edit' },
    {icon: 'delete', classList: 'btn-success main-header__button', typeButton: 'button', disabled: false, iconColor:'#E43C3F', action: 'delete' },
  ]


  
   // Se dispara cuando cambian los @Input
   ngOnChanges(changes: SimpleChanges): void {
    if (changes['columns']) {
      this.displayedKeys = this.columns.map(c => c.key.toString()).concat('actions');
    }
}
    

  onAction(row: T, action: string): void {
    if (action === 'edit') {
      this.edit.emit(row);
    }
    if (action === 'delete') {
      this.delete.emit(row);
    }
  }
}

 


  
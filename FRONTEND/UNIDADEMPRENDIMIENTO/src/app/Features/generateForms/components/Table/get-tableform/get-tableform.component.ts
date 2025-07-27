import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormArray,
  FormBuilder,
  FormGroup,
  ReactiveFormsModule,
} from '@angular/forms';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';

@Component({
  selector: 'app-get-tableform',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    ButtonwithiconComponent,
    LabelComponent,
  ],
  templateUrl: './get-tableform.component.html',
  styleUrls: ['./get-tableform.component.scss'],
})
export class GetTableformComponent implements OnInit {
  @Input() enunciado!: string;
  @Input() columns: {
    key: string;
    label: string;
    isCalculated?: boolean;
    formula?: (row: any) => number;
  }[] = [];

  @Input() rows: { key: string; label: string }[] = [];

  btndelete: ButtonWithIconConfig = {
    icon: 'xmark',
    typeButton: 'button',
    disabled: false,
    iconColor: '#E43C3F',
    action: 'removeOption',
    typeIcon: 'fontawesome',
  };

  btnadd: ButtonWithIconConfig = {
    icon: 'plus',
    typeButton: 'button',
    disabled: false,
    iconColor: '#ffffff',
    action: 'AddOption',
    typeIcon: 'fontawesome',
  };

  // Arreglo reactivo que representa las filas con sus columnas
  formRows!: FormArray;

  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {
    this.formRows = this.fb.array([]);

    // Inicializa una fila por defecto (puedes cambiar la cantidad inicial)
    this.addRow();
  }

  // Agrega una nueva fila al arreglo de formularios
  addRow(): void {
    const group = this.fb.group({});

    // Por cada columna, agrega un control al grupo
    this.columns.forEach((col) => {
      const value = col.isCalculated ? { value: '', disabled: true } : '';
      group.addControl(col.key, this.fb.control(value));
    });

    // Suscríbete a cambios en el grupo para recalcular si hay campos calculados
    group.valueChanges.subscribe((values) => {
      this.columns.forEach((col) => {
        if (col.isCalculated && col.formula) {
          const result = col.formula(values);
          group.get(col.key)?.setValue(result, { emitEvent: false });
        }
      });
    });

    this.formRows.push(group);
  }

  // Elimina una fila por índice
  removeRow(index: number): void {
    this.formRows.removeAt(index);
  }

  // Devuelve el valor de todas las filas (útil para guardar o emitir datos)
  get tableData(): any[] {
    return this.formRows.getRawValue();
  }

  get formGroups(): FormGroup[] {
    return this.formRows.controls as FormGroup[];
  }
}

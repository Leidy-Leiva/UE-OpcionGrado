import { Component, EventEmitter, OnInit, Output, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormArray,
  FormBuilder,
  FormGroup,
  Validators,
  ReactiveFormsModule,
} from '@angular/forms';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { InputComponent } from 'src/app/shared/components/atoms/input/input.component';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';
import { LabelwithinputComponent } from 'src/app/shared/components/molecules/labelwithinput/labelwithinput.component';

@Component({
  selector: 'app-table-form-builder',
  standalone: true,
  imports: [
    CommonModule,
    ButtonwithiconComponent,
    InputComponent,
    ReactiveFormsModule,
    LabelComponent,
    LabelwithinputComponent,
  ],
  templateUrl: './table-form-builder.component.html',
  styleUrls: ['./table-form-builder.component.scss'],
})
export class TableFormBuilderComponent implements OnInit {
  @Input() enunciado: string = '';
  
  @Output() questionChange = new EventEmitter<string>();
  @Output() formDefinition = new EventEmitter<{
    columns: { key: string; label: string }[];
    rows: any[];
  }>();

  form: FormGroup;

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      columns: this.fb.array([]),
      rows: this.fb.array([]),
    });
  }

  ngOnInit() {
    this.addColumn();
    this.addRow();
    this.emitDefinition();
  }

  onQuestionChange(newValue: string) {
    this.enunciado = newValue;
    this.questionChange.emit(newValue);
  }

  get columns(): FormArray {
    return this.form.get('columns') as FormArray;
  }

  get rows(): FormArray {
    return this.form.get('rows') as FormArray;
  }

  private newColumn(): FormGroup {
    return this.fb.group({
      key: ['', Validators.required],
      label: ['', Validators.required],
    });
  }

  addColumn() {
    this.columns.push(this.newColumn());
    this.emitDefinition();
  }

  removeColumn(i: number) {
    const removedKey = this.columns.at(i).value.key; // Guardamos la key a eliminar
    this.columns.removeAt(i);
    this.rows.controls.forEach((row) =>
      (row as FormGroup).removeControl(removedKey)
    );
    this.emitDefinition();
  }

  private newRow(): FormGroup {
    const group: Record<string, any> = {
      label: ['', Validators.required],
    };
    this.columns.value.forEach((col: any) => {
      group[col.key] = [''];
    });
    return this.fb.group(group);
  }

  addRow() {
    this.rows.push(this.newRow());
    this.emitDefinition();
  }

  removeRow(i: number) {
    this.rows.removeAt(i);
    this.emitDefinition();
  }

  private emitDefinition() {
    this.formDefinition.emit({
      columns: this.columns.value,
      rows: this.rows.value,
    });
  }

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

  onRowLabelChange(index: number, newValue: string) {
    const row = this.rows.at(index) as FormGroup;
    row.patchValue({ label: newValue });
    this.emitDefinition();
  }

  onColumnLabelChange(index: number, newValue: string) {
    const column = this.columns.at(index) as FormGroup;
    column.patchValue({ label: newValue });
    this.emitDefinition();
  }

  get groupedRows(): FormGroup[][] {
    const groupSize = 5;
    const allRows = this.rows.controls as FormGroup[];
    const groups: FormGroup[][] = [];
    for (let i = 0; i < allRows.length; i += groupSize) {
      groups.push(allRows.slice(i, i + groupSize));
    }
    return groups;
  }

  get groupedColumns(): FormGroup[][] {
    const groupSize = 5;
    const allCols = this.columns.controls as FormGroup[];
    const groups: FormGroup[][] = [];
    for (let i = 0; i < allCols.length; i += groupSize) {
      groups.push(allCols.slice(i, i + groupSize));
    }
    return groups;
  }
  
  trackByGroup(index: number, _group: any[]): number {
    return index;
  }

  trackByIndex(index: number, _item: any): number {
    return index;
  }
}

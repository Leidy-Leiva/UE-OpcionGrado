import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import {
  AbstractControl,
  FormArray,
  FormBuilder,
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { CheckBoxComponent } from 'src/app/shared/components/atoms/check-box/check-box.component';
import { ScheduleDefinition } from '../models/ScheduleDefinition-config';
import { ScheduleRow } from '../models/SheduleRow-config';

@Component({
  selector: 'app-get-schedule',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    LabelComponent,
    ButtonwithiconComponent,
    CheckBoxComponent,
  ],
  templateUrl: './get-schedule.component.html',
  styleUrls: ['./get-schedule.component.scss'],
})
export class GetScheduleComponent implements OnChanges {
  @Input() definition!: ScheduleDefinition;

  form!: FormGroup;

  btnadd: ButtonWithIconConfig = {
    icon: 'plus',
    typeButton: 'button',
    disabled: false,
    iconColor: '#fff',
    typeIcon: 'fontawesome',
    action: 'add',
  };

  btndelete: ButtonWithIconConfig = {
    icon: 'xmark',
    typeButton: 'button',
    disabled: false,
    iconColor: '#E43C3F',
    typeIcon: 'fontawesome',
    action: 'DeleteOption',
  };

  constructor(private fb: FormBuilder) {}

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['definition'] && this.definition) {
      console.log('[GetScheduleComponent] Recibí definición:', this.definition); // <-- ¿se imprime esto?
      this.buildForm(this.definition);
    }
  }

  private buildForm(def: ScheduleDefinition) {
    this.form = this.fb.group({
      title: [def.title],
      enunciado: [def.enunciado],
      startMonth: [def.startMonth],
      endMonth: [def.endMonth],
      rows: this.fb.array(def.rows.map((r) => this.buildRowGroup(r, def))),
    });

    console.log('[GetScheduleComponent] Formulario cargado:', this.form.value);
  }

  private buildRowGroup(row: ScheduleRow, def: ScheduleDefinition): FormGroup {
    const months = def.endMonth - def.startMonth + 1;
    const valuesFGs = row.values.map((weekArr) =>
      this.fb.array(weekArr.map((v) => this.fb.control(v)))
    );
    return this.fb.group({
      label: [row.label],
      values: this.fb.array(valuesFGs),
    });
  }

  get title(): string {
    return this.form?.get('title')?.value ?? '';
  }

  get enunciado(): string {
    return this.form?.get('enunciado')?.value ?? '';
  }

  get rows(): FormArray {
    return this.form.get('rows') as FormArray;
  }

  monthHeaders(): number[] {
    const start = this.form.get('startMonth')!.value;
    const end = this.form.get('endMonth')!.value;
    return Array.from({ length: end - start + 1 }, (_, i) => start + i);
  }

  getValues(i: number): FormArray {
    return this.rows.at(i).get('values') as FormArray;
  }

  addRows() {
    const def = this.definition;
    const months = def.endMonth - def.startMonth + 1;
    const emptyRow: ScheduleRow = {
      label: '',
      values: Array.from({ length: months }, () => [false,false,false,false,]),
    };
    this.rows.push(this.buildRowGroup(emptyRow, def));
  }

  removeRow(i: number) {
    this.rows.removeAt(i);
  }

  asFormArray(ctrl: AbstractControl): FormArray {
    return ctrl as FormArray;
  }

  castToFormControl(control: AbstractControl): FormControl<boolean> {
    return control as FormControl<boolean>;
  }
}

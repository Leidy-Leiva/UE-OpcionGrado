import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelwithinputComponent } from 'src/app/shared/components/molecules/labelwithinput/labelwithinput.component';
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
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { CheckBoxComponent } from 'src/app/shared/components/atoms/check-box/check-box.component';
import { ScheduleDefinition } from '../models/ScheduleDefinition-config';

@Component({
  selector: 'app-create-schedule',
  standalone: true,
  imports: [
    CommonModule,
    LabelwithinputComponent,
    ReactiveFormsModule,
    ButtonwithiconComponent,
    CheckBoxComponent,
  ],
  templateUrl: './create-schedule.component.html',
  styleUrls: ['./create-schedule.component.scss'],
})
export class CreateScheduleComponent implements OnInit {
  @Input() title: string = '';
  @Input() enunciado: string = '';
  @Output() scheduleChange = new EventEmitter<ScheduleDefinition>();
  @Output() validityChange = new EventEmitter<boolean>();

  form: FormGroup;

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group(
      {
        rows: this.fb.array<FormGroup>([]),
        title: ['', Validators.required],
        enunciado: ['', Validators.required],
        firstColumnLabel: ['Actividad', Validators.required],
        startMonth: [
          1,
          [Validators.required, Validators.min(1), Validators.max(12)],
        ],
        endMonth: [
          3,
          [Validators.required, Validators.min(1), Validators.max(12)],
        ],
      },
      { validators: this.rangeValidator }
    );
  }

  asFormArray(ctrl: AbstractControl): FormArray {
    return ctrl as FormArray;
  }

  castToFormControl(control: AbstractControl): FormControl<boolean> {
    return control as FormControl<boolean>;
  }

  btnadd: ButtonWithIconConfig = {
    icon: 'plus',
    typeButton: 'button',
    disabled: false,
    iconColor: '#ffffff',
    action: 'AddOption',
    typeIcon: 'fontawesome',
  };

  btndelete: ButtonWithIconConfig = {
    icon: 'xmark',
    typeButton: 'button',
    disabled: false,
    iconColor: '#E43C3F',
    typeIcon: 'fontawesome',
    action: 'DeleteOption',
  };

  ngOnInit(): void {
    this.form.valueChanges.subscribe((value) => {
      this.scheduleChange.emit(value);
    });

    this.form.statusChanges.subscribe((status) => {
      this.validityChange.emit(status === 'VALID');
    });

    this.form.get('startMonth')!.valueChanges.subscribe(() => this.resetRows());
    this.form.get('endMonth')!.valueChanges.subscribe(() => this.resetRows());

    this.addRows();
  }

  private rangeValidator(group: FormGroup) {
    const start = group.get('startMonth')!.value;
    const end = group.get('endMonth')!.value;
    return start <= end ? null : { rangeInvalid: true };
  }

  get monthHeaders() {
    const start = this.form.get('startMonth')!.value;
    const end = this.form.get('endMonth')!.value;
    const headers: { name: string; weeks: number[] }[] = [];

    for (let m = start; m <= end; m++) {
      headers.push({ name: `Mes ${m}`, weeks: [1, 2, 3, 4] });
    }
    return headers;
  }

  private buildRow(): FormGroup {
    const headers = this.monthHeaders;

    const valuesArrays = headers.map(() => {
      const weeksArray = this.fb.array(
        Array.from({ length: 4 }, () => this.fb.control(false))
      );
      return weeksArray;
    });
    return this.fb.group({
      label: ['', Validators.required],
      values: this.fb.array(valuesArrays),
    });
  }

  get rows() {
    return this.form.get('rows') as FormArray;
  }

  addRows() {
    this.rows.push(this.buildRow());
    this.emitChange();
  }

  removeRow(i: number) {
    this.rows.removeAt(i);
    console.log('Acabo de dar click');
    this.emitChange();
  }

  getValues(i: number) {
    return this.rows.at(i).get('values') as FormArray;
  }

  private resetRows() {
    const data: string[] = this.rows.value.map(
      (r: { label: string }) => r.label
    );
    this.rows.clear();
    data.forEach((label: string) => {
      const row = this.buildRow();
      row.get('label')!.setValue(label);
      this.rows.push(row);
    });
  }

  private emitChange() {
    if (this.form.valid) {
      const def: ScheduleDefinition = {
        title: this.form.value.title,
        enunciado: this.form.value.enunciado,
        startMonth: this.form.value.startMonth,
        endMonth: this.form.value.endMonth,
        rows: this.form.value.rows, 
      };
      this.scheduleChange.emit(def);
    }
  }

  onTitleChange(newValue: string) {
    this.title = newValue;
    this.form.get('title')!.setValue(newValue);
    this.form.get('title')!.markAsTouched();
  }

  onQuestionChange(newValue: string) {
    this.enunciado = newValue;
    this.form.get('enunciado')!.setValue(newValue);
    this.form.get('enunciado')!.markAsTouched();
  }
}

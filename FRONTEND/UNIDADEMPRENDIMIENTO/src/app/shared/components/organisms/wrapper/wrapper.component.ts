import {
  Component,
  ComponentRef,
  EventEmitter,
  Output,
  ViewChild,
  ViewContainerRef,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonwithiconComponent } from '../../molecules/buttonwithicon/buttonwithicon.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { Action } from 'rxjs/internal/scheduler/Action';
import { ElementsFormMapper } from 'src/app/shared/mappers/generate-forms.mapper';

@Component({
  selector: 'app-wrapper',
  standalone: true,
  imports: [CommonModule, ButtonwithiconComponent],
  templateUrl: './wrapper.component.html',
  styleUrls: ['./wrapper.component.css'],
})
export class WrapperComponent {
  @Output() delete = new EventEmitter<void>();
  @ViewChild('componentsForm', { read: ViewContainerRef })
  viewContainer!: ViewContainerRef;

  buttondelete: ButtonWithIconConfig = {
    title:'Eliminar',
    icon: 'delete',
    classList: 'btnDelete',
    typeButton: 'button',
    disabled: false,
    iconColor: '#ffffff',
    showText:false,
    action: 'delete'
  };

  onDelete() {
    this.delete.emit();
  }
}
    

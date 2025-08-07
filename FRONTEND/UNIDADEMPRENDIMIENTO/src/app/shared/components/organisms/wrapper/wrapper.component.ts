import {
  Component,
  Input,
  EventEmitter,
  Output,
  ViewChild,
  ViewContainerRef,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonwithiconComponent } from '../../molecules/buttonwithicon/buttonwithicon.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';

@Component({
  selector: 'app-wrapper',
  standalone: true,
  imports: [CommonModule, ButtonwithiconComponent],
  templateUrl: './wrapper.component.html',
  styleUrls: ['./wrapper.component.scss'],
})
export class WrapperComponent {
  @Input() mode: 'create' | 'edit' | 'view' = 'view';

  @Output() delete = new EventEmitter<void>();
  @Output() edit = new EventEmitter<void>();

  @ViewChild('componentsForm', { read: ViewContainerRef, static: true })
  viewContainer!: ViewContainerRef;

  buttondelete: ButtonWithIconConfig = {
    title: 'Eliminar',
    icon: 'delete',
    classList: 'btnDelete',
    typeButton: 'button',
    disabled: false,
    iconColor: '#ffffff',
    showText: false,
    action: 'delete',
  };

  onDelete() {
    this.delete.emit();
  }

  clear() {
  this.viewContainer.clear();
  }

  onWrapperClick(event: MouseEvent) {
    const target = event.target as HTMLElement;

    if (target.closest('.btnDelete')) {
      return;
    }

    if (event.target === event.currentTarget) {
      this.edit.emit();
    }
  }
}

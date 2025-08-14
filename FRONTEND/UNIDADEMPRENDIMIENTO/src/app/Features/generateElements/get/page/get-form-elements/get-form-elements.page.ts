import {
  Component,
  ComponentRef,
  OnInit,
  ViewChild,
  ViewContainerRef,
  Output,
  EventEmitter,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';
import { SeekerComponent } from 'src/app/shared/components/molecules/seeker/seeker.component';
import { ButtonwithiconComponent } from '../../../../../shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { TableComponent } from 'src/app/shared/components/molecules/table/table.component';
import { ColumnDef } from 'src/app/shared/models/ColumnDef-config';
import { PageEvent } from '@angular/material/paginator';
import { FormElement } from 'src/app/shared/models/FormElement-config';
import { ModalComponentMapper } from 'src/app/shared/mappers/generate-elements.mapper';
import { Sort } from '@angular/material/sort';
import { ButtonwithicongroupComponent } from 'src/app/shared/components/organisms/buttonwithicongroup/buttonwithicongroup.component';
import { BancoElementoService } from 'src/app/core/services/banco-elemento.service';
import { GetBEFormularioDTO } from 'src/app/core/models/ELEMENTSFORM/GetBEFormularioDTO';
import { TipoElemento } from 'src/app/core/models/ELEMENTSFORM/TipoElemento';

@Component({
  selector: 'app-get-form-elements',
  standalone: true,
  imports: [
    CommonModule,
    HeaderComponent,
    SeekerComponent,
    ButtonwithicongroupComponent,
    TableComponent,
    ButtonwithiconComponent,
  ],
  templateUrl: './get-form-elements.page.html',
  styleUrls: ['./get-form-elements.page.scss'],
})
export class GetFormElements implements OnInit {
  selectedElement?: FormElement;
  @ViewChild('modalContainer', { read: ViewContainerRef, static: true })
  private modalHost!: ViewContainerRef;
  private activeModalRef?: ComponentRef<any>;

  @Output() edit = new EventEmitter();
  @Output() delete = new EventEmitter();

  constructor(private bancoElementoService: BancoElementoService) {}

  buttontable: ButtonWithIconConfig[] = [
    {
      icon: 'edit',
      classList: 'btnEdit',
      typeButton: 'button',
      disabled: false,
      iconColor: '#ffffff',
      action: 'edit',
    },
    {
      icon: 'delete',
      classList: 'btnDelete',
      typeButton: 'button',
      disabled: false,
      iconColor: '#ffffff',
      action: 'delete',
    },
  ];

  columns: ColumnDef<FormElement>[] = [
    { key: 'tipo', label: 'Tipo de pregunta' },
    { key: 'pregunta', label: 'Enunciado' },
  ];

  // Datos y paginación
  preguntas: FormElement[] = []; // aquí llenas con tu servicio
  total = 0; // total de registros para paginador
  pageSize = 10; // filas por página

  buttonHeaderGet: ButtonWithIconConfig = {
    icon: 'plus',
    classList: 'solid',
    typeButton: 'button',
    disabled: false,
    iconColor: '#ffffff',
    action: 'crear',
    typeIcon: 'fontawesome',
  };

  async handleAction(action: string, payload?: any): Promise<void> {
    this.modalHost.clear();
    this.activeModalRef = undefined;

    try {
      const loadFn = ModalComponentMapper[action];
      if (!loadFn) {
        console.warn(`Acción desconocida: ${action}`);
        return;
      }
      const compType = await loadFn();
      this.activeModalRef = this.modalHost.createComponent(compType);
      const instance = this.activeModalRef.instance as {
        isModalOpen?: boolean;
        element?: FormElement;
        closeModal?: any;
      };

      instance.isModalOpen = true;

      if (action === 'editar' && payload) {
        instance.element = payload as FormElement;
      }

      instance.closeModal?.subscribe(() => this.modalHost.clear());
    } catch (err) {
      console.error('Error al abrir modal:', err);
    }
  }

  onCreateClick(): void {
    this.handleAction('crear');
  }

  onEditClick(element: FormElement): void {
    this.handleAction('editar', element);
  }
  onDeleteClick(element: FormElement): void {
    this.handleAction('editar', element);
  }

  ngOnInit(): void {
    this.total = this.preguntas.length;
    this.loadData();
  }

  loadData(): void {
    this.bancoElementoService.getAll().subscribe({
      next: (res: GetBEFormularioDTO[]) => {
        console.log('Datos crudos del backend:', res);
        this.preguntas = res.map((item) => ({
          tipo: TipoElemento[+item.tefO_CODIGO], // convierte string a number y busca el enum
          pregunta: item.befO_ENUNCIADO,
        }));
        this.total = this.preguntas.length;
      },
      error: (err) => console.error('Error al obtener datos:', err),
    });
  }

  onSort(sort: Sort): void {}

  onPage(page: PageEvent): void {}

  onAction(action: string): void {
    if (action === 'edit') {
      this.edit.emit();
    }
    if (action === 'delete') {
      this.delete.emit();
    }
  }
}

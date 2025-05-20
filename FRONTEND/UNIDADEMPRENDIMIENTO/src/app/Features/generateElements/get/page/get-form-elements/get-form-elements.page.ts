import { Component, ComponentRef, OnInit, ViewChild, ViewContainerRef,Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';
import { SeekerComponent } from 'src/app/shared/components/molecules/seeker/seeker.component';
import { ButtonwithiconComponent } from "../../../../../shared/components/molecules/buttonwithicon/buttonwithicon.component";
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { TableComponent } from 'src/app/shared/components/molecules/table/table.component';
import { ColumnDef } from 'src/app/shared/models/ColumnDef-config';
import { PageEvent } from '@angular/material/paginator';
import { FormElement } from 'src/app/shared/models/FormElement-config';
import { ModalComponentMapper } from 'src/app/shared/mappers/generate-elements.mapper'; 
import { Sort } from '@angular/material/sort';

@Component({
  selector: 'app-get-form-elements',
  standalone: true,
  imports: [CommonModule, HeaderComponent, SeekerComponent, ButtonwithiconComponent,TableComponent],
  templateUrl: './get-form-elements.page.html',
  styleUrls: ['./get-form-elements.page.css']
})
export class GetFormElements implements OnInit  {
selectedElement?: FormElement;

@ViewChild('modalContainer',{read:ViewContainerRef,static:true})
   private modalHost!: ViewContainerRef;

  private activeModalRef?: ComponentRef<any>;
  // Configuración de columnas para este componente
  columns: ColumnDef<FormElement>[] = [
    { key: 'tipo',     label: 'Tipo de pregunta' },
    { key: 'pregunta', label: 'Pregunta'     }
  ];

  // Datos y paginación
  preguntas: FormElement[] = [
    { tipo: 'Cerrada',        pregunta: '¿Está Libre?' },
    { tipo: 'Abierta',        pregunta: 'Describa su experiencia' },
    { tipo: 'Opción Múltiple', pregunta: 'Elija su color favorito' },
    { tipo: 'Cerrada',        pregunta: '¿Aprueba el cambio?' },
    { tipo: 'Abierta',        pregunta: 'Comentarios adicionales' }
  ];// aquí llenas con tu servicio
  total = 0;                // total de registros para paginador
  pageSize = 10;            // filas por página


buttonHeaderGet:ButtonWithIconConfig={
    icon: 'plus', classList: 'solid', typeButton: 'button', disabled: false, iconColor:'#ffffff', action:'crear',typeIcon:"fontawesome"
}


 constructor(
    // private readonly elementService: /* tu servicio aquí */ any
  ) {}

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

      // 6.4) Pass data & subscribe to close event
      const instance = this.activeModalRef.instance as { 
        isModalOpen?: boolean;
        element?: FormElement;
        closeModal?: any;
      };
      // Abro el modal
      instance.isModalOpen = true;

      // Si viene payload (editar)
      if (action === 'editar' && payload) {
        instance.element = payload as FormElement;
      }

      // Escucho evento cerrar para limpiar
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

    // ----------------------------------------
  // 4) Ciclo de vida: carga inicial de datos
  // ----------------------------------------
  ngOnInit(): void {
    this.loadData();
  }

  // ----------------------------------------
  // 5) Carga de datos paginada y ordenada
  // ----------------------------------------
  loadData(sort?: Sort, page?: PageEvent): void {
  //   const params = {
  //     page: page?.pageIndex ?? 0,
  //     size: page?.pageSize ?? this.pageSize,
  //     sort: sort?.active ?? '',
  //     dir: sort?.direction ?? ''
  //   };
  //   this.elementService.getAll(params)
  //     .subscribe(res => {
  //       this.preguntas = res.items;
  //       this.total = res.total;
  //     });
  }

  onSort(sort: Sort): void {
    this.loadData(sort, undefined);
  }

  onPage(page: PageEvent): void {
    this.loadData(undefined, page);
  }


}




























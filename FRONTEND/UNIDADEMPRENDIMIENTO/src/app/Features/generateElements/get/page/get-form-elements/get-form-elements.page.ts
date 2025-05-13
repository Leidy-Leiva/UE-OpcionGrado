import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';
import { SeekerComponent } from 'src/app/shared/components/molecules/seeker/seeker.component';
import { ButtonwithiconComponent } from "../../../../../shared/components/molecules/buttonwithicon/buttonwithicon.component";
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { TableComponent } from 'src/app/shared/components/molecules/table/table.component';
import { ColumnDef } from 'src/app/shared/models/ColumnDef-config';
import { Sort } from '@angular/material/sort';
import { PageEvent } from '@angular/material/paginator';
import { FormElement } from 'src/app/shared/models/FormElement-config';


@Component({
  selector: 'app-get-form-elements',
  standalone: true,
  imports: [CommonModule, HeaderComponent, SeekerComponent, ButtonwithiconComponent,TableComponent],
  templateUrl: './get-form-elements.page.html',
  styleUrls: ['./get-form-elements.page.css']
})
export class GetFormElements  {
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
    icon: 'plus', classList: 'solid', typeButton: 'button', disabled: false, iconColor:'#ffffff', action:'Crear',typeIcon:"fontawesome"
}


handleAction(action: string) {
  console.log('Acción del menú:', action);

  switch(action) {
    case 'Crear':
      break;
    default:
      console.warn('Acción no reconocida:', action);
  }
}

ngOnInit() {
  this.loadData(); // inicializa datos al cargar el componente
}

// Recupera datos desde backend según sort y paginado
loadData(sort?: Sort, pageEvent?: PageEvent) {
  // Lógica de llamada a servicio...
  // Ejemplo: this.service.getAll({ page: pageEvent?.pageIndex, size: pageEvent?.pageSize, sort: sort?.active, dir: sort?.direction })
  // .subscribe(response => { this.elements = response.items; this.total = response.total; });
}

// Maneja evento de ordenamiento
onSort(sort: Sort) {
  this.loadData(sort, undefined);
}

// Maneja evento de cambio de página
onPage(pageEvent: PageEvent) {
  this.loadData(undefined, pageEvent);
}

onEdit(element: FormElement) {
  console.log('Editar:', element);
}

onDelete(element: FormElement) {
  console.log('Eliminar:', element);
}

}

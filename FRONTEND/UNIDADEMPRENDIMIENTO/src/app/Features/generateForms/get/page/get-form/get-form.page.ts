import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';
import { SeekerComponent } from 'src/app/shared/components/molecules/seeker/seeker.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { TableComponent } from 'src/app/shared/components/molecules/table/table.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { ColumnDef } from 'src/app/shared/models/ColumnDef-config';
import { Sort } from '@angular/material/sort';
import { PageEvent } from '@angular/material/paginator';
import { getForm } from '../../../models/getForm.config';
import { Router } from '@angular/router';
import { ButtonwithicongroupComponent } from 'src/app/shared/components/organisms/buttonwithicongroup/buttonwithicongroup.component';

@Component({
  selector: 'app-get-form',
  standalone: true,
  imports: [
    CommonModule,
    HeaderComponent,
    SeekerComponent,
    ButtonwithiconComponent,
    TableComponent,
    ButtonwithicongroupComponent,
  ],
  templateUrl: './get-form.page.html',
  styleUrls: ['./get-form.page.scss'],
})
export class GetForm implements OnInit {
  @Output() edit = new EventEmitter();
  @Output() delete = new EventEmitter();

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
      classList:'btnDelete',
      typeButton: 'button',
      disabled: false,
      iconColor: '#ffffff',
      action: 'delete',
    },
  ];

  constructor(private router: Router) {}

  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  columns: ColumnDef<getForm>[] = [
    { key: 'tipo', label: 'Tipo de Formulario' },
    { key: 'nombre', label: 'Formulario' },
  ];

  // Datos y paginación
  preguntas: getForm[] = [
    { tipo: 'Formulario', nombre: '¿Está Libre?' },
    { tipo: 'Formulario', nombre: 'Describa su experiencia' },
    { tipo: 'Formulario', nombre: 'Elija su color favorito' },
    { tipo: 'Modelo Financiero', nombre: '¿Aprueba el cambio?' },
    { tipo: 'Modelo Financiero', nombre: 'Comentarios adicionales' },
  ]; // aquí llenas con tu servicio
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

  onCreateClick(): void {
    this.handleAction('crear');
  }
  onEditClick(element: getForm): void {
    // this.handleAction('editar', element);
  }
  onDeleteClick(element: getForm): void {
    // this.handleAction('editar', element);
  }

  onSort(sort: Sort): void {
    this.loadData(sort, undefined);
  }

  onPage(page: PageEvent): void {
    this.loadData(undefined, page);
  }

  onAction(action: string): void {
    if (action === 'edit') {
      this.edit.emit();
    }
    if (action === 'delete') {
      this.delete.emit();
    }
  }

  async handleAction(action: string) {
    switch (action) {
      case 'crear':
        this.router.navigate(['/generate-form/crear']);
        break;
    }
  }
}

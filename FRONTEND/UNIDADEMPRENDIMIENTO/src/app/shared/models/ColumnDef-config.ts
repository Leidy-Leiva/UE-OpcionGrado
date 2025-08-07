import { TemplateRef } from '@angular/core';

export interface ColumnDef<T> {
  key: keyof T;
  label: string;
  sortable?: boolean;
  formatter?: (v: any) => string;
  width?: string;
  component?: any; // <- Nuevo: componente dinámico a renderizar
  componentInputs?: (row: T) => Record<string, any>; // <- Inputs dinámicos para ese componente
}
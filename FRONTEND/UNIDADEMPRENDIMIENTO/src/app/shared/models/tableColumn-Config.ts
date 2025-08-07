import { TemplateRef, Type } from '@angular/core';

export interface TableColumnConfig {
  key: string;
  label: string;
  width?: string;
  component?: Type<any>; // Componente dinámico
  formatter?: (value: any) => string;
}
import { ColumnDef } from './ColumnDef-config';

export interface TableQuestion {
  enunciado: string;
  columns: ColumnDef<any>[];
  rows?: any[];
}

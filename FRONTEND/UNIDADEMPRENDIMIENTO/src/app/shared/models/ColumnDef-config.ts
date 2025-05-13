export interface ColumnDef<T> {
    key: keyof T;
    label: string;
    sortable?: boolean;
    formatter?: (v: any) => string;
    width?: string;
  }
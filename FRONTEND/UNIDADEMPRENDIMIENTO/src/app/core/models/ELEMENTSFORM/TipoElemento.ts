export enum TipoElemento {
  Abierta = 1,
  Cerrada = 2,
  Multiple = 3,
  Seccion = 4,
  Cronograma = 5,
  Tabla = 6
}
export function isQuestionType(tipo: TipoElemento): boolean {
  return tipo === TipoElemento.Abierta || tipo === TipoElemento.Cerrada || tipo === TipoElemento.Multiple;
}
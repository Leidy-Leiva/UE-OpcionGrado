
import { PostBORElementoDTO } from "./PostBORElementosDTO";
import { TipoElemento } from "./TipoElemento";

export interface PostBEFormularioDTO
{
  BEFO_ENUNCIADO: string;
  TEFO_CODIGO: TipoElemento | number;
  BEFO_ORDEN?: number;
  BANCOOPCRESELEMENTOS?: PostBORElementoDTO[];
}
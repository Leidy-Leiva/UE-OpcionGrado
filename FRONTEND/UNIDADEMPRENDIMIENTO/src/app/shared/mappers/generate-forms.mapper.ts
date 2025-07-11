import { Type } from '@angular/core';

export const ElementsFormMapper: Record<string, () => Promise<Type<any>>> = {
  Crear_Pregunta: () =>
    import('../components/organisms/formelements/formelements.component').then(
      (cp) => cp.FormElementsComponent),

  Traer_Preguntas:()=>
    import('../../Features/generateForms/components/get-question/get-question.component').then(
      (gq)=>gq.GetQuestionComponent),
      
  Seccion: () =>
    import(
      '../../Features/generateForms/components/seccion/seccion.component'
    ).then((s) => s.SeccionComponent),
};

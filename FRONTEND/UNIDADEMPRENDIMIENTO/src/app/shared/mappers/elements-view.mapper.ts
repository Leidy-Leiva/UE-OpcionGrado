import { Type } from '@angular/core';

export const ElementsViewMapper: Record<string, () => Promise<Type<any>>> = {
   Crear_Pregunta: () =>
    import('../components/organisms/question/view/get-form-elements/get-form-elements.component').then(
       (p) => p.GetFormElementsComponent),

  // Traer_Preguntas:()=>
  //   import('../../Features/generateForms/components/get-question/get-question.component').then(
  //     (gq)=>gq.GetQuestionComponent),
      
   Seccion: () =>
    import(
       '../../Features/generateForms/components/Section/get-section/get-section.component').then(
        (s) => s.GetSectionComponent),

  Tabla: () =>
    import(
      '../../Features/generateForms/components/Table/get-tableform/get-tableform.component').then(
        (t) => t.GetTableformComponent),
};

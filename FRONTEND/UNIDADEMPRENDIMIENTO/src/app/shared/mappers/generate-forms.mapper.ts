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
      '../../Features/generateForms/components/Section/create-section/create-section.component').then(
        (s) => s.SectionComponent),

  Tabla: () =>
    import(
      '../../Features/generateForms/components/Table/table-form-builder/table-form-builder.component').then(
        (t) => t.TableFormBuilderComponent),
};

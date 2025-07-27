import { Type } from '@angular/core';

export const GetQuestionElementMapper: Record<string, () => Promise<Type<any>>> = {
  Multiple: () =>
    import('../components/molecules/multiplechoicequestion/multiplechoicequestion.component')
      .then(m => m.MultiplechoicequestionComponent),

  Abierta: () =>
    import('../components/molecules/openquestion/openquestion.component')
      .then(m => m.OpenquestionComponent),

  Cerrada: () =>
    import('../components/molecules/closedquestion/closedquestion.component')
      .then(m => m. ClosedquestionComponent),



};
import { Type } from '@angular/core';

export const QuestionElementMapper: Record<string, () => Promise<Type<any>>> = {
  Multiple: () =>
    import('../../components/organisms/question/create/multiplechoicequestion/multiplechoicequestion.component')
      .then(m => m.MultiplechoicequestionComponent),

  Abierta: () =>
    import('../../components/organisms/question/create/openquestion/openquestion.component')
      .then(m => m.OpenquestionComponent),

  Cerrada: () =>
    import('../../components/organisms/question/create/closedquestion/closedquestion.component')
      .then(m => m. ClosedquestionComponent),



};
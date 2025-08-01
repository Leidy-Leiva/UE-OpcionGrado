import { Type } from '@angular/core';

export const GetQuestionElementMapper: Record<string,() => Promise<Type<any>>> = {
  Multiple: () =>
    import('../../components/organisms/question/view/view-multiple-choice-question/view-multiple-choice-question.component')
      .then(m => m.ViewMultipleChoiceQuestionComponent),

  Abierta: () =>
    import('../../components/organisms/question/view/view-open-question/view-open-question.component')
      .then(m => m.ViewOpenQuestionComponent),

  Cerrada: () =>
    import('../../components/organisms/question/view/view-closed-question/view-closed-question.component')
      .then(m => m. ViewClosedQuestionComponent),
};

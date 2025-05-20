
import { Type } from '@angular/core';

export const ModalComponentMapper: Record<string, () => Promise<Type<any>>> = {
  crear: () =>
    import('../../Features/generateElements/create/pages/create-form-elements/create-form-elements.page')
      .then(m => m.CreateFormElements),
  editar: () =>
    import('../../Features/generateElements/update/page/update-form-elements/update-form-elements.page')
      .then(m => m.UpdateFormElements),
 
};
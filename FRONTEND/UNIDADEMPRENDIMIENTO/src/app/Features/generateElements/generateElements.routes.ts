import { Routes } from '@angular/router';

export const routes: Routes = [];
import { CreateFormElements } from './create/pages/create-form-elements/create-form-elements.page';
import { GetFormElements } from './get/page/get-form-elements/get-form-elements.page'; 
import { UpdateFormElements} from './update/page/update-form-elements/update-form-elements.page';

export default [
  {
    path: 'crear',
    component: CreateFormElements
  }
  ,
  {
    path: 'listar',
    component: GetFormElements
  },
  {
    path: 'editar',
    component: UpdateFormElements
  },
  {
    path: '',                     
    redirectTo: 'listar',
    pathMatch: 'full'              
  }
]as Routes;

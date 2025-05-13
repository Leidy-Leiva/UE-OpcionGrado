import { Routes } from '@angular/router';

export const routes: Routes = [];
import { CreateFormElements } from './create/pages/create-form-elements/create-form-elements.page';
import { GetFormElements } from './get/page/get-form-elements/get-form-elements.page'; 

export const GENERATE_ELEMENTS_FORM_ROUTES: Routes = [
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
    path: '',                     
    redirectTo: 'listar',
    pathMatch: 'full'              
  }
];

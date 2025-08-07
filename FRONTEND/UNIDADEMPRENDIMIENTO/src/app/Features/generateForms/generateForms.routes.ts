import { Component } from "@angular/core";
import { Routes } from "@angular/router";
import { CreateForm } from "./create/page/create-form/create-form.page";
import { GetForm } from "./get/page/get-form/get-form.page";

export default[
 {
   path:'crear',
   loadComponent:()=>
      import('./create/page/create-form/create-form.page')
      .then(m=>m.CreateForm),
 },
 {
   path:'listar',
   loadComponent:()=>
      import('./get/page/get-form/get-form.page')
      .then(m=>m.GetForm),
 }
] as Routes;
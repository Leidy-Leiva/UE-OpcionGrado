import { ApplicationConfig } from '@angular/core';
import { provideRouter, Routes } from '@angular/router';
import { provideAnimations } from '@angular/platform-browser/animations';
import { ListaPreguntasComponent } from './shared/components/organisms/lista-preguntas/lista-preguntas.component';
import { BquestionEditComponent } from './Features/Bquestions/bquestion-edit/bquestion-edit.component';
import { LayoutComponent } from './templates/layout/layout.component';

const routes: Routes = [

];

export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes),
    provideAnimations()
  ]
};

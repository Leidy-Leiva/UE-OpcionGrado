import { Routes } from '@angular/router';
import { LayoutComponent } from './templates/layout/layout.component';
import { GENERATE_ELEMENTS_FORM_ROUTES } from './Features/generateElements/generateElements.routes';

export const routes: Routes = [
    {
        path:'',
        component:LayoutComponent,
        children:[
            {
                path: 'generate-elements-form',
                children: GENERATE_ELEMENTS_FORM_ROUTES
            }
        ]
    }
];

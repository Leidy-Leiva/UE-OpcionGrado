import { Routes } from '@angular/router';
import { LayoutComponent } from './templates/layout/layout.component';

export const routes: Routes = [
    {
        path:'',
        component:LayoutComponent,
        children:[
            {
                path: 'generate-elements-form',
                loadChildren: () =>
                    import('./Features/generateElements/generateElements.routes').then((m) => m.default)
            },
            {
                path: 'generate-form',
                loadChildren:()=>
                    import ('./Features/generateForms/generateForms.routes').then((m)=>m.default)
            }
        ]
    }
];

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'person',
    loadChildren: () => import('./person/person.module').then(m => m.PersonModule)
  },
  {
    path: '',
    redirectTo: 'person',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
 
  exports: [RouterModule]
})
export class AppRoutingModule { }

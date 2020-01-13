import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PersonEditComponent } from './person-edit/person-edit.component';
import { PersonComponent } from './person/person.component';
import { PersonListComponent } from './person-list/person-list.component';

const routes: Routes = [
    {
        path: '',
        component: PersonComponent,
        children: [
          {
            path: 'list',
            component: PersonListComponent
          },
          {
            path: ':id/edit',
            component: PersonEditComponent
          },
          {
            path: 'new',
            component: PersonEditComponent
          },
          {
            path: '',
            redirectTo: 'list',
            pathMatch: 'full'
          }
        ]
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PersonRoutingModule { }

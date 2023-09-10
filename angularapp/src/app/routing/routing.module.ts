import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ConfirmationComponent } from '../confirmation/confirmation.component'
import { AddUsersComponent } from '../addusers/addusers.component';

const routes: Routes = [
  { path: 'addusers', component: AddUsersComponent },
  { path: 'confirmation', component: ConfirmationComponent },
  { path: '', redirectTo: '/addusers', pathMatch: 'full' },
]; 

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class RoutingModule { }

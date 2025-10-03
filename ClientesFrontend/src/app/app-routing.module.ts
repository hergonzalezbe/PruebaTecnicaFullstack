import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BuscarClienteComponent } from './components/buscar-cliente/buscar-cliente.component';

const routes: Routes = [
  { path: 'buscar', component: BuscarClienteComponent },
  { path: '', redirectTo: 'buscar', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}

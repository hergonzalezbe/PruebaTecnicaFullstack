import { Component } from '@angular/core';
import { ClienteService } from '../../services/cliente.service';
import { Cliente } from '../../models/cliente.model';

@Component({
  selector: 'app-buscar-cliente',
  templateUrl: './buscar-cliente.component.html',
  styleUrls: ['./buscar-cliente.component.css']
})
export class BuscarClienteComponent {
  identificacion = '';
  cliente: Cliente | null = null;
  loading = false;
  errorMessage = '';

  constructor(private clienteService: ClienteService) {}

  buscarCliente() {
    this.loading = true;
    this.errorMessage = '';
    this.cliente = null;

    this.clienteService.getClienteByIdentificacion(this.identificacion)
      .subscribe({
        next: (data) => {
          this.cliente = data;
          this.loading = false;
        },
        error: () => {
          this.errorMessage = 'Cliente no encontrado';
          this.loading = false;
        }
      });
  }
}

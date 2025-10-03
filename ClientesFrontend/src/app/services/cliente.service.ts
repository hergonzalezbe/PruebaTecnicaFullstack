import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from '../models/cliente.model';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  private apiUrl = 'https://localhost:7157/api/Clientes'; 

  constructor(private http: HttpClient) {}

  getClienteByIdentificacion(identificacion: string): Observable<Cliente> {
    return this.http.get<Cliente>(`${this.apiUrl}/${identificacion}`);
  }
}

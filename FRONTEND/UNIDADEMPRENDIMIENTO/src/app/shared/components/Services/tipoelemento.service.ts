import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TipoelementoService {
  private apiUrl = 'http://localhost:5239/Api/V1/TipoElemento/GetAllTipoElementoFormulario';

  constructor(private http: HttpClient) {}

  getTipoElementos(): Observable<string[]> {
    return this.http.get<string[]>(this.apiUrl);
  }
}
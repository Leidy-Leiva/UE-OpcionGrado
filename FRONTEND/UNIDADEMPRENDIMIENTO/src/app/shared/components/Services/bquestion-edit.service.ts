import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BquestionEditService {
  private baseUrl = 'https://tu-api.com/api'; // Cambia la URL según tu backend

  constructor(private http: HttpClient) {}

  // Método para guardar una nueva pregunta
  saveQuestion(payload: any): Observable<any> {
    return this.http.post(`${this.baseUrl}/preguntas`, payload);
  }
}

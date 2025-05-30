import {
  HttpClient,
  HttpErrorResponse,
  HttpHeaders,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, tap, throwError } from 'rxjs';
import { PersonalDataRequest } from 'src/app/shared/models/personal-date-request';
import { PersonalDataResponse } from 'src/app/shared/models/personal-date-response';

@Injectable({
  providedIn: 'root',
})
export class PersonalDataService {
  private apiUrl = 'https://localhost:7139/Api/V1/Auth/DatosPersonales';

  constructor(private http: HttpClient) {}

   getPersonalData(): Observable<PersonalDataResponse> {
    const token = localStorage.getItem('token') || '';
    const pg_Id = localStorage.getItem('pg_Id') || '';

    if (!token || !pg_Id) {
      return throwError(() => new Error('Faltan token o pg_Id en localStorage'));
    }

    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'token':token
    });

    const body: PersonalDataRequest = {  pg_Id };

    // Log para depurar qué se envía
    console.log('📤 Body enviado a DatosPersonales:', body);

    return this.http
      .post<PersonalDataResponse>(this.apiUrl, body, { headers })
      .pipe(
        tap((resp) => console.log('📥 Respuesta DatosPersonales:', resp)),
        catchError((err: HttpErrorResponse) => {
          console.error(
            '❌ Error en DatosPersonales (body, errores de validación):',
            body,
            err.error.errors
          );
          return throwError(() => err);
        })
      );
  }
}
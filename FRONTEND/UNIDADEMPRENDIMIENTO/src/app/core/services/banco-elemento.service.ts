import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PostBEFormularioDTO } from '../models/ELEMENTSFORM/PostBEFormularioDTO';
import { GetBEFormularioDTO } from '../models/ELEMENTSFORM/GetBEFormularioDTO';


@Injectable({ providedIn: 'root' })
export class BancoElementoService {
  private base = 'https://localhost:7139/Api/V1/BancoElementoFormulario';

  constructor(private http: HttpClient) {}

  create(dto: PostBEFormularioDTO): Observable<any> {
    return this.http.post(`${this.base}/PostBancoElemento`, dto);
  }

  getAll() {
    return this.http.get<GetBEFormularioDTO[]>(`${this.base}/GetAllBancoElemento`);
  }

  copyToDraft(befoId: number, borradorId: number) {
    return this.http.post(`${this.base}/CopyToDraft`, { befoId, borradorId });
  }
}

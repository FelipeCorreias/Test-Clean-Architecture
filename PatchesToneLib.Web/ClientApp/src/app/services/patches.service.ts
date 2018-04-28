import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Patch } from '../models/patch.model';


@Injectable()
export class PatchesService {
  public _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  getPatchesList() {
    return this._http.get<Patch[]>('/api/Patches');
  }

  getPatchFile(id: number) : string {
    return ('/api/Patches/'+ id + '/File');
  }

}

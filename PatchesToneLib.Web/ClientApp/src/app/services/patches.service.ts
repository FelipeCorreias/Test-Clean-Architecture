import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Patch } from '../models/patch.model';

@Injectable()
export class PatchesService {
  public _http: HttpClient;
  public patches: Patch[];

  constructor(http: HttpClient) {
    this._http = http;
  }

  getPatchesList() {
  return this._http.get('/api/Patches');
  }

}

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

  postPatch(patch : Patch, file : File){
    const formData: FormData = new FormData();
    formData.append("file",file,file.name);
    formData.append("name", patch.Name);
    formData.append("artist", patch.Artist);
    formData.append("genre", patch.Genre);
    formData.append("model", patch.Model);
    return this._http.post('/api/Patches',formData)
  }

}

import { Component, OnInit } from '@angular/core';
import { PatchesService } from '../services/patches.service';
import { Patch } from '../models/patch.model';

@Component({
  selector: 'app-patches',
  templateUrl: './patches.component.html',
  styleUrls: ['./patches.component.css']
})
export class PatchesComponent implements OnInit {
  public patches : Patch[];
  public _patchesService: PatchesService;

  constructor(private patchesService: PatchesService) {
    this._patchesService = patchesService;
  }

  ngOnInit() {
    this.getPatches();
  }

  getPatches() {
    this._patchesService.getPatchesList().subscribe(data => { this.patches = data; })
      , err => {
        console.log(err);
      };
  }

  getPatchFile(id: number) {
    return this._patchesService.getPatchFile(id);
  }

}

import { Component, OnInit } from '@angular/core';
import { PatchesService } from '../services/patches.service';
import { Patch } from '../models/patch.model';

@Component({
  selector: 'app-patches',
  templateUrl: './patches.component.html',
  styleUrls: ['./patches.component.css']
})
export class PatchesComponent implements OnInit {
  public patches: Patch[];
  public _patchesService: PatchesService;

  constructor(private patchesService: PatchesService) {
    this._patchesService = patchesService;
  }

  ngOnInit() {
    this.getPatches();
  }

  getPatches() {
    console.log(this._patchesService.getPatchesList().subscribe(result => {
      this.patches = result;
    }));
    //this.patches = this._patchesService.getPatchesList();
  }

}

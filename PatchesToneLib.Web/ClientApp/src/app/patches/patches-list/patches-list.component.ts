import { Component, OnInit } from '@angular/core';
import { Patch } from '../../models/patch.model';
import { PatchesService } from '../../services/patches.service';

@Component({
  selector: 'app-patches-list',
  templateUrl: './patches-list.component.html',
  styleUrls: ['./patches-list.component.css']
})
export class PatchesListComponent implements OnInit {
  public patches: Patch[];
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

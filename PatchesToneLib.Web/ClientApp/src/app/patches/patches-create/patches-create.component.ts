import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Patch } from '../../models/patch.model';
import { PatchesService } from '../../services/patches.service';
import { patch } from 'webdriver-js-extender';

@Component({
  selector: 'app-patches-create',
  templateUrl: './patches-create.component.html',
  styleUrls: ['./patches-create.component.css']
})
export class PatchesCreateComponent implements OnInit {
  formPatchCreate: FormGroup;
  public patch = new Patch();
  public file: File;
  public _patchesService: PatchesService;
  constructor(private patchesService: PatchesService) {
    this._patchesService = patchesService;
  }

  ngOnInit() {
    this.formPatchCreate = new FormGroup({
      name: new FormControl(this.patch.Name, [Validators.required]),
      artist: new FormControl(this.patch.Artist),
      genre: new FormControl(this.patch.Genre),
      model: new FormControl(this.patch.Model),
      file: new FormControl(null, Validators.required)
    });
  }

  onSubmit(values) {
    if (this.formPatchCreate.valid) {
      this.patch.Name = values.name;
      this.patch.Artist = values.artist;
      this.patch.Genre = values.genre;
      this.patch.Model = values.model;
      this._patchesService.postPatch(this.patch, this.file).subscribe();
    }
  }

  handleFileInput(files: FileList) {
    this.file = files.item(0);
  }

}

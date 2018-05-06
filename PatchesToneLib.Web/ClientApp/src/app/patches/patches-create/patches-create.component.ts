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
  public messageShow: boolean = false;
  public messageClass: string;
  public message: string;


  constructor(private patchesService: PatchesService) {
    this._patchesService = patchesService;
  }

  ngOnInit() {
    this.formPatchCreate = new FormGroup({
      name: new FormControl(this.patch.Name, [Validators.required]),
      artist: new FormControl(this.patch.Artist),
      genre: new FormControl(this.patch.Genre),
      model: new FormControl(this.patch.Model, [Validators.required]),
      file: new FormControl(null, [Validators.required]),
      author: new FormControl(this.patch.Author)
    });
  }

  onSubmit(values) {
    if (this.formPatchCreate.valid) {
      this.patch.Name = values.name;
      this.patch.Artist = values.artist;
      this.patch.Genre = values.genre;
      this.patch.Model = values.model;
      this.patch.Author = values.author;
      this._patchesService.postPatch(this.patch, this.file).subscribe(result => {
        //console.log(result)
      },
        error => {
          this.message = "Oops ... Failed to send the patch, check the completed information. " + error;
          this.messageClass = "alert alert-danger";
          this.messageShow = true;
        },
        () => {
          this.message = "Thanks for submitting a patch. Soon it will be available.";
          this.messageClass = "alert alert-success";
          this.messageShow = true;
          this.formPatchCreate.reset();
        });
    }
  }

  handleMessage() {
    this.messageShow = false;
  }

  handleFileInput(files: FileList) {
    this.file = files.item(0);
  }

}

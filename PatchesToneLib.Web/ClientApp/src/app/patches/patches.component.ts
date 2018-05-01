import { Component, OnInit } from '@angular/core';
import { PatchesService } from '../services/patches.service';
import { Patch } from '../models/patch.model';

@Component({
  selector: 'app-patches',
  templateUrl: './patches.component.html',
  styleUrls: ['./patches.component.css']
})
export class PatchesComponent implements OnInit {


  constructor() {
  }

  ngOnInit() {

  }


}

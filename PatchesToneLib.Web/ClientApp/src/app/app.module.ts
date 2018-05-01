import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';

import { PatchesComponent } from './patches/patches.component';
import { PatchesListComponent } from './patches/patches-list/patches-list.component';
import { PatchesCreateComponent } from './patches/patches-create/patches-create.component';

import { PatchesService } from './services/patches.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    PatchesComponent,
    PatchesListComponent,
    PatchesCreateComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: PatchesComponent, pathMatch: 'full' },
      { path: 'patches/list', component: PatchesListComponent },
      { path: 'patches/send', component: PatchesCreateComponent }
      //{ path: 'fetch-data', component: FetchDataComponent }
    ])
  ],
  providers: [PatchesService],
  bootstrap: [AppComponent]
})
export class AppModule { }

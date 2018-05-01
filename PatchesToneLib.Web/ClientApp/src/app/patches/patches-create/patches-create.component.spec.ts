import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PatchesCreateComponent } from './patches-create.component';

describe('PatchesCreateComponent', () => {
  let component: PatchesCreateComponent;
  let fixture: ComponentFixture<PatchesCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PatchesCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PatchesCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

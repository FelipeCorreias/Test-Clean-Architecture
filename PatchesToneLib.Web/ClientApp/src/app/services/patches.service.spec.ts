import { TestBed, inject } from '@angular/core/testing';

import { PatchesService } from './patches.service';

describe('PatchesService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PatchesService]
    });
  });

  it('should be created', inject([PatchesService], (service: PatchesService) => {
    expect(service).toBeTruthy();
  }));
});

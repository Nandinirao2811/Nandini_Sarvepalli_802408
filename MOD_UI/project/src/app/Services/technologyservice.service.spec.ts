import { TestBed } from '@angular/core/testing';

import { TechnologyserviceService } from './technologyservice.service';

describe('TechnologyserviceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TechnologyserviceService = TestBed.get(TechnologyserviceService);
    expect(service).toBeTruthy();
  });
});

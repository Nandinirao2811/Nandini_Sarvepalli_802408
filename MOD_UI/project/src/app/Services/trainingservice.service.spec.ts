import { TestBed } from '@angular/core/testing';

import { TrainingserviceService } from './trainingservice.service';

describe('TrainingserviceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TrainingserviceService = TestBed.get(TrainingserviceService);
    expect(service).toBeTruthy();
  });
});

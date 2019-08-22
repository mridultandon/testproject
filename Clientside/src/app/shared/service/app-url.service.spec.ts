import { TestBed } from '@angular/core/testing';

import { AppUrlService } from './app-url.service';

describe('AppUrlService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AppUrlService = TestBed.get(AppUrlService);
    expect(service).toBeTruthy();
  });
});

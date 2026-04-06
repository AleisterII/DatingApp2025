import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LikesService } from './likes-service';

describe('LikesService', () => {
  let component: LikesService;
  let fixture: ComponentFixture<LikesService>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LikesService]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LikesService);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

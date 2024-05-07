import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResendentialComponent } from './resendential.component';

describe('ResendentialComponent', () => {
  let component: ResendentialComponent;
  let fixture: ComponentFixture<ResendentialComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ResendentialComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ResendentialComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

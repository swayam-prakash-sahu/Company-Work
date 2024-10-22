import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormDataDisplayComponent } from './form-data-display.component';

describe('FormDataDisplayComponent', () => {
  let component: FormDataDisplayComponent;
  let fixture: ComponentFixture<FormDataDisplayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormDataDisplayComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FormDataDisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

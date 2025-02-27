import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ButtonwithiconComponent } from './buttonwithicon.component';

describe('ButtonwithiconComponent', () => {
  let component: ButtonwithiconComponent;
  let fixture: ComponentFixture<ButtonwithiconComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [ButtonwithiconComponent]
    });
    fixture = TestBed.createComponent(ButtonwithiconComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

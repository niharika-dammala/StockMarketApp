import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AppbaseComponent } from './appbase.component';

describe('AppbaseComponent', () => {
  let component: AppbaseComponent;
  let fixture: ComponentFixture<AppbaseComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppbaseComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppbaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

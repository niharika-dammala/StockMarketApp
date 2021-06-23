import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserviewCompaniesComponent } from './userview-companies.component';

describe('UserviewCompaniesComponent', () => {
  let component: UserviewCompaniesComponent;
  let fixture: ComponentFixture<UserviewCompaniesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserviewCompaniesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserviewCompaniesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddUsersComponent } from './addusers.component';

describe('AddusersComponent', () => {
  let component: AddUsersComponent;
  let fixture: ComponentFixture<AddUsersComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddUsersComponent]
    });
    fixture = TestBed.createComponent(AddUsersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

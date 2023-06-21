import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowProfileOfOtherUserComponent } from './show-profile-of-other-user.component';

describe('ShowProfileOfOtherUserComponent', () => {
  let component: ShowProfileOfOtherUserComponent;
  let fixture: ComponentFixture<ShowProfileOfOtherUserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowProfileOfOtherUserComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShowProfileOfOtherUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

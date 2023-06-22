import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowOtherAllPostsComponent } from './show-other-all-posts.component';

describe('ShowOtherAllPostsComponent', () => {
  let component: ShowOtherAllPostsComponent;
  let fixture: ComponentFixture<ShowOtherAllPostsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowOtherAllPostsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShowOtherAllPostsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

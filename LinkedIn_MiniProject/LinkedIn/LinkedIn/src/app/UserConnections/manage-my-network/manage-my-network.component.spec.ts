import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageMyNetworkComponent } from './manage-my-network.component';

describe('ManageMyNetworkComponent', () => {
  let component: ManageMyNetworkComponent;
  let fixture: ComponentFixture<ManageMyNetworkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManageMyNetworkComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManageMyNetworkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

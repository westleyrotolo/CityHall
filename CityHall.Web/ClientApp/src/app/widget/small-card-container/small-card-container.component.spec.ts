import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SmallCardContainerComponent } from './small-card-container.component';

describe('SmallCardContainerComponent', () => {
  let component: SmallCardContainerComponent;
  let fixture: ComponentFixture<SmallCardContainerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SmallCardContainerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SmallCardContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

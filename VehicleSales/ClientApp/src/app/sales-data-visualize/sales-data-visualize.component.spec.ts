import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SalesDataVisualizeComponent } from './sales-data-visualize.component';

describe('SalesDataVisualizeComponent', () => {
  let component: SalesDataVisualizeComponent;
  let fixture: ComponentFixture<SalesDataVisualizeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SalesDataVisualizeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SalesDataVisualizeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

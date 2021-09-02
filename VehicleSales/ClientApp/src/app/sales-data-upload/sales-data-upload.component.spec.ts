import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SalesDataUploadComponent } from './sales-data-upload.component';

describe('SalesDataUploadComponent', () => {
  let component: SalesDataUploadComponent;
  let fixture: ComponentFixture<SalesDataUploadComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SalesDataUploadComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SalesDataUploadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

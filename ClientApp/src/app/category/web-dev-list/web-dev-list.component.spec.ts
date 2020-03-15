import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WebDevListComponent } from './web-dev-list.component';

describe('WebDevListComponent', () => {
  let component: WebDevListComponent;
  let fixture: ComponentFixture<WebDevListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WebDevListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WebDevListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

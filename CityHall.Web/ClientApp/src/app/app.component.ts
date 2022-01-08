import { AfterViewInit, Component, ElementRef, HostListener, OnInit, ViewChild } from '@angular/core';
import { DeviceDetectorService } from 'ngx-device-detector';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit, AfterViewInit {

  constructor(
    public deviceService: DeviceDetectorService
  ) {

  }

  collapseNavbarClass: string = 'collapse-navbar'

  ngAfterViewInit(): void {
  }

  ngOnInit(): void {
    this.isExpanded = true;
    if (this.deviceService.isMobile()) {
      this.collapseNavbarClass = 'collapse-navbar-mobile'
    } else {
      this.collapseNavbarClass = 'collapse-navbar'
    }
  }

  @ViewChild(NavMenuComponent) 
  nav!: NavMenuComponent;
  
  isExpanded = true;
  title = 'app';

  @HostListener('window:scroll', ['$event']) // for window scroll events
  onScroll(event: any) {
    if (window)
    if (window.scrollY > this.headerSize()) {
      this.nav.collapse();
      this.isExpanded = false;
    } else {
      this.nav.expand();
      this.isExpanded = true;
    }
  }

  headerSize(): number {
    if (this.deviceService.isMobile()) {
      return 50;
    } else {
      return 160;
    }
  }

}

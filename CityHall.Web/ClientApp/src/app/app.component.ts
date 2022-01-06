import { Component, ElementRef, HostListener, ViewChild } from '@angular/core';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {

  @ViewChild(NavMenuComponent) 
  nav!: NavMenuComponent;
  
  isExpanded = true;
  title = 'app';

  @HostListener('window:scroll', ['$event']) // for window scroll events
  onScroll(event: any) {
    console.log(event);
    console.log(window.pageYOffset);
    if (window && window.scrollY)
    if (window.scrollY > 160) {
      this.nav.collapse();
      this.isExpanded = false;
    } else {
      this.nav.expand();
      this.isExpanded = true;
    }
  }

}

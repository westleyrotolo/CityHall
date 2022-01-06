import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(){
  } 

  collapse() {
    this.isExpanded = false;
  }
  expand() {
    this.isExpanded = true;
  }

  toggle() {
  }
}

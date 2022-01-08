import { Component, Input, OnInit } from '@angular/core';
import { Header } from '../models/header';
import { LinkType } from '../models/shared';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {

  @Input() headerData: Header = {};

  isExpanded = true;

  baseSvgPath="./../../assets/bootstrap-italia/svg/sprite.svg";
  itExpand = `${this.baseSvgPath}#it-expand`;
  itSearch = `${this.baseSvgPath}#it-search`;
  itUser = `${this.baseSvgPath}#it-user`;
  itFacebook = `${this.baseSvgPath}#it-facebook`;
  itTwitter = `${this.baseSvgPath}#it-twitter`;
  itPA = `${this.baseSvgPath}#it-pa`;
  itBurger = `${this.baseSvgPath}#it-burger`;
  

  constructor(){
    this.headerData.cityTitle = "City Hall";
    this.headerData.followUs = [
      {
        icon : this.itFacebook,
        name : 'Facebook',
        url : 'https://facebook.com'
      },
      {
        icon : this.itTwitter,
        name : 'Twitter',
        url : 'https://twitter.com'
      },
    ]
    this.headerData.logo = this.itPA;
    this.headerData.region = 'Campania';
    this.headerData.sections = [
      {
        name: 'Amministrazione',
        link: {
          linkType : LinkType.Internal,
          linkedPageId: '1'
        }
      },
      {
        name: 'Storia',
        link: {
          linkType : LinkType.Internal,
          linkedPageId: '1'
        }
      },
      {
        name: 'Uffici e orari',
        link: {
          linkType : LinkType.Internal,
          linkedPageId: '1'
        }
      },
      {
        name: 'Modulistica',
        link: {
          linkType : LinkType.Internal,
          linkedPageId: '1'
        }
      }
    ]
    this.headerData.supportedLanguage = [
      'ITA', 'ENG'
    ]
  } 
  ngOnInit(): void {
    this.isExpanded = true;
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

import { Component } from '@angular/core';
import { Card } from '../models/card';
import { LinkType } from '../models/shared';
import { SmallCard } from '../models/small-card';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  smallCards: SmallCard[] = [];
  smallCardsWithImage: SmallCard[] = [];
  cards: Card[] = [];
  baseSvgPath = "./../../assets/bootstrap-italia/svg/sprite.svg";
  itChevronRight = `${this.baseSvgPath}#it-chevron-right`;
  constructor() {
    this.cards = [
      {
        title: 'Titolo della card',
        content: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat',
        category: {
          title: 'News'
        },
        date: new Date(),
        image: 'https://via.placeholder.com/310x190/0066cc/FFFFFF/?text=IMMAGINE%20DI%20ESEMPIO',
        tags: [
          {
            title: 'Tag1'
          },
          {
            title: 'Tag2'
          },
          {
            title: 'Tag3'
          }
        ]
      },
      {
        title: 'Titolo della card',
        image: 'https://via.placeholder.com/310x190/0066cc/FFFFFF/?text=IMMAGINE%20DI%20ESEMPIO',
        content: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat',
        category: {
          title: 'News'
        },
        date: new Date(),
        tags: [
          {
            title: 'Tag1'
          },
          {
            title: 'Tag2'
          },
          {
            title: 'Tag3'
          },
          {
            title: 'Tag4'
          },
          {
            title: 'Tag5 molto lungo'
          },
          {
            title: 'Tag6'
          },
        ]
      },

      {
        title: 'Titolo della card',
        content: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat',
        category: {
          title: 'News'
        },
        date: new Date(),
        tags: [
          {
            title: 'Tag1'
          },
          {
            title: 'Tag2'
          }
        ]
      },

    ]
    this.smallCards = [
      {
        title: "Amministrazione super mega iper stra Trasparente con contenuto su due righe massimo",
        textColor: "#ffffff",
        backgroundColor: "#cc2c29",
        link: {
          linkType: LinkType.Internal,
          linkedPageId: '1'
        },
        icon: this.itChevronRight
      },
      {
        title: "Storia",
        subtitle: "Sottotitolo",
        textColor: "#ffffff",
        backgroundColor: "#0066cc",
        link: {
          linkType: LinkType.Internal,
          linkedPageId: '1'
        },
        icon: this.itChevronRight
      },
      {
        title: "Uffici e Orari",
        textColor: "#ffffff",
        backgroundColor: "#5a768a",
        link: {
          linkType: LinkType.External,
          externalLink: 'https://google.it'
        },
        icon: this.itChevronRight
      },
      
    ]

    this.smallCardsWithImage = [
      {
        title: "Amministrazione super mega iper stra Trasparente con contenuto su due righe massimo",
        textColor: "#ffffff",
        backgroundColor: "#cc2c29",
        link: {
          linkType: LinkType.Internal,
          linkedPageId: '1'
        },
        image: 'https://www.fulltravel.it/wp-content/uploads/2015/10/dublino-irlanda.jpg',
      },
      {
        title: "Storia",
        subtitle: "Sottotitolo",
        textColor: "#ffffff",
        backgroundColor: "#cc2c29",
        link: {
          linkType: LinkType.Internal,
          linkedPageId: '1'
        },
        image: 'https://via.placeholder.com/310x190/0066cc/FFFFFF/?text=IMMAGINE%20DI%20ESEMPIO',
      },
      {
        title: "Uffici e Orari",
        textColor: "#ffffff",
        backgroundColor: "#cc2c29",
        link: {
          linkType: LinkType.External,
          externalLink: 'https://google.it'
        },
        image: 'https://via.placeholder.com/310x190/0066cc/FFFFFF/?text=IMMAGINE%20DI%20ESEMPIO',
      },
      
    ]
  }
}

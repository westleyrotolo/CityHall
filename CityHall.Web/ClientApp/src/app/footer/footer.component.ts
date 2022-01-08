import { Component, Input, OnInit } from '@angular/core';
import { Footer } from '../models/footer';
import { LinkType } from '../models/shared';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.scss']
})
export class FooterComponent implements OnInit {

  @Input() footerData: Footer = {}

  baseSvgPath="./../../assets/bootstrap-italia/svg/sprite.svg";
  itMail = `${this.baseSvgPath}#it-mail`;
  itFacebook = `${this.baseSvgPath}#it-facebook`;
  itTwitter = `${this.baseSvgPath}#it-twitter`;
  itPA = `${this.baseSvgPath}#it-pa`;

  constructor() {
    this.footerData.hasNewsletter = true;
    this.footerData.cityTitle = "City Hall";
    this.footerData.followUs = [
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
    this.footerData.logo = this.itPA;
    this.footerData.sections = [
      {
        name: 'Amministrazione',
        link: {
          linkType : LinkType.Internal,
          linkedPageId: '1'
        },
        items: [
          {
            name: 'Item 1',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 2',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 3',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 4',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
        ]
      },
      {
        name: 'Storia',
        link: {
          linkType : LinkType.Internal,
          linkedPageId: '1'
        },
        items: [
          {
            name: 'Item 1',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 2',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 3',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
        ]
      },
      {
        name: 'Uffici e orari',
        link: {
          linkType : LinkType.Internal,
          linkedPageId: '1'
        },
        items: [

          {
            name: 'Item 1',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 2',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 3',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 4',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 5',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
        ]
      },
      {
        name: 'Modulistica',
        link: {
          linkType : LinkType.Internal,
          linkedPageId: '1'
        }, 
        items: [

          {
            name: 'Item 1',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 2',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 3',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 4',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 5',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
          {
            name: 'Item 6',
            link: {
              linkType: LinkType.Internal,
              linkedPageId: '1'
            }
          },
        ]
      }
    ]
    this.footerData.footerItem = {
      title: {
        title: 'AMMINISTRAZIONE TRASPARENTE',
        link: {
          linkType: LinkType.Internal,
          linkedPageId: '1'
        }
      },
      content: 'I dati personali pubblicati sono riutilizzabili solo alle condizioni previste dalla direttiva comunitaria 2003/98/CE e dal d.lgs. 36/2006'
    }
    this.footerData.contacts = {
      content: 'Via Roma 0 - 00000 Lorem Ipsum Codice fiscale / P. IVA: 000000000',
      links: [
        {
          title: 'Posta Elettronica Certificata',
          link: {
            linkType: LinkType.Internal,
            linkedPageId: '1'
          }
        },
        {
          title: 'URP - Ufficio Relazioni con il Pubblico',
          link: {
            linkType: LinkType.Internal,
            linkedPageId: '1'
          }
        },
      ]
    }

    this.footerData.usefulLinksSection = [
      {
        title: 'Media policy',
        link: {
          linkType: LinkType.Internal,
          linkedPageId: '1'
        }
      },
      {
        title: 'Note legali',
        link: {
          linkType: LinkType.Internal,
          linkedPageId: '1'
        }
      },
      {
        title: 'Privacy policy',
        link: {
          linkType: LinkType.Internal,
          linkedPageId: '1'
        }
      },
      {
        title: 'Mappa del sito',
        link: {
          linkType: LinkType.Internal,
          linkedPageId: '1'
        }
      },
    ]


   }

  ngOnInit(): void {
  }

}

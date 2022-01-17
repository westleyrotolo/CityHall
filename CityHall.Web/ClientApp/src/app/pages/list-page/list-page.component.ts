import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Card } from 'src/app/models/card';
import { HyperLink, LinkType } from 'src/app/models/shared';

@Component({
  selector: 'app-list-page',
  templateUrl: './list-page.component.html',
  styleUrls: ['./list-page.component.scss']
})
export class ListPageComponent implements OnInit {

  baseSvgPath="./../../../assets/bootstrap-italia/svg/sprite.svg";
  itChevronLeft= `${this.baseSvgPath}#it-chevron-left`;
  itChevronRight= `${this.baseSvgPath}#it-chevron-right`;
  links: HyperLink[] = [{title: 'Home', link: {linkType: LinkType.None}}]
  constructor(private route: ActivatedRoute) { 
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


  }

  @Input() sectionName: string = ''
  cards: Card[] = []

  showMoreLx: boolean = false;
  showMoreRx: boolean = false;
  selectedPage: number = 1;
  pager: number[] = [];
  lastPage: number = 1;

  ngOnInit(): void {
    this.sectionName = this.capitalizeFirstLetter(this.route.snapshot.paramMap.get('name') ?? '')
    this.changePage(3);
  }

  changePage(pageIndex: number) {
    this.setPager(pageIndex, 30);
  }

  setPager(pageIndex: number, numberOfPage: number){
    this.selectedPage = pageIndex
    if (pageIndex > 4
        && numberOfPage > 7) {
      this.showMoreLx = true;
    } 
    else {
      this.showMoreLx = false;
    }
    if (numberOfPage > 7
        && pageIndex + 3 < numberOfPage) {
        this.showMoreRx = true;
    } else {
      this.showMoreRx = false;
    }
    this.lastPage  = numberOfPage;
    const numb =  Math.min(5, numberOfPage-2)
    const startIndex =  Math.max(1,Math.min(this.selectedPage - 3, numberOfPage - 6))
    this.pager = Array(numb).fill(startIndex).map((x, i) => x + i + 1);
  }

   capitalizeFirstLetter(value: string): string {
    return value.charAt(0).toUpperCase() + value.slice(1);
  }


}

import { Component, Input, OnInit } from '@angular/core';
import { Detail } from 'src/app/models/detail';
import { HyperLink, LinkType } from 'src/app/models/shared';
import { DropdownItem } from 'src/app/widget/dropdown-button/dropdown-button.component';

@Component({
  selector: 'app-detail-page',
  templateUrl: './detail-page.component.html',
  styleUrls: ['./detail-page.component.scss']
})
export class DetailPageComponent implements OnInit {

  @Input() sectionName: string = ''
  @Input() detail: Detail = {}
  links: HyperLink[] = [{title: 'Home', link: {linkType: LinkType.None}}]
  constructor() { }

  ngOnInit(): void {
    this.sectionName = 'Osservatorio sul turismo';
    this.detail = {
      title: 'Osservatorio sul turismo',
      briefDescription: 'Donec in consequat nunc. Duis semper fermentum lacus, ac condimentum justo auctor a. Nam erat erat, porta vel pharetra in, ullamcorper vel turpis.',
      date: new Date(),
      readingTime: 5,
      imageUrl: 'https://picsum.photos/800/400',
      captionImage: 'Donec in consequat nunc',
      htmlContent: 'Vivamus orci risus, fringilla sit amet enim vel, semper faucibus elit. Aliquam nec laoreet leo. Integer eu venenatis purus, eu tincidunt eros. Aliquam egestas est quis lacinia ultrices. Vestibulum vehicula sit amet purus id suscipit. Sed gravida urna tellus, sed aliquet erat faucibus porta. Aenean condimentum.<br/><br/>Vivamus orci risus, fringilla sit amet enim vel, semper faucibus elit. Aliquam nec laoreet leo. Integer eu venenatis purus, eu tincidunt eros. Aliquam egestas est quis lacinia ultrices. Vestibulum vehicula sit amet purus id suscipit. Sed gravida urna tellus, sed aliquet erat faucibus porta. Aenean condimentum.',
      updatedAt: new Date(),
      createdAt: new Date(),
      editedBy: {
        title: 'Assessorato allo sport',
        imageUrl: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWsAoxUdWANGBxH5Wn0cmd7o97OHLGmWVBnA&usqp=CAU',
        subtitle: 'Via del Comune'
      },
      topics: [
        {
          title: 'Sport'
        },
        {
          title: 'Turismo'
        },
        {
          title: 'Ambiente'
        }
      ],
      documents:[
        {
          link: '',
          contentType: 'application/pdf',
          filename: 'pdf.pdf',  
          description: 'Documento relativo al contenuto'
        }
      ]
    }
  }

  baseSvgPath='./../../../assets/bootstrap-italia/svg/sprite.svg';
  itChevronLeft: string = `${this.baseSvgPath}#it-chevron-left`;
  itClip: string = `${this.baseSvgPath}#it-clip`;
  shareTitle: string = 'Condividi';
  shareIcon: string = `${this.baseSvgPath}#it-share`;
  shareItems: DropdownItem[] = [
    {
      title: 'Facebook',
      icon: `${this.baseSvgPath}#it-facebook`
    },
    {
      title: 'Twitter',
      icon: `${this.baseSvgPath}#it-twitter`
    },
    {
      title: 'Linkedin',
      icon: `${this.baseSvgPath}#it-linkedin`
    },
    {
      title: 'Whatsapp',
      icon: `${this.baseSvgPath}#it-whatsapp`
    }
  ]
  actionTitle: string = 'Vedi azioni';
  actionIcon: string = `${this.baseSvgPath}#it-more-items`;
  actionItems:  DropdownItem[] = [
    {
      title: 'Scarica',
      icon: `${this.baseSvgPath}#it-download`
    },
    {
      title: 'Stampa',
      icon: `${this.baseSvgPath}#it-print`
    },
    {
      title: 'Invia',
      icon: `${this.baseSvgPath}#it-mail`
    }
  ]
}

import { Component, Input, OnInit } from '@angular/core';
import { SmallCard } from 'src/app/models/small-card';

@Component({
  selector: 'app-small-card',
  templateUrl: './small-card.component.html',
  styleUrls: ['./small-card.component.scss']
})
export class SmallCardComponent implements OnInit {

  @Input() smallCardData?: SmallCard 

  baseSvgPath="./../../../assets/bootstrap-italia/svg/sprite.svg";
  itExternalLink= `${this.baseSvgPath}#it-external-link`;

  constructor() { }

  ngOnInit(): void {
  }

}

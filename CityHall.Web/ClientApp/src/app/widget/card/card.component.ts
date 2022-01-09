import { Component, Input, OnInit } from '@angular/core';
import { Card } from 'src/app/models/card';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {

  @Input() cardData?: Card;
  
  baseSvgPath="./../../../assets/bootstrap-italia/svg/sprite.svg";
  itArrowRight= `${this.baseSvgPath}#it-arrow-right`;
  itCalendar= `${this.baseSvgPath}#it-calendar`;

  constructor() { 
  }

  ngOnInit(): void {
  }

}

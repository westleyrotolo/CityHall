import { Component, Input, OnInit } from '@angular/core';
import { SmallCard } from 'src/app/models/small-card';

@Component({
  selector: 'app-small-card-container',
  templateUrl: './small-card-container.component.html',
  styleUrls: ['./small-card-container.component.scss']
})
export class SmallCardContainerComponent implements OnInit {

  @Input() smallCards: SmallCard[] = []

  constructor() { }

  ngOnInit(): void {
  }

}

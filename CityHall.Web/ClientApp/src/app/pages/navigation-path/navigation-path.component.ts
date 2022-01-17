import { Component, Input, OnInit } from '@angular/core';
import { HyperLink } from 'src/app/models/shared';

@Component({
  selector: 'app-navigation-path',
  templateUrl: './navigation-path.component.html',
  styleUrls: ['./navigation-path.component.scss']
})
export class NavigationPathComponent implements OnInit {

  @Input() items: HyperLink[] = []
  @Input() currentPage: string = ''

  constructor() { }

  ngOnInit(): void {
  }

}

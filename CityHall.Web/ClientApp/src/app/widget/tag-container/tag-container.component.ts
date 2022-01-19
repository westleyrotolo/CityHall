import { Component, Input, OnInit } from '@angular/core';
import { Tag } from 'src/app/models/shared';

@Component({
  selector: 'app-tag-container',
  templateUrl: './tag-container.component.html',
  styleUrls: ['./tag-container.component.scss']
})
export class TagContainerComponent implements OnInit {

  @Input() tags: Tag[] = []

  @Input() title?: string;
  
  constructor() { }

  ngOnInit(): void {
  }

}

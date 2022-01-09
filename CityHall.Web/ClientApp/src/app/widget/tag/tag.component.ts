import { Component, Input, OnInit } from '@angular/core';
import { Tag } from 'src/app/models/shared';

@Component({
  selector: 'app-tag',
  templateUrl: './tag.component.html',
  styleUrls: ['./tag.component.scss']
})
export class TagComponent implements OnInit {

  @Input() tag?: Tag;

  constructor() { }

  ngOnInit(): void {
  }

}

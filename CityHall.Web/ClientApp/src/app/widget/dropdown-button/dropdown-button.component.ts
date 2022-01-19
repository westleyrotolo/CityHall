import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-dropdown-button',
  templateUrl: './dropdown-button.component.html',
  styleUrls: ['./dropdown-button.component.scss']
})
export class DropdownButtonComponent implements OnInit {

  @Input() title: string = '';
  @Input() icon?: string = '';
  @Input() items: DropdownItem[] = [];
  @Output() itemSelected = new EventEmitter<DropdownItem>();
  constructor() { }

  ngOnInit(): void {
  }

  itemClicked(item: DropdownItem) {
    this.itemSelected.emit(item);
  }

}
export interface DropdownItem {
  icon?: string;
  title: string;
}
import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
})
export class HeaderComponent {
  @Input() title: string;
  @Input() versionNumber: number;
  @Input() showVersionNumber: Function;

  inputText: string;

  count: number;
}

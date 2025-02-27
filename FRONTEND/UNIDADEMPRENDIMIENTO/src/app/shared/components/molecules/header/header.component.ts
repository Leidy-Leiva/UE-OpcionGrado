import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IconComponent } from '../../atoms/icon/icon.component';
import { LabelComponent } from '../../atoms/label/label.component';
import { ButtonwithiconComponent } from '../buttonwithicon/buttonwithicon.component';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [CommonModule,LabelComponent,ButtonwithiconComponent,IconComponent],
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {

}

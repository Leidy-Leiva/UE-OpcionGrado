import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from "src/app/shared/components/atoms/label/label.component";
import { HeaderComponent } from "src/app/shared/components/organisms/header/header.component";

@Component({
  selector: 'app-get-section',
  standalone: true,
  imports: [CommonModule, LabelComponent, HeaderComponent],
  templateUrl: './get-section.component.html',
  styleUrls: ['./get-section.component.scss']
})
export class GetSectionComponent {
  @Input() title:string='';
  @Input() description:string='';

}

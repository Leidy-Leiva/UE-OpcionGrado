import { Component,Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../atoms/label/label.component';
import { ListGroupComponent } from '../../atoms/list-group/list-group.component';

@Component({
  selector: 'app-labelwithlistgroup',
  standalone: true,
  imports: [CommonModule, LabelComponent,ListGroupComponent],
  templateUrl: './labelwithlistgroup.component.html',
  styleUrls: ['./labelwithlistgroup.component.css']
})
export class LabelwithlistgroupComponent {
  @Input() label: string = 'Etiqueta por defecto';
  @Input() items: string[] = [];

}

import { Component,Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../atoms/label/label.component';

@Component({
  selector: 'app-labelwithlistgroup',
  standalone: true,
  imports: [CommonModule, LabelComponent],
  templateUrl: './labelwithlistgroup.component.html',
  styleUrls: ['./labelwithlistgroup.component.scss']
})
export class LabelwithlistgroupComponent {
  @Input() label: string = 'Etiqueta por defecto';
  @Input() items: string[] = [];

}

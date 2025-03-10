import { Component,Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AvatarComponent } from "../../atoms/avatar/avatar.component";
import { DropdownComponent } from "../../atoms/dropdown/dropdown.component";
import { CardComponent } from '../../molecules/card/card.component';
import { LabelComponent } from '../../atoms/label/label.component';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-panelinfo',
  standalone: true,
  imports: [CommonModule, AvatarComponent, DropdownComponent,CardComponent,AvatarComponent,LabelComponent,FormsModule],
  templateUrl: './panelinfo.component.html',
  styleUrls: ['./panelinfo.component.css']
})
export class PanelinfoComponent {
  @Input() name!: string;
  programOptions = [
    { value: 'Ingeniería de Sistemas', label: 'Ingeniería de Sistemas' },
    { value: 'Ingeniería Industrial', label: 'Ingeniería Industrial' }
  ];

  selectedProgram = 'Ingeniería de Sistemas';
  @Input() semester!: number;
  @Input() credits!: number;
  @Input() gpa!: number;
  @Input() image: string = '';

}

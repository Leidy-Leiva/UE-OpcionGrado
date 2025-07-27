import { Component,Input, OnInit } from '@angular/core';
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
  styleUrls: ['./panelinfo.component.scss']
})
export class PanelinfoComponent{
   @Input() image: string = '';
   @Input() infoFields: { label: string, value: string | number }[] = [];
   @Input() selectedProgram: string | null = null;
  programOptions = [
    { value: 'prog1', label: 'Programa 1' },
    { value: 'prog2', label: 'Programa 2' },
    { value: 'prog3', label: 'Programa 3' }
  ];

  // infoFields = [
  //   { label: 'Edad', value: '30 años' },
  //   { label: 'Primedio:', value:'' }
  // ];

  
  // @Input() programOptions: { value: string, label: string }[] = [];
  // @Input() selectedProgram: string = '';

}
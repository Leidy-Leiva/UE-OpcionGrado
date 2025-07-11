import { Component,Input,Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModalComponent } from 'src/app/shared/components/organisms/modal/modal.component';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';
import { IconComponent } from 'src/app/shared/components/atoms/icon/icon.component';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';
import { ButtonComponent } from 'src/app/shared/components/atoms/button/button.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { CheckBoxComponent } from "src/app/shared/components/atoms/check-box/check-box.component";

@Component({
  selector: 'app-create-table',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './create-table.component.html',
  styleUrls: ['./create-table.component.css']
})
export class CreateTableComponent {

 
}

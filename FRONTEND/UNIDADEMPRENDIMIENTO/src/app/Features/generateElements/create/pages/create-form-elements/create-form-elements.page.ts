import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from 'src/app/shared/components/organisms/header/header.component';

@Component({
  selector: 'app-create-form-elements',
  standalone: true,
  imports: [CommonModule, HeaderComponent],
  templateUrl: './create-form-elements.page.html',
  styleUrls: ['./create-form-elements.page.css']
})
export class CreateFormElements {

}

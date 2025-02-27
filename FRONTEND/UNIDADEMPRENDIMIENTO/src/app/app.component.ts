import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { ButtonwithiconComponent } from './shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { ButtonComponent } from './shared/components/atoms/button/button.component';
import { LabelComponent } from './shared/components/atoms/label/label.component';
import { HeaderComponent } from "./shared/components/molecules/header/header.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet,HeaderComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'UNIDADEMPRENDIMIENTO';
}

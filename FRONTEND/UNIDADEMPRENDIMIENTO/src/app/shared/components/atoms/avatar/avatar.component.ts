import { Component,Input } from '@angular/core';
import { CommonModule, NgIf, NgStyle } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-avatar',
  standalone: true,
  imports: [CommonModule,NgStyle, NgIf,MatIconModule,],
  templateUrl: './avatar.component.html',
  styleUrls: ['./avatar.component.css']
})
export class AvatarComponent {
  @Input() imageUrl: string = ''; // URL de la imagen del avatar
  @Input() size: number = 50; // Tamaño del avatar (por defecto 50px)
  @Input() alt: string = 'Avatar'; // Texto alternativo
  @Input() rounded: boolean = true; // Define si es circular o cuadrado
}

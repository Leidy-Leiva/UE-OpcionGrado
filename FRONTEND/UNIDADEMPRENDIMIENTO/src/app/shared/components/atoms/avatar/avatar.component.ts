import { Component,Input } from '@angular/core';
import { CommonModule, NgIf, NgStyle } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-avatar',
  standalone: true,
  imports: [CommonModule, NgIf,MatIconModule,],
  templateUrl: './avatar.component.html',
  styleUrls: ['./avatar.component.scss']
})
export class AvatarComponent {
  @Input() imageUrl: string = ''; 
  @Input() size?: number ; 
  @Input() alt: string = 'Avatar'; 
  @Input() rounded: boolean = true; 
  @Input() extraClass = '';
}

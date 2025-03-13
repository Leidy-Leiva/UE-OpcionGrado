import { Component, AfterViewInit, ElementRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Input } from 'mdb-ui-kit';

@Component({
  selector: 'app-seeker',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './seeker.component.html',
  styleUrls: ['./seeker.component.css'],
})
export class SeekerComponent implements AfterViewInit {
  constructor(private el: ElementRef) {}

  ngAfterViewInit(): void {
    const elements = this.el.nativeElement.querySelectorAll('.form-outline');
    elements.forEach((element: any) => new Input(element)); // Inicialización de MDB
  }
}

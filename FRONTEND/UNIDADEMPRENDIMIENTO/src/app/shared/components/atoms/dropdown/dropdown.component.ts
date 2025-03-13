import { Component,Input,Output,EventEmitter,signal} from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { LabelComponent } from "../label/label.component";

@Component({
  selector: 'app-dropdown',
  standalone: true,
  imports: [CommonModule, MatSelectModule, MatFormFieldModule, LabelComponent],
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.css']
})
export class DropdownComponent {
  @Input() options:{value:any;label:string}[]=[];
  @Input() label:string='';
  selected=signal<any>(null);
  @Output() valueChange=new EventEmitter<any>();

  OnSelectionChange(value: any){
    this.selected.set(value);
    this.valueChange.emit(value);
  }

}

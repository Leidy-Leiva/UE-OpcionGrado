import { Component,Input , Output,EventEmitter, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MenuOptionsService } from 'src/app/core/services/menu-options.service';
import { ButtongroupComponent } from 'src/app/shared/components/organisms/buttongroup/buttongroup.component';
import { buttonconfig } from 'src/app/shared/models/button-config';

@Component({
  selector: 'app-menuoptions',
  standalone: true,
  imports: [CommonModule,FormsModule,ButtongroupComponent],
  templateUrl: './menuoptions.component.html',
  styleUrls: ['./menuoptions.component.scss']
})
export class MenuoptionsComponent implements OnInit {
  @Input() userRoles: string[] = [];
  @Output() btnClick = new EventEmitter<string>();

  menuOptionsButtons: buttonconfig[] = [];
  constructor(private menuOptionsService: MenuOptionsService) {}

  ngOnInit() {
    this.menuOptionsButtons = this.menuOptionsService.getButtonsByRoles(this.userRoles); 
  }

  Action(action: string) {
    this.btnClick.emit(action);
  }
}

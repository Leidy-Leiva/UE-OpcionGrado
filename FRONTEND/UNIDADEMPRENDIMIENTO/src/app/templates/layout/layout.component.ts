import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../../shared/components/organisms/header/header.component';
import { PanelinfoComponent } from '../../shared/components/organisms/panelinfo/panelinfo.component';
import { Router, RouterModule } from '@angular/router';
import { LabelComponent } from 'src/app/shared/components/atoms/label/label.component';
import { IconComponent } from 'src/app/shared/components/atoms/icon/icon.component';
import { ButtonwithiconComponent } from 'src/app/shared/components/molecules/buttonwithicon/buttonwithicon.component';
import { ButtonwithicongroupComponent } from 'src/app/shared/components/organisms/buttonwithicongroup/buttonwithicongroup.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { MenuoptionsComponent } from '../../shared/components/organisms/menuoptions/menuoptions.component';
import { PersonalDataService } from 'src/app/core/services/personal-data.service';
@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [
    CommonModule,
    HeaderComponent,
    PanelinfoComponent,
    MenuoptionsComponent,
    RouterModule,
    LabelComponent,
    IconComponent,
    ButtonwithicongroupComponent,
    ButtonwithiconComponent,
  ],
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css'],
})
export class LayoutComponent implements OnInit {
  @Input() pageTitle?: string;
  panelImage: string = '';
  panelInfoFields: { label: string; value: string }[] = [];

  isCollapsed: boolean = false;

  constructor(
    private router: Router,
    private userInfoService: PersonalDataService
  ) {}
  ngOnInit(): void {
    this.userInfoService.getPersonalData().subscribe({
      next: (data) => {
        this.panelImage = data.foto?? '';
        this.panelInfoFields = [
          { label: '', value: data.nombre},
          { label: '', value: '23' },
        ];
      },
      error: (err) => {
        console.error('Error al obtener datos personales');
      },
    });
  }

  mainHeaderButtons: ButtonWithIconConfig[] = [
    {
      icon: 'remove',
      typeButton: 'button',
      disabled: false,
      iconColor: '#264390',
      action: 'minimize',
    },
    {
      icon: 'crop_square',
      typeButton: 'button',
      disabled: false,
      iconColor: '#264390',
      action: 'maximize',
    },
    {
      icon: 'close',
      typeButton: 'button',
      disabled: false,
      iconColor: '#264390',
      action: 'close',
    },
  ];

  secondaryHeaderButtons: ButtonWithIconConfig[] = [
    {
      icon: 'sync',
      title: 'Recargar página',
      typeButton: 'button',
      disabled: false,
      iconColor: '#91CA8A',
      action: 'recargar',
    },
    {
      icon: 'help',
      title: 'Ayuda',
      typeButton: 'button',
      disabled: false,
      iconColor: '#6995C3',
    },
  ];

  buttonPanelInfoHeader: ButtonWithIconConfig = {
    icon: 'arrow-right',
    typeButton: 'button',
    disabled: false,
    iconColor: '#ffffff',
    action: 'toggle-sidebar',
    typeIcon: 'fontawesome',
  };

  onMenuButtonClick(action: string) {
    console.log('Accion del menú', action);

    switch (action) {
      case 'Elementos':
        console.log('Acabe de darle clic');
        this.router.navigate(['/generate-elements-form/listar']);
        break;

      case 'Convocatoria':
        console.log('Acabe de darle clic');
        this.router.navigate(['/generate-call/listar']);
        break;

      case 'Formulario':
        console.log('Acabe de darle clic');
        this.router.navigate(['/generate-form/listar']);
        break;
    }
  }

  handleAction(action: string) {
    console.log('Acción del menú:', action);

    switch (action) {
      case 'toggle-sidebar':
        this.isCollapsed = !this.isCollapsed;
        break;

      case 'recargar':
        window.location.reload();
        break;

      case 'ayuda':
        break;

      case 'closeWindow':
        break;

      case 'minimizeWindow':
        break;

      case 'maximizeWindow':
        break;

      default:
        console.warn('Acción no reconocida:', action);
    }
  }
}

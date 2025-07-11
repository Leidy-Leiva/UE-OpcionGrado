import { Component, OnInit, Input, Output, EventEmitter, ViewChild, ViewContainerRef, ComponentRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonwithicongroupComponent } from '../../../../shared/components/organisms/buttonwithicongroup/buttonwithicongroup.component';
import { ButtonWithIconConfig } from 'src/app/shared/models/buttonwithicon-config';
import { ButtonsFormService } from '../../Services/buttons-form.service';
import { WrapperComponent } from 'src/app/shared/components/organisms/wrapper/wrapper.component';
import { ElementsFormMapper } from 'src/app/shared/mappers/generate-forms.mapper';

@Component({
  selector: 'app-formbuilder',
  standalone: true,
  imports: [CommonModule, ButtonwithicongroupComponent],
  templateUrl: './formbuilder.component.html',
  styleUrls: ['./formbuilder.component.css'],
})
export class FormbuilderComponent implements OnInit {
  @Input() typeForm: string[] = [];
  @Output() btnClick = new EventEmitter<string>();
  private wrapperRefs: ComponentRef<WrapperComponent>[] = [];


  buttonOptionForm: ButtonWithIconConfig[] = [];
  
  constructor(private buttonsFomrService: ButtonsFormService) {}
  ngOnInit(): void {
    this.buttonOptionForm = this.buttonsFomrService.getButtonsTypeForm(
      this.typeForm
    );
  }

  Action(action: string) {
    this.btnClick.emit(action);

    if(action!="Traer_Preguntas"){
      this.loadFormComponent(action);
    }
    
  }

  @ViewChild('wrappersContainer', { read: ViewContainerRef })
  wrappersContainer!: ViewContainerRef;



  async loadFormComponent(type: string) {
  // 1. Busca el loader en el mapper
  const loader = ElementsFormMapper[type];
  if (!loader) {
    console.warn(`Tipo no soportado: ${type}`);
    return;
  }

  try {
    const wrapperRef = this.wrappersContainer.createComponent(WrapperComponent);

    const componentType = await loader();                  
    const contentRef = wrapperRef.instance.viewContainer.createComponent(componentType);

    wrapperRef.instance.onDelete = () => {

      const idx = this.wrapperRefs.indexOf(wrapperRef);
      if (idx > -1) {
        this.wrapperRefs[idx].destroy();
        this.wrapperRefs.splice(idx, 1);
      }
    };

  
    // this.wrapperRefs.push(wrapperRef);

  } catch (error) {
    console.error('Error cargando componente:', error);
  }
}

}

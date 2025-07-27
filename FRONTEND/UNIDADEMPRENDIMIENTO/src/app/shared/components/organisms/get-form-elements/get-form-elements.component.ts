import {
  Component,
  Input,
  OnInit,
  ViewChild,
  ViewContainerRef,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../atoms/label/label.component';

@Component({
  selector: 'app-get-form-elements',
  standalone: true,
  imports: [CommonModule, LabelComponent],
  templateUrl: './get-form-elements.component.html',
  styleUrls: ['./get-form-elements.component.scss'],
})
export class GetFormElementsComponent  {

  @Input() question: string = '';
  @Input() typeQuestion: string = '';

  @ViewChild('dynamicGetComponentContainer', { read: ViewContainerRef })
  dynamicComponentContainer!: ViewContainerRef;

  ngAfterViewInit() {
    this.loadComponentByType();
  }

  async loadComponentByType() {
    this.dynamicComponentContainer.clear();

    switch (this.typeQuestion) {
      case 'opcionMultiple':
        const { ViewOpenQuestionComponent } = await import(
          'src/app/shared/components/molecules/view-open-question/view-open-question.component'
        );
        this.dynamicComponentContainer.createComponent(
          ViewOpenQuestionComponent
        );
        break;
      case 'opcionMultiple':
        const { ViewClosedQuestionComponent } = await import(
          'src/app/shared/components/molecules/view-closed-question/view-closed-question.component'
        );
        this.dynamicComponentContainer.createComponent(
          ViewClosedQuestionComponent
        );
        break;
      case 'escala':
        const { ViewMultipleChoiceQuestionComponent } = await import(
          'src/app/shared/components/molecules/view-multiple-choice-question/view-multiple-choice-question.component'
        );
        this.dynamicComponentContainer.createComponent(
          ViewMultipleChoiceQuestionComponent
        );
        break;
      default:
        break;
    }
  }
}

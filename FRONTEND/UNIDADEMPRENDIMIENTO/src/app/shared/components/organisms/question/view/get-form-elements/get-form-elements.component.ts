import {
  AfterViewInit,
  Component,
  Input,
  OnChanges,
  OnInit,
  SimpleChanges,
  ViewChild,
  ViewContainerRef,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelComponent } from '../../../../atoms/label/label.component';

@Component({
  selector: 'app-get-form-elements',
  standalone: true,
  imports: [CommonModule, LabelComponent],
  templateUrl: './get-form-elements.component.html',
  styleUrls: ['./get-form-elements.component.scss'],
})
export class GetFormElementsComponent implements OnChanges, AfterViewInit {

  @Input() question: string = '';
  @Input() typeQuestion: string = '';
  @Input() options: string[] = [];
  @Input() selected: string | string[] = '';

  @ViewChild('dynamicGetComponentContainer', { read: ViewContainerRef, static: true })
  dynamicComponentContainer!: ViewContainerRef;

  private initialized = false;

  ngAfterViewInit() {
     this.initialized = true;
    this.loadComponentByType();
  }

  ngOnChanges(changes: SimpleChanges) {
    if (this.initialized && (
       changes['typeQuestion']?.currentValue !== changes['typeQuestion']?.previousValue ||
      changes['options']?.currentValue !== changes['options']?.previousValue ||
      changes['selected']?.currentValue !== changes['selected']?.previousValue)) {
      this.loadComponentByType();
    }
  }

  async loadComponentByType() {
    this.dynamicComponentContainer.clear();
         console.log("el tipo que me llega es:" ,this.typeQuestion);
    switch (this.typeQuestion) {
      case 'Abierta':
        const { ViewOpenQuestionComponent } = await import(
          'src/app/shared/components/organisms/question/view/view-open-question/view-open-question.component'
        );
        const cmp=this.dynamicComponentContainer.createComponent(
          ViewOpenQuestionComponent
        );
          cmp.instance.question = this.question;
        break;
      case 'Cerrada':
        const { ViewClosedQuestionComponent } = await import(
          'src/app/shared/components/organisms/question/view/view-closed-question/view-closed-question.component'
        );
        const cmc=this.dynamicComponentContainer.createComponent(
          ViewClosedQuestionComponent
        );
        cmc.instance.options  = this.options;         
        cmc.instance.selected = this.selected as string; 

        break;
      case 'Multiple':
        const { ViewMultipleChoiceQuestionComponent } = await import(
          'src/app/shared/components/organisms/question/view/view-multiple-choice-question/view-multiple-choice-question.component'
        );
       const cmm= this.dynamicComponentContainer.createComponent(
          ViewMultipleChoiceQuestionComponent
        );
        cmm.instance.options  = this.options;
        cmm.instance.selected = this.selected as string[];

        break;
      default:
        break;
    }
  }
}

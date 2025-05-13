import { Component, inject, OnInit,Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelwithinputComponent } from '../../molecules/labelwithinput/labelwithinput.component';
import { ElementtypeService } from 'src/app/core/services/element-type.service';
import { LabelwithdropdownComponent } from '../../molecules/labelwithdropdown/labelwithdropdown.component';

@Component({
  selector: 'app-form-elements',
  standalone: true,
  imports: [CommonModule,LabelwithdropdownComponent,LabelwithinputComponent],
  templateUrl: './form-elements.component.html',
  styleUrls: ['./form-elements.component.css']
})
export class FormElementsComponent implements OnInit {

 private questionService= inject (ElementtypeService);
  @Input() questionOptions: { value: any; label: string }[] = [];
   showOptionsField: boolean = false;
   questionText: string = '';

   ngOnInit() {
    this.loadQuestionOptions();  //Llamar al metodo para obtener los datos de la API
  }

  private loadQuestionOptions(){
  this.questionService.getTipoElementos().subscribe({
    next:(data: string[]) => {
      this.questionOptions = data.map(item => ({
        value: item,
        label: item
      }));
    },
    error:(err)=>console.error("Error cargando las opciones de elemento formulario:", err)
  });
}

    onSelectionChange(selectedValue: string) {
    console.log('Tipo de cuestionario seleccionado:', selectedValue);
    this.showOptionsField = selectedValue === 'Opcional';
  }

  onQuestionChange(newValue: string) {
    console.log('Pregunta ingresada:', newValue);
    this.questionText = newValue;
  }
}

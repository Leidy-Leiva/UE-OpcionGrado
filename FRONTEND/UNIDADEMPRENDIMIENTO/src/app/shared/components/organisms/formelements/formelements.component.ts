import { Component, ComponentRef, inject, OnInit,ViewChild, ViewContainerRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LabelwithinputComponent } from '../../molecules/labelwithinput/labelwithinput.component';
import { ElementtypeService } from 'src/app/core/services/element-type.service';
import { LabelwithdropdownComponent } from '../../molecules/labelwithdropdown/labelwithdropdown.component';
import { QuestionElementMapper } from 'src/app/shared/mappers/question-elements.mapper';

@Component({
  selector: 'app-form-elements',
  standalone: true,
  imports: [CommonModule,LabelwithdropdownComponent,LabelwithinputComponent],
  templateUrl: './formelements.component.html',
  styleUrls: ['./formelements.component.css']
})
export class FormElementsComponent implements OnInit {

 private questionService= inject (ElementtypeService);


  @ViewChild('dynamicComponentContainer', { read: ViewContainerRef })
  dynamicComponentContainer!: ViewContainerRef;

  questionOptions: { value: string; label: string }[] = [];
  selectedType: string = '';
  questionText: string = '';
  currentComponentRef: ComponentRef<any> | null = null;


   ngOnInit() {
    this.loadQuestionOptions();  //Llamar al metodo para obtener los datos de la API
  }

 private loadQuestionOptions(){
  this.questionService.getTipoElementos().subscribe({
    next:(data: any[]) => {
      console.log('Datos crudos de la API:', data); // <-- Aquí
      this.questionOptions = data.map(item => ({
        value: item.tpeF_NOMBRE,
        label: item.tpeF_NOMBRE
      }));
      console.log("Opciones construidas:", this.questionOptions);
    },
    error:(err)=>console.error("Error cargando las opciones de elemento formulario:", err)
  });
}


  onSelectionChange(selected: string) {
    console.log("Tipo seleccionado:", selected);
    this.selectedType = selected;
    this.loadQuestionComponent(selected);
  }

  onQuestionChange(newValue: string) {
    console.log('Pregunta ingresada:', newValue);
    this.questionText = newValue;
  }

  async loadQuestionComponent(type: string) {
    this.dynamicComponentContainer.clear(); // 🧹 Limpia el contenedor actual (si hay algo)

    const loader = QuestionElementMapper[type]; // 🔍 Busca en el mapper el importador

    if (!loader) {
      console.warn(`Tipo de componente no soportado: ${type}`);
      return;
    }

    try {
      const component = await loader(); // ⏳ Espera a que cargue dinámicamente el componente
      this.currentComponentRef = this.dynamicComponentContainer.createComponent(component); // 🧱 Crea e inserta el componente en el contenedor

    } catch (error) {
      console.error('Error al cargar componente:', error); // 🚨 Captura errores si algo falla
    }
  }
}

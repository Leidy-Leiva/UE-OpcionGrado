using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoElementoFormulario;
using Api.UnidadEmprendimiento.Application.Enums;
using FluentValidation;

namespace Api.UnidadEmprendimiento.Application.Validators
{
    public class PostBEFormularioDTOValidator : AbstractValidator<PostBEFormularioDTO>
    {
        public PostBEFormularioDTOValidator()
        {
            RuleFor(x => x.BEFO_ENUNCIADO).NotEmpty().MaximumLength(500);
            RuleFor(x => x.TEFO_CODIGO)
                .Must(codigo => Enum.IsDefined(typeof(TipoElemento), codigo))
                .WithMessage("Código de tipo de elemento no válido.");
                
            When(x => ((TipoElemento)x.TEFO_CODIGO).IsQuestionType(), () =>
            {

                When(x => x.TEFO_CODIGO == (int)TipoElemento.Cerrada || x.TEFO_CODIGO == (int)TipoElemento.Multiple, () =>
                {
                    RuleFor(x => x.BANCOOPCRESELEMENTOS)
                        .NotNull().WithMessage("Se requieren opciones para este tipo de pregunta.")
                        .Must(list => list != null && list.Count >= 2).WithMessage("Se requieren al menos 2 opciones.");
                    RuleForEach(x => x.BANCOOPCRESELEMENTOS).SetValidator(new PostBORElementoDTOValidator());
                });


                When(x => x.TEFO_CODIGO == (int)TipoElemento.Abierta, () =>
                {
                    RuleFor(x => x.BANCOOPCRESELEMENTOS)
                        .Must(list => list == null || list.Count == 0)
                        .WithMessage("Las preguntas abiertas no deben incluir opciones de respuesta.");
                });
            });


            When(x => !((TipoElemento)x.TEFO_CODIGO).IsQuestionType(), () =>
            {
                RuleFor(x => x.BANCOOPCRESELEMENTOS)
                    .Must(list => list == null || list.Count == 0)
                    .WithMessage("Sólo los elementos de tipo pregunta pueden contener opciones.");
            });
        }
    }


}

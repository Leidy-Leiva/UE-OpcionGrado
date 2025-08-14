using Api.UnidadEmprendimiento.Application.DTO_s.GEST_FORM.BancoOpcResElemento;
using FluentValidation;

public class PostBORElementoDTOValidator : AbstractValidator<PostBORElementoDTO>
    {
        public PostBORElementoDTOValidator()
        {
            RuleFor(x => x.BORE_VALOR).NotEmpty().WithMessage("El valor de la opción no puede estar vacío.");
        }
    }
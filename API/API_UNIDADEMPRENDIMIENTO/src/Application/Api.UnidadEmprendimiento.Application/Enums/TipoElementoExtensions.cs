namespace Api.UnidadEmprendimiento.Application.Enums{
    public static class TipoElementoExtensions
    {
        public static bool IsQuestionType(this TipoElemento tipo) =>
            tipo == TipoElemento.Abierta ||
            tipo == TipoElemento.Cerrada ||
            tipo == TipoElemento.Multiple;
    }
}

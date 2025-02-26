using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.UnidadEmprendimiento.Data.Migrations
{
    /// <inheritdoc />
    public partial class MiPrimerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CONVOCATORIA",
                columns: table => new
                {
                    CONV_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONV_FECHAINICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CONV_FECHAFIN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PERS_CODIGO = table.Column<int>(type: "int", nullable: false),
                    CONV_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONVOCATORIA", x => x.CONV_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "ESTADOPROPUESTA",
                columns: table => new
                {
                    ESTP_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESTP_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ESTP_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADOPROPUESTA", x => x.ESTP_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "EVALUACION",
                columns: table => new
                {
                    EVAL_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EVAL_PROMEDIOCALIFICACION = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EVAL_FECHACALIFICACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EVAL_COMENTARIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EVAL_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EVALUACION", x => x.EVAL_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "JURADO",
                columns: table => new
                {
                    JURA_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JURA_PNOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JURA_SNOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JURA_PAPELLIDO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JURA_SAPELLIDO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JURA_CORREO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JURA_TELEFONO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JURA_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JURADO", x => x.JURA_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "TIPOFORMULARIO",
                columns: table => new
                {
                    TIPF_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPF_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TIPF_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOFORMULARIO", x => x.TIPF_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "TIPOPREGUNTA",
                columns: table => new
                {
                    TIPR_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPR_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TIPR_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOPREGUNTA", x => x.TIPR_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    USUA_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUA_PNOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    USUA_SNOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    USUA_PAPELLIDO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    USUA_SAPELLIDO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    USUA_NOMBREUSUARIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    USUA_CONTRASENIA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    USUA_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PERS_PEGEID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.USUA_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "PROPUESTA",
                columns: table => new
                {
                    PROP_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROP_TITULO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PROP_DESCRIPCION = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PROP_PRESENTACION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PROP_CALIFICACION = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PROP_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SALA_CODIGO = table.Column<int>(type: "int", nullable: false),
                    CONV_CODIGO = table.Column<int>(type: "int", nullable: false),
                    ESTP_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROPUESTA", x => x.PROP_CODIGO);
                    table.ForeignKey(
                        name: "FK_PROPUESTA_CONVOCATORIA_CONV_CODIGO",
                        column: x => x.CONV_CODIGO,
                        principalTable: "CONVOCATORIA",
                        principalColumn: "CONV_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PROPUESTA_ESTADOPROPUESTA_ESTP_CODIGO",
                        column: x => x.ESTP_CODIGO,
                        principalTable: "ESTADOPROPUESTA",
                        principalColumn: "ESTP_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ITEM",
                columns: table => new
                {
                    ITEM_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITEM_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ITEM_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ITEM_PUNTAJEMAXIMO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ITEM_COMENTARIO = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    EVAL_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM", x => x.ITEM_CODIGO);
                    table.ForeignKey(
                        name: "FK_ITEM_EVALUACION_EVAL_CODIGO",
                        column: x => x.EVAL_CODIGO,
                        principalTable: "EVALUACION",
                        principalColumn: "EVAL_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FORMULARIO",
                columns: table => new
                {
                    FORM_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FORM_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FORM_DESCRIPCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FORM_FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FORM_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TIPF_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMULARIO", x => x.FORM_CODIGO);
                    table.ForeignKey(
                        name: "FK_FORMULARIO_TIPOFORMULARIO_TIPF_CODIGO",
                        column: x => x.TIPF_CODIGO,
                        principalTable: "TIPOFORMULARIO",
                        principalColumn: "TIPF_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EVALUACIONDETALLE",
                columns: table => new
                {
                    EVDE_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EVDE_COMENTARIO = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    EVDE_CALIFICACION = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EVDE_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    EVAL_CODIGO = table.Column<int>(type: "int", nullable: false),
                    PROP_CODIGO = table.Column<int>(type: "int", nullable: false),
                    JURA_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EVALUACIONDETALLE", x => x.EVDE_CODIGO);
                    table.ForeignKey(
                        name: "FK_EVALUACIONDETALLE_EVALUACION_EVAL_CODIGO",
                        column: x => x.EVAL_CODIGO,
                        principalTable: "EVALUACION",
                        principalColumn: "EVAL_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EVALUACIONDETALLE_JURADO_JURA_CODIGO",
                        column: x => x.JURA_CODIGO,
                        principalTable: "JURADO",
                        principalColumn: "JURA_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EVALUACIONDETALLE_PROPUESTA_PROP_CODIGO",
                        column: x => x.PROP_CODIGO,
                        principalTable: "PROPUESTA",
                        principalColumn: "PROP_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PROPUESTAJURADO",
                columns: table => new
                {
                    PROPJ_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRPJ_FECHAASIGNACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROPJ_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PROP_CODIGO = table.Column<int>(type: "int", nullable: false),
                    JURA_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROPUESTAJURADO", x => x.PROPJ_CODIGO);
                    table.ForeignKey(
                        name: "FK_PROPUESTAJURADO_JURADO_JURA_CODIGO",
                        column: x => x.JURA_CODIGO,
                        principalTable: "JURADO",
                        principalColumn: "JURA_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PROPUESTAJURADO_PROPUESTA_PROP_CODIGO",
                        column: x => x.PROP_CODIGO,
                        principalTable: "PROPUESTA",
                        principalColumn: "PROP_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONVOCATORIAFORMULARIO",
                columns: table => new
                {
                    COFO_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COFO_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FORM_CODIGO = table.Column<int>(type: "int", nullable: false),
                    CONV_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONVOCATORIAFORMULARIO", x => x.COFO_CODIGO);
                    table.ForeignKey(
                        name: "FK_CONVOCATORIAFORMULARIO_CONVOCATORIA_CONV_CODIGO",
                        column: x => x.CONV_CODIGO,
                        principalTable: "CONVOCATORIA",
                        principalColumn: "CONV_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CONVOCATORIAFORMULARIO_FORMULARIO_FORM_CODIGO",
                        column: x => x.FORM_CODIGO,
                        principalTable: "FORMULARIO",
                        principalColumn: "FORM_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SECCION",
                columns: table => new
                {
                    SECC_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SECC_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SECC_ORDEN = table.Column<int>(type: "int", nullable: false),
                    SECC_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FORM_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECCION", x => x.SECC_CODIGO);
                    table.ForeignKey(
                        name: "FK_SECCION_FORMULARIO_FORM_CODIGO",
                        column: x => x.FORM_CODIGO,
                        principalTable: "FORMULARIO",
                        principalColumn: "FORM_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PREGUNTA",
                columns: table => new
                {
                    PREG_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PREG_ENUNCIADO = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PREG_ORDEN = table.Column<int>(type: "int", nullable: false),
                    PREG_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TIPR_CODIGO = table.Column<int>(type: "int", nullable: false),
                    SECC_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PREGUNTA", x => x.PREG_CODIGO);
                    table.ForeignKey(
                        name: "FK_PREGUNTA_SECCION_SECC_CODIGO",
                        column: x => x.SECC_CODIGO,
                        principalTable: "SECCION",
                        principalColumn: "SECC_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PREGUNTA_TIPOPREGUNTA_TIPR_CODIGO",
                        column: x => x.TIPR_CODIGO,
                        principalTable: "TIPOPREGUNTA",
                        principalColumn: "TIPR_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RESPUESTA",
                columns: table => new
                {
                    RESP_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RESP_VALOR = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RESP_FECHARESPUESTA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RESP_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PREG_CODIGO = table.Column<int>(type: "int", nullable: false),
                    PROP_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESPUESTA", x => x.RESP_CODIGO);
                    table.ForeignKey(
                        name: "FK_RESPUESTA_PREGUNTA_PREG_CODIGO",
                        column: x => x.PREG_CODIGO,
                        principalTable: "PREGUNTA",
                        principalColumn: "PREG_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RESPUESTA_PROPUESTA_PROP_CODIGO",
                        column: x => x.PROP_CODIGO,
                        principalTable: "PROPUESTA",
                        principalColumn: "PROP_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CONVOCATORIAFORMULARIO_CONV_CODIGO",
                table: "CONVOCATORIAFORMULARIO",
                column: "CONV_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_CONVOCATORIAFORMULARIO_FORM_CODIGO",
                table: "CONVOCATORIAFORMULARIO",
                column: "FORM_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_EVALUACIONDETALLE_EVAL_CODIGO",
                table: "EVALUACIONDETALLE",
                column: "EVAL_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_EVALUACIONDETALLE_JURA_CODIGO",
                table: "EVALUACIONDETALLE",
                column: "JURA_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_EVALUACIONDETALLE_PROP_CODIGO",
                table: "EVALUACIONDETALLE",
                column: "PROP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIO_TIPF_CODIGO",
                table: "FORMULARIO",
                column: "TIPF_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_ITEM_EVAL_CODIGO",
                table: "ITEM",
                column: "EVAL_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_PREGUNTA_SECC_CODIGO",
                table: "PREGUNTA",
                column: "SECC_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_PREGUNTA_TIPR_CODIGO",
                table: "PREGUNTA",
                column: "TIPR_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_PROPUESTA_CONV_CODIGO",
                table: "PROPUESTA",
                column: "CONV_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_PROPUESTA_ESTP_CODIGO",
                table: "PROPUESTA",
                column: "ESTP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_PROPUESTAJURADO_JURA_CODIGO",
                table: "PROPUESTAJURADO",
                column: "JURA_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_PROPUESTAJURADO_PROP_CODIGO",
                table: "PROPUESTAJURADO",
                column: "PROP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_RESPUESTA_PREG_CODIGO",
                table: "RESPUESTA",
                column: "PREG_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_RESPUESTA_PROP_CODIGO",
                table: "RESPUESTA",
                column: "PROP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_SECCION_FORM_CODIGO",
                table: "SECCION",
                column: "FORM_CODIGO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONVOCATORIAFORMULARIO");

            migrationBuilder.DropTable(
                name: "EVALUACIONDETALLE");

            migrationBuilder.DropTable(
                name: "ITEM");

            migrationBuilder.DropTable(
                name: "PROPUESTAJURADO");

            migrationBuilder.DropTable(
                name: "RESPUESTA");

            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropTable(
                name: "EVALUACION");

            migrationBuilder.DropTable(
                name: "JURADO");

            migrationBuilder.DropTable(
                name: "PREGUNTA");

            migrationBuilder.DropTable(
                name: "PROPUESTA");

            migrationBuilder.DropTable(
                name: "SECCION");

            migrationBuilder.DropTable(
                name: "TIPOPREGUNTA");

            migrationBuilder.DropTable(
                name: "CONVOCATORIA");

            migrationBuilder.DropTable(
                name: "ESTADOPROPUESTA");

            migrationBuilder.DropTable(
                name: "FORMULARIO");

            migrationBuilder.DropTable(
                name: "TIPOFORMULARIO");
        }
    }
}

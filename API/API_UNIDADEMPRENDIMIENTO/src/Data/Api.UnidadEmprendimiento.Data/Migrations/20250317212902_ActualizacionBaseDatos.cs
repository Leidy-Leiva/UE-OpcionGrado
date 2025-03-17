using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.UnidadEmprendimiento.Data.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionBaseDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EVALUACIONDETALLE_EVALUACION_EVAL_CODIGO",
                table: "EVALUACIONDETALLE");

            migrationBuilder.DropForeignKey(
                name: "FK_EVALUACIONDETALLE_JURADO_JURA_CODIGO",
                table: "EVALUACIONDETALLE");

            migrationBuilder.DropForeignKey(
                name: "FK_EVALUACIONDETALLE_PROPUESTA_PROP_CODIGO",
                table: "EVALUACIONDETALLE");

            migrationBuilder.DropForeignKey(
                name: "FK_ITEM_EVALUACION_EVAL_CODIGO",
                table: "ITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_PROPUESTA_CONVOCATORIA_CONV_CODIGO",
                table: "PROPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_PROPUESTA_ESTADOPROPUESTA_ESTP_CODIGO",
                table: "PROPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_PROPUESTAJURADO_JURADO_JURA_CODIGO",
                table: "PROPUESTAJURADO");

            migrationBuilder.DropForeignKey(
                name: "FK_PROPUESTAJURADO_PROPUESTA_PROP_CODIGO",
                table: "PROPUESTAJURADO");

            migrationBuilder.DropForeignKey(
                name: "FK_RESPUESTA_PREGUNTA_PREG_CODIGO",
                table: "RESPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_RESPUESTA_PROPUESTA_PROP_CODIGO",
                table: "RESPUESTA");

            migrationBuilder.DropTable(
                name: "CONVOCATORIAFORMULARIO");

            migrationBuilder.DropTable(
                name: "PREGUNTA");

            migrationBuilder.DropTable(
                name: "CONVOCATORIA");

            migrationBuilder.DropTable(
                name: "SECCION");

            migrationBuilder.DropTable(
                name: "TIPOPREGUNTA");

            migrationBuilder.DropTable(
                name: "FORMULARIO");

            migrationBuilder.DropColumn(
                name: "PROP_DESCRIPCION",
                table: "PROPUESTA");

            migrationBuilder.DropColumn(
                name: "PROP_PRESENTACION",
                table: "PROPUESTA");

            migrationBuilder.DropColumn(
                name: "PROP_TITULO",
                table: "PROPUESTA");

            migrationBuilder.RenameColumn(
                name: "PERS_PEGEID",
                table: "USUARIO",
                newName: "PERS_CODIGO");

            migrationBuilder.RenameColumn(
                name: "PREG_CODIGO",
                table: "RESPUESTA",
                newName: "EFOP_CODIGO");

            migrationBuilder.RenameIndex(
                name: "IX_RESPUESTA_PREG_CODIGO",
                table: "RESPUESTA",
                newName: "IX_RESPUESTA_EFOP_CODIGO");

            migrationBuilder.RenameColumn(
                name: "CONV_CODIGO",
                table: "PROPUESTA",
                newName: "CONP_CODIGO");

            migrationBuilder.RenameIndex(
                name: "IX_PROPUESTA_CONV_CODIGO",
                table: "PROPUESTA",
                newName: "IX_PROPUESTA_CONP_CODIGO");

            migrationBuilder.CreateTable(
                name: "CONVOCATORIABORRADOR",
                columns: table => new
                {
                    CONB_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONB_FECHAINICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CONB_FECHAFIN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PERS_CODIGO = table.Column<int>(type: "int", nullable: false),
                    CONB_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONVOCATORIABORRADOR", x => x.CONB_CODIGO);
                    table.ForeignKey(
                        name: "FK_CONVOCATORIABORRADOR_USUARIO_PERS_CODIGO",
                        column: x => x.PERS_CODIGO,
                        principalTable: "USUARIO",
                        principalColumn: "USUA_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CONVOCATORIAPUBLICADA",
                columns: table => new
                {
                    CONP_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONP_FECHAINICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CONP_FECHAFIN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PERS_CODIGO = table.Column<int>(type: "int", nullable: false),
                    CONP_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONVOCATORIAPUBLICADA", x => x.CONP_CODIGO);
                    table.ForeignKey(
                        name: "FK_CONVOCATORIAPUBLICADA_USUARIO_PERS_CODIGO",
                        column: x => x.PERS_CODIGO,
                        principalTable: "USUARIO",
                        principalColumn: "USUA_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ESTADOFORMULARIO",
                columns: table => new
                {
                    ESTF_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESTF_NOMBRE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ESTF_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADOFORMULARIO", x => x.ESTF_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "TIPOELEMENTOFORMULARIO",
                columns: table => new
                {
                    TPEF_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TPEF_NOMBRE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TPEF_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOELEMENTOFORMULARIO", x => x.TPEF_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOPROPUESTA",
                columns: table => new
                {
                    USUP_CODIGO = table.Column<int>(type: "int", nullable: false),
                    USUP_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    USUP_FECHAASOCIACION = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PERS_CODIGO = table.Column<int>(type: "int", nullable: false),
                    PROP_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOPROPUESTA", x => x.USUP_CODIGO);
                    table.ForeignKey(
                        name: "FK_USUARIOPROPUESTA_PROPUESTA_PERS_CODIGO",
                        column: x => x.PERS_CODIGO,
                        principalTable: "PROPUESTA",
                        principalColumn: "PROP_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USUARIOPROPUESTA_USUARIO_USUP_CODIGO",
                        column: x => x.USUP_CODIGO,
                        principalTable: "USUARIO",
                        principalColumn: "USUA_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VERSION",
                columns: table => new
                {
                    VERS_CODIGO = table.Column<int>(type: "int", nullable: false),
                    VERS_FECHAMOFICIACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VERS_NUMERO = table.Column<int>(type: "int", nullable: false),
                    VERS_COMENTARIO = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    VERS_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PERS_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VERSION", x => x.VERS_CODIGO);
                    table.ForeignKey(
                        name: "FK_VERSION_PROPUESTA_VERS_CODIGO",
                        column: x => x.VERS_CODIGO,
                        principalTable: "PROPUESTA",
                        principalColumn: "PROP_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VERSION_USUARIO_PERS_CODIGO",
                        column: x => x.PERS_CODIGO,
                        principalTable: "USUARIO",
                        principalColumn: "USUA_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BANCOFORMULARIO",
                columns: table => new
                {
                    BANF_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BANF_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BANF_DESCRIPCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BANF_FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BANF_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TIPF_CODIGO = table.Column<int>(type: "int", nullable: false),
                    ESTF_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANCOFORMULARIO", x => x.BANF_CODIGO);
                    table.ForeignKey(
                        name: "FK_BANCOFORMULARIO_ESTADOFORMULARIO_ESTF_CODIGO",
                        column: x => x.ESTF_CODIGO,
                        principalTable: "ESTADOFORMULARIO",
                        principalColumn: "ESTF_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BANCOFORMULARIO_TIPOFORMULARIO_TIPF_CODIGO",
                        column: x => x.TIPF_CODIGO,
                        principalTable: "TIPOFORMULARIO",
                        principalColumn: "TIPF_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FORMULARIOBORRADOR",
                columns: table => new
                {
                    FORB_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FORB_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FORB_DESCRIPCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FORB_FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FORB_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TIPF_CODIGO = table.Column<int>(type: "int", nullable: false),
                    ESTF_CODIGO = table.Column<int>(type: "int", nullable: false),
                    CONB_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMULARIOBORRADOR", x => x.FORB_CODIGO);
                    table.ForeignKey(
                        name: "FK_FORMULARIOBORRADOR_CONVOCATORIABORRADOR_CONB_CODIGO",
                        column: x => x.CONB_CODIGO,
                        principalTable: "CONVOCATORIABORRADOR",
                        principalColumn: "CONB_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FORMULARIOBORRADOR_ESTADOFORMULARIO_ESTF_CODIGO",
                        column: x => x.ESTF_CODIGO,
                        principalTable: "ESTADOFORMULARIO",
                        principalColumn: "ESTF_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FORMULARIOBORRADOR_TIPOFORMULARIO_TIPF_CODIGO",
                        column: x => x.TIPF_CODIGO,
                        principalTable: "TIPOFORMULARIO",
                        principalColumn: "TIPF_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FORMULARIOPUBLICADO",
                columns: table => new
                {
                    FORP_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FORP_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FORP_DESCRIPCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FORP_FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FORP_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TIPF_CODIGO = table.Column<int>(type: "int", nullable: false),
                    CONP_CODIGO = table.Column<int>(type: "int", nullable: false),
                    ESTF_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMULARIOPUBLICADO", x => x.FORP_CODIGO);
                    table.ForeignKey(
                        name: "FK_FORMULARIOPUBLICADO_CONVOCATORIAPUBLICADA_CONP_CODIGO",
                        column: x => x.CONP_CODIGO,
                        principalTable: "CONVOCATORIAPUBLICADA",
                        principalColumn: "CONP_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FORMULARIOPUBLICADO_ESTADOFORMULARIO_ESTF_CODIGO",
                        column: x => x.ESTF_CODIGO,
                        principalTable: "ESTADOFORMULARIO",
                        principalColumn: "ESTF_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FORMULARIOPUBLICADO_TIPOFORMULARIO_TIPF_CODIGO",
                        column: x => x.TIPF_CODIGO,
                        principalTable: "TIPOFORMULARIO",
                        principalColumn: "TIPF_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BANCOELEMENTOFORMULARIO",
                columns: table => new
                {
                    BEFO_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BEFO_ENUNCIADO = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BEFO_ORDEN = table.Column<int>(type: "int", nullable: false),
                    BEFO_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TEFO_CODIGO = table.Column<int>(type: "int", nullable: false),
                    BEFO_DATOSJSON = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANCOELEMENTOFORMULARIO", x => x.BEFO_CODIGO);
                    table.ForeignKey(
                        name: "FK_BANCOELEMENTOFORMULARIO_TIPOELEMENTOFORMULARIO_TEFO_CODIGO",
                        column: x => x.TEFO_CODIGO,
                        principalTable: "TIPOELEMENTOFORMULARIO",
                        principalColumn: "TPEF_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ELEMENTOFORMULARIOBORRADOR",
                columns: table => new
                {
                    EFOB_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EFOB_ENUNCIADO = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EFOB_ORDEN = table.Column<int>(type: "int", nullable: true),
                    EFOB_ESTADO = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    TEFO_CODIGO = table.Column<int>(type: "int", nullable: false),
                    EFOB_DATOSJSON = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ELEMENTOFORMULARIOBORRADOR", x => x.EFOB_CODIGO);
                    table.ForeignKey(
                        name: "FK_ELEMENTOFORMULARIOBORRADOR_TIPOELEMENTOFORMULARIO_TEFO_CODIGO",
                        column: x => x.TEFO_CODIGO,
                        principalTable: "TIPOELEMENTOFORMULARIO",
                        principalColumn: "TPEF_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ELEMENTOFORMULARIOPUBLICADO",
                columns: table => new
                {
                    EFOP_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EFOP_ENUNCIADO = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EFOP_ORDEN = table.Column<int>(type: "int", nullable: true),
                    EFOP_ESTADO = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    TEFO_CODIGO = table.Column<int>(type: "int", nullable: false),
                    EFOP_DATOSJSON = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ELEMENTOFORMULARIOPUBLICADO", x => x.EFOP_CODIGO);
                    table.ForeignKey(
                        name: "FK_ELEMENTOFORMULARIOPUBLICADO_TIPOELEMENTOFORMULARIO_TEFO_CODIGO",
                        column: x => x.TEFO_CODIGO,
                        principalTable: "TIPOELEMENTOFORMULARIO",
                        principalColumn: "TPEF_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VERSIONFORMULARIOPUBLICADO",
                columns: table => new
                {
                    VFOP_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VFOP_FECHA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VFOP_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FORP_CODIGO = table.Column<int>(type: "int", nullable: false),
                    VERS_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VERSIONFORMULARIOPUBLICADO", x => x.VFOP_CODIGO);
                    table.ForeignKey(
                        name: "FK_VERSIONFORMULARIOPUBLICADO_FORMULARIOPUBLICADO_FORP_CODIGO",
                        column: x => x.FORP_CODIGO,
                        principalTable: "FORMULARIOPUBLICADO",
                        principalColumn: "FORP_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VERSIONFORMULARIOPUBLICADO_VERSION_VERS_CODIGO",
                        column: x => x.VERS_CODIGO,
                        principalTable: "VERSION",
                        principalColumn: "VERS_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BANCOFORMULARIOELEMENTO",
                columns: table => new
                {
                    BFOE_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BFOE_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    BEFO_CODIGO = table.Column<int>(type: "int", nullable: false),
                    BANF_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANCOFORMULARIOELEMENTO", x => x.BFOE_CODIGO);
                    table.ForeignKey(
                        name: "FK_BANCOFORMULARIOELEMENTO_BANCOELEMENTOFORMULARIO_BEFO_CODIGO",
                        column: x => x.BEFO_CODIGO,
                        principalTable: "BANCOELEMENTOFORMULARIO",
                        principalColumn: "BEFO_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BANCOFORMULARIOELEMENTO_BANCOFORMULARIO_BANF_CODIGO",
                        column: x => x.BANF_CODIGO,
                        principalTable: "BANCOFORMULARIO",
                        principalColumn: "BANF_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BANCOOPCRESELEMENTO",
                columns: table => new
                {
                    BORE_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BORE_VALOR = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BORE_FECHARESPUESTA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BORE_ESTADO = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    BORE_ORDEN = table.Column<int>(type: "int", nullable: true),
                    BEFO_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANCOOPCRESELEMENTO", x => x.BORE_CODIGO);
                    table.ForeignKey(
                        name: "FK_BANCOOPCRESELEMENTO_BANCOELEMENTOFORMULARIO_BEFO_CODIGO",
                        column: x => x.BEFO_CODIGO,
                        principalTable: "BANCOELEMENTOFORMULARIO",
                        principalColumn: "BEFO_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FORMULARIOELEMENTOBORRADOR",
                columns: table => new
                {
                    FOEB_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EFOB_CODIGO = table.Column<int>(type: "int", nullable: false),
                    FOEB_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FORB_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMULARIOELEMENTOBORRADOR", x => x.FOEB_CODIGO);
                    table.ForeignKey(
                        name: "FK_FORMULARIOELEMENTOBORRADOR_ELEMENTOFORMULARIOBORRADOR_EFOB_CODIGO",
                        column: x => x.EFOB_CODIGO,
                        principalTable: "ELEMENTOFORMULARIOBORRADOR",
                        principalColumn: "EFOB_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FORMULARIOELEMENTOBORRADOR_FORMULARIOBORRADOR_EFOB_CODIGO",
                        column: x => x.EFOB_CODIGO,
                        principalTable: "FORMULARIOBORRADOR",
                        principalColumn: "FORB_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPCIONRESPUESTABOIRRADOR",
                columns: table => new
                {
                    OPRB_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OPRB_VALOR = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OPRB_FECHARESPUESTA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OPRB_ESTADO = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    OPRB_ORDEN = table.Column<int>(type: "int", nullable: false),
                    EFOB_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPCIONRESPUESTABOIRRADOR", x => x.OPRB_CODIGO);
                    table.ForeignKey(
                        name: "FK_OPCIONRESPUESTABOIRRADOR_ELEMENTOFORMULARIOBORRADOR_EFOB_CODIGO",
                        column: x => x.EFOB_CODIGO,
                        principalTable: "ELEMENTOFORMULARIOBORRADOR",
                        principalColumn: "EFOB_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FORMULARIOELEMENTOPUBLICADO",
                columns: table => new
                {
                    FOEP_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EFOP_CODIGO = table.Column<int>(type: "int", nullable: false),
                    FORP_CODIGO = table.Column<int>(type: "int", nullable: false),
                    FOEP_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMULARIOELEMENTOPUBLICADO", x => x.FOEP_CODIGO);
                    table.ForeignKey(
                        name: "FK_FORMULARIOELEMENTOPUBLICADO_ELEMENTOFORMULARIOPUBLICADO_EFOP_CODIGO",
                        column: x => x.EFOP_CODIGO,
                        principalTable: "ELEMENTOFORMULARIOPUBLICADO",
                        principalColumn: "EFOP_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FORMULARIOELEMENTOPUBLICADO_FORMULARIOPUBLICADO_FORP_CODIGO",
                        column: x => x.FORP_CODIGO,
                        principalTable: "FORMULARIOPUBLICADO",
                        principalColumn: "FORP_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPCIONRESPUESTAPUBLICADO",
                columns: table => new
                {
                    OPRP_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OPRP_VALOR = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OPRP_FECHARESPUESTA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OPRP_ORDEN = table.Column<int>(type: "int", nullable: false),
                    OPRP_ESTADO = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    EFOP_CODIGO = table.Column<int>(type: "int", nullable: false),
                    PROP_CODIGO = table.Column<int>(type: "int", nullable: false),
                    PROPUESTAPROP_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPCIONRESPUESTAPUBLICADO", x => x.OPRP_CODIGO);
                    table.ForeignKey(
                        name: "FK_OPCIONRESPUESTAPUBLICADO_ELEMENTOFORMULARIOPUBLICADO_EFOP_CODIGO",
                        column: x => x.EFOP_CODIGO,
                        principalTable: "ELEMENTOFORMULARIOPUBLICADO",
                        principalColumn: "EFOP_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OPCIONRESPUESTAPUBLICADO_PROPUESTA_PROPUESTAPROP_CODIGO",
                        column: x => x.PROPUESTAPROP_CODIGO,
                        principalTable: "PROPUESTA",
                        principalColumn: "PROP_CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PROPUESTA_COMENTARIO",
                columns: table => new
                {
                    PROC_CODIGO = table.Column<int>(type: "int", nullable: false),
                    PROC_FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROC_COMENTARIO = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    VFOP_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROPUESTA_COMENTARIO", x => x.PROC_CODIGO);
                    table.ForeignKey(
                        name: "FK_PROPUESTA_COMENTARIO_VERSIONFORMULARIOPUBLICADO_PROC_CODIGO",
                        column: x => x.PROC_CODIGO,
                        principalTable: "VERSIONFORMULARIOPUBLICADO",
                        principalColumn: "VFOP_CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BANCOELEMENTOFORMULARIO_TEFO_CODIGO",
                table: "BANCOELEMENTOFORMULARIO",
                column: "TEFO_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_BANCOFORMULARIO_ESTF_CODIGO",
                table: "BANCOFORMULARIO",
                column: "ESTF_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_BANCOFORMULARIO_TIPF_CODIGO",
                table: "BANCOFORMULARIO",
                column: "TIPF_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_BANCOFORMULARIOELEMENTO_BANF_CODIGO",
                table: "BANCOFORMULARIOELEMENTO",
                column: "BANF_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_BANCOFORMULARIOELEMENTO_BEFO_CODIGO",
                table: "BANCOFORMULARIOELEMENTO",
                column: "BEFO_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_BANCOOPCRESELEMENTO_BEFO_CODIGO",
                table: "BANCOOPCRESELEMENTO",
                column: "BEFO_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_CONVOCATORIABORRADOR_PERS_CODIGO",
                table: "CONVOCATORIABORRADOR",
                column: "PERS_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_CONVOCATORIAPUBLICADA_PERS_CODIGO",
                table: "CONVOCATORIAPUBLICADA",
                column: "PERS_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_ELEMENTOFORMULARIOBORRADOR_TEFO_CODIGO",
                table: "ELEMENTOFORMULARIOBORRADOR",
                column: "TEFO_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_ELEMENTOFORMULARIOPUBLICADO_TEFO_CODIGO",
                table: "ELEMENTOFORMULARIOPUBLICADO",
                column: "TEFO_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIOBORRADOR_CONB_CODIGO",
                table: "FORMULARIOBORRADOR",
                column: "CONB_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIOBORRADOR_ESTF_CODIGO",
                table: "FORMULARIOBORRADOR",
                column: "ESTF_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIOBORRADOR_TIPF_CODIGO",
                table: "FORMULARIOBORRADOR",
                column: "TIPF_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIOELEMENTOBORRADOR_EFOB_CODIGO",
                table: "FORMULARIOELEMENTOBORRADOR",
                column: "EFOB_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIOELEMENTOPUBLICADO_EFOP_CODIGO",
                table: "FORMULARIOELEMENTOPUBLICADO",
                column: "EFOP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIOELEMENTOPUBLICADO_FORP_CODIGO",
                table: "FORMULARIOELEMENTOPUBLICADO",
                column: "FORP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIOPUBLICADO_CONP_CODIGO",
                table: "FORMULARIOPUBLICADO",
                column: "CONP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIOPUBLICADO_ESTF_CODIGO",
                table: "FORMULARIOPUBLICADO",
                column: "ESTF_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIOPUBLICADO_TIPF_CODIGO",
                table: "FORMULARIOPUBLICADO",
                column: "TIPF_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_OPCIONRESPUESTABOIRRADOR_EFOB_CODIGO",
                table: "OPCIONRESPUESTABOIRRADOR",
                column: "EFOB_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_OPCIONRESPUESTAPUBLICADO_EFOP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO",
                column: "EFOP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_OPCIONRESPUESTAPUBLICADO_PROPUESTAPROP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO",
                column: "PROPUESTAPROP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIOPROPUESTA_PERS_CODIGO",
                table: "USUARIOPROPUESTA",
                column: "PERS_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_VERSION_PERS_CODIGO",
                table: "VERSION",
                column: "PERS_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_VERSIONFORMULARIOPUBLICADO_FORP_CODIGO",
                table: "VERSIONFORMULARIOPUBLICADO",
                column: "FORP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_VERSIONFORMULARIOPUBLICADO_VERS_CODIGO",
                table: "VERSIONFORMULARIOPUBLICADO",
                column: "VERS_CODIGO");

            migrationBuilder.AddForeignKey(
                name: "FK_EVALUACIONDETALLE_EVALUACION_EVAL_CODIGO",
                table: "EVALUACIONDETALLE",
                column: "EVAL_CODIGO",
                principalTable: "EVALUACION",
                principalColumn: "EVAL_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EVALUACIONDETALLE_JURADO_JURA_CODIGO",
                table: "EVALUACIONDETALLE",
                column: "JURA_CODIGO",
                principalTable: "JURADO",
                principalColumn: "JURA_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EVALUACIONDETALLE_PROPUESTA_PROP_CODIGO",
                table: "EVALUACIONDETALLE",
                column: "PROP_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ITEM_EVALUACION_EVAL_CODIGO",
                table: "ITEM",
                column: "EVAL_CODIGO",
                principalTable: "EVALUACION",
                principalColumn: "EVAL_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PROPUESTA_CONVOCATORIAPUBLICADA_CONP_CODIGO",
                table: "PROPUESTA",
                column: "CONP_CODIGO",
                principalTable: "CONVOCATORIAPUBLICADA",
                principalColumn: "CONP_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PROPUESTA_ESTADOPROPUESTA_ESTP_CODIGO",
                table: "PROPUESTA",
                column: "ESTP_CODIGO",
                principalTable: "ESTADOPROPUESTA",
                principalColumn: "ESTP_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PROPUESTAJURADO_JURADO_JURA_CODIGO",
                table: "PROPUESTAJURADO",
                column: "JURA_CODIGO",
                principalTable: "JURADO",
                principalColumn: "JURA_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PROPUESTAJURADO_PROPUESTA_PROP_CODIGO",
                table: "PROPUESTAJURADO",
                column: "PROP_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RESPUESTA_ELEMENTOFORMULARIOPUBLICADO_EFOP_CODIGO",
                table: "RESPUESTA",
                column: "EFOP_CODIGO",
                principalTable: "ELEMENTOFORMULARIOPUBLICADO",
                principalColumn: "EFOP_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RESPUESTA_PROPUESTA_PROP_CODIGO",
                table: "RESPUESTA",
                column: "PROP_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EVALUACIONDETALLE_EVALUACION_EVAL_CODIGO",
                table: "EVALUACIONDETALLE");

            migrationBuilder.DropForeignKey(
                name: "FK_EVALUACIONDETALLE_JURADO_JURA_CODIGO",
                table: "EVALUACIONDETALLE");

            migrationBuilder.DropForeignKey(
                name: "FK_EVALUACIONDETALLE_PROPUESTA_PROP_CODIGO",
                table: "EVALUACIONDETALLE");

            migrationBuilder.DropForeignKey(
                name: "FK_ITEM_EVALUACION_EVAL_CODIGO",
                table: "ITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_PROPUESTA_CONVOCATORIAPUBLICADA_CONP_CODIGO",
                table: "PROPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_PROPUESTA_ESTADOPROPUESTA_ESTP_CODIGO",
                table: "PROPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_PROPUESTAJURADO_JURADO_JURA_CODIGO",
                table: "PROPUESTAJURADO");

            migrationBuilder.DropForeignKey(
                name: "FK_PROPUESTAJURADO_PROPUESTA_PROP_CODIGO",
                table: "PROPUESTAJURADO");

            migrationBuilder.DropForeignKey(
                name: "FK_RESPUESTA_ELEMENTOFORMULARIOPUBLICADO_EFOP_CODIGO",
                table: "RESPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_RESPUESTA_PROPUESTA_PROP_CODIGO",
                table: "RESPUESTA");

            migrationBuilder.DropTable(
                name: "BANCOFORMULARIOELEMENTO");

            migrationBuilder.DropTable(
                name: "BANCOOPCRESELEMENTO");

            migrationBuilder.DropTable(
                name: "FORMULARIOELEMENTOBORRADOR");

            migrationBuilder.DropTable(
                name: "FORMULARIOELEMENTOPUBLICADO");

            migrationBuilder.DropTable(
                name: "OPCIONRESPUESTABOIRRADOR");

            migrationBuilder.DropTable(
                name: "OPCIONRESPUESTAPUBLICADO");

            migrationBuilder.DropTable(
                name: "PROPUESTA_COMENTARIO");

            migrationBuilder.DropTable(
                name: "USUARIOPROPUESTA");

            migrationBuilder.DropTable(
                name: "BANCOFORMULARIO");

            migrationBuilder.DropTable(
                name: "BANCOELEMENTOFORMULARIO");

            migrationBuilder.DropTable(
                name: "FORMULARIOBORRADOR");

            migrationBuilder.DropTable(
                name: "ELEMENTOFORMULARIOBORRADOR");

            migrationBuilder.DropTable(
                name: "ELEMENTOFORMULARIOPUBLICADO");

            migrationBuilder.DropTable(
                name: "VERSIONFORMULARIOPUBLICADO");

            migrationBuilder.DropTable(
                name: "CONVOCATORIABORRADOR");

            migrationBuilder.DropTable(
                name: "TIPOELEMENTOFORMULARIO");

            migrationBuilder.DropTable(
                name: "FORMULARIOPUBLICADO");

            migrationBuilder.DropTable(
                name: "VERSION");

            migrationBuilder.DropTable(
                name: "CONVOCATORIAPUBLICADA");

            migrationBuilder.DropTable(
                name: "ESTADOFORMULARIO");

            migrationBuilder.RenameColumn(
                name: "PERS_CODIGO",
                table: "USUARIO",
                newName: "PERS_PEGEID");

            migrationBuilder.RenameColumn(
                name: "EFOP_CODIGO",
                table: "RESPUESTA",
                newName: "PREG_CODIGO");

            migrationBuilder.RenameIndex(
                name: "IX_RESPUESTA_EFOP_CODIGO",
                table: "RESPUESTA",
                newName: "IX_RESPUESTA_PREG_CODIGO");

            migrationBuilder.RenameColumn(
                name: "CONP_CODIGO",
                table: "PROPUESTA",
                newName: "CONV_CODIGO");

            migrationBuilder.RenameIndex(
                name: "IX_PROPUESTA_CONP_CODIGO",
                table: "PROPUESTA",
                newName: "IX_PROPUESTA_CONV_CODIGO");

            migrationBuilder.AddColumn<string>(
                name: "PROP_DESCRIPCION",
                table: "PROPUESTA",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PROP_PRESENTACION",
                table: "PROPUESTA",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PROP_TITULO",
                table: "PROPUESTA",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CONVOCATORIA",
                columns: table => new
                {
                    CONV_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONV_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CONV_FECHAFIN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CONV_FECHAINICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PERS_CODIGO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONVOCATORIA", x => x.CONV_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "FORMULARIO",
                columns: table => new
                {
                    FORM_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPF_CODIGO = table.Column<int>(type: "int", nullable: false),
                    FORM_DESCRIPCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FORM_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FORM_FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FORM_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                name: "TIPOPREGUNTA",
                columns: table => new
                {
                    TIPR_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPR_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TIPR_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOPREGUNTA", x => x.TIPR_CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "CONVOCATORIAFORMULARIO",
                columns: table => new
                {
                    COFO_CODIGO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONV_CODIGO = table.Column<int>(type: "int", nullable: false),
                    FORM_CODIGO = table.Column<int>(type: "int", nullable: false),
                    COFO_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
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
                    FORM_CODIGO = table.Column<int>(type: "int", nullable: false),
                    SECC_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SECC_NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SECC_ORDEN = table.Column<int>(type: "int", nullable: false)
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
                    SECC_CODIGO = table.Column<int>(type: "int", nullable: false),
                    TIPR_CODIGO = table.Column<int>(type: "int", nullable: false),
                    PREG_ENUNCIADO = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PREG_ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PREG_ORDEN = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_CONVOCATORIAFORMULARIO_CONV_CODIGO",
                table: "CONVOCATORIAFORMULARIO",
                column: "CONV_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_CONVOCATORIAFORMULARIO_FORM_CODIGO",
                table: "CONVOCATORIAFORMULARIO",
                column: "FORM_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FORMULARIO_TIPF_CODIGO",
                table: "FORMULARIO",
                column: "TIPF_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_PREGUNTA_SECC_CODIGO",
                table: "PREGUNTA",
                column: "SECC_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_PREGUNTA_TIPR_CODIGO",
                table: "PREGUNTA",
                column: "TIPR_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_SECCION_FORM_CODIGO",
                table: "SECCION",
                column: "FORM_CODIGO");

            migrationBuilder.AddForeignKey(
                name: "FK_EVALUACIONDETALLE_EVALUACION_EVAL_CODIGO",
                table: "EVALUACIONDETALLE",
                column: "EVAL_CODIGO",
                principalTable: "EVALUACION",
                principalColumn: "EVAL_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EVALUACIONDETALLE_JURADO_JURA_CODIGO",
                table: "EVALUACIONDETALLE",
                column: "JURA_CODIGO",
                principalTable: "JURADO",
                principalColumn: "JURA_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EVALUACIONDETALLE_PROPUESTA_PROP_CODIGO",
                table: "EVALUACIONDETALLE",
                column: "PROP_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ITEM_EVALUACION_EVAL_CODIGO",
                table: "ITEM",
                column: "EVAL_CODIGO",
                principalTable: "EVALUACION",
                principalColumn: "EVAL_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROPUESTA_CONVOCATORIA_CONV_CODIGO",
                table: "PROPUESTA",
                column: "CONV_CODIGO",
                principalTable: "CONVOCATORIA",
                principalColumn: "CONV_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROPUESTA_ESTADOPROPUESTA_ESTP_CODIGO",
                table: "PROPUESTA",
                column: "ESTP_CODIGO",
                principalTable: "ESTADOPROPUESTA",
                principalColumn: "ESTP_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROPUESTAJURADO_JURADO_JURA_CODIGO",
                table: "PROPUESTAJURADO",
                column: "JURA_CODIGO",
                principalTable: "JURADO",
                principalColumn: "JURA_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROPUESTAJURADO_PROPUESTA_PROP_CODIGO",
                table: "PROPUESTAJURADO",
                column: "PROP_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RESPUESTA_PREGUNTA_PREG_CODIGO",
                table: "RESPUESTA",
                column: "PREG_CODIGO",
                principalTable: "PREGUNTA",
                principalColumn: "PREG_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RESPUESTA_PROPUESTA_PROP_CODIGO",
                table: "RESPUESTA",
                column: "PROP_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

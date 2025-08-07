using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.UnidadEmprendimiento.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixIdentityColumnInVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_VERSIONFORMULARIOPUBLICADO_VERSION_VERS_CODIGO",
                table: "VERSIONFORMULARIOPUBLICADO");

            migrationBuilder.DropForeignKey(
                name: "FK_OPCIONRESPUESTABOIRRADOR_ELEMENTOFORMULARIOBORRADOR_EFOB_CODIGO",
                table: "OPCIONRESPUESTABOIRRADOR");

            migrationBuilder.DropForeignKey(
                name: "FK_OPCIONRESPUESTAPUBLICADO_PROPUESTA_PROPUESTAPROP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOPROPUESTA_PROPUESTA_PERS_CODIGO",
                table: "USUARIOPROPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOPROPUESTA_USUARIO_USUP_CODIGO",
                table: "USUARIOPROPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_VERSION_PROPUESTA_VERS_CODIGO",
                table: "VERSION");

            migrationBuilder.DropIndex(
                name: "IX_OPCIONRESPUESTAPUBLICADO_PROPUESTAPROP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OPCIONRESPUESTABOIRRADOR",
                table: "OPCIONRESPUESTABOIRRADOR");

            migrationBuilder.DropColumn(
                name: "OPRP_FECHARESPUESTA",
                table: "OPCIONRESPUESTAPUBLICADO");

            migrationBuilder.DropColumn(
                name: "PROPUESTAPROP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO");

            migrationBuilder.DropColumn(
                name: "PROP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO");

            migrationBuilder.DropColumn(
                name: "BORE_FECHARESPUESTA",
                table: "BANCOOPCRESELEMENTO");

            migrationBuilder.DropColumn(
                name: "OPRB_FECHARESPUESTA",
                table: "OPCIONRESPUESTABOIRRADOR");

            migrationBuilder.RenameTable(
                name: "OPCIONRESPUESTABOIRRADOR",
                newName: "OPCIONRESPUESTABORRADOR");

            migrationBuilder.RenameColumn(
                name: "PRPJ_FECHAASIGNACION",
                table: "PROPUESTAJURADO",
                newName: "PROJ_FECHAASIGNACION");

            migrationBuilder.RenameColumn(
                name: "PROPJ_CODIGO",
                table: "PROPUESTAJURADO",
                newName: "PROJ_CODIGO");

            migrationBuilder.RenameIndex(
                name: "IX_OPCIONRESPUESTABOIRRADOR_EFOB_CODIGO",
                table: "OPCIONRESPUESTABORRADOR",
                newName: "IX_OPCIONRESPUESTABORRADOR_EFOB_CODIGO");

  // 2️⃣ Eliminar la clave primaria de VERSION
            migrationBuilder.DropPrimaryKey(
                name: "PK_VERSION",
                table: "VERSION");

            migrationBuilder.DropColumn(
                name: "VERS_CODIGO",
                table: "VERSION");

            migrationBuilder.AddColumn<int>(
                name: "VERS_CODIGO",
                table: "VERSION",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"); // Configuración de autoincremento

        //5️⃣ Volver a establecer la clave primaria
            migrationBuilder.AddPrimaryKey(
                name: "PK_VERSION",
                table: "VERSION",
                column: "VERS_CODIGO");

            // 6️⃣ Volver a agregar la clave foránea
            migrationBuilder.AddForeignKey(
                name: "FK_VERSIONFORMULARIOPUBLICADO_VERSION_VERS_CODIGO",
                table: "VERSIONFORMULARIOPUBLICADO",
                column: "VERS_CODIGO",
                principalTable: "VERSION",
                principalColumn: "VERS_CODIGO",
                onDelete:ReferentialAction.Restrict);



            migrationBuilder.AddColumn<int>(
                name: "PROP_CODIGO",
                table: "VERSION",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.DropPrimaryKey(
                name: "PK_USUARIOPROPUESTA",
                table: "USUARIOPROPUESTA");


            migrationBuilder.DropColumn(
                name: "USUP_CODIGO",
                table: "USUARIOPROPUESTA");

           migrationBuilder.AddColumn<int>(
                name: "USUP_CODIGO",
                table: "USUARIOPROPUESTA",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"); // Configuración de autoincremento

            migrationBuilder.AddPrimaryKey(
                name: "PK_OPCIONRESPUESTABORRADOR",
                table: "OPCIONRESPUESTABORRADOR",
                column: "OPRB_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_VERSION_PROP_CODIGO",
                table: "VERSION",
                column: "PROP_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIOPROPUESTA_PROP_CODIGO",
                table: "USUARIOPROPUESTA",
                column: "PROP_CODIGO");

            migrationBuilder.AddForeignKey(
                name: "FK_OPCIONRESPUESTABORRADOR_ELEMENTOFORMULARIOBORRADOR_EFOB_CODIGO",
                table: "OPCIONRESPUESTABORRADOR",
                column: "EFOB_CODIGO",
                principalTable: "ELEMENTOFORMULARIOBORRADOR",
                principalColumn: "EFOB_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOPROPUESTA_PROPUESTA_PROP_CODIGO",
                table: "USUARIOPROPUESTA",
                column: "PROP_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOPROPUESTA_USUARIO_PERS_CODIGO",
                table: "USUARIOPROPUESTA",
                column: "PERS_CODIGO",
                principalTable: "USUARIO",
                principalColumn: "USUA_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VERSION_PROPUESTA_PROP_CODIGO",
                table: "VERSION",
                column: "PROP_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OPCIONRESPUESTABORRADOR_ELEMENTOFORMULARIOBORRADOR_EFOB_CODIGO",
                table: "OPCIONRESPUESTABORRADOR");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOPROPUESTA_PROPUESTA_PROP_CODIGO",
                table: "USUARIOPROPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOPROPUESTA_USUARIO_PERS_CODIGO",
                table: "USUARIOPROPUESTA");

            migrationBuilder.DropForeignKey(
                name: "FK_VERSION_PROPUESTA_PROP_CODIGO",
                table: "VERSION");

            migrationBuilder.DropIndex(
                name: "IX_VERSION_PROP_CODIGO",
                table: "VERSION");

            migrationBuilder.DropIndex(
                name: "IX_USUARIOPROPUESTA_PROP_CODIGO",
                table: "USUARIOPROPUESTA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OPCIONRESPUESTABORRADOR",
                table: "OPCIONRESPUESTABORRADOR");

            migrationBuilder.DropColumn(
                name: "PROP_CODIGO",
                table: "VERSION");

            migrationBuilder.RenameTable(
                name: "OPCIONRESPUESTABORRADOR",
                newName: "OPCIONRESPUESTABOIRRADOR");

            migrationBuilder.RenameColumn(
                name: "PROJ_FECHAASIGNACION",
                table: "PROPUESTAJURADO",
                newName: "PRPJ_FECHAASIGNACION");

            migrationBuilder.RenameColumn(
                name: "PROJ_CODIGO",
                table: "PROPUESTAJURADO",
                newName: "PROPJ_CODIGO");

            migrationBuilder.RenameIndex(
                name: "IX_OPCIONRESPUESTABORRADOR_EFOB_CODIGO",
                table: "OPCIONRESPUESTABOIRRADOR",
                newName: "IX_OPCIONRESPUESTABOIRRADOR_EFOB_CODIGO");

            migrationBuilder.AlterColumn<int>(
                name: "VERS_CODIGO",
                table: "VERSION",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "USUP_CODIGO",
                table: "USUARIOPROPUESTA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "OPRP_FECHARESPUESTA",
                table: "OPCIONRESPUESTAPUBLICADO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PROPUESTAPROP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PROP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "BORE_FECHARESPUESTA",
                table: "BANCOOPCRESELEMENTO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OPRB_FECHARESPUESTA",
                table: "OPCIONRESPUESTABOIRRADOR",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OPCIONRESPUESTABOIRRADOR",
                table: "OPCIONRESPUESTABOIRRADOR",
                column: "OPRB_CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_OPCIONRESPUESTAPUBLICADO_PROPUESTAPROP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO",
                column: "PROPUESTAPROP_CODIGO");

            migrationBuilder.AddForeignKey(
                name: "FK_OPCIONRESPUESTABOIRRADOR_ELEMENTOFORMULARIOBORRADOR_EFOB_CODIGO",
                table: "OPCIONRESPUESTABOIRRADOR",
                column: "EFOB_CODIGO",
                principalTable: "ELEMENTOFORMULARIOBORRADOR",
                principalColumn: "EFOB_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OPCIONRESPUESTAPUBLICADO_PROPUESTA_PROPUESTAPROP_CODIGO",
                table: "OPCIONRESPUESTAPUBLICADO",
                column: "PROPUESTAPROP_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOPROPUESTA_PROPUESTA_PERS_CODIGO",
                table: "USUARIOPROPUESTA",
                column: "PERS_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOPROPUESTA_USUARIO_USUP_CODIGO",
                table: "USUARIOPROPUESTA",
                column: "USUP_CODIGO",
                principalTable: "USUARIO",
                principalColumn: "USUA_CODIGO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VERSION_PROPUESTA_VERS_CODIGO",
                table: "VERSION",
                column: "VERS_CODIGO",
                principalTable: "PROPUESTA",
                principalColumn: "PROP_CODIGO",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

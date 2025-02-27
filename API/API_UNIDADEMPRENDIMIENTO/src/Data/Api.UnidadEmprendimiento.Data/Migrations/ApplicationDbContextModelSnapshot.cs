﻿// <auto-generated />
using System;
using Api.UnidadEmprendimiento.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.UnidadEmprendimiento.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.Evaluacion", b =>
                {
                    b.Property<int>("EVAL_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EVAL_CODIGO"));

                    b.Property<string>("EVAL_COMENTARIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("EVAL_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("EVAL_FECHACALIFICACION")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("EVAL_PROMEDIOCALIFICACION")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EVAL_CODIGO");

                    b.ToTable("EVALUACION", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.EvaluacionDetalle", b =>
                {
                    b.Property<int>("EVDE_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EVDE_CODIGO"));

                    b.Property<int>("EVAL_CODIGO")
                        .HasColumnType("int");

                    b.Property<decimal>("EVDE_CALIFICACION")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EVDE_COMENTARIO")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool?>("EVDE_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("JURA_CODIGO")
                        .HasColumnType("int");

                    b.Property<int>("PROP_CODIGO")
                        .HasColumnType("int");

                    b.HasKey("EVDE_CODIGO");

                    b.HasIndex("EVAL_CODIGO");

                    b.HasIndex("JURA_CODIGO");

                    b.HasIndex("PROP_CODIGO");

                    b.ToTable("EVALUACIONDETALLE", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.Item", b =>
                {
                    b.Property<int>("ITEM_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ITEM_CODIGO"));

                    b.Property<int>("EVAL_CODIGO")
                        .HasColumnType("int");

                    b.Property<string>("ITEM_COMENTARIO")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool?>("ITEM_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ITEM_NOMBRE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ITEM_PUNTAJEMAXIMO")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ITEM_CODIGO");

                    b.HasIndex("EVAL_CODIGO");

                    b.ToTable("ITEM", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.PropuestaJurado", b =>
                {
                    b.Property<int>("PROPJ_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PROPJ_CODIGO"));

                    b.Property<int>("JURA_CODIGO")
                        .HasColumnType("int");

                    b.Property<bool?>("PROPJ_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("PROP_CODIGO")
                        .HasColumnType("int");

                    b.Property<DateTime>("PRPJ_FECHAASIGNACION")
                        .HasColumnType("datetime2");

                    b.HasKey("PROPJ_CODIGO");

                    b.HasIndex("JURA_CODIGO");

                    b.HasIndex("PROP_CODIGO");

                    b.ToTable("PROPUESTAJURADO", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Convocatoria", b =>
                {
                    b.Property<int>("CONV_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CONV_CODIGO"));

                    b.Property<bool?>("CONV_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("CONV_FECHAFIN")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CONV_FECHAINICIO")
                        .HasColumnType("datetime2");

                    b.Property<int>("PERS_CODIGO")
                        .HasColumnType("int");

                    b.HasKey("CONV_CODIGO");

                    b.ToTable("CONVOCATORIA", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.ConvocatoriaFormulario", b =>
                {
                    b.Property<int>("COFO_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("COFO_CODIGO"));

                    b.Property<bool?>("COFO_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("CONV_CODIGO")
                        .HasColumnType("int");

                    b.Property<int>("FORM_CODIGO")
                        .HasColumnType("int");

                    b.HasKey("COFO_CODIGO");

                    b.HasIndex("CONV_CODIGO");

                    b.HasIndex("FORM_CODIGO");

                    b.ToTable("CONVOCATORIAFORMULARIO", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Formulario", b =>
                {
                    b.Property<int>("FORM_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FORM_CODIGO"));

                    b.Property<string>("FORM_DESCRIPCION")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("FORM_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("FORM_FECHACREACION")
                        .HasColumnType("datetime2");

                    b.Property<string>("FORM_NOMBRE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TIPF_CODIGO")
                        .HasColumnType("int");

                    b.HasKey("FORM_CODIGO");

                    b.HasIndex("TIPF_CODIGO");

                    b.ToTable("FORMULARIO", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Pregunta", b =>
                {
                    b.Property<int>("PREG_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PREG_CODIGO"));

                    b.Property<string>("PREG_ENUNCIADO")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool?>("PREG_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("PREG_ORDEN")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("SECC_CODIGO")
                        .HasColumnType("int");

                    b.Property<int>("TIPR_CODIGO")
                        .HasColumnType("int");

                    b.HasKey("PREG_CODIGO");

                    b.HasIndex("SECC_CODIGO");

                    b.HasIndex("TIPR_CODIGO");

                    b.ToTable("PREGUNTA", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Respuesta", b =>
                {
                    b.Property<int>("RESP_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RESP_CODIGO"));

                    b.Property<int>("PREG_CODIGO")
                        .HasColumnType("int");

                    b.Property<int>("PROP_CODIGO")
                        .HasColumnType("int");

                    b.Property<bool?>("RESP_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("RESP_FECHARESPUESTA")
                        .HasColumnType("datetime2");

                    b.Property<string>("RESP_VALOR")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("RESP_CODIGO");

                    b.HasIndex("PREG_CODIGO");

                    b.HasIndex("PROP_CODIGO");

                    b.ToTable("RESPUESTA", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Seccion", b =>
                {
                    b.Property<int>("SECC_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SECC_CODIGO"));

                    b.Property<int>("FORM_CODIGO")
                        .HasColumnType("int");

                    b.Property<bool?>("SECC_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("SECC_NOMBRE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SECC_ORDEN")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("SECC_CODIGO");

                    b.HasIndex("FORM_CODIGO");

                    b.ToTable("SECCION", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.TipoFormulario", b =>
                {
                    b.Property<int>("TIPF_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TIPF_CODIGO"));

                    b.Property<bool?>("TIPF_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("TIPF_NOMBRE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TIPF_CODIGO");

                    b.ToTable("TIPOFORMULARIO", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.TipoPregunta", b =>
                {
                    b.Property<int>("TIPR_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TIPR_CODIGO"));

                    b.Property<bool?>("TIPR_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("TIPR_NOMBRE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TIPR_CODIGO");

                    b.ToTable("TIPOPREGUNTA", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA.EstadoPropuesta", b =>
                {
                    b.Property<int>("ESTP_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ESTP_CODIGO"));

                    b.Property<bool?>("ESTP_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ESTP_NOMBRE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ESTP_CODIGO");

                    b.ToTable("ESTADOPROPUESTA", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA.Propuesta", b =>
                {
                    b.Property<int>("PROP_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PROP_CODIGO"));

                    b.Property<int>("CONV_CODIGO")
                        .HasColumnType("int");

                    b.Property<int>("ESTP_CODIGO")
                        .HasColumnType("int");

                    b.Property<decimal>("PROP_CALIFICACION")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PROP_DESCRIPCION")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool?>("PROP_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("PROP_PRESENTACION")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PROP_TITULO")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SALA_CODIGO")
                        .HasColumnType("int");

                    b.HasKey("PROP_CODIGO");

                    b.HasIndex("CONV_CODIGO");

                    b.HasIndex("ESTP_CODIGO");

                    b.ToTable("PROPUESTA", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO.Jurado", b =>
                {
                    b.Property<int>("JURA_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JURA_CODIGO"));

                    b.Property<string>("JURA_CORREO")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("JURA_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("JURA_PAPELLIDO")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JURA_PNOMBRE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JURA_SAPELLIDO")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JURA_SNOMBRE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JURA_TELEFONO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JURA_CODIGO");

                    b.ToTable("JURADO", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO.Usuario", b =>
                {
                    b.Property<int>("USUA_CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("USUA_CODIGO"));

                    b.Property<int>("PERS_PEGEID")
                        .HasColumnType("int");

                    b.Property<string>("USUA_CONTRASENIA")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("USUA_ESTADO")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("USUA_NOMBREUSUARIO")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("USUA_PAPELLIDO")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("USUA_PNOMBRE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("USUA_SAPELLIDO")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("USUA_SNOMBRE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("USUA_CODIGO");

                    b.ToTable("USUARIO", (string)null);
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.EvaluacionDetalle", b =>
                {
                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.Evaluacion", "EVALUACION")
                        .WithMany("EVALUACIONDETALLES")
                        .HasForeignKey("EVAL_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO.Jurado", "JURADO")
                        .WithMany("EVALUACIONDETALLES")
                        .HasForeignKey("JURA_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA.Propuesta", "PROPUESTA")
                        .WithMany("EVALUACIONDETALLES")
                        .HasForeignKey("PROP_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EVALUACION");

                    b.Navigation("JURADO");

                    b.Navigation("PROPUESTA");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.Item", b =>
                {
                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.Evaluacion", "EVALUACION")
                        .WithMany("ITEMS")
                        .HasForeignKey("EVAL_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EVALUACION");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.PropuestaJurado", b =>
                {
                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO.Jurado", "JURADO")
                        .WithMany("PROPUESTASJURADOS")
                        .HasForeignKey("JURA_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA.Propuesta", "PROPUESTA")
                        .WithMany("PROPUESTASJURADOS")
                        .HasForeignKey("PROP_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JURADO");

                    b.Navigation("PROPUESTA");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.ConvocatoriaFormulario", b =>
                {
                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Convocatoria", "CONVOCATORIA")
                        .WithMany("CONVOCATORIASFORMULARIOS")
                        .HasForeignKey("CONV_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Formulario", "FORMULARIO")
                        .WithMany("CONVOCATORIASFORMULARIOS")
                        .HasForeignKey("FORM_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CONVOCATORIA");

                    b.Navigation("FORMULARIO");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Formulario", b =>
                {
                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.TipoFormulario", "TIPOFORMULARIO")
                        .WithMany("FORMULARIOS")
                        .HasForeignKey("TIPF_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TIPOFORMULARIO");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Pregunta", b =>
                {
                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Seccion", "SECCION")
                        .WithMany("PREGUNTAS")
                        .HasForeignKey("SECC_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.TipoPregunta", "TIPOPREGUNTA")
                        .WithMany("PREGUNTAS")
                        .HasForeignKey("TIPR_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SECCION");

                    b.Navigation("TIPOPREGUNTA");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Respuesta", b =>
                {
                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Pregunta", "PREGUNTA")
                        .WithMany("RESPUESTAS")
                        .HasForeignKey("PREG_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA.Propuesta", "PROPUESTA")
                        .WithMany("RESPUESTAS")
                        .HasForeignKey("PROP_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PREGUNTA");

                    b.Navigation("PROPUESTA");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Seccion", b =>
                {
                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Formulario", "FORMULARIO")
                        .WithMany("SECCIONES")
                        .HasForeignKey("FORM_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FORMULARIO");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA.Propuesta", b =>
                {
                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Convocatoria", "CONVOCATORIA")
                        .WithMany("PROPUESTAS")
                        .HasForeignKey("CONV_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA.EstadoPropuesta", "ESTADOPROPUESTA")
                        .WithMany("PROPUESTAS")
                        .HasForeignKey("ESTP_CODIGO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CONVOCATORIA");

                    b.Navigation("ESTADOPROPUESTA");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION.Evaluacion", b =>
                {
                    b.Navigation("EVALUACIONDETALLES");

                    b.Navigation("ITEMS");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Convocatoria", b =>
                {
                    b.Navigation("CONVOCATORIASFORMULARIOS");

                    b.Navigation("PROPUESTAS");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Formulario", b =>
                {
                    b.Navigation("CONVOCATORIASFORMULARIOS");

                    b.Navigation("SECCIONES");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Pregunta", b =>
                {
                    b.Navigation("RESPUESTAS");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.Seccion", b =>
                {
                    b.Navigation("PREGUNTAS");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.TipoFormulario", b =>
                {
                    b.Navigation("FORMULARIOS");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.TipoPregunta", b =>
                {
                    b.Navigation("PREGUNTAS");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA.EstadoPropuesta", b =>
                {
                    b.Navigation("PROPUESTAS");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA.Propuesta", b =>
                {
                    b.Navigation("EVALUACIONDETALLES");

                    b.Navigation("PROPUESTASJURADOS");

                    b.Navigation("RESPUESTAS");
                });

            modelBuilder.Entity("Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO.Jurado", b =>
                {
                    b.Navigation("EVALUACIONDETALLES");

                    b.Navigation("PROPUESTASJURADOS");
                });
#pragma warning restore 612, 618
        }
    }
}

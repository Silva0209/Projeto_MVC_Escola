using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_MVC_Escola.web.Migrations
{
    public partial class BD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome_curso = table.Column<string>(maxLength: 30, nullable: false),
                    carga_horaria_curso = table.Column<int>(nullable: false),
                    data_inicio = table.Column<DateTime>(nullable: false),
                    data_fim = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    genero = table.Column<string>(nullable: true),
                    cc = table.Column<string>(maxLength: 8, nullable: false),
                    nif = table.Column<string>(maxLength: 9, nullable: false),
                    contacto = table.Column<string>(maxLength: 9, nullable: false),
                    morada = table.Column<string>(maxLength: 100, nullable: false),
                    localidade = table.Column<string>(maxLength: 100, nullable: false),
                    cp_1 = table.Column<string>(maxLength: 4, nullable: false),
                    cp_2 = table.Column<string>(maxLength: 3, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome_turma = table.Column<string>(maxLength: 10, nullable: false),
                    id_curso = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turmas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome_disciplina = table.Column<string>(maxLength: 30, nullable: false),
                    area_formação = table.Column<string>(maxLength: 30, nullable: false),
                    carga_horaria_discplina = table.Column<DateTime>(nullable: false),
                    creditos_discplina = table.Column<int>(maxLength: 8, nullable: false),
                    id_curso = table.Column<int>(nullable: false),
                    id_professor = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    genero = table.Column<string>(nullable: true),
                    cc = table.Column<string>(maxLength: 8, nullable: false),
                    nif = table.Column<string>(maxLength: 9, nullable: false),
                    contacto = table.Column<string>(maxLength: 9, nullable: false),
                    morada = table.Column<string>(maxLength: 100, nullable: false),
                    localidade = table.Column<string>(maxLength: 100, nullable: false),
                    cp_1 = table.Column<string>(maxLength: 4, nullable: false),
                    cp_2 = table.Column<string>(maxLength: 3, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    TurmaId = table.Column<int>(nullable: true),
                    id_turma = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Turmas_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_aluno = table.Column<int>(nullable: false),
                    id_disciplina = table.Column<int>(nullable: false),
                    nota_final = table.Column<decimal>(nullable: false),
                    aprovado = table.Column<string>(nullable: true),
                    AlunoId = table.Column<int>(nullable: true),
                    DisciplinaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TurmaId",
                table: "Alunos",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_AlunoId",
                table: "Notas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_DisciplinaId",
                table: "Notas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_CursoId",
                table: "Turmas",
                column: "CursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}

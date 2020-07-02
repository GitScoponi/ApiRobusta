using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiRobusta.Infra.Migrations
{
    public partial class AjusteCampanhaEnvio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campanha_Usuario_UsuarioId",
                table: "Campanha");

            migrationBuilder.DropForeignKey(
                name: "FK_Contato_Usuario_UsuarioId",
                table: "Contato");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Campanha_CampanhaId",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Contato_ContatoId",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Grupo_GrupoId",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_Usuario_UsuarioId",
                table: "Grupo");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Grupo",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Grupo_UsuarioId",
                table: "Grupo",
                newName: "IX_Grupo_IdUsuario");

            migrationBuilder.RenameColumn(
                name: "GrupoId",
                table: "Envio",
                newName: "IdGrupo");

            migrationBuilder.RenameColumn(
                name: "ContatoId",
                table: "Envio",
                newName: "IdContato");

            migrationBuilder.RenameColumn(
                name: "CampanhaId",
                table: "Envio",
                newName: "IdCampanha");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_GrupoId",
                table: "Envio",
                newName: "IX_Envio_IdGrupo");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_ContatoId",
                table: "Envio",
                newName: "IX_Envio_IdContato");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_CampanhaId",
                table: "Envio",
                newName: "IX_Envio_IdCampanha");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Contato",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Contato_UsuarioId",
                table: "Contato",
                newName: "IX_Contato_IdUsuario");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Campanha",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Campanha_UsuarioId",
                table: "Campanha",
                newName: "IX_Campanha_IdUsuario");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Grupo",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contato",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Contato",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Campanha",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Campanha_Usuario_IdUsuario",
                table: "Campanha",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contato_Usuario_IdUsuario",
                table: "Contato",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Campanha_IdCampanha",
                table: "Envio",
                column: "IdCampanha",
                principalTable: "Campanha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Contato_IdContato",
                table: "Envio",
                column: "IdContato",
                principalTable: "Contato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Grupo_IdGrupo",
                table: "Envio",
                column: "IdGrupo",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_Usuario_IdUsuario",
                table: "Grupo",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campanha_Usuario_IdUsuario",
                table: "Campanha");

            migrationBuilder.DropForeignKey(
                name: "FK_Contato_Usuario_IdUsuario",
                table: "Contato");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Campanha_IdCampanha",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Contato_IdContato",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Grupo_IdGrupo",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupo_Usuario_IdUsuario",
                table: "Grupo");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Grupo",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Grupo_IdUsuario",
                table: "Grupo",
                newName: "IX_Grupo_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdGrupo",
                table: "Envio",
                newName: "GrupoId");

            migrationBuilder.RenameColumn(
                name: "IdContato",
                table: "Envio",
                newName: "ContatoId");

            migrationBuilder.RenameColumn(
                name: "IdCampanha",
                table: "Envio",
                newName: "CampanhaId");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_IdGrupo",
                table: "Envio",
                newName: "IX_Envio_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_IdContato",
                table: "Envio",
                newName: "IX_Envio_ContatoId");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_IdCampanha",
                table: "Envio",
                newName: "IX_Envio_CampanhaId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Contato",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Contato_IdUsuario",
                table: "Contato",
                newName: "IX_Contato_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Campanha",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Campanha_IdUsuario",
                table: "Campanha",
                newName: "IX_Campanha_UsuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Grupo",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contato",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Contato",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Campanha",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AddForeignKey(
                name: "FK_Campanha_Usuario_UsuarioId",
                table: "Campanha",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contato_Usuario_UsuarioId",
                table: "Contato",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Campanha_CampanhaId",
                table: "Envio",
                column: "CampanhaId",
                principalTable: "Campanha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Contato_ContatoId",
                table: "Envio",
                column: "ContatoId",
                principalTable: "Contato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Grupo_GrupoId",
                table: "Envio",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupo_Usuario_UsuarioId",
                table: "Grupo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

namespace SenacGames.Application.DTOs
{
// DTO usado para listar(repare que não enviamos a senha para a tela!)
public class UsuarioDto
    {
        public string Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<string> Roles { get; set; } = new();
    }
// DTO usado APENAS quando formos criar um usuário novo
public class CreateUsuarioDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string ConfirmarSenha { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
// DTO para atualizar(senha é opcional)
public class UpdateUsuarioDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Senha { get; set; }
        public string? ConfirmarSenha { get; set; }
        public string Role { get; set; } = string.Empty;
    }
}

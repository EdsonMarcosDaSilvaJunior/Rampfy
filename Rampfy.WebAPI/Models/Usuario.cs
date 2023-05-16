namespace Rampfy.WebAPI.Models
{
  public class Usuario
    {

        public Usuario(){}

        public Usuario(int codigo, string email, string senha) 
        {
            this.Codigo = codigo;
            this.Email = email;
            this.Senha = senha;
        }
        public int Codigo { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }
    }
}
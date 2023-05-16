namespace Rampfy.WebAPI.Models
{
  public class Usuario
    {

        public Usuario(){}

        public Usuario(int id, int codigo, string email, string senha) 
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Email = email;
            this.Senha = senha;
        }
        public int Id { get; set; }
        public int Codigo { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }
    }
}
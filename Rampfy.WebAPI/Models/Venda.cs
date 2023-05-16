namespace Rampfy.WebAPI.Models
{
  public class Venda
    {
        public Venda(){}
    public Venda(int id, int codigo, DateTime data, float valor) 
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Data = data;
            this.Valor = valor;
        }

        public int Id { get; set; }

        public int Codigo { get; set; }

        public DateTime Data { get; set; }

        public float Valor { get; set; }
    }
}
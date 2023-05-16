namespace Rampfy.WebAPI.Models
{
  public class Venda
    {
        public Venda(){}
    public Venda(int codigo, DateTime data, float valor) 
        {
            this.Codigo = codigo;
            this.Data = data;
            this.Valor = valor;
        }
                public int Codigo { get; set; }

        public DateTime Data { get; set; }

        public float Valor { get; set; }
    }
}
namespace Projeto_Final.Models
{
    public class Plano : Produto
    {
        

        public Plano()
        {

        }

        public Plano(string Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }
    }
}
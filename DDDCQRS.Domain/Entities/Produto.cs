namespace DDDCQRS.Domain.Entities
{
    public class Produto
    {
        public int id { get; private set; }
        
        public string nome { get; private set; }

        public string fornecedor { get; private set; }
        
        public string marca { get; private set; }

        public decimal valor { get; private set; }

        public Produto()
        {

        }

        public Produto(string Nome, string Fornecedor, string Marca, decimal Valor)
        {
            nome = Nome;
            fornecedor = Fornecedor;
            marca = Marca;
            valor = Valor;
        }

        public Produto(int ide, string Nome, string Fornecedor, string Marca, decimal Valor)
        {
            id = ide;
            nome = Nome;
            fornecedor = Fornecedor;
            marca = Marca;
            valor = Valor;
        }

        public Produto(int ide)
        {
            id = ide;
        }


    }
}

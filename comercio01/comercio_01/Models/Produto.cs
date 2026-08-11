namespace comercio_01.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int Contato_Id { get; set; }
        public int Fornecedor_Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Preco { get; set; }
    }
}
namespace comercio_01.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int Fornecedor_Id { get; set; }
        public int Categoria_Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int Preco { get; set; }
        public int Estoque { get; set; }
    }
}
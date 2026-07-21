namespace produtoDB.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int Categoria_id { get; set; }
        public int Fornecedor_id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int preco { get; set; }
    }
}

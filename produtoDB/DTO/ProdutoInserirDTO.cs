namespace produtoDB.DTO
{
    public class ProdutoInserirDTO
    {
        public int Categoria_id { get; set; }
        public int Fornecedor_id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int preco { get; set; }
    }
}

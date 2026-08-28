namespace comercio_01.DTO
{
    public class ProdutoInserirDTO
    {
        public int Categoria_Id { get; set; }
        public int Fornecedor_Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int Preco { get; set; }
        public int Estoque { get; set; }
    }
}
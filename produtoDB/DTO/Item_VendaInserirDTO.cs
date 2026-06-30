namespace produtoDB.DTO
{
    public class Item_VendaInserirDTO
    {
        public int Quantidade { get; set; }
        public decimal Preco_unitario { get; set; }
        public int Produto_id { get; set; }
        public int Venda_id { get; set; }
    }
}

namespace comercio_01.DTO
{
    public class Item_VendaInserirDTO
    {
        public int Quantidade { get; set; }
        public decimal Preco_unitario { get; set; }
        public int Produto_Id { get; set; }
        public int Venda_Id { get; set; }
    }
}
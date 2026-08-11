namespace comercio_01.Models
{
    public class Item_Venda
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco_unitario { get; set; }
        public int Produto_Id { get; set; }
        public int Venda_Id { get; set; }
    }
}
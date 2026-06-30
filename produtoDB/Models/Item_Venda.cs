namespace produtoDB.Models
{
    public class Item_Venda
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco_unitario { get; set; }
        public int Produto_id { get; set; }
        public int Venda_id { get; set; }
    }
}

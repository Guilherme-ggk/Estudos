namespace produtoDB.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data_hora { get; set; }
        public int Funcionario_id { get; set; }
        public int Cliente_id { get; set; }
    }
}

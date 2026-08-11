namespace comercio_01.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data_hora { get; set; }
        public int Funcionario_Id { get; set; }
        public int Cliente_Id { get; set; }
    }
}
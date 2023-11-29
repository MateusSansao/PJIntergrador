namespace PJIntergrador.Models
{
    public class Faturas
    {
        public int IDFatura { get; set; }

        public DateTime MesAnoFatura { get; set; }

        public double Valor { get; set; }

        public bool FlagPagamento { get; set; }

        public int IDSocio { get; set; }
    }
}

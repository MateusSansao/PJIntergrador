namespace PJIntergrador.Models
{
    public class Eventos
    {
        public int IDEvento { get; set; }

        public string NomeEvento { get; set; }

        public DateTime DataEvento { get; set; }

        public string DescricaoEvento { get; set; }

        public int CapacidadeMaxima { get; set; }

        public bool Participante { get; set; }
    }
}

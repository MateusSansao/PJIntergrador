namespace PJIntergrador.Models
{
    public class Participacao
    {
        public int IDParticipacao { get; set; }

        public DateTime DataHoraConfirmacao { get; set; }

        public int IDEvento { get; set; }

        public int IDSocio { get; set; }
    }
}

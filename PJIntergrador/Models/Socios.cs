namespace PJIntergrador.Models
{
    public class Socios
    {
        public int IDSocio { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataAdesao { get; set; }
        public bool FlagTitular { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}

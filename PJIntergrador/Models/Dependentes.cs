namespace PJIntergrador.Models
{
    public class Dependentes
    {
        public int IDDepente { get; set; }
        public int IDSocio { get; set; }
        public string NomeCompleto { get; set; }
        public string Parentesco { get; set; }
        public string UsuarioDependente { get;set; }
        public string SenhaDependente { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IDUsuario { get; set; }
    }
}

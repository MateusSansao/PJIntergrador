using PJIntergrador.Data.Repositorio.Interfaces;
using PJIntergrador.Models;

namespace PJIntergrador.Data.Repositorio
{
    public class ExamesRepositorio : IExamesRepositorio
    {
        private readonly BancoContexto _bancoContexto;



        public ExamesRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Exames> BuscarExames()
        {
            return _bancoContexto.Exames.ToList();
        }
    }
}

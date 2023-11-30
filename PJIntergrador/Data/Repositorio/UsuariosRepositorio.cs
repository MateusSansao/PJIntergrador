using PJIntergrador.Data.Repositorio.Interfaces;
using PJIntergrador.Models;
using static PJIntergrador.Data.Repositorio.UsuariosRepositorio;

namespace PJIntergrador.Data.Repositorio
{

        public class UsuariosRepositorio : IUsuariosRepositorio
        {



            private readonly BancoContexto _bancoContexto;



            public UsuariosRepositorio(BancoContexto bancoContexto)
            {
                _bancoContexto = bancoContexto;
            }

            public Usuarios ValidarUsuario(Usuarios usuarios)
            {
                return _bancoContexto.Usuarios.FirstOrDefault(x => x.NomeUsuario == usuarios.NomeUsuario && x.Senha == usuarios.Senha);
            }
        }
}

using PJIntergrador.Data.Repositorio.Interfaces;
using PJIntergrador.Models;
using static PJIntergrador.Data.Repositorio.SociosRepositorio;

namespace PJIntergrador.Data.Repositorio
{

        public class SociosRepositorio : ISociosRepositorio
        {



            private readonly BancoContexto _bancoContexto;



            public SociosRepositorio(BancoContexto bancoContexto)
            {
                _bancoContexto = bancoContexto;
            }



            public List<Socios> BuscarSocios()
            {
                return _bancoContexto.Socios.ToList();
            }

            public void InserirSocio(Socios socios)
            {
                _bancoContexto.Socios.Add(socios);
                _bancoContexto.SaveChanges();
            }

            public void ExcluirSocio(Socios socios)
            {
                _bancoContexto.Socios.Remove(socios);
                _bancoContexto.SaveChanges();
            }

            public void Editar(Socios socios)
            {
                _bancoContexto.Socios.Update(socios);
                _bancoContexto.SaveChanges();
            }

            public Socios ListarPorId(int IDSocio)
            {
                return _bancoContexto.Socios.FirstOrDefault(x => x.IDSocio == IDSocio);
            }

            public Socios Atualizar(Socios socios)
            {
                Socios sociosDB = ListarPorId(socios.IDSocio);


                if (sociosDB == null) throw new System.Exception("Erro");

                sociosDB.NomeCompleto = socios.NomeCompleto;
                sociosDB.Cpf = socios.Cpf;
                sociosDB.DataNascimento = socios.DataNascimento;
                sociosDB.Endereco = socios.Endereco;
                sociosDB.Telefone = socios.Telefone;
                sociosDB.Email = socios.Email;
                sociosDB.DataAdesao = socios.DataAdesao;
                sociosDB.FlagTitular = socios.FlagTitular;
                sociosDB.IDUsuario = socios.IDUsuario;

                _bancoContexto.Socios.Update(sociosDB);
                _bancoContexto.SaveChanges();

                return sociosDB;
            }

            public bool Apagar(int IDSocio)
            {
                Socios sociosDB = ListarPorId(IDSocio);
                if (sociosDB == null) throw new System.Exception("Erro");
                _bancoContexto.Socios.Remove(sociosDB);
                _bancoContexto.SaveChanges();
                return true;
            }




        }
    
}

using PJIntergrador.Models;

namespace PJIntergrador.Data.Repositorio.Interfaces
{
    public interface ISociosRepositorio
    {
        Socios ValidarInformacao(Socios socios);
        List<Socios> BuscarSocios();
        void InserirSocio(Socios socios);
        void ExcluirSocio(Socios socios);
        void Editar(Socios socios);
        Socios ListarPorId(int IDSocio);
        Socios Atualizar(Socios socios);
        bool Apagar(int IDSocio);
    }
}

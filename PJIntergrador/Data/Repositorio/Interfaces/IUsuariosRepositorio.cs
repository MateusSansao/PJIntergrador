using PJIntergrador.Models;

namespace PJIntergrador.Data.Repositorio.Interfaces
{
    public interface IUsuariosRepositorio
    {
        Usuarios ValidarUsuario(Usuarios usuarios);
    }
}

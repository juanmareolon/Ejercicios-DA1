using LabDTO.Domain;

namespace LabDTO.BusinessLogic;

public class UsuarioServicio
{
    private readonly List<Usuario> _usuarios = new()
    {
        new Usuario { Id = 1, Nombre = "Ana Pereyra", Email = "ana@mail.com", Password = "sol1234" },
        new Usuario { Id = 2, Nombre = "Bruno Díaz", Email = "bruno@mail.com", Password = "elgato99" },
        new Usuario { Id = 3, Nombre = "Carla Gómez", Email = "carla@mail.com", Password = "hunter2" },
    };

    private int _proximoId = 4;

    public IReadOnlyList<Usuario> Listar() => _usuarios;

    public void Agregar(Usuario usuario)
    {
        usuario.Id = _proximoId++;
        _usuarios.Add(usuario);
    }
}

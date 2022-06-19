using Clase16.Modelo;
using Clase16.Repositorio;

var repositorio = new RepositorioPersonas();

var usuarioNombre = "Julián";

repositorio.insertar(new Empleado
{
    Nombre = usuarioNombre
});



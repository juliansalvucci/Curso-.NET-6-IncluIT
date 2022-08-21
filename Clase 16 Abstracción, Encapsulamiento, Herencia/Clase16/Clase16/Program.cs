using Clase16.Modelo;
using Clase16.Frontend;
using Clase16.Repositorio;
using Clase16.Interfaces;

var menuApp = new MenuApp(new RepositorioPersonas());
menuApp.Iniciar();

new MenuAppJubilado(new RepositoryPersonasEnArchivos<Jubilado>()).Iniciar();


//¿Es necesario que conozca como esta implementada una interface dentro de una clase? No


//CLASE22
//1-¿Es obligación definir restricciones cuando trabajamos con generics? Si <T> no puede ser  cualquier cosa.
//2-¿Es posible invocar a un método de una instancia recién creada y que esa instancia no se guarde en una variable.?
//Las interfaces tienen miembros públicos porque es un contrato, en cambio, una clase abstracta, puede modelar miembros provados
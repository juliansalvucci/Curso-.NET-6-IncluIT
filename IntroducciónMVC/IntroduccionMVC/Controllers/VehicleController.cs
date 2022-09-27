using IntroduccionMVC.Data;
using IntroduccionMVC.Data.Entities;
using IntroduccionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace IntroduccionMVC.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        
        public VehicleController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public IActionResult Edit(int id)
        {
            if(_dbContext.Vehiculos.Any(x => x.Id == id)) //Si existe el registro en BD
            {
                VehicleModel modelo = _dbContext.Vehiculos.Select(v => new VehicleModel  //Mapeo vehículo entity a vehículo model
                {
                    Id = v.Id,
                    NumeroChasis = v.NumeroChasis,
                    Dominio = v.Dominio,
                    AnioFabricacion = v.AnioFabricacion,
                    Propietario = v.Propietario
                }).First(x => x.Id == id);

                return View(modelo);
            }

            return RedirectToAction("Error", "Home"); //Redirecciona al action Error del HomeController.
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(VehicleModel vehiculo)
        {
            if (!ModelState.IsValid)
            {
                return View("New",vehiculo); //Si un campo es inválido, retorname la misma vista sin vaciarme los campos.
            }

            try
            {
                _dbContext.Add(vehiculo);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(VehicleModel vehiculo)
        {
            try
            {
                if(_dbContext.Vehiculos.Any(x => x.Id == vehiculo.Id))
                {
                    Vehiculo vehiculoUpdate = _dbContext.Vehiculos.Select(v => new Vehiculo
                    {
                        Id = v.Id,
                        Dominio = vehiculo.Dominio,
                        NumeroChasis = vehiculo.NumeroChasis,
                        Propietario = vehiculo.Propietario,
                        AnioFabricacion = vehiculo.AnioFabricacion

                    }).First(x => x.Id == vehiculo.Id);

                    _dbContext.Update(vehiculo);
                    await _dbContext.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
                //throw;
            }
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            if (_dbContext.Vehiculos.Any(x => x.Id == id)) //Si existe el registro en BD
            {
                VehicleModel modelo = _dbContext.Vehiculos.Select(v => new VehicleModel  //Mapeo vehículo entity a vehículo model
                {
                    Id = v.Id,
                    NumeroChasis = v.NumeroChasis,
                    Dominio = v.Dominio,
                    AnioFabricacion = v.AnioFabricacion,
                    Propietario = v.Propietario
                }).First(x => x.Id == id);

                return View(modelo);
            }

            return RedirectToAction("Error", "Home"); //Redirecciona al action Error del HomeController.
        }

        public async IActionResult Delete(int id)
        {
            try
            {
                if (_dbContext.Vehiculos.Any(x => x.Id == id)) //Si existe el registro en BD
                {
                    Vehiculo v = _dbContext.Vehiculos.First(x => x.Id == id);
                    _dbContext.Remove(v);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return RedirectToAction("Error", "Home"); //Redirecciona al action Error del HomeController.
            }
           
        }


        public IActionResult Index()
        {
            var vehiculos = _dbContext.Vehiculos.ToList();

            //var model = new VehicleListViewModel
            //{
            //    Vehiculos = new List<VehicleListModel>()
            //};

            //foreach(var vehiculo in vehiculos)
            //{
            //    model.Vehiculos.Add(new VehicleListModel
            //    {
            //        Id = vehiculo.Id,
            //        Dominio = vehiculo.Dominio,
            //        AnioFabricacion = vehiculo.AnioFabricacion
            //    });
            //}

            //Utilizando Linq
            var vehiclesList = vehiculos
                .Select(v => new VehicleListModel
                {
                    Id = v.Id,
                    Dominio = v.Dominio,
                    AnioFabricacion = v.AnioFabricacion
                })
                .ToList();

            ViewData["miTitulo"] = "My Vehicles";
           // ViewData["Vehicles"] = vehiclesList;

            ViewBag.Vehicles = vehiclesList;

            return View("List");
        }
    }
}

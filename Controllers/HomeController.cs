﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP_2.Models;

namespace TP_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Hello, this is the index!");
            return View();
        }

        public IActionResult CargaEmpleado()
        {
            //_logger.LogInformation("Hola, soy el controller del empleado!");
            return View();
        }

        public string MostrarEmpleado(string nombre, string apellido, int dni, int ingreso)
        {
            try
            {
                _logger.LogInformation($"Empleado:{nombre} {apellido} DNI: {dni} Alta:{ingreso}");
                return $"Empleado:{nombre} {apellido} DNI: {dni} Alta:{ingreso} ";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return $"Error {ex}";
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

﻿using Lab.Models.Grupo7;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace Grupo7.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrestamoController : Controller
    {

        private readonly PrestamoService _prestamoServices;

        public PrestamoController(PrestamoService prestamoServices) 
        {
            _prestamoServices = prestamoServices;
        }

        [HttpGet(Name = "GetPrestamo")]
        public Task<Prestamos> Get()
        {
            return _prestamoServices.ListaPrestamo();
        }
    }
}

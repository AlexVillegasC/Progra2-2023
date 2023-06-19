using Lab.Models.Grupo2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace Grupo02.API.Controllers;

[ApiController]
[Route("[Controller]")]




public class InventarioController : Controller
{

    private readonly InventarioService _inventarioService;

    public InventarioController(InventarioService inventarioService)
    {
        _inventarioService = inventarioService;
    }

    [HttpGet(Name = "GetInventario")]
    public Task<Inventario> Get()
    {
        return _inventarioService.GetMyInventario();
    } 
}
































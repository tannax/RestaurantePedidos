using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
      
        [HttpPost]
  public IActionResult Index(ItemPedido novoPedido)
        {
            Dados.PedidoAtual.Adicionar(novoPedido);
            ViewBag.Retorno ="Pedido registrado com sucesso!";
            return View();
        }

public IActionResult Retornodedados()
        {
            List<ItemPedido> buscarRegistro = Dados.PedidoAtual.Listar();
            ViewBag.Total = Dados.PedidoAtual.ValorTotal();
            return View(buscarRegistro);
        }
  public IActionResult Suporte()
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Context;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly VendasContext _context;

        public VendaController(VendasContext context)
        {
            _context = context;
        }


        [HttpPost("CadastrarVendedor")]
        public IActionResult CadastrarVendedor(Vendedor vendedor)
        {
            _context.Add(vendedor);
            _context.SaveChanges();
            return Ok(vendedor);
        }

        [HttpGet("ListarVendedores")]
        public IActionResult ListaVendedores()
        {
            var vendedoresBanco = _context.Vendedores;
            if (vendedoresBanco.Count() <= 0)
            {
                return NotFound("ERRO! Não existem vendedores registrados!");
            }
            return Ok(vendedoresBanco);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarVendaPorId(int id)
        {
            Venda vendaCompleta = _context.Vendas
                .Include(v => v.Itens)
                .Include(v => v.Vendedor)
                .FirstOrDefault(v => v.Id == id);

            if (vendaCompleta == null)
            {
                return NotFound();
            }

            return Ok(vendaCompleta);
        }

        [HttpPost("RegistrarVenda")]
        public IActionResult RegistrarVenda(int IdVendedor, DateTime Data, string Itens, StatusVenda Status)
        {
            Venda venda = new Venda
            {
                IdVendedor = IdVendedor,
                Data = Data,
                Itens = Itens.Split(',').Select(i => new ItemVenda { Nome = i }).ToList(),
                Status = Status
            };

            _context.Add(venda);
            _context.SaveChanges();

            Venda vendaCompleta = _context.Vendas
                .Include(v => v.Itens)
                .Include(v => v.Vendedor)
                .FirstOrDefault(v => v.Id == venda.Id);

            return Ok(vendaCompleta);
        }


        [HttpGet("ListarVendas")]
        public IActionResult ListarVendas()
        {
            var vendaCompleta = _context.Vendas
                .Include(v => v.Itens)
                .Include(v => v.Vendedor);

            if (vendaCompleta.Count() <= 0)
            {
                return NotFound("ERRO! Não existem vendas registradas!");
            }

            return Ok(vendaCompleta);
        }


        [HttpPut("AtualizarVenda")]
        public IActionResult AtualizarVenda(int id, DateTime Data, int IdVendedor, string Itens, StatusVenda Status)
        {
            var vendaBanco = _context.Vendas.Include(v => v.Itens).FirstOrDefault(v => v.Id == id);
            if (vendaBanco == null)
            {
                return NotFound("Venda não encontrada");
            }

            Venda vendaAtualizada = new Venda
            {
                Id = id,
                IdVendedor = IdVendedor,
                Data = Data,
                Itens = Itens.Split(',').Select(i => new ItemVenda { Nome = i }).ToList(),
                Status = Status
            };

            switch (vendaBanco.Status)
            {
                case StatusVenda.AguardandoPagamento:
                    if (Status == StatusVenda.PagamentoAprovado || Status == StatusVenda.Cancelada)
                    {
                        break;
                    }
                    else
                    {
                        return BadRequest("Transição de status não permitida");
                    }
                case StatusVenda.PagamentoAprovado:
                    if (Status == StatusVenda.EnviadoParaTransportadora || Status == StatusVenda.Cancelada)
                    {
                        break;
                    }
                    else
                    {
                        return BadRequest("Transição de status não permitida");
                    }
                case StatusVenda.EnviadoParaTransportadora:
                    if (Status == StatusVenda.Entregue)
                    {
                        break;
                    }
                    else
                    {
                        return BadRequest("Transição de status não permitida");
                    }
                default:
                    return BadRequest("Transição de status não permitida");
            }

            var itensBanco = _context.ItemVendas.Where(i => i.Id_Venda == id).ToList();
            _context.ItemVendas.RemoveRange(itensBanco);

            _context.ItemVendas.AddRange(vendaAtualizada.Itens);

            vendaBanco.Id = vendaAtualizada.Id;
            vendaBanco.IdVendedor = vendaAtualizada.IdVendedor;
            vendaBanco.Data = vendaAtualizada.Data;
            vendaBanco.Status = vendaAtualizada.Status;
            vendaBanco.Itens = vendaAtualizada.Itens;

            _context.Update(vendaBanco).State = EntityState.Modified;

            _context.SaveChanges();

            return Ok(vendaBanco);
        }





    }


}

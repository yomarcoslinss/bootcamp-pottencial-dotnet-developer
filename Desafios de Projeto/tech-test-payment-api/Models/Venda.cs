using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace tech_test_payment_api.Models
{

    public class Venda
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public List<ItemVenda> Itens { get; set; }

        public StatusVenda Status { get; set; }

        public int IdVendedor { get; set; }

        public Vendedor Vendedor { get; set; }
    }

}
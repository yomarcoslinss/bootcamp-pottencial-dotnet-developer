using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace tech_test_payment_api.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        [JsonIgnore]
        public ICollection<Venda> Vendas { get; set; }

    }
}
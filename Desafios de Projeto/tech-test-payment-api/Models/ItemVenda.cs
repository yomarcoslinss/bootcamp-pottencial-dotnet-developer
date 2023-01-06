using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tech_test_payment_api.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int Id_Venda { get; set; }
        public string Nome { get; set; }
        [JsonIgnore]
        public Venda Venda { get; set; }
    }
}
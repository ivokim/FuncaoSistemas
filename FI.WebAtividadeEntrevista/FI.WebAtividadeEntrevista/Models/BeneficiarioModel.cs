using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        public long Id { get; set; }
        public string CPF { get; set; }
        public string NOME { get; set; }
        public long IDCLIENTE { get; set; }
    }
}
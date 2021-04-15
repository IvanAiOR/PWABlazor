using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PWABlazor.Server.Models
{
    public class Boton
    {
        public string  ID{ get; set; }
        public DateTime  Fecha{ get; set; }
        public int  Contador{ get; set; }
    }
}

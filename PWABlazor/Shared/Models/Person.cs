using System;
using System.Collections.Generic;
using System.Text;

namespace PWABlazor.Shared.Models
{
    public class Person
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
    }
}

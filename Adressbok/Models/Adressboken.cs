using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adressbok.Models
{
    public class Adressboken
    {
        public Guid Id { get; set; }
        public string Namn { get; set; }
        public int Telefonnummer { get; set; }
        public string Adress { get; set; }
        public DateTime Tidpunkt { get; set; }


    }
}
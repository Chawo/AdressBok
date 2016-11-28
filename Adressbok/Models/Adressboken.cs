using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adressbok.Models
{
    public class Adressboken
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public int Telefonnummer { get; set; }
        public string Adress { get; set; }

    }
}
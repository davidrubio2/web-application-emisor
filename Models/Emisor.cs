using System;

namespace webappemisor
{
    public class Emisor
    {
        public string Id{get; set;}
        public string Rfc {get;set;}
        public DateTime FechaInicioOperacion {get; set;}
        public decimal Capital {get; set;}
    }
}
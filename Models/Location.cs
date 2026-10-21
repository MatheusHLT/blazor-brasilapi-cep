using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmBrasilApiCep.Models
{
    public class Location
    {
        public string type { get; set; }
        public Coordinates coordinates { get; set; }
    }
}
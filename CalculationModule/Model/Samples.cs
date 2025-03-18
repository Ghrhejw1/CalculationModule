using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace CalculationModule.Model
{
    public class Samples
    {
        public int ID { get; set; }
        public int FK_locations { get; set; }
        public string TEXT { get; set; }
        public int FK_metal { get; set; }
        public int FK_method { get; set; }
        public double Value { get; set; }
    }
}

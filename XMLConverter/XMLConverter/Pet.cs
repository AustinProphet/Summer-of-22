using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLConverter
{
    public class Pet : IPet
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
}

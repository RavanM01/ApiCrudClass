using Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public int Count { get; set; }
    
        public int ModelId { get; set; }
        public Model model { get; set; }
        public List<Color> Colors { get; set; }
    }
}

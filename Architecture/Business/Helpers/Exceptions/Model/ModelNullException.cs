using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helpers.Exceptions.Model
{
    public class ModelNullException : Exception
    {
        public ModelNullException() : base("Model Yoxduki") { }
        public ModelNullException(string? message) : base(message)
        {
        }
    }
}

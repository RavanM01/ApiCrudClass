using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helpers.Exceptions.Model
{
    public class ModelNameExsistException : Exception
    {
        public ModelNameExsistException():base("SAme NAme Issue ")
        {
        }

        public ModelNameExsistException(string? message) : base(message)
        {
        }
    }
}

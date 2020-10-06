using System;
using System.Runtime.Serialization;

namespace ManejoExcepciones.Properties
{
    public class ExcepcionPersonalizada:ApplicationException
    {

        public ExcepcionPersonalizada(string message):base("No se encontro el consumible")
        {
        }
    }
}

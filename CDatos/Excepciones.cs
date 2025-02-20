using System;

namespace CDatos
{
    public class Excepciones :ApplicationException
    {
        
        public Excepciones(string mensaje, Exception original)
               : base(mensaje, original)
        {

        }
        public Excepciones(string mensaje)
            : base(mensaje)
        {

        }
    }
}

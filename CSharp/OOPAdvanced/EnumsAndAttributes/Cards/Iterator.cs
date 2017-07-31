namespace EnumsAndAttributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Iterator<T> 
    {
        public IEnumerable<T> GetValues()
        {
            if (typeof(T).BaseType != typeof(Enum))
            {
                throw new InvalidOperationException();
            }
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}

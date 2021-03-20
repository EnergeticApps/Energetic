using System;

namespace Energetic.Enumerables
{
    public class EnumerableArgumentEmptyException : ArgumentException
    {
        public EnumerableArgumentEmptyException(string paramName) : base("Enumeration or collection object passed as an argument needs to have at least one item in it.", paramName)
        {
        }
    }
}

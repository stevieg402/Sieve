using System;

namespace Sieve.Services
{
    public interface ISieveTypeConverter
    {
        object Convert(string filterTermValue, Type propertyType);
    }
}

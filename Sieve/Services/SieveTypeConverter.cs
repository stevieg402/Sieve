using System;
using System.ComponentModel;

namespace Sieve.Services
{
    public class SieveTypeConverter : ISieveTypeConverter
    {
        public object Convert(string filterTermValue, Type propertyType)
        {
            var converter = TypeDescriptor.GetConverter(propertyType);

            return converter.CanConvertFrom(typeof(string))
                ? converter.ConvertFrom(filterTermValue)
                : System.Convert.ChangeType(filterTermValue, propertyType);
        }
    }
}

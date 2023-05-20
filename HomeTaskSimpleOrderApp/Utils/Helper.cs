using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskSimpleOrderApp.Utils
{
    public static class Helper
    {
        public static string PropertiesToString(object obj)
        {
            var properties = obj.GetType().GetProperties();
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"Class {obj.GetType().Name}: ");

            foreach (var prop in properties)
            {
                var value = prop.GetValue(obj, null);
                stringBuilder.Append($"{prop.Name}: {value}, ");
            }

            // Remove last comma and space
            stringBuilder.Remove(stringBuilder.Length - 2, 2);

            return stringBuilder.ToString();
        }
    }
}

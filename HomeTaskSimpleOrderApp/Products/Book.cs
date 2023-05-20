using HomeTaskSimpleOrderApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskSimpleOrderApp.Products
{
    public class Book : Product
    {
        public string Author { get; private set; }
        public Book(string name, decimal price) : base(name, price)
        {
            Author = "No Author";
        }
        public Book(string name, decimal price, string author) : base(name, price)
        {
            Author = author;
        }

        public override string ToString()
        {
            return Helper.PropertiesToString(this);
            //return GetAllProperttiesAsString(nameof(Book));
            //return $"Class {nameof(Book)} :" + GetType().GetProperties()
            //    .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
            //    .Aggregate(
            //        new StringBuilder(),
            //        (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
            //        sb => sb.ToString());
            //return String.Format("Class {0}: {1}-'{2}', {3}-'{4}', {5}-'{6}'"
            //    , nameof(Author), nameof(Name), Name, nameof(Price), Price, nameof(Author), Author);
        }
    }
}

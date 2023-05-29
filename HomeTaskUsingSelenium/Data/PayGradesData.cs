using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskUsingSelenium.Data
{
    public class PayGradesData
    {
        public static int MinSalary = 20;
        public static int MaxSalary = 100;
        public static string Name = NameFaker.FirstName();
    }

    
}

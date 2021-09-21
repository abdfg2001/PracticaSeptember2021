using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSeptember2021.Models
{
    public static class Static_List
    {
        public static List<string> MyList;
        static Static_List()
        {
            MyList = new();
            MyList.Add("First");

        }
    }
}

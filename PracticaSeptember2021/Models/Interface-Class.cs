using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSeptember2021.Models
{
    public interface Interface_Class
    {
        public void Cook();
    }

    public class poultry : Interface_Class
    {
        public void Cook()
        {
            Static_Class.result = "Chicken";
        }
    }

    public class Animal : Interface_Class
    {
        public void Cook()
        {
            Static_Class.result = "Beef";
        }
    }

}

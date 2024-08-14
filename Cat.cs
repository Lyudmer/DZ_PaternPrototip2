using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DZ_PaternPrototip2
{
    public class Cat : Predators
    {
        public Cat(string eyes,string breed, string color, string name, int age,string myfunc, string mysound) 
            : base(breed, color, name, age)
        {
            Eyes = eyes;
            MyFunc = myfunc;
            MySound = mysound;
        }
        public string Eyes { get; set; }
        public string MyFunc { get; set; }
        public string MySound { get; set; }
        public override string ToString()
        {

            return $":Кот {base.Name},возраст {base.Age}"+
                $"\n порода {base.Breed} окрас {base.Color} глаза {Eyes}" +
                $" \n  {base.MainFunction(MyFunc)} и {base.MakeSound(MySound)}";
        }
        public new Cat MyClone()
        {
            return new(Eyes, MyFunc, MySound, Breed, Age, Color, Name);
        }
        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DZ_PaternPrototip2
{
    public class Lemurs : Primates, IAnimalClone<Lemurs>, ICloneable
    {
        public Lemurs(float weight, float size, string mysound, string color, string habitat, string name, int age) 
            : base( color, habitat, name, age)
        {
            MySize = size;
            MyWeight = weight;
            MySound = mysound;
        }
        public float MySize { get; set; }
        public float MyWeight { get; set; }
        public string MySound { get; set; }
        public override string ToString()
        {

            return $":Лемур {base.Name},возраст {base.Age}"+
                $"\n размер {MySize} вес {MyWeight} окрас {base.Color}" +
                $" \n  {base.MyHabitat} и {base.MakeSound(MySound)} ";
        }
    
        public new Lemurs MyClone()
        {
            return new(MyWeight,MySize,MySound, MyHabitat, Color, Name, Age);
        }
        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

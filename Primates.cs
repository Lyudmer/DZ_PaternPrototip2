using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_PaternPrototip2
{
    public class Primates : Animals, IAnimalClone<Primates>, ICloneable
    {
        public Primates( string color, string habitat, string name,int age):base(name,age)
        {
            Color = color;
            MyHabitat = habitat;
        }
      
        public string Color {  get; set; }
        public string MyHabitat { get; set; }

        public string Move(string vidmoved)
        {
            return vidmoved;
        }
        public new Primates MyClone()
        {
          return  new(Color, MyHabitat,  Name, Age);
        }
        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

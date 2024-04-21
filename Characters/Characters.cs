using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.Main_Character_Description
{
    public class Characters
    {
        public virtual string Name { get; set; }
        public virtual double hp { get; set; }
        public virtual int gold { get; set; }
        public virtual string Weapon {  get; set; }
        public virtual int damage { get; set; } = 10;

    }
    internal class Zarlock
    {
        public string Name { private get; set; } = "Zarlock";
        public int hp { get; set; } = 2000;
        public int damage = 50;
    }
   
}

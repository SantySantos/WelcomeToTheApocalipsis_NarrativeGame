using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_GV5.SaveSystem
{
    [Serializable]
    public class SaveSystem
    {
        //character

        //public string name;
        //public double hp;
        //public int gold;
        //public string weapon;
        //public int damage;

        //Inventory
        public double Fruits;
        public double SuperFruits;
        public int Coins;
        public double MegaFruits;

        //skull
        public bool Skull;

        public SaveSystem(double Fruits, double SuperFruits, int Coins, double MegaFruits, bool Skull)
        {
            //this.name = name;
            //this.hp = hp;
            //this.gold = gold;
            //this.weapon = weapon;
            //this.damage = damage;
            this.Fruits = Fruits;
            this.SuperFruits = SuperFruits;
            this.Coins = Coins;
            this.MegaFruits = MegaFruits;
            this.Skull = Skull;
        }

    }
}

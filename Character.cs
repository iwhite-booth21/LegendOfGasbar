using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegendOfGasbar
{
    public class Character 
    { 
        public string c_name { get; set; }
        public int c_speed { get; set; }
        public int c_power { get; set; }
        public int c_limit { get; set; }
        public int c_health { get; set; }

        public string[] characterBuilds = { "Knight", "Healer", "Thief", "Assassin", "Monk", "Paladin" };
        public string[] characterData = { "Strength", "Mana", "Luck", "Lockpick", "GASMA" };

        private double StrengthVal;
        private double ManaVal;
        private double LockPickVal;
        private double GasmaVal;

        public string CharacterBuilder(string input) 
        {
            string build = "";
            Debug.Write("What is your Desired Character Build");
            if (input == characterBuilds[0])
                build += input;
            else if(input == characterBuilds[1])
                build += input;
            else if(input == characterBuilds[2])
                build += input;
            else if(input == characterBuilds[3])
                build += input;
            else if(input == characterBuilds[4])
                build += input;
            
            return build;
        }

        public double defBuildStatGenerator(double val) 
        {   
            Random r = new Random();
            StrengthVal = r.NextDouble() * val;
            ManaVal = r.NextDouble() + val;
            LockPickVal =r.NextDouble() + val;
            GasmaVal = r.NextDouble() + val;
            return val * r.NextDouble();
        }
    }

    public class DataManager<T> 
    { 
        public T dataId { get; set;}
        public T dataString { get; set;}    
    }

}

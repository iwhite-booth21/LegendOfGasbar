using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LegendOfGasbar
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // You need to bring in the prototype character object
            Character myCharacter = new Character();

            // Generate Random Values for Character
            Random rnd = new Random();
            myCharacter.c_limit = rnd.Next(0, 100000);
            myCharacter.c_health = rnd.Next(0, 100);
            myCharacter.c_power = rnd.Next(0, 999);
            myCharacter.c_speed = rnd.Next(1, 10);

            // Logic for the remaining items -> Random Name
            string[] randomNames = { "Axel", "Thrasher", "Xcel", "DangerMan", "The Rock", "MegurManX" };
            myCharacter.c_name = randomNames[rnd.Next(0, 5)];

            // Show the player the character build
            MessageBox.Show 
                (
                "Name : \t" + myCharacter.c_name + "\n" + "Power Level: \t " +
                myCharacter.c_power.ToString() + "\n" + "Character Health: \t" 
                + myCharacter.c_health.ToString() + "\n" + "Character Speed: \t" + myCharacter.c_speed.ToString() 
                + "\n" + "Power Limit: \t" + myCharacter.c_limit.ToString(), "Character Build"
                );
      

            // Capture the character in a holder (Save File???)
            List<Character> list = new List<Character>();
            list.Add(myCharacter);
            
            
           
        }
    }
}

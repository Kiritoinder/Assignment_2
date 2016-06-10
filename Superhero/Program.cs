using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Author: Inderjeet Singh
* Student Number: 300874118
* Date Created: June 10, 2016
* Description: The SuperHero and Hero Assignment_2
* Version: 0.0.2
*/
namespace Superhero
{
    /**
     * this class is the "driver" class for my program
     * @class Program
     */
    class Program
    {
        /**Main method of driver class
         * 
         * @method Main
         * param {string} args
         */
        static void Main(string[] args)
        {
            //Superhero Name
            Console.WriteLine("Yo! What's Your Superhero's Name? ");
            string Avenger = Console.ReadLine();
            //Create a new instance of the Superhero class
            SuperHero superHero = new SuperHero(Avenger);
            //Create a new instance of the Hero class
            Hero hero = new Hero(Avenger);
            //calling the Public show method 
            hero.Show();
            //calling the public fight method
            hero.Fight();

            //Calling ShowPower method
            superHero.ShowPowers();

            Console.ReadLine();
        } //End Main
    } //End Program
} //End Name Space


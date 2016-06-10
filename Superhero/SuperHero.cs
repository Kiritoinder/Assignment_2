using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    /**
     * <summary>
     * This class contains a superHero class that have super abilties or super powers
     * </summary>
     * @class SuperHero
     * @field {stringArray} _superPowers
     */

   public class SuperHero : Hero
    {
        /**
        * <summary>
        * The main method for our driver class Program
        * </summary>
        * @method main
        * @param {string[]} args
        */

        //PRIVATE INSTANCE VARIABLES --------------------------------------------------------------
        private string[] _superPowers;


        //initializing "Powers " object for the original random class
        Random Spowers = new Random();

        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public SuperHero(string name)
            : base(name)
        {
            this._superPowers = new string[3];
            _generateRandomPowers();
        }
        //PRIVATE METHODS--------------------------------------------------------------------------
        /**
         * <summary>
         * This method Create a list of superpowers and assign only three of them
         * to the superhero
         * </summary>
         * @method _generateRandomPowers
         * @return {void}
         */
        private void _generateRandomPowers()
        {
            List<string> sAbilitiesList = new List<string>();
            sAbilitiesList.Add("Time Power");
            sAbilitiesList.Add("Transformation");
            sAbilitiesList.Add("Fire Generation");
            sAbilitiesList.Add("Size power");
            sAbilitiesList.Add("Super Intellegence");
            sAbilitiesList.Add("Duplication");
            sAbilitiesList.Add("Claws");
            sAbilitiesList.Add("Vampire");
            sAbilitiesList.Add("DiamondHead");


            for (int i = 0; i < 3; i++)
            {
                int randomPower = Spowers.Next(0, sAbilitiesList.Count);
                _superPowers[i] = sAbilitiesList.ElementAt(randomPower);
                sAbilitiesList.RemoveAt(randomPower);
            }
        }
        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method outputs the super powers of the hero
         * </summary>
         * @method ShowPowers
         * @return {void}
         */
        public void ShowPowers()
        {
            Console.WriteLine("Our Super Hero {0} Have the  following super powers.", base.Name);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(_superPowers[i]);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}

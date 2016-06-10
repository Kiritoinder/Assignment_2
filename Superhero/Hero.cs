using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Author: Inderjeet Singh
* Student Number: 300874118
* Date Created: June 10, 2016
* Description: My Hero Class
* Version: 0.0.2
*/
namespace Superhero
{
    /**
     * This class defines a Hero
     * 
     * @class Hero
     * @field {int} _strength
     * @field {int} _speed
     * @field {int} _health
     * @field {string} _name

     */
    public class Hero
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++
        private string _name;
        private int _strength;
        private int _health;
        private int _speed;

        //Initilizing a Random Object
        Random num = new Random();



        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * this is property for our private _name field
         * </summary>
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {

                this._name = Name;
            }
        }

        //CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is a constructor that takes name as as paramater and 
         * passes it to the _name Private instance variable
         * </summary>
         *           
         * @constructor Superhero
         * @parm {string} _name
         */

        public Hero(string name)
        {
            this._name = name;
            _generateAbilities();
        }

        // PRIVATE METHODS -----------------------------------------------
        /**
        * <summary>
        * This method generates abilities randomly for the
        * strength, speed and health variables
        * </summary>
        * @method _generateAbilities
        * @return {void}
        */

        private void _generateAbilities()
        {
            _strength = num.Next(1, 101);
            _speed = num.Next(1, 101);
            _health = num.Next(1, 101);
        }
        /**
         * <summary>
         * This method determines if the hero hits 
         * </summary>
         * @method _hitAttempt
         * @return {bool}
         */
        private bool _hitAttempt()
        {
            //Generating a random number between 1-100 
            int hit = num.Next(1, 101);
            if (hit <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /**
         * <summary>
         * Method that calculates the damage the Superhero causes to the target
         * on a hit by multiplying a number between 1, 6 by strenght.
         * </summary>
         * @method _hitDamage
         * @return {int}
         */
        private int _hitDamage()
        {
            int damage = this._strength * num.Next(1, 6);
            return damage;
        }
        //PUBLIC METHODS +++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method calls the _hitAttempt method and if returns
         * true it calls the _hitDamage method and the damaged amount is passed 
         * to the console
         * </summary>
         * @method Fight
         * @return {void}
         */
        public void Fight()
        {
            int damage;

            if (_hitAttempt())
            {
                damage = _hitDamage();
                Console.WriteLine("Get That You SU***R!");
                Console.WriteLine("{0} made {1}% damage to the Enemy:", this.Name, damage);
            }
            else
            {
                Console.WriteLine("I'll Get You Next Time!");
                Console.WriteLine("{0} made no damage to the Enemy.", this.Name);
            }
        }
        /**
        * <summary>
        * This method calculates the Superhero's Speed and displays it to the console.
        * </summary>
        * @method speed
        * @return {void}
        */
        public void speed()
        {
            if (this._speed <= 50)
            {
                Console.WriteLine("Awwwww____ Your Superhero is Sooooo Slow -_-");
            }
            else
            {
                Console.WriteLine("OMG your Superhero is Soooo Fast <_>");
            }
        }
        /**
         * <summary>
         * This method outputs the health of the Superhero to the console.
         * </summary>
         * @method health 
         * @return {void}
         */
        public void health()
        {
            if (this._health <= 65)
            {
                Console.WriteLine("Gosh Low Health.");
            }
            else
            {
                Console.WriteLine("Great! Good health.");
            }
        }
        /**
         * <summary>
         * This method will display the Hero’s ability scores to the console
         * </summary>
         * @method Show
         * @return {void}
         */
        public void Show()
        {
            _hitAttempt();
            _hitDamage();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+{0} is the Superhero!  \t\t\t\t", this.Name);
            Console.WriteLine("+These are {0}'s abilities\t\t\t ", this.Name);
            Console.WriteLine("+Health  ==== {0}\t\t\t\t", _health);
            Console.WriteLine("+Strength  ====  {0}\t\t\t\t", _strength);
            Console.WriteLine("+Speed ====  {0} \t\t\t\t", _speed);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
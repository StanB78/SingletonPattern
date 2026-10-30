using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        private static ChocolateBoiler? uniqueInstance;

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        // This code is only started when the boiler is empty
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }
        // To fill the boiler it must be empty and once it is full, we set the empty and boiled flag
        public void fill()
        {
            if(empty)
            {
                empty = false;
                boiled = false;
            }
        }
        // To drain the boiler, it must be full (non empty) and also boiled.
        // Once it is drained we set empty back to true
        public void drain()
        {
            if(!empty && boiled)
            {
                empty = true;
            }
        }
        // To boil the mixture, the boiler has to be full and not already boiled.
        // Once it is boiled we set the boiled flag to true
        public void boil()
        {
            if(!empty && !boiled)
            {
                boiled = true;
            }
        }
    }
}

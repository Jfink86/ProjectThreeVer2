using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Dog
    {

        //Fields

        private bool treat;
        private bool isHungry;
        private bool goPotty;
        private int tickercount;
        // Properties
        public int Tickercount
        {get { return this.tickercount; }
            set { this.tickercount = value; }


        }

        public bool Treat
        {
            get { return this.treat; }
            set { this.treat = value; }
        }

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public bool GoPotty
        {
            get { return this.goPotty; }
            set { this.goPotty = value; }
        }

        //  Constructors

        public Dog()
        {

        }

        public Dog(bool treat, bool isHungry, bool goPotty)
        {
            this.treat = treat;
            this.isHungry = isHungry;
            this.goPotty = goPotty;
        }

        // Methods

        public void WantaTreat()
        {
            treat = true;
            Console.WriteLine("Isa Good Boy? Isa wanna Treat?");
        }

        public void FeedDog()
        {
            Console.WriteLine("Get the dinner BooBoo!!!");
            isHungry = true;
        }

        public void PottyStatus()
        {
            Console.WriteLine("Datta Wadda Good Boy BooBoo");
            goPotty = true;
        }

        public void Dogstatus()
        {
            Console.WriteLine("Wants to Eat.........:" + isHungry);
            Console.WriteLine("Wants to go OutSide..:" + goPotty);
            Console.WriteLine("Wants a Treat........:" + treat);
        }

        public void Tick()
        {

            tickercount++;
            if (isHungry == false)
            {
                goPotty = true;
            }
            if (goPotty == false )
            {
                treat = true;
            }
            if (isHungry == false)
            {
                isHungry = true;
            }
            else treat = false;






        }




    }    

}


    


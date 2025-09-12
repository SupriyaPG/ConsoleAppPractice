using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
namespace practiceApp
{
    abstract class Animal
    {
        public abstract void FoodHabits();
    }

    internal class Carnivorus : Animal
    {
        public override void FoodHabits()
        {
            Console.WriteLine("Carnivorus eats other animals.");
        }
    }

    internal class Herbivores : Animal
    {
        public override void FoodHabits()
        {
            Console.WriteLine("Harbivores eats grass and plants.");
        }
    }

}

﻿using System;

namespace CoffeeMachine
{
    public class DrinkMaker
    {
        public DrinkMaker()
        {
        }

        public string Coffee()
        {
            return "C::";
        }

        public string CoffeeWithSugar()
        {
            return "C:1:1";
        }

        public string CoffeeWithTwoSugar()
        {
            return "C:2:1";
        }

        public object Tea()
        {
            return "T::";
        }

        public object TeaWithSugar()
        {
            return "T:1:1";
        }

        public object TeaWithTwoSugar()
        {
            return "T:2:1";
        }

        public object Chocolate()
        {
            return "H::";
        }

        public object ChocolateWithSugar()
        {
            return "H:1:1";
        }

        public object ChocolateWithTwoSugar()
        {
            return "H:2:1";
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine {
    public static class RandomNumberGenerator {
        private static Random _generator = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue) {
            return _generator.Next(minimumValue, maximumValue + 1);
        } // In the simple version, we create a Random object (_generator) and use its Next() method to get a random value between the minimum and maximum values passed in as parameter.


    }
    // This is the more complex version
    public static class BetterRandomNumberGenerator {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();
        public static int NumberBetween(int minimumValue, int maximumValue) {
            byte[] randomNumber = new byte[1];
            _generator.GetBytes(randomNumber);
            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);
            // We are using Math.Max, and substracting 0.00000000001,
            // to ensure "multiplier" will always be between 0.0 and .99999999999
            // Otherwise, it's possible for it to be "1", which causes problems in our rounding.
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);
            // We need to add one to the range, to allow for the rounding done with Math.Floor
            int range = maximumValue - minimumValue + 1;
            double randomValueInRange = Math.Floor(multiplier * range);
            return (int)(minimumValue + randomValueInRange);
            //In this version, we use an instance of an encryption class (RNGCryptoServiceProvider). This class is better at not following a pattern when it creates random numbers. But we need to do some more math to get a value between the passed in parameters.


        }
    }
}

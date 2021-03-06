﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fizzBuzzLib;

namespace FizzBuzzlib.Test
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_when_default_return_input ([Values(1,2,4,7,8,11,13,14,16,17)] int input) {
            
            string output = fizzBuzzer.getValue(input);
            Assert.AreEqual(input.ToString(), output);          

        }

        [Test]
        public void Buzzer_whenDev3_return_Fizz([Values(3,6,9,12,18)] int input)
        {

            string output = fizzBuzzer.getValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_whenDev5_return_Buzz([Values(5,10)] int input)
        {

            string output = fizzBuzzer.getValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_whenDev5_and_Dev3_returnFizzBuzz([Values (15) ]int input) {


            string output = fizzBuzzer.getValue(input);
            Assert.AreEqual("FizzBuzz", output);    
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Tests
{
    [TestClass()]
    public class BobTests
    {
        [TestMethod()]
        
        public void Stating_something()
        {
            Assert.AreEqual(Bob.Hey("Tom-ay-to, tom-aaaah-to."), "Whatever.");
        }

        [TestMethod()]
        public void Shouting()
        {
            Assert.AreEqual(Bob.Hey("WATCH OUT!"), ("Whoa, chill out!"));
        }

        [TestMethod()]
        public void Asking_a_question()
        {
            Assert.AreEqual(Bob.Hey("Does this cryogenic chamber make me look fat?"), ("Sure."));
        }

        [TestMethod()]
        public void Asking_a_question_with_a_trailing_space()
        {
            Assert.AreEqual(Bob.Hey("Do I like my  spacebar  too much?  "), ("Sure."));
        }


        [TestMethod()]
        public void Asking_a_numeric_question()
        {
            Assert.AreEqual(Bob.Hey("You are, what, like 15?"), ("Sure."));
        }
        [TestMethod()]
        public void Talking_forcefully()
        {
            Assert.AreEqual(Bob.Hey("Let's go make out behind the gym!"), ("Whatever."));
        }

        [TestMethod()]
        public void Using_acronyms_in_regular_search()
        {
            Assert.AreEqual(Bob.Hey("It's OK if you don't want to go to the DMV."), ("Whatever."));
        }

        [TestMethod()]
        public void Forceful_questions()
        {
            Assert.AreEqual(Bob.Hey("WHAT THE HELL WERE YOU THINKING?"), ("Whoa, chill out!"));
        }

        [TestMethod()]
        public void Shouting_numbers()
        {
            Assert.AreEqual(Bob.Hey("1, 2, 3 GO!"), ("Whoa, chill out!"));
        }


        [TestMethod()]
        public void Only_numbers()
        {
            Assert.AreEqual(Bob.Hey("1, 2, 3"), ("Whatever."));
        }

        [TestMethod()]
        public void Question_with_only_numbers()
        {
            Assert.AreEqual(Bob.Hey("4?"), ("Sure."));
        }


        [TestMethod()]
        public void Shouting_with_special_characters()
        {
            Assert.AreEqual(Bob.Hey("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"), ("Whoa, chill out!"));
        }

        [TestMethod()]
        public void Shouting_with_no_exclamation_mark()
        {
            Assert.AreEqual(Bob.Hey("I HATE YOU"), ("Whoa, chill out!"));
        }
        [TestMethod()]
        public void Statement_containing_question_mark()
        {
            Assert.AreEqual(Bob.Hey("Ending with ? means a question."), ("Whatever."));
        }

        [TestMethod()]
        public void Prattling_on()
        {
            Assert.AreEqual(Bob.Hey("Wait! Hang on. Are you going to be OK?"), ("Sure."));
        }
        [TestMethod()]
        public void Silence()
        {
            Assert.AreEqual(Bob.Hey(""), "Fine. Be that way!");
        }
        [TestMethod()]
        public void Prolonged_silence()
        {
            Assert.AreEqual(Bob.Hey("    "), "Fine. Be that way!");
        }
        
        public void Multiple_line_question()
        {
            Assert.AreEqual(Bob.Hey("Does this cryogenic chamber make me look fat?\nno"), "Whatever.");
        }
    }
}
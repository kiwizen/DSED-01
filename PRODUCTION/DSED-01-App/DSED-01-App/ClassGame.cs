﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_01_App
{
    class BombInBoxGame
    {
        /// <summary>
        /// a Random number generator
        /// </summary>
        private Random NumGenerator { set; get; } = new Random(DateTime.Now.Millisecond);
        /// <summary>
        /// The number of Bomb Disposal Robot avialable
        /// </summary>
        public int RobotCount { set; get; } = 2;
        /// <summary>
        /// The total number of Box to be used in the game
        /// </summary>
        public int NoOfBox { private set; get; } = 6;
        /// <summary>
        /// return the current box id
        /// </summary>
        public int CurrentBoxID { private set; get; } = 1;
        /// <summary>
        /// Total number of game that the play has played so far
        /// </summary>
        //public int TotalGamePlayed { private set; get; } = 0;
        public int TotalGamePlayed { get => Win + Lose; }
        /// <summary>
        /// The box number where the bomb is.
        /// This is generated by the radom generator when a new game start.
        /// </summary>
        public int SecretBoxID { private set; get; }
        /// <summary>
        /// The game win counter
        /// </summary>
        public int Win { private set; get; } = 0;
        /// <summary>
        /// The game Lose counter
        /// </summary>
        public int Lose { private set; get; } = 0;
        /// <summary>
        /// constructor for the BombInBox class
        /// </summary>
        public BombInBoxGame()
        {
            NewGame();
        }
        /// <summary>
        /// The function is called when starting a new game.
        /// It generate a new secret box ID and reset game variable to initial value;
        /// </summary>
        public void NewGame()
        {
            // generate the secert Box ID where the bomb will be hided
            SecretBoxID = NumGenerator.Next(1, NoOfBox + 1);
            RobotCount = 2; // Default number of Robot to be 2
            CurrentBoxID = 1; // Always start from Box 1
        }
        /// <summary>
        /// Check whether the current box ID match the secret box ID. 
        ///    Return true if matched, else return false.
        /// </summary>
        /// <returns>return True when the current box ID match the secret box ID</returns>
        public bool isBomb()
        {
            return CurrentBoxID == SecretBoxID;
        }
        /// <summary>
        /// increment to the next box number.
        /// </summary>
        public void Next()
        {
            CurrentBoxID++;
        }
        /// <summary>
        /// The player won the game. Increment the game win counter.
        /// </summary>
        public void YouWon()
        {
            Win++;
        }
        /// <summary>
        /// The player lose the game. Increment the game lose counter.
        /// </summary>
        public void YouLose()
        {
            Lose++;
        }

        public int getRandomNumber(int start =1 , int end = 7)
        {
            return NumGenerator.Next(start, end + 1);
        }
    }
}

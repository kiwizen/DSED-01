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
        private Random NumGenerator { set; get; } 
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
        public int CurrentBoxID { set; get; } = 1;
        /// <summary>
        /// Total number of game that the play has played so far
        /// </summary>
        //public int TotalGamePlayed { private set; get; } = 0;
        public int TotalGamePlayed { get => Win + Lose; }
        /// <summary>
        /// The box number where the bomb is.
        /// This is generated by the radom generator when a new game start.
        /// </summary>
        public int SecretBoxID { private set; get; } = 0;
        /// <summary>
        /// The game win counter
        /// </summary>
        public int Win { private set; get; } = 0;
        /// <summary>
        /// The game Lose counter
        /// </summary>
        public int Lose { private set; get; } = 0;

        private int[] randomArray;
        public int RandomImageNo { get => this.randomArray[CurrentBoxID-1]; }
        /// <summary>
        /// constructor for the BombInBox class
        /// </summary>
        public BombInBoxGame()
        {
            NumGenerator = new Random(DateTime.Now.Millisecond);
        }

        public void GenerateRandom()
        {
            int num = CommonControlClass.ImageList.Length;
            int [] temp = new int[num];
            for (int i = 0; i < num; i++)
                temp[i] = i;
            this.randomArray = temp.OrderBy(x => NumGenerator.Next()).ToArray();
        }

        /// <summary>
        /// The function is called when starting a new game.
        /// It generate a new secret box ID and reset game variable to initial value;
        /// </summary>
        public void NewGame()
        {
            GenerateRandom();
            SecretBoxID = getRandomNumber(1, NoOfBox, SecretBoxID);
            RobotCount = 2; // Default number of Robot to be 2
            CurrentBoxID = 1; // Always start from Box 1
        }
        /// <summary>
        /// Check whether the current box ID match the secret box ID. 
        ///    Return true if matched, else return false.
        /// </summary>
        /// <returns>return True when the current box ID match the secret box ID</returns>
        public bool isMatch()
        {
            return CurrentBoxID == SecretBoxID;
        }
        /// <summary>
        /// increment to the next box number.
        /// </summary>      
        /*
        public void Next()
        {
            CurrentBoxID++;
        }
        */
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
        /// <summary>
        /// Return a random number between start and end and the number should not be the same as current number
        /// </summary>
        private int getRandomNumber(int start =1 , int end = 7, int currentNum = 0)
        {
            /*
            int num = NumGenerator.Next(start, end + 1);

            while( num == currentNum)
                num = NumGenerator.Next(start, end + 1);
            */
            int num;
            while ((num = NumGenerator.Next(start, end + 1)) == currentNum) ;

            return num;
        }

 
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_01_App
{
    class CommonControlClass
    {
        private static int _index = 0;
        private string[] _randomArray;
        public CommonControlClass()
        {
            //GenerateRandomArray();
        }

        private void GenerateRandomArray()
        {
            string[] array = { "bird", "cat", "dog", "duck", "giraffe", "guitar", "seahorse" };
            //_randomArray = array.(x => rnd.Next()).ToArray();
        }

        public static int getTabIndex() { return ++_index; }

        public static System.Drawing.Bitmap GetBoxImage()
        {
            return global::DSED_01_App.Properties.Resources.box;
        }

        public static System.Drawing.Bitmap GetBombImage()
        {
            return global::DSED_01_App.Properties.Resources.bomb;
        }

        public static string getRandom(int i)
        {
            string[] array = { "bird", "cat", "dog", "duck", "giraffe", "guitar", "seahorse" };
            if (i < array.Length)
                return array[i];
            return array[array.Length - 1];
            
        }

        public static System.Drawing.Bitmap getRandomImage(int i)
        {
            return  global::DSED_01_App.Properties.Resources.ResourceManager.GetObject(getRandom(i))
                            as System.Drawing.Bitmap;
        }
    }
}
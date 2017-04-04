using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_01_App
{
    class CommonControlClass
    {
        private static int _index = 0;
        public CommonControlClass()
        {
        }

        public static int getTabIndex() { return ++_index; }

        public static System.Drawing.Bitmap GetBoxImage()
        {
            return global::DSED_01_App.Properties.Resources.box;
        }

        public static string getRandom(int i)
        {
            string[] array = { "bird", "cats", "dog", "duck", "giraffe", "guitar", "seahorse" };
            if (i >= array.Length)
                return array[array.Length - 1];
            return array[i];
        }

        public static System.Drawing.Bitmap getRandomImage(int i)
        {
            object O = global::DSED_01_App.Properties.Resources.ResourceManager.GetObject(getRandom(i));
            return O as System.Drawing.Bitmap;
        }
    }
}

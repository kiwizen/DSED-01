using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRouletteApp
{
    class RouletteClass
    {
        private const int CHANCES = 2;

        private Random _rand;
        private int _num, _selected, _chances ;
        public int Value { get => _num; set { _num = value; } }
        public int Selected { get => _selected; set { _selected = value; } }
        public int Try { get => _chances; set { _selected = value; } }

        private int _gameCounter ;
        private int _win;
        public int Win { get => _win; }
        public int Loss { get => _gameCounter - _win ; }

        public int NumberOfGamePlayed()  {   return _gameCounter; }

        public RouletteClass()
        {
            _rand = new Random(DateTime.Now.Millisecond);
            NewGame();
        }

        public void NewGame()
        {
            _num = _rand.Next(1, 7);
            _chances = CHANCES;
        }
        public void Roll()
        {
            _selected = _rand.Next(1, 7);
        }

        public bool isShoot()
        {
            bool flag = _num == _selected;
            if (flag)
                _gameCounter++;
            return flag;
        }

        public bool isWon()
        {
            bool flag = (--_chances== 0);
            if (flag)
            {
                _win++;
                _gameCounter++;
            }

            return flag;
        }
    }
}

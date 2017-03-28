using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRouletteApp
{
    class ClassRoulette
    {
        private const int CHANCES = 2;

        private Random _rand;
        private int _num, _selected, _chances;
        public int Counter { get => _num; set { _num = value; } }
        public int Value { get => _selected; set { _selected = value; } }
        public int Try { get => _chances; set { _selected = value; } }

        private int _gameCounter;
        private int _win;
        public int Win { get => _win; }
        public int Loss { get => _gameCounter - _win; }

        public int NumberOfGamePlayed() { return _gameCounter; }

        public ClassRoulette()
        {
            _rand = new Random(DateTime.Now.Millisecond);
            NewGame();
        }
        public void NewGame()
        {
            // This is the random number to be guessed
            _selected = _rand.Next(1, 7);
            // This is the start of the counter
            _num = _rand.Next(1, 7);
            _chances = CHANCES;
        }
        public bool isShoot()
        {
            bool flag = _num == _selected;
            if (flag)
                _gameCounter++;
            return flag;
        }

        public void Next()
        {
            _num = _num % 6 + 1;
            //return _num;
        }
    }
}

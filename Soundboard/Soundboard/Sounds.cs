using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard
{
    internal class Sounds
    {
        string _name = "";
        int _minX = 0;
        int _maxX = 0;
        int _minY = 0;
        int _maxY = 0;

        public int GetMinX()
        {
            return _minX;
        }
        public void SetMinX(int input)
        {
            _minX = input;
        }
        public int GetMinY()
        {
            return _minY;
        }
        public void SetMinY(int input)
        {
            _minY = input;
        }
        public int GetMaxX()
        {
            return _maxX;
        }
        public void SetMaxX(int input)
        {
            _maxX = input;
        }
        public int GetMaxY()
        {
            return _maxY;
        }
        public void SetMaxY(int input)
        {
            _maxY = input;
        }
    }
}

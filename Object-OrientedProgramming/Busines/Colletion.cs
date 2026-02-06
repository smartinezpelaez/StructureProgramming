using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientedProgramming.Busines
{
    public class Colletion<T>
    {
        private T[] _elements;
        private int _index;
        private int _limit;

        public Colletion(int limit)
        {
            _index = 0;
            _limit = limit;
            _elements = new T[_limit];
        }

        public void Add(T element) 
        {
            if (_index < _limit)
            {
                _elements[_index] = element;
                _index++;
            }
        }
        public T[] Get()
        { 
            return _elements;
        }

    }
}

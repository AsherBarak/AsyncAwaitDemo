using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncAwait
{

    public interface IMyService
    {
        int GetInt();
    }

    public class MyService : IMyService
    {
        private int _i;
        public MyService(int i)
        {
            _i = i;
        }

        public int GetInt()
        {
            if (_i > 100)
            {
                throw new ArgumentOutOfRangeException("i", _i, "i cannot be biger than 100");
            }
            return _i;
        }
    }
}

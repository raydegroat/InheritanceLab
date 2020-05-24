using System;
using System.Text;
using System.Collections.Generic;

namespace RandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();

        public string RandomString
        {
            get
            {
                int rnd = random.Next(0, maxValue: Count);
                string remove = this[rnd];
                RemoveAt(rnd);
                return remove;
            }
        }
    }
}

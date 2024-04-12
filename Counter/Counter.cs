using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    
        public class Counter
        {
            
            int value = 0;

            // ökar räknaren med ett
            public void Increment()
            {
                value++;
            }

            // återställer värdet till noll
            public void Reset()
            {
                value = 0;
            }

            // ger värdet på räknaren
            public int GetValue()
            {
                
                return value;
            }
        }


    
}

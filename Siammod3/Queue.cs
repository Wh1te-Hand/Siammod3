using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siammod3
{
    public class Queue
    {
        byte state;
        Boolean empty = true;
        long tacts_full= 0;
        long tacts_state_1 = 0;
        long tacts_state_0 = 0;

        public Queue() {
            state = 0;
        }

        public long getCount() {
            if (state == 2){
                return 2;
            }
            else if(state == 1){
                return 1;
            }
            else return 0;
        }
        public Boolean queueState {
            get => empty;
        }
        public long tactsBlock
        {
            get => tacts_full;
        }
        public long tacts_state1
        {
            get => tacts_state_1;
        }
        public long tacts_state0
        {
            get => tacts_state_0;
        }
        public Boolean Download()
        {
            if (state == 0)
            {
                state++;
                empty = true;
                return true;
            }
            else if (state == 1)
            {
                state++;
                empty= false;
                return true;
            }
            else {
                return false;
            }
        }
        public Boolean Tact_channel1(Boolean next_channel1) {
            if (state == 0)
            {
                return false;
            }
            else
            {
                if (next_channel1)
                {
                    state--;
                    empty = true;
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public Boolean Tact_channel2(Boolean next_channel2) {
            if (state == 0)
            {
                return false;
            }
            else
            {
                if (next_channel2)
                {
                    state--;
                    empty = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Calculate_tacts()
        {
            if (state == 2)
            {
                tacts_full++;
            }
            else if (state == 1)
            {
                tacts_state_1++;
            }
            else if (state == 0)
            {
                tacts_state_0++;
            }
        }
    }
}

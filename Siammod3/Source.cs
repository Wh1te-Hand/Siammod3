using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siammod3
{
    public class Source
    {
        byte state;
        long number_generated =0;
        long tacts_block = 0;
        long tacts_state_1 = 0;
        long tacts_state_2 = 0;

        public Source() {
            state = 2;
        }
        public Boolean Block() {
            if (state == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long tactsBlock
        {
            get => tacts_block;
        }
        public long tactsFree
        {
            get => tacts_state_1+tacts_state_2;
        }
        public long numberGenerated
        {
            get => number_generated;
        }
        public Boolean Tact(Boolean queue_empty)
        {
            if (state == 2)
            {
                state--;
                return false;
            }
            else
            if (state == 1)
            {
                if (queue_empty)
                {
                    state = 2;
                    number_generated++;
                    return true;
                }
                else
                {
                    state = 0;
                    number_generated++;
                    return false;
                }
            }
            else // state==0;
            {
                if (queue_empty)
                {
                    state = 2;
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
                tacts_state_2++;
            }
            else if (state == 1)
            {
                tacts_state_1++;
            }
            else if (state == 0) {
                tacts_block++;
            }
        }
    }
}

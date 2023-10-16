using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Siammod3
{
    public class Channel
    {
        long number_processed = 0;
        double probability;
        Boolean employed;
        long tacts_busy=0;
        long tacts_free=0; 
        private Random rand = new Random();

        public Channel(double probability) { 
        this.probability = probability;
            employed = false;
        }
         public long tactsWork
        {
            get => tacts_busy;
        }
        public Boolean Busy {
            get => employed;
        }
        public long numberProcessed { 
        get=> number_processed;
        }
        public long tactsFree
        {
            get => tacts_free;
        }
        public Boolean Download() {
            if (employed)
            {
                return false;
            }
            else {
                employed = true;
                return true;
            }
        }
        public Boolean Solve() {
            if (employed)
            {                
                double var = rand.NextDouble();
                if (var < probability)
                {
                    return false;
                }
                else
                {

                    employed = false;
                    number_processed++;
                    return true;
                }
            }
            else
            return true;
        }
        public void Calculate_tacts() {
            if (employed)
            { tacts_busy++; }
            else { tacts_free++; }
        }

    }
}

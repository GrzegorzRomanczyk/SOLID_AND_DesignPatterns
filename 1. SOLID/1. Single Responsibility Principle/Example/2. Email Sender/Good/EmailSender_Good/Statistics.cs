using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender_Good
{
    public class Statistics : IStatistics
    {
        public void AddToStats(IEmailSender emailSender)
        {
            Console.WriteLine("Added to stats");
        }
    }
}

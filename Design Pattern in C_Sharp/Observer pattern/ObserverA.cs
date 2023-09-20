using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_pattern
{
    public class ObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine(subject.ToString() + "is called");
        }
    }
}

using System;

namespace Observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SubjectA subjectA = new SubjectA();
            subjectA.RegisterObserver(new ObserverA());
            subjectA.RegisterObserver(new ObserverA());
            subjectA.NotifyAllObserver();
        }
    }
}

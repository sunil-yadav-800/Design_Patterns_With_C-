﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_pattern
{
    public class SubjectA : ISubject
    {
        private List<IObserver> _observers;
        public SubjectA()
        {
            _observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyAllObserver()
        {
            foreach(var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}

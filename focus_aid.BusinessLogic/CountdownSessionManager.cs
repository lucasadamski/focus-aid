using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic
{
    public class CountdownSessionManager : ICountdownSession
    {
        public bool IsSessionActive { get; private set; }
        public int InitialSeconds { get; private set; }
        public int SecondsElapsed { get; private set; }
        public CountdownSessionManager()
        { }
        public CountdownSessionManager(int seconds)
        {
            InitialSeconds = seconds;
        }
        public bool Cancel()
        {
            throw new NotImplementedException();
        }

        public bool DelegateCountdownToUI(int seconds) // that should be in external software
        {
            throw new NotImplementedException();
        }

        public bool Pause()
        {
            throw new NotImplementedException();
        }

        public bool Start(int seconds)
        {
            throw new NotImplementedException();
        }

        public bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}

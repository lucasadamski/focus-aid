using focus_aid.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CountdownSessionManager manages Countdown, Feedbac and Report 


namespace focus_aid.BusinessLogic.Countdown
{
    public class CountdownManager : IManager
    {
        public Countdown Countdown { get; set; }
        public CountdownManager()
        { }

        public bool ReceiveDTOFromMessageBus(UiDto uiDTO)
        {
            throw new NotImplementedException();
        }

        public UiDto SendDTOToMessageBus()
        {
            throw new NotImplementedException();
        }
    }
}

using focus_aid.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic
{
    /// <summary>
    /// Talks to UI and BL. Middleman between UI and BL. 
    /// </summary>
    public class MessageBus : IMessageBus
    {
        public bool ReceiveFromUI(UIDTO countdownSessionDTO)
        {
            throw new NotImplementedException();
        }

        public UIDTO SendToUI()
        {
            throw new NotImplementedException();
        }
    }
}

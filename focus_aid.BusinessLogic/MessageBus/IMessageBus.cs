using focus_aid.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.MessageBus
{
    public interface IMessageBus
    {
        UIDTO SendToUI();
        bool ReceiveFromUI(UIDTO countdownSessionDTO);
    }
}

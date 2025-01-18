using focus_aid.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic
{
    public interface ICommunicationWithUI
    {
        CountdownSessionDTO SendToUI();
        bool ReceiveFromUI(CountdownSessionDTO countdownSessionDTO);
    }
}

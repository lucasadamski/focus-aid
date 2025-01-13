using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.DTOs
{
    public struct CountdownSessionDTO
    {
        int Seconds;
        string FeedbackMessage;
        Instruction Instruction;
    }
}

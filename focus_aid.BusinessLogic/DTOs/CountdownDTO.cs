using focus_aid.BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.DTOs
{
    public class CountdownDto : UiDto
    {
        public int Seconds { get; set; }
        public CountdownInstruction Instruction { get; set; }
    }
}

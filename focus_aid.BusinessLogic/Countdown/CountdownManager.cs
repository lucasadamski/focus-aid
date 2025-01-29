using DTO;
// CountdownSessionManager manages Countdown, Feedbac and Report 


namespace focus_aid.BusinessLogic.Countdown
{
    public class CountdownManager : IManager
    {
        public CoutdownByDelegatingToUi Countdown { get; set; }
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

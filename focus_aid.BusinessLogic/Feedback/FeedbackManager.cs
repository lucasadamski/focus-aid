using DTO;

namespace focus_aid.BusinessLogic.Feedback
{
    public class FeedbackManager : IManager
    {
        public Feedback Feedback { get; set; }
        public FeedbackManager()
        {
            
        }

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

using focus_aid.DTO;

namespace focus_aid.BusinessLogic
{
    public interface IManager
    {
        bool ReceiveDTOFromMessageBus(UiDto uiDTO);
        UiDto SendDTOToMessageBus();
    }
}

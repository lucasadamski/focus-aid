using DTO;
namespace focus_aid.BusinessLogic.Countdown
{
    public class CountdownByServer : ICountdownStrategy
    {
        public CountdownDto Cancel()
        {
            throw new NotImplementedException();
        }

        public CountdownDto Pause()
        {
            throw new NotImplementedException();
        }

        public CountdownDto Start()
        {
            return new CountdownDto() { Seconds = 0, Success = true, Message = "Test countdown successful!" };
        }

        public CountdownDto Stop()
        {
            throw new NotImplementedException();
        }
    }
}

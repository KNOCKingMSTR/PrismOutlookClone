using PrismOutlook.Services.Interfaces;

namespace PrismOutlook.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}

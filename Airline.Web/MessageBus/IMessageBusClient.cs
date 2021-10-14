using Airline.Web.Dtos;

namespace Airline.Web.MessageBus
{
    public interface IMessageBusClient
    {
        void SendMessage(NotificationMessageDto notificationMessageDto);
    }
}

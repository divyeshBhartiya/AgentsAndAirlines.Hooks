using AirlineAgentConsole.Dtos;
using System.Threading.Tasks;

namespace AirlineAgentConsole.Client
{
    public interface IWebhookClient
    {
        Task SendWebhookNotification(FlightDetailChangePayloadDto flightDetailChangePayloadDto);
    }
}

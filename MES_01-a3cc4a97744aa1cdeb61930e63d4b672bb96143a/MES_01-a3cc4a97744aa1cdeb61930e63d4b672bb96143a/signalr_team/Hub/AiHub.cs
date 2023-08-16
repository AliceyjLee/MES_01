using Microsoft.AspNetCore.SignalR;

namespace signalr_team.IoTHub
{
    public class AiHub : Hub
    {
        public async Task SendMessage1(string message)
        {
            await Console.Out.WriteLineAsync(message);
            await Clients.All.SendAsync("ReceiveAiMessage", message);
        }
    }
}

using Microsoft.AspNetCore.SignalR;

namespace WebsocketTest;
public class WSTestHub : Hub
{
    public async Task DifundirMensaje(string message)
    {
        await Clients.All.SendAsync("MensajeRecibido", message);
    }
}

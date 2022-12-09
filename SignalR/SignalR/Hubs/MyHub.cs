using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
    public class MyHub : Hub    //Hub class'ım. Bu class'a abone olan tüm clientlar class'ın metotları ile haberleşebilecek.
    {
        public async Task SendMessageAsync(string message)  //Client'tan gönderilen bir mesaj hub class'ının bu metodu ile karşılanıp hub'a abone olan tüm client'lara dağıtılacak.
        {
            await Clients.All.SendAsync("receiveMessage",message);  //rpc ile client'ta ismini yazdığımız function'u çağırıp client'ın gönderdiği mesajı bunlara gönder
        }
    }
}

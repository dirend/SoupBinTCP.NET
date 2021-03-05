using SoupBinTCP.NET;
using SoupBinTCP.NET.Messages;
using System;
using System.Threading.Tasks;

namespace Client
{
    public class ClientListener : IClientListener
    {
        public async Task OnConnect()
        {
            Console.WriteLine($"OnConnect ");
            await Task.FromResult(false);
        }

        public async Task OnMessage(byte[] message)
        {
            Console.WriteLine($"OnMessage {message.Length}");
            await Task.FromResult(false);
        }

        //public async Task OnMessage(OUCHMessage message)
        //{
        //    // TODO Log

        //    // TODO switch

        //    await Task.FromResult(false);
        //}

        public async Task OnLoginAccept(string session, ulong sequenceNumber)
        {
            Console.WriteLine($"OnLoginAccept {session}");
            await Task.FromResult(false);
        }

        public async Task OnLoginReject()
        {
            Console.WriteLine($"OnLoginReject");
            await Task.FromResult(false);
        }

        public async Task OnDisconnect()
        {
            Console.WriteLine($"OnDisconnect");
            await Task.FromResult(false);
        }

        public Task OnDebug(string message)
        {
            Console.WriteLine($"OnDebug {message}");
            return Task.FromResult(false);
        }

        public Task OnLoginReject(char rejectReasonCode)
        {
            Console.WriteLine($"OnLoginReject {rejectReasonCode}");
            return Task.FromResult(false);
        }


    }
}

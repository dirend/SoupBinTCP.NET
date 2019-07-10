﻿using DotNetty.Transport.Channels;
using SoupBinTCP.NET.Messages;

namespace SoupBinTCP.NET.Handlers
{
    internal class ClientHandler : ChannelHandlerAdapter
    {
        private readonly IClientListener _listener;
        private readonly LoginDetails _loginDetails;

        public ClientHandler(LoginDetails loginDetails, IClientListener listener)
        {
            _listener = listener;
            _loginDetails = loginDetails;
        }
        
        public override void ChannelRead(IChannelHandlerContext context, object message)
        {
            switch (message)
            {
                case Debug msg:
                    _listener.OnDebug(msg.Text);
                    break;
                case LoginAccepted msg:
                    _listener.OnLoginAccept(msg.Session, msg.SequenceNumber);
                    break;
                case LoginRejected msg:
                    _listener.OnLoginReject(msg.RejectReasonCode);
                    break;
                case SequencedData msg:
                    _listener.OnMessage(msg.Message);
                    break;
            }
        }

        //public override void ChannelReadComplete(IChannelHandlerContext context) => context.Flush();

        public override void ChannelActive(IChannelHandlerContext context)
        {
            _listener.OnConnect();
            context.WriteAndFlushAsync(new LoginRequest(_loginDetails.Username, _loginDetails.Password,
                _loginDetails.RequestedSession, _loginDetails.RequestedSequenceNumber));
        }

        public override void ChannelInactive(IChannelHandlerContext context)
        {
            _listener.OnDisconnect();
        }
    }
}
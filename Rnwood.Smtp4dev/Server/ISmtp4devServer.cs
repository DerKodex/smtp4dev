using System;
using System.Net;
using System.Threading.Tasks;
using MimeKit;
using Rnwood.Smtp4dev.DbModel;

namespace Rnwood.Smtp4dev.Server
{
    public interface ISmtp4devServer
    {
        RelayResult TryRelayMessage(Message message, MailboxAddress[] overrideRecipients);
        Exception Exception { get; }
        bool IsRunning { get; }
        public IPEndPoint[] ListeningEndpoints { get;  }
        void TryStart();
        void Stop();
        Task DeleteSession(Guid id);
        Task DeleteAllSessions();
    }
}
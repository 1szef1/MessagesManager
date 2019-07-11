using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesManager.Api.Interfaces
{
    public interface IApiMsgSender
    {
        bool Send(IApiMsg msg);
        Task<bool> SendAsync(IApiMsg msg);
    }
}

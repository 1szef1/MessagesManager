using MessagesManager.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MessagesManager.Services
{
    class SenderService : IApiMsgSender
    {
        public bool Send(IApiMsg msg)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SendAsync(IApiMsg msg)
        {
            return await Task.Run(async () => 
            {
                await Task.Delay(2500);
                return true;
            });
        }
    }
}

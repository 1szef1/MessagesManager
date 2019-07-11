using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesManager.Api.Interfaces
{
    public interface IApiMsg
    {
        int Id { get; set; }
        string Content { get; set; }
        bool Favorite { get; set; }
        string IconName { get; set; }
        bool NeedConfirm { get; set; }
        int Duration { get; set; }
    }
}

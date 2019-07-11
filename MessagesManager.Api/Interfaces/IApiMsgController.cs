using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesManager.Api.Interfaces
{
    public interface IApiMsgController
    {
        IList<IApiMsg> GetList();
        Task<IList<IApiMsg>> GetListAsync();

        IApiMsg Get(int id);
        Task<IApiMsg> GetAsync(int id);

        void Add(IApiMsg msg);
        Task AddAsync(IApiMsg msg);

        int Update(IApiMsg msg);
        Task<int> UpdateAsync(IApiMsg msg);

        int Remove(IApiMsg msg);
        Task<int> RemoveAsync(IApiMsg msg);
    }
}

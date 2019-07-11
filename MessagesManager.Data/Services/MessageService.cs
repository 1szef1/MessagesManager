using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MessagesManager.Api.Interfaces;
using MessagesManager.Data.Model;

namespace MessagesManager.Data.Services
{
    public class MessageService : IApiMsgController
    {
        private readonly SQLiteConnection _connection;

        #region Konstruktory

        public MessageService()
        {
            _connection = MsgContext.DbConnection;
        }

        public MessageService(SQLiteConnection connection)
        {
            _connection = connection;
        }

        #endregion

        #region Modyfikacja danych

        public IApiMsg Get(int id)
        {
            return _connection.Query<WndMessage>(GetQuery(), new { Id = id }).FirstOrDefault();
        }

        public async Task<IApiMsg> GetAsync(int id)
        {
            return (await _connection.QueryAsync<WndMessage>(GetQuery(), new { Id = id })).FirstOrDefault();
        }

        public IList<IApiMsg> GetList()
        {
            return _connection.Query<WndMessage>(GetListQuery()).ToList<IApiMsg>();
        }

        public async Task<IList<IApiMsg>> GetListAsync()
        {
            return (await _connection.QueryAsync<WndMessage>(GetListQuery())).ToList<IApiMsg>();
        }

        public async Task<IList<IApiMsg>> GetFavoriteList()
        {
            return (await GetListAsync()).Where(x => x.Favorite == true).ToList();
        }

        public void Add(IApiMsg msg)
        {
            try
            {
                _connection.Open();
                _connection.Execute(InsertQuery(), new
                {
                    msg.Content,
                    msg.Favorite,
                    msg.IconName,
                    msg.NeedConfirm,
                    msg.Duration
                });

                msg.Id = (int)_connection.LastInsertRowId;
            }
            finally
            {
                _connection.Close();
            }
        }

        public async Task AddAsync(IApiMsg msg)
        {
            try
            {
                _connection.Open();
                await _connection.ExecuteAsync(InsertQuery(), new
                {
                    msg.Content,
                    msg.Favorite,
                    msg.IconName,
                    msg.NeedConfirm,
                    msg.Duration
                });

                msg.Id = (int)_connection.LastInsertRowId;
            }
            finally
            {
                _connection.Close();
            }
        }

        public int Update(IApiMsg msg)
        {
            try
            {
                _connection.Open();
                return _connection.Execute(UpdateQuery(), new
                {
                    msg.Content,
                    msg.Favorite,
                    msg.IconName,
                    msg.NeedConfirm,
                    msg.Duration,
                    msg.Id
                });
            }
            finally
            {
                _connection.Close();
            }
        }

        public async Task<int> UpdateAsync(IApiMsg msg)
        {
            try
            {
                _connection.Open();
                return await _connection.ExecuteAsync(UpdateQuery(), new
                {
                    msg.Content,
                    msg.Favorite,
                    msg.IconName,
                    msg.NeedConfirm,
                    msg.Duration,
                    msg.Id
                });
            }
            finally
            {
                _connection.Close();
            }
        }

        public int Remove(IApiMsg msg)
        {
            try
            {
                _connection.Open();
                return _connection.Execute(RemoveQuery(), new
                {
                    msg.Id
                });
            }
            finally
            {
                _connection.Close();
            }
        }

        public async Task<int> RemoveAsync(IApiMsg msg)
        {
            try
            {
                _connection.Open();
                return await _connection.ExecuteAsync(RemoveQuery(), new
                {
                    msg.Id
                });
            }
            finally
            {
                _connection.Close();
            }
        }

        #endregion

        #region Zapytania

        private string GetQuery()
        {
            return $"select * from {nameof(WndMessage)} where Id = @id";
        }

        private string GetListQuery()
        {
            return $"select * from {nameof(WndMessage)}";
        }

        private string InsertQuery()
        {
            return $"insert into {nameof(WndMessage)} " +
                $"({nameof(WndMessage.Content)}, " +
                $"{nameof(WndMessage.Favorite)}, " +
                $"{nameof(WndMessage.IconName)}, " +
                $"{nameof(WndMessage.NeedConfirm)}," +
                $"{nameof(WndMessage.Duration)}) " +
                $"values (@Content, @Favorite, @IconName, @NeedConfirm, @Duration);";
        }

        private string UpdateQuery()
        {
            return $"update {nameof(WndMessage)} set " +
                $"{nameof(WndMessage.Content)} = @Content, " +
                $"{nameof(WndMessage.Favorite)} = @Favorite, " +
                $"{nameof(WndMessage.IconName)} = @IconName, " +
                $"{nameof(WndMessage.NeedConfirm)} = @NeedConfirm, " +
                $"{nameof(WndMessage.Duration)} =  @Duration " +
                $"where {nameof(WndMessage.Id)} = @Id;";
        }

        private string RemoveQuery()
        {
            return $"delete from {nameof(WndMessage)} " +
                $"where {nameof(WndMessage.Id)} = @Id;";
        }

        #endregion
    }
}

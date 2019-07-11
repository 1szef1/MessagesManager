using Dapper;
using MessagesManager.Data.Model;
using System.Data.SQLite;
using System.IO;

namespace MessagesManager.Data
{
    public class MsgContext 
    {
        public static string DbName => "data.sqlite";

        public static string ConnectionString
        {
            get
            {
                return new SQLiteConnectionStringBuilder()
                {
                    DataSource = DbName,
                }.ConnectionString;
            }
        }

        public static SQLiteConnection DbConnection { get; private set; }

        public static void CreateAndInitDb()
        {
            DbConnection = new SQLiteConnection(ConnectionString);

            if (!File.Exists(DbName))
            {
                SQLiteConnection.CreateFile(DbName);
                SeedDatabase();
            }
        }

        private static void SeedDatabase()
        {
            DbConnection.Execute(
                $"create table if not exists {nameof(WndMessage)} (" +
                $"{nameof(WndMessage.Id)} integer not null primary key autoincrement," +
                $"{nameof(WndMessage.Content)} text not null," +
                $"{nameof(WndMessage.Favorite)} bit," +
                $"{nameof(WndMessage.IconName)} varchar(100)," +
                $"{nameof(WndMessage.NeedConfirm)} bit," +
                $"{nameof(WndMessage.Duration)} int)");
        }
    }
}

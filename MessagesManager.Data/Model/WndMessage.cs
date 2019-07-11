using MessagesManager.Api.Interfaces;

namespace MessagesManager.Data.Model
{
    public class WndMessage : IApiMsg
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Favorite { get; set; }
        public string IconName { get; set; }
        public bool NeedConfirm { get; set; }
        public int Duration { get; set; }
    }
}

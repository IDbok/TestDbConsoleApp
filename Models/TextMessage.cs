
namespace TeleBot.Models
{
    public class TextMessage
    {
        public int TextMessageId { get; set; }
        public User User { get; set; }
        public long UserId { get; set; }
        public long ChatId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public DateTime? EditDate { get; set; }

        public TextMessage()
        {
            
        }
        
    }
}

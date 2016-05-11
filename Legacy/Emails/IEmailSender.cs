using System.Text;

namespace Legacy.Emails
{
	public class EmailMessage
	{
		public string Subject;
		public StringBuilder Body = new StringBuilder();
		public bool Important;

		public override string ToString()
		{
			return $"Subject: {Subject}, Important: {Important}\r\n{Body}";
		}
	}

	public interface IEmailSender
	{
		void SendMessage(EmailMessage message);
	}
}
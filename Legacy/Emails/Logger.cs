using System;

namespace Legacy.Emails
{
	public class Logger
	{
		public void Log(string message)
		{
			// Тут какой-то код, который трудно заставить работать в тестовом окружении
			throw new Exception("Logging is not configured");
		}
	}
}
using System;

namespace Legacy.Emails
{
	public class Logger
	{
		public void Log(string message)
		{
			// ��� �����-�� ���, ������� ������ ��������� �������� � �������� ���������
			throw new Exception("Logging is not configured");
		}
	}
}
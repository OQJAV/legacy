using FakeItEasy;
using NUnit.Framework;

namespace Legacy.ProviderProcessing
{
	[TestFixture]
	public class ProviderProcessor_should
	{
		private ProviderRepository repo;
		private ProviderProcessor processor;

		[SetUp]
		public void SetUp()
		{
			repo = A.Fake<ProviderRepository>();
			processor = new ProviderProcessor(repo);
		}

		[Test]
		public void Ignore_OutdatedData()
		{
		}

		[Test]
		public void SaveData_ForNewProvider()
		{

		}

		[Test]
		public void FailWithDetailedInfo_OnValidationErrors()
		{

		}
	}
}
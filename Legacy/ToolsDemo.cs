using ApprovalTests;
using ApprovalTests.Reporters;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace Legacy
{
	[TestFixture]
	public class ToolsDemo
	{
		[Test]
		public void Puzzle15_InitialState()
		{
			var puzzle15 = new Puzzle15();
			// TODO assert
		}
		[Test]
		[UseReporter(typeof(DiffReporter))]
		public void Puzzle15_MoveRight()
		{
			var puzzle15 = new Puzzle15();
			puzzle15.MoveRight();
			// TODO assert
		}

		[Test]
		[UseReporter(typeof(DiffReporter))]
		public void ApproveProductDataWithStateprinter()
		{
			var product = new Product
			{
				Id = Guid.Empty,
				Name = "Name",
				Price = 3.14m,
				UnitsCode = "112"
			};
			//TODO Verify product
			//TODO Exclude TemporaryData
			Approvals.Verify(product);
		}

		[Test]
		[UseReporter(typeof(DiffReporter))]
		public void ProductData_IsJsonSerializable()
		{
			Product original = new Product
			{
				Id = Guid.Empty,
				Name = "Name",
				Price = 3.14m,
				UnitsCode = "112",
				TemporaryData = "qwe"
			};
			string serialized = JsonConvert.SerializeObject(original);
			Product deserialized = JsonConvert.DeserializeObject<Product>(serialized);
			//TODO проверить, что сериализуется корректно!
		}
	}

	public class Product
	{
		public Guid Id { get; set; }
		[JsonIgnore]
		public string TemporaryData { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string UnitsCode { get; set; }
	}

}
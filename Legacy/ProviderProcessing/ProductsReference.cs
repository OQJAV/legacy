using System;

namespace Legacy.ProviderProcessing
{
	public class ProductsReference
	{
		private static ProductsReference instance;

		public static ProductsReference GetInstance()
		{
			return instance ?? (instance = LoadReference());
		}
		public static ProductsReference LoadReference()
		{
			throw new NotImplementedException("Долгая-долгая инициализация справочника.");
		}

		public virtual int? FindCodeByName(string name)
		{
			throw new NotImplementedException("Работа со справочником");
		}

		public static void SetTestingInstance(ProductsReference fake)
		{
			instance = fake;
		}

		// Прочие методы

	}
}
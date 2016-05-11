using System;

namespace Legacy.ProviderProcessing
{
	public class UnitsReference
	{
		private static UnitsReference instance;
		public static UnitsReference GetInstance()
		{
			return instance ?? (instance = LoadReference());
		}
		public static UnitsReference LoadReference()
		{
			throw new NotImplementedException("Долгая-долгая инициализация справочника.");
		}

		public virtual MeasureUnit FindByCode(string unitsCode)
		{
			throw new NotImplementedException("Работа со справочником");
		}

		// Прочие методы

		public static void SetTestingInstance(UnitsReference fake)
		{
			instance = fake;
		}
	}
}
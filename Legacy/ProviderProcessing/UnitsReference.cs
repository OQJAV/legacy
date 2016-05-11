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
			throw new NotImplementedException("������-������ ������������� �����������.");
		}

		public virtual MeasureUnit FindByCode(string unitsCode)
		{
			throw new NotImplementedException("������ �� ������������");
		}

		// ������ ������

		public static void SetTestingInstance(UnitsReference fake)
		{
			instance = fake;
		}
	}
}
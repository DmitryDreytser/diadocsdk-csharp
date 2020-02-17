using Diadoc.Api.Proto;

namespace Diadoc.Api
{
	public partial class DiadocHttpApi
	{
		public RussianAddress ParseRussianAddress(string address)
		{
			var queryString = string.Format("/ParseRussianAddress?address={0}", address);
			return PerformHttpRequest<RussianAddress>(null, "GET", queryString);
		}
	}
}

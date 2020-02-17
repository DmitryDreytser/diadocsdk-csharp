using System.Threading.Tasks;
using Diadoc.Api.Proto;

namespace Diadoc.Api
{
	public partial class DiadocHttpApi
	{
		public Task<RussianAddress> ParseRussianAddressAsync(string address)
		{
			var queryString = $"/ParseRussianAddress?address={address}";
			return PerformHttpRequestAsync<RussianAddress>(null, "GET", queryString);
		}
	}
}

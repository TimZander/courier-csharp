using Polly;
using RestSharp;

namespace Com.Courier.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public class RetryConfiguration
    {
		/// <summary>
		/// Retry policy
		/// </summary>
		public static Policy<RestResponse> RetryPolicy { get; set; }

		/// <summary>
		/// Async retry policy
		/// </summary>
		public static AsyncPolicy<RestResponse> AsyncRetryPolicy { get; set; }
	}
}

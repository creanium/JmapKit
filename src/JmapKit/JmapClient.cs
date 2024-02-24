using Ardalis.GuardClauses;

namespace JmapKit;

/// <summary>
/// A client to use to connect to a JMAP endpoint
/// </summary>
public class JmapClient
{
	private readonly IHttpClientFactory _httpClientFactory;
	private Uri? _endpoint;
	private string? _username;
	private string? _password;

	public JmapClient(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}

	public void Connect(Uri endpoint, string username, string password)
	{
		Guard.Against.Null(endpoint);
		Guard.Against.Null(username);
		Guard.Against.Null(password);
		
		_endpoint = endpoint;
		_username = username;
		_password = password;
		
		using var client = _httpClientFactory.CreateClient();
	}
}

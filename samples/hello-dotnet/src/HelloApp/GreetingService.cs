using System.Reflection.Metadata;

namespace HelloApp;

public static class GreetingService
{
	private const string DEFAULT_NAME = "world";
	private const string GREETING_TEMPLATE = "Hello, {0}!";

	public static string SayHello(string? name)
	{
		return string.Format(GREETING_TEMPLATE, name?.Trim() ?? DEFAULT_NAME);
	}
}

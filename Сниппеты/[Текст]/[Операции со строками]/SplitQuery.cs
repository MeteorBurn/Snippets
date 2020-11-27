public static Dictionary<string, string> SplitQuery(this string query)
{
	var dic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
	var paramsEncoded = query.TrimStart('?').Split("&");
	foreach (var paramEncoded in paramsEncoded)
	{
		var param = WebUtility.UrlDecode(paramEncoded);

		// Look for the equals sign
		var equalsPos = param.IndexOf('=');
		if (equalsPos <= 0)
			continue;

		// Get the key and value
		var key = param.Substring(0, equalsPos);
		var value = equalsPos < param.Length
			? param.Substring(equalsPos + 1)
 			: string.Empty;

		// Add to dictionary
		dic[key] = value;
	}

	return dic;
}
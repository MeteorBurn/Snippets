public static bool IsValidJson(string supposedJsonString)
{
	supposedJsonString = supposedJsonString.Trim();
	if ((supposedJsonString.StartsWith("{") && supposedJsonString.EndsWith("}")) || //For object
		(supposedJsonString.StartsWith("[") && supposedJsonString.EndsWith("]"))) //For array
		{
			try
			{
				var obj = JToken.Parse(supposedJsonString);
				return true;
			}
			catch (JsonReaderException jex)
			{
				//Exception in parsing json
				Console.WriteLine(jex.Message);
				return false;
			}
			catch (Exception ex) //some other exception
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}

		return false;
}
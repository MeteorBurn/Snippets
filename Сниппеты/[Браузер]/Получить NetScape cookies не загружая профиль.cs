// Получить cookies в формате NetScape из ZP Profile не загружая сам профиль

// Добавить в GAC System.IO.Compression
// Добавить using System.IO.Compression;

string profilePath = "profile path here";

using(var file = File.OpenRead(profilePath))
using(var zip = new ZipArchive(file, ZipArchiveMode.Read))
{
	foreach(var entry in zip.Entries)
	{
		if (entry.FullName == "profilecookie.zpcookie")
		{
			using(var stream = entry.Open())
			{
				using (var reader = new StreamReader(stream))
				{
					string cookiesString = reader.ReadToEnd();
					
					// обработка полученныйх NetScape cookies
				}
			}
		}
	}
}
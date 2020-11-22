// получение кук из ПОСТ / ГЕТ запроса и приображение в строчку с разделителем

string get_cookie = project.Variables["ИМЯ_ПЕРЕМЕННОЙ_ОТ_КУДА_НАДО_ВЗЯТЬ"].Value;
var Cookie = string.Join("; ", Regex.Matches(get_cookie, @"(?<=Set-Cookie:\ ).*?(?=;)").Cast<Match>().Select(x=>x.Value));
return Cookie;
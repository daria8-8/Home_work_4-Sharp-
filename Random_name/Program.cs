Console.Write("Введите имена: ");
string names = Console.ReadLine()?? "0";
string[] separator = { ",", " " };
string[] words = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);
Random rnd = new Random();
string name = words[rnd.Next(words.Length)];
Console.WriteLine(name);
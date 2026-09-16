Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

Console.WriteLine();
Console.WriteLine("Границы дробных типов");
Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");

Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter;
Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
Console.WriteLine($"Табуляция:\tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");

Console.WriteLine();
Console.WriteLine("decimal против double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20;
var gpa = 4.75;
var fullName = "Смирнова А.С.";

Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

Console.WriteLine();
Console.WriteLine("Введите текста");

Console.Write("Введите ваше имя: ");
string enteredName = Console.ReadLine();

Console.Write("Введите название вашей группы: ");
string enteredGroup = Console.ReadLine();

Console.Write($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");

Console.Write("Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();

int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);

Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse: {birthYearParse}");
Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");

Console.Write("Введите количество прочитанных книг за семестр: ");
string booksInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {booksCount}");

Console.WriteLine();
Console.WriteLine("Анкета студента");

Console.Write("Введите своё имя и фамилию: ");
string NameSurname = Console.ReadLine();
Console.Write("Введите группу: ");
string group = Console.ReadLine();
Console.Write("Введите год рождения: ");
string god = Console.ReadLine();
int.TryParse(god, out int godlet);
Console.Write("Введите средний балл: ");
string srdn = Console.ReadLine();
double.TryParse(srdn.Replace('.', ','), out double srdnNum);
Console.Write("Введите любимую букву: ");
string bukva = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"   Анкета");
Console.WriteLine($"{NameSurname} , {group}");
Console.WriteLine($"Год рождения: {godlet} (в 2030 году вам будет {2030 - godlet}) ");
Console.WriteLine($"Средний балл: {srdnNum}");
Console.WriteLine($"Балл: {srdnNum >= 4.6}");
Console.WriteLine($"Любимая буква: {bukva}");


Console.WriteLine();
Console.WriteLine("Разбор ФИО через char");

Console.Write("Введите Имя: ");
string Name = Console.ReadLine();
Console.Write("Введите Фамилию: ");
string Famil = Console.ReadLine();

char firstName = Name[0];
Console.WriteLine($"{Famil} {firstName}.");
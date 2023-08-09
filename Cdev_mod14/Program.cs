using System.Threading.Channels;

namespace Cdev_mod14
{

        class Program
        {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            int pageCount = phoneBook.Count / 2 + phoneBook.Count % 2;
            var sortedPhonebook = from entry in phoneBook
                                  orderby entry.Name, entry.LastName
                                  select entry;

            while (true)
            {
                Console.Write("Укажите номер страницы: ");
                char input = Console.ReadKey().KeyChar;
                bool parseResult = Int32.TryParse(input.ToString(), out int page);

                if (!parseResult || page < 1 || page > pageCount)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка: Такой страницы не существует");
                }
                else
                {
                    var pageContent = sortedPhonebook.Skip((page - 1) * 2).Take(2);
                    Console.WriteLine();

                    Console.Clear();
                    Console.WriteLine($"Текущая страница: {page}");
                    foreach (var entry in pageContent)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);

                    Console.WriteLine();
                }
            }
            }
        }
       
  
}
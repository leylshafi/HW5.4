using HW5._4.Exceptions;
using HW5._4.Models;
using System.Text.RegularExpressions;

namespace HW5._4
{
    internal class Program
    {
        public static List<Library> libraries;
        public static List<Category> categories;
        public static List<Book> books;
        static void Main(string[] args)
        {
            libraries = new List<Library>();
            categories = new List<Category>();
            books = new List<Book>();
            Menu();

        }
        public static void Menu()
        {
            Console.WriteLine(@"======= ANA MENYU =======
[1] New Library
[2] New Category
[3] New Book
[4] Enter Library
[5] Exit
");
            Console.Write(">>> ");
            int.TryParse(Console.ReadLine(), out int choice);
            Choose(choice);
        }

        public static void Choose(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter library name: ");
                    Console.Write(">>> ");
                    try
                    {
                        string name = Console.ReadLine();
                        if (Format(ref name) != "")
                        {
                            Library library = new Library(name);
                            libraries.Add(library);
                            Console.WriteLine("Library created successfully");
                        }
                        else
                        {
                            throw new WrongInputException("Incorrect input");
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Choose(1);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter category name: ");
                    Console.Write(">>> ");
                    try
                    {
                        string categoryName = Console.ReadLine();
                        if (Format(ref categoryName) != "")
                        {
                            Category category = new Category(categoryName);
                            categories.Add(category);
                            Console.WriteLine($"{category} Created");
                        }
                        else
                        {
                            throw new WrongInputException("Wrong format, Try again");
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Choose(2);
                    }
                    break;
                case 3:
                    if (categories.Count > 0)
                    {
                        try
                        {
                            Console.WriteLine("Enter Book name: ");
                            Console.Write(">>> ");
                            string bookName = Console.ReadLine();
                            if (books.Any(x => x.Name == bookName))
                                throw new BookAlreadyExistsException("This book already exists");
                            if (Format(ref bookName) != "")
                            {
                                Console.WriteLine("Enter Author name: ");
                                Console.Write(">>> ");
                                string authorName = Console.ReadLine();
                                if (Format(ref authorName) != "")
                                {
                                    Console.WriteLine("Choose category: ");
                                    foreach (Category cat in categories)
                                    {
                                        Console.WriteLine(cat);
                                    }
                                    try
                                    {
                                        int.TryParse(Console.ReadLine(), out int catId);
                                        if (!categories.Any(c => c.Id == catId))
                                        {
                                            throw new CategoryNotFoundException("There is no such category found");
                                        }
                                        else
                                        {
                                            Book book = new Book(bookName, authorName, catId);
                                            books.Add(book);
                                            Console.WriteLine($"{book} Created");
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    
                                }
                                else
                                {
                                    throw new WrongInputException();
                                    
                                }

                            }
                            else
                            {
                                throw new WrongInputException();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else Console.WriteLine("There is no category to create a book");
                    break;
                case 4:
                    if (libraries.Count > 0)
                    {
                        Console.WriteLine("Enter library");
                        foreach (Library lib in libraries)
                        {
                            Console.WriteLine(lib);
                        }
                        Console.Write(">>> ");
                        int.TryParse(Console.ReadLine(), out int libId);
                        try
                        {
                            if (!libraries.Any(c => c.Id == libId))
                            {
                                throw new LibraryNotFoundException();
                            }
                            else
                            {
                                Library lib = libraries.Find(l => l.Id == libId);

                                LibraryMenu(lib);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                    }
                    else Console.WriteLine("There is no library to enter");
                    break;
                case 5:
                    Console.WriteLine("Good bye");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    Menu();
                    break;
            }

            Menu();
        }

        public static string Format(ref string text)
        {
            text = text.Trim();
            char firstLetter = text[0];
            string temp = text.Substring(1).ToLower();
            text = Char.ToUpper(firstLetter) + temp;

            Regex rg = new Regex("^[A-Z][a-z]+(\\s[A-Z]?[a-z]+)*$");
            if (rg.IsMatch(text))
                return text;
            else return string.Empty;
        }

        public static void LibraryMenu(Library library)
        {
            Console.WriteLine(@"======= LIBRARY MENYU =======
[1] New Book
[2] Show Books
[3] Exit
");
            Console.Write(">>> ");
            int.TryParse(Console.ReadLine(), out int choice);
            ChooseMethod(choice, library);
        }

        private static void ChooseMethod(int choice, Library library)
        {
            switch (choice)
            {
                case 1:
                    if (books.Count > 0)
                    {
                        try
                        {
                            foreach (var item in books)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("Choose book: ");
                            Console.Write(">>> ");
                            int.TryParse(Console.ReadLine(), out int bookId);
                            if (!books.Any(c => c.Id == bookId))
                            {
                                throw new BookNotFoundException("No book exists like this");
                            }
                            else
                            {
                                Book book = books.Find(l => l.Id == bookId);
                                library.AddBook(book);
                                Console.WriteLine($"{book} Added");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else Console.WriteLine("There is no book to add");
                    break;
                case 2:
                    library.ListAllBooks();
                    break;
                case 3:
                    Menu();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    LibraryMenu(library);
                    break;
            }

            LibraryMenu(library);
        }
    }
}

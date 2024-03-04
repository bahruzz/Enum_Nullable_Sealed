//using Enum_Struct_Sealed.Helpers.Extensions;

//string str = "Salam425";

////Console.WriteLine(str.CheckTextWithRegex());
//Console.WriteLine(str.CheckTextWithRegex(@"[A-Z]"));

using Enum_Struct_Sealed;

//Book book = new Book();
//book.Name = "Bahruz";
//Console.WriteLine(book.Name);

//Class1 class1 = new Class1();
//class1.MyProperty = 100;
//Console.WriteLine(class1.MyProperty);

//int? num = null;
//Console.WriteLine(book.Id);
//if(book.Id ==null)
//{
//    Console.WriteLine("Book Id not found");
//}

//Book book1 = new Book()
//{
//    Id = 1,
//    Name = "Isgendarname",
//    Author=new Author() { Name="Nizami",Id=2}
//};

//Book book2 = new Book()
//{
//    Id = 2,
//    Name = "Xosrov ve Shirin",
//};

//Console.WriteLine("Book:" +book1.Name+ "  " + "Author:"+book1.Author.Name);

//Console.WriteLine("Book:" + book2.Name + "  " + "Author:" + book2.Author?.Name);

//Book[] array = { book1, book2 };

//void GetBookById(Book [] array,int? id =null)
//{
//    if (id == null)
//    {
//        Console.WriteLine("Your id is null");
//        return;
//    }

//   Book result=array.FirstOrDefault(m => m.Id == id);
//    Console.WriteLine(result.Name);


//}

//GetBookById(array,2);

//Level level = Level.Low;
//Console.WriteLine(level);
//Console.WriteLine((int)level==1);

//void GetLevel(int LevelNum)
//{
//    switch (LevelNum)
//    {
//        case (int)Level.Low:
//            Console.WriteLine("Low");
//            break;
//        case (int)Level.Medium:
//            Console.WriteLine("Medium");
//            break;
//        case (int)Level.High:
//            Console.WriteLine("High");
//            break;
//        default:
//            break;

//    }
//}
//GetLevel(2);


//void GetLevel(string level)
//{
//    switch (level)
//    {
//        case nameof(Level.Low):
//            Console.WriteLine("Low");
//            break;
//        case nameof(Level.Medium):
//            Console.WriteLine("Medium");
//            break;
//        case nameof(Level.High):
//            Console.WriteLine("High");
//            break;
//        default:
//            Console.WriteLine("Telefonu yere qoy Elmir bey");
//            break;

//    }
//}
//GetLevel("asdsfsd");
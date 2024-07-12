using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("A Great Book");
        
        Console.WriteLine(book1.GetBook());

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Jones");
        book2.SetTitle("A Wonderful Picture");
        book2.SetIllustrator("Miwa");

        Console.WriteLine(book2.GetPictureBook());

        Book book3 = new Book("Stephe King","The Mist");
        Console.WriteLine(book3.GetBook());

        PictureBook book4 = new PictureBook("Sui Ishida", "Tokyo Ghoul", "Sui Ishida");
        Console.WriteLine(book4.GetPictureBook());
    }
}
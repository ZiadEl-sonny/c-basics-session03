using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
            //  both title and upperTitle to show that title did not change.


            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);




            #endregion

            #region Question 2
            //            Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals()
            //to check if they point to the same object in memory.


            //string Var1 = "clean code ";
            //string Var2 = "clean code ";
            //Console.WriteLine(ReferenceEquals(Var1, Var2));


            #endregion

            #region Question 3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.

            //StringBuilder bookList = new StringBuilder();
            //bookList.Append("Book List");
            //bookList.Append( " -Update");
            //Console.WriteLine(bookList);



            #endregion

            #region Question 4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.

            //StringBuilder bookList = new StringBuilder();

            //bookList.Append("Book List");
            //bookList.Append(" -Update");

            //bookList.Replace("Book List", "library");
            //Console.WriteLine(bookList);

            #endregion

            #region Question 5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            // Pages: 464" using the + operator.

            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book: " + title + ", Pages:" + pages);

            #endregion

            #region Question 6
            // Build the same sentence as above, but using string interpolation ($"...").

            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine($"Book: {title}, Pages: {pages}");
            #endregion

            #region Question 7
            //Build the same sentence again, but using string.Format().

            //string title = "Clean Code";
            //int pages = 464;


            //string Sentence = string.Format("Book: {0}, Pages: {1}",title,pages);
            //Console.WriteLine(Sentence);

            #endregion

            #region Question 8
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            //300, otherwise prints "Short Book".

            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine(" Long Book");
            //}
            //else { Console.WriteLine("Short Book");
            //}
            #endregion

            #region Question 9
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            //greater than 300 and isAvailable is true.Use the && operator.

            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable) {
            //    Console.WriteLine("You can borrow this book");

            //}

            #endregion

            #region Question 10
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            //string title = "Refactoring";
            //if (title == "Claen Code")
            //{
            //    Console.WriteLine("Great Choice!");
            //}
            //else if (title == "Refactoring")
            //{
            //    Console.WriteLine("Nice Pick!");

            //}
            //else { Console.WriteLine("Never heard of it"); }

            #endregion

            #region Question 11
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            //variable sizeLabel(same rule as question 8: long if pages > 300).

            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);

            #endregion

            #region Question 12
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            //to print each book with its position number, like 1.Clean Code.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < books.Length; i++) {
            //    Console.WriteLine ($"{i+1}.{books[i]}");

            //}


            #endregion

            #region Question 13
            //Using the same books array, use a while loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine($"{i + 1}.{books[i]}");
            //    i++;
            //}

            #endregion

            #region Question 14
            //Write a do-while loop that prints "Checking book..." exactly 3 times.

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //} while (i < 3);

            #endregion

            #region Question 15
            //Using the same books array, use a foreach loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books) {
            //    Console.WriteLine(book);
            //}

            #endregion

            #region Question 16
            //Using the same books array, loop through it and print each title, but stop completely (break) once
            //you reach "Refactoring".

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{

            //    if (books[i] == "Refactoring")
            //        break;

            //    Console.WriteLine($"{i + 1}.{books[i]}");

            //}
            #endregion

            #region Question 17
            //Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
            //continue, don't stop the loop).
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")  
            //        continue; 

            //    Console.WriteLine(books[i]);
            //}

            #endregion

            #region Question 18
            //Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
            //use return to exit the method early instead of printing anything.
            void PrintFirstBook(string [] BooksArr) {
                if (BooksArr.Length == 0)
              
                    return;
                
                else
                {
                    Console.WriteLine(BooksArr[0]);
                }
                
            
            }

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            PrintFirstBook(books);
            #endregion




        }
    }
}

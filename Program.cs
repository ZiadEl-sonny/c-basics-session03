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

            string title = "Clean Code";
            int pages = 464;


            string Sentence = string.Format("Book: {0}, Pages: {1}",title,pages);
            Console.WriteLine(Sentence);

            #endregion



        }
    }
}

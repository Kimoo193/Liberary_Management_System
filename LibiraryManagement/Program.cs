namespace LibiraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librarian librarian = new Librarian();
            List<Book> books = new List<Book>();
            List <Member> members = new List<Member>();

           
            books.Add(new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", NumberOfCopies = 5 });
            books.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", NumberOfCopies = 3 });
            members.Add(new Member { MemberID = 1, Name = "Kareem" });

            // Display all books and members
            librarian.DisplayAllBooks(books);
            librarian.DisplayAllMembers(members);

            // Member borrows a book
            var member = members[0];
            var bookToBorrow = books[0];
            librarian.BorrowBook(member, bookToBorrow);

            // Member returns the book
            librarian.ReturnBook(member, bookToBorrow);
        }
    }
}

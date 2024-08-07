using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibiraryManagement
{
    internal class Librarian
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
       
        
        public void AddBook(List<Book> books, Book newBook)
        {
            books.Add(newBook);
        }

        public void RemoveBook(List<Book> books, Book bookToRemove)
        {
            books.Remove(bookToRemove);
        }

        public void DisplayAllBooks(List<Book> books)
        {
            Console.WriteLine("All Books:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Copies: {book.NumberOfCopies}");
            }
        }

        public void RegisterMember(List<Member> members, Member newMember)
        {
            members.Add(newMember);
        }

        public void DisplayAllMembers(List<Member> members)
        {
            Console.WriteLine("All Members:");
            foreach (var member in members)
            {
                Console.WriteLine($"MemberID: {member.MemberID}, Name: {member.Name}");
            }
        }



        public void BorrowBook(Member member, Book book)
        {
            if (book.NumberOfCopies > 0)
            {
                Console.WriteLine($"{member.Name} borrowed {book.Title}.");
                book.NumberOfCopies--;
            }
            else
            {
                Console.WriteLine($"Sorry, {book.Title} is out of stock.");
            }
        }

        public void ReturnBook(Member member, Book book)
        {
            Console.WriteLine($"{member.Name} returned {book.Title}.");
            book.NumberOfCopies++;
        }
    }

}


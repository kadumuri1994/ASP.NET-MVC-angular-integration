using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapp6.Controllers
{
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public double price { get; set; }
  
    }
    public class BooksController : ApiController
    {
        public List<Book> Get() //Handles HTTP Get Request
        {
            System.Threading.Thread.Sleep(4000);
            List<Book> books = new List<Book>();
            books.Add(new Book() {title="T1", author="A1", price=2000 });
            books.Add(new Book() { title = "T2", author = "A2", price = 2000 });
            books.Add(new Book() { title = "T3", author = "A3", price = 2000 });
            return books; //JSON serialization (string formatted as JSON) will 
            //Object from server RAM cannot be sent to browser RAM directly
            //Serialization will be done in server which means keeping the object data in string format (either JSON or XML)
            //Deserialization is done on client side (browser)
        }
    }
}

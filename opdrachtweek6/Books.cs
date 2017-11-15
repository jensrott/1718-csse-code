using System;
using System.Collections.Generic;


namespace opdrachtweek5
{
    public class Books
        
    {

        public string _name;
        public Author _author;
        public double _price;
        public int _qtyInStock = 0;

        private List<Author> _authors;
 
        public void Book(string name, Author author, double price, int qtyInStock) 
        {
            this._name = name;
            this._author = author;
            this._price = price;
            this._qtyInStock = qtyInStock;
        } 

        public string getName() 
        {
            return _name;
        }

        public Author getAuthor() 
        {
            return _author;
        }

        public double getPrice() 
        {
            return _price;
        }

        public int getQtyInStock() 
        {
            return _qtyInStock;
        }

        public void setPrice(int price) 
        {
            _price = price;
        }

        public void setQtyInStock(int qtyInStock) 
        {
            _qtyInStock = qtyInStock;
        }

        public string getAuthorName()
        {
            return _name;
        }

        public void print() 
        {
            Console.WriteLine("book: {0}, {1}, {2} In Stock {3}", this._name, this._author, this._price, this._qtyInStock);
        }

        
        static void Mainn(string[] args)
        {
            Books books = new Books();
            books.print();
        }
    }
}
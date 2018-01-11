using System;
using System.Collections.Generic;


namespace opdrachtweek5
{
    public class Book
        
    {

        private string _name;
        private Author _author;
        private double _price;
        private int _qtyInStock = 0;

        private List<Author> _authors;

        public Book(string name, Author author, double price, int qtyInStock)
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
            return _author._name;
        }

        public void print() 
        {
            Console.WriteLine("Book-Name: {0} , Author: {1}, Price: {2} , In Stock: {3}", this._name, this._author, this._price, this._qtyInStock);
        }
    }
}
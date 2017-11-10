using System;
using System.Collections.Generic;

namespace opdrachtweek5
{
   public class Book
    {
        private string Name;
        private double Price;
        private Author Author;

        // 1. B
        private List<Author> authors;

        private int qtyInStock = 0;
    }

    class Book(string name, Author author, double price) 
    {
        this.Name = name;
        this.Author = author;
        this.Price = price;
    }

    public static print() {
        Console.WriteLine("book: {0}, {1}", this.name, this.author, this.price)
    }

    public double getPrint() {

    }

}
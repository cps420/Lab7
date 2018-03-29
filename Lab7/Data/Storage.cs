using Lab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Data
{
    public class Storage
    {
        public static List<Student> StudentStorage;
        public static List<Book> BookStorage;
        public static List<SalesData> SalesDataStorage;

        public static void InstantiateStudentsHardCoded()
        {
            StudentStorage = new List<Student>();
            StudentStorage.Add(
                new Student {
                    FirstName="Ian",
                    LastName="Kirkpatrick",
                    Scores = new int[] { 79, 82, 80, 99 }
                });
            StudentStorage.Add(
                new Student
                {
                    FirstName = "Svetlana",
                    LastName = "Omelchenko",
                    Scores = new int[] { 98, 92, 81, 60 }
                });
            StudentStorage.Add(
                new Student
                {
                    FirstName = "Claire",
                    LastName = "O’Donnell",
                    Scores = new int[] { 75, 84, 91, 39 }
                });
            StudentStorage.Add(
                new Student
                {
                    FirstName = "Sven",
                    LastName = "Mortensen",
                    Scores = new int[] { 88, 94, 65, 91 }
                });
            StudentStorage.Add(
                new Student
                {
                    FirstName = "Cesar",
                    LastName = "Garcia",
                    Scores = new int[] { 97, 89, 85, 82 }
                });


            StudentStorage.Add(
                new Student
                {
                    FirstName = "John",
                    LastName = "Jackson",
                    Scores = new int[] { 98, 87, 100, 94 }
                });
            StudentStorage.Add(
                new Student
                {
                    FirstName = "Adam",
                    LastName = "Smith",
                    Scores = new int[] { 97, 59, 79, 81 }
                });
            StudentStorage.Add(
                new Student
                {
                    FirstName = "Daniel",
                    LastName = "Young",
                    Scores = new int[] { 92, 84, 81, 79 }
                });
            StudentStorage.Add(
                new Student
                {
                    FirstName = "Jack",
                    LastName = "Garcia",
                    Scores = new int[] { 87, 94, 83, 82 }
                });
            StudentStorage.Add(
                new Student
                {
                    FirstName = "Samual",
                    LastName = "Hutt",
                    Scores = new int[] { 90, 81, 99, 100 }
                });
        }

        public static void InstantiateBooksHardCoded()
        {
            List<Book> list = new List<Book>();
            list.Add(new Book
            {
                ID = "001",
                Title = "Programming in C#",
                Price = 634.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            list.Add(new Book
            {
                ID = "002",
                Title = "Learn Java in 30 days",
                Price = 250.76m,
                DateOfRelease = Convert.ToDateTime("2011-08-15")
            });

            list.Add(new Book
            {
                ID = "003",
                Title = "Programming in ASP.Net 4.0",
                Price = 700.00m,
                DateOfRelease = Convert.ToDateTime("2011-02-05")
            });

            list.Add(new Book
            {
                ID = "004",
                Title = "VB.Net Made Easy",
                Price = 500.99m,
                DateOfRelease = Convert.ToDateTime("2011-12-31")
            });

            list.Add(new Book
            {
                ID = "005",
                Title = "Programming in C",
                Price = 314.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            list.Add(new Book
            {
                ID = "006",
                Title = "Programming in C++",
                Price = 456.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            list.Add(new Book
            {
                ID = "007",
                Title = "Datebase Developement",
                Price = 1000.76m,
                DateOfRelease = Convert.ToDateTime("2010-02-05")
            });

            BookStorage = list;
        }

        public static void InstantiateSalesDataHardCoded()
        {
            InstantiateBooksHardCoded();
            InstantiateStudentsHardCoded();

            SalesDataStorage = new List<SalesData>();

            SalesDataStorage.Add(new SalesData
            {
                ID = BookStorage[2].ID,
                Customer = StudentStorage[4]
            });
            SalesDataStorage.Add(new SalesData
            {
                ID = BookStorage[1].ID,
                Customer = StudentStorage[6]
            });
            SalesDataStorage.Add(new SalesData
            {
                ID = BookStorage[2].ID,
                Customer = StudentStorage[6]
            });
            SalesDataStorage.Add(new SalesData
            {
                ID = BookStorage[2].ID,
                Customer = StudentStorage[9]
            });
        }

    }
}

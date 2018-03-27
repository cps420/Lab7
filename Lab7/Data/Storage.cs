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
    }
}

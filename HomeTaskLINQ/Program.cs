
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System;
using HomeTaskLINQ;
using System.ComponentModel;
using System.Security.Cryptography;

namespace HW_LINQ
{
    public class MainClass
    {
        

        public static void Main()
        {
            List<int> list = new List<int>();
            list.AddRange(Enumerable.Range(1,200));

            //1.Write a lambda expression that will return the next number after the provided integer
            Console.WriteLine("---1---");
            int _number = 154;
            int _nextIndexAfterNumber = list.FindIndex(x => x == _number) + 1;
            int nextNumber = list[_nextIndexAfterNumber];
            Console.WriteLine("Next number is " + nextNumber);

            //2. Using LINQ query syntax, write a method that will take IEnumerable<string> values and a string pattern,
            //filters the values that contain the pattern, and return the sorted result.
            Console.WriteLine("\n---2---");
            List<string> strList = new List<string>() { "value15", "value5", "value51", "value0", "value10", "value210", "value3200" };

            Regex regex = new Regex("5$");
            FilterAndSort(strList, regex);

            Console.WriteLine();
            FilterAndSort(strList, new Regex(".*value[1,5]"));


            //3. Do the same thing, but now using method syntax.
            Console.WriteLine("\n---3---");
            Console.WriteLine("The same as before but with syntax");
            FilterAndSortSyntax(strList, new Regex(".*value[1,5]"));

            //4. Write a method that takes a collection of elements, and returns the 3rd, 4th, and 5th items of the provided sequence.
            //Console.WriteLine();
            //strList.GetRange(3, 3).ForEach(x => Console.WriteLine(x));
            Console.WriteLine("\n---4---");
            Console.WriteLine("Initial list ");
            strList.ForEach(x =>  Console.Write(x + " "));
            Console.WriteLine("\nOnly 3 items:");
            GetThreeItems(strList, 3).ForEach(x => Console.Write(x + " "));
            Console.WriteLine() ;

            //5. Write a method that returns all words in the sequence between "start" (inclusive) and "end" (non-inclusive). For example, if given { "One", "start", "more", "end", "thing" } ... this method should return { "start", "more" }
            Console.WriteLine("\n---5---");
            List<string> strList2 = new() { "One", "start", "more", "end", "thing"};

            IEnumerable<string> strList3 = GetValuesBetween(strList2, "start", "end");
            foreach (string word in strList3)
            {
                Console.WriteLine(word);
            }



            //6. Write a method that returns all distinct words that have less than four letters in them.
            Console.WriteLine("\n---6---");
            List<string> strList6 = new() { "One", "end", "two", "more", "end", "thing", "thing" };
            GetAllDistinctLessFourLetters(strList6).ToList().ForEach(x => Console.Write(x + " "));



            //7. Create a class Name with 3 properties: First, Middle, Last. Write a method that returns the provided list of names,
            //ordered by Last, in descending order.
            Console.WriteLine("\n---7---");

            List<Name> listName = new() {
                    new Name { first = "John", middle = "James", last = "Doe" },
                    new Name { first = "Robert", middle = "Elizabeth", last = "Doe" },
                    new Name { first = "Jane", middle = "Elizabeth", last = "Doe" },
                    new Name { first = "Jane", middle = "Andrew", last = "Smith" },
                    new Name { first = "Jane", middle = "Elizabeth", last = "Smith" },
                    new Name { first = "Robert", middle = "Andrew", last = "Johnson" },
                    new Name { first = "Andrew", middle = "Andrew", last = "Johnson" }
            };

            GetNameInOrder(listName).ToList().ForEach(x => Console.WriteLine(x + " "));

            //8. Using the same Name class as before, write a method that returns the provided list of names, ordered by Last, then Middle, then First in descending order.
            Console.WriteLine("\n---8---");
            GetNameInOrderByAllFields(listName).ToList().ForEach(x => Console.WriteLine(x + " "));


            //9. Write a method that returns the number of strings in the provided sequence that begin with the provided startString.
            Console.WriteLine("\n---9---");
            List<string> strList9 = new() { "On", "end", "two", "more", "end", "thing", "thing" };
            string stringForSearching = "en";
            int numberOfString = CountStringStartedByProvidedString(strList9, "en");
            Console.WriteLine("Number of string = {0}, string for searching is {1} " , numberOfString,  stringForSearching);

            
            Console.WriteLine("Number of string = {0}, string for searching is {1} "
                , CountStringStartedByProvidedString(strList9, "t"), "t");


            //10.Write a method that returns the length of the shortest word
            Console.WriteLine("\n---10---");
            Console.WriteLine("Length of shortest word is " + GetLengthOfShortestWord(strList9));


            //11. Write a method that returns the total number of characters in all words in the source sequence
            Console.WriteLine("\n---11---");
            Console.WriteLine("Total number of characters is " + GetTotalNumberOfCharacters(strList9));


            //12. Write a method that returns display strings in the form of "<Last>, <First>" for each provided name. Use Name class from above.
            Console.WriteLine("\n---12---");
            listName.ForEach(Console.WriteLine);
            Console.WriteLine();
            var newList = DisplayString(listName);
            foreach (var item in newList)
            {
                Console .WriteLine(item);
            }


            //13. Given a sequence of words, get rid of any that don't have the character 'e' in them,
            //then sort the remaining words alphabetically,
            //then return the following phrase using only the final word in the resulting sequence: -> "The last word is <word>"
            //If there are no words with the character 'e' in them, then return null.

            Console.WriteLine("\n---13---");
            List<string> strList13 = new() { "On", "end", "two", "more", "end" };
            strList13.ForEach(Console.WriteLine);
            Console.WriteLine();
            char expectedChar = 'e';
            WriteLastWordWithChar(strList13, expectedChar);

            Console.WriteLine();
            List<string> strList14 = new() { "One", "end"};
            strList13.ForEach(Console.WriteLine);
            Console.WriteLine();
            WriteLastWordWithChar(strList14, expectedChar);

            Console.WriteLine();
        }

        private static void WriteLastWordWithChar(List<string> listName, char expectedChar)
        {
            List<string> tempList = listName.FindAll(a=> !a.Contains(expectedChar));
            tempList.Sort();
            Console.WriteLine("Only items without char = " + expectedChar);
            foreach (var item in tempList) { Console.WriteLine(item); };
            Console.WriteLine ("\nThe lastWord is '" + tempList.LastOrDefault() + "'");
        }

        private static IEnumerable<string> FilterAndSort (IEnumerable<string> list , Regex regex)
        {
            var stringValuesMatchRegex = from str in list
                              where regex.IsMatch(str)
                              orderby str descending
                              select str;
            foreach (var item in stringValuesMatchRegex)
            {
                Console.WriteLine(item);
            }

            return stringValuesMatchRegex;
        }


        private static IEnumerable<string> FilterAndSortSyntax(IEnumerable<string> list, Regex regex)
        {
            var stringValuesMatchRegex = list.Where(item => regex.IsMatch(item)).OrderByDescending(item => item).ToList();
                                         
            foreach (var item in stringValuesMatchRegex)
            {
                Console.WriteLine(item);
            }

            return stringValuesMatchRegex;
        }

        private static List<T> GetThreeItems<T>(List<T> list, int startIndex)
        {
            return list.GetRange(startIndex, 3);
        }


        private static IEnumerable<string> GetValuesBetween(IEnumerable<string> list, string startValue, string endValue)
        {
            return list
                .SkipWhile(item => item != startValue)
                .TakeWhile(item => item != endValue);

        }

        private static IEnumerable<string> GetAllDistinctLessFourLetters(IEnumerable<string> list)
        {
            return list.Distinct().Where(x=>x.Length<4);
        }


        private static IEnumerable<Name> GetNameInOrder(IEnumerable<Name> listName)
        {
            return from i in listName
                   orderby i.last descending
                   select i;
        }

        private static IEnumerable<Name> GetNameInOrderByAllFields(IEnumerable<Name> listName)
        {
            return from i in listName
                   orderby  i.last descending,
                             i.middle descending,
                             i.first descending
                   select i;
        }

        private static int CountStringStartedByProvidedString(List<string> strList9, string stringForSearch)
        {
            return strList9.FindAll(a => a.StartsWith(stringForSearch)).Count;
        }

        private static int GetLengthOfShortestWord(List<string> strList9)
        {
            return strList9.Select(a => a.Length).Min();
        }


        private static int GetTotalNumberOfCharacters(List<string> strList9)
        {
            return strList9.Select(a=> a.Length).Sum();
        }


        private static IEnumerable<String> DisplayString(List<Name> listName)
        {
            var newList = from a in listName
                          select $"{a.last} , {a.first}";
            return newList;
            //return listName.Select(a => $" {a.last}, {a.first}");
        }
    }
}

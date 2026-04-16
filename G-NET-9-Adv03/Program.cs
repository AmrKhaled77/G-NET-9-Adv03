using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {


        #region xercise 1: Student Grade Manager

        // Create collection
        List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

        // Print collection
        Console.WriteLine("Grades: " + string.Join(", ", grades));

        // Count, first, last
        Console.WriteLine("Count: " + grades.Count);
        Console.WriteLine("First Grade: " + grades.First());
        Console.WriteLine("Last Grade: " + grades.Last());

        // Sort ascending
        grades.Sort();
        Console.WriteLine("\nSorted Grades: " + string.Join(", ", grades));

        // First grade above 90
        int firstAbove90 = grades.FirstOrDefault(g => g > 90);
        Console.WriteLine("First grade above 90: " + firstAbove90);

        // All grades below 75
        var failingGrades = grades.Where(g => g < 75).ToList();
        Console.WriteLine("Failing Grades: " + string.Join(", ", failingGrades));

        // Remove failing grades
        grades.RemoveAll(g => g < 75);
        Console.WriteLine("After Removing Failing Grades: " + string.Join(", ", grades));

        // Check if any grade equals 100
        bool has100 = grades.Any(g => g == 100);
        Console.WriteLine("Contains 100? " + has100);

        // Convert to List<string>
        List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
        Console.WriteLine("String List:");
        gradeStrings.ForEach(g => Console.WriteLine(g));
        #endregion




        #region Exercise 2: Leaderboard

        SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
        {
            {500, "Ahmed"},
            {200, "Sara"},
            {800, "Ali"},
            {350, "Mona"}
        };

   
        Console.WriteLine("Leaderboard:");
        foreach (var entry in leaderboard)
        {
            Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
        }

       
        var firstEntry = leaderboard.First();
        Console.WriteLine("\nFirst Score: " + firstEntry.Key);
        Console.WriteLine("First Player: " + firstEntry.Value);

       
        bool has500 = leaderboard.ContainsKey(500);
        Console.WriteLine("\nContains score 500? " + has500);

        
        if (leaderboard.TryGetValue(999, out string player))
            Console.WriteLine("Player with score 999: " + player);
        else
            Console.WriteLine("Score 999 not found");

        
        leaderboard.Remove(200);

     
        Console.WriteLine("\nUpdated Leaderboard:");
        foreach (var entry in leaderboard)
        {
            Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
        }
        #endregion



        #region Exercise 3: Phone Book

        Dictionary<string, string> phoneBook = new Dictionary<string, string>()
        {
            {"Ahmed", "01011111111"},
            {"Sara", "01022222222"},
            {"Ali", "01033333333"},
            {"Mona", "01044444444"}
        };

      
        phoneBook["Omar"] = "01055555555";   
        phoneBook["Ahmed"] = "01100000000"; 

        
        try
        {
            phoneBook.Add("Sara", "01299999999");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error adding duplicate with Add(): " + ex.Message);
        }

        
        bool added = phoneBook.TryAdd("Ali", "01288888888");
        Console.WriteLine("TryAdd Ali success? " + added);

        
        Console.WriteLine("\nContains 'Youssef'? " + phoneBook.ContainsKey("Youssef"));

        
        string result = phoneBook.TryGetValue("Youssef", out string number)
                        ? number
                        : "Not Found";
        Console.WriteLine("Youssef's number: " + result);

        
        Console.WriteLine("\nAll Names:");
        Console.WriteLine(string.Join(", ", phoneBook.Keys));

        
        Console.WriteLine("All Numbers:");
        Console.WriteLine(string.Join(", ", phoneBook.Values));
        #endregion



        #region Exercise 4: Unique Email Validator
        HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "ahmed@test.com",
            "AHMED@test.com",
            "sara@test.com",
            "Sara@Test.Com"
        };

   
        Console.WriteLine("Email Count: " + emails.Count);

        
        Console.WriteLine("Stored Emails:");
        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }

        
        Console.WriteLine("\nExplanation:");
        Console.WriteLine("HashSet ignores duplicates.");
        Console.WriteLine("Case-insensitive comparer treats 'ahmed@test.com' and 'AHMED@test.com' as the same.");
        Console.WriteLine("So only unique emails are stored.");

        
        HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

       
        HashSet<int> union = new HashSet<int>(setA);
        union.UnionWith(setB);
        Console.WriteLine("\nUnion: " + string.Join(", ", union));

        HashSet<int> intersect = new HashSet<int>(setA);
        intersect.IntersectWith(setB);
        Console.WriteLine("Intersection: " + string.Join(", ", intersect));

       
        HashSet<int> except = new HashSet<int>(setA);
        except.ExceptWith(setB);
        Console.WriteLine("Except (A - B): " + string.Join(", ", except));

        HashSet<int> subset = new HashSet<int> { 1, 2 };
        Console.WriteLine("\nIs {1,2} subset of A? " + subset.IsSubsetOf(setA));
        #endregion


       



    }
}
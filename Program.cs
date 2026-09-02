namespace AssignmentAdv_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
           
            List<int> Grades = [85, 92, 78, 95, 88, 70, 100, 65];
           
            //Console.WriteLine(Grades.Count);
            //Console.WriteLine(Grades[0]);//first grade
            //Console.WriteLine(Grades[7]);//last grade

         
            //Grades.Sort();
            //foreach (int Grade in Grades)
            //{
            //    Console.WriteLine(Grade);
            //}

          
            //Console.WriteLine(Grades.Find(p=>p>90));

            //List<int> result = Grades.FindAll(p => p < 75);
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            
            //Grades.RemoveAll(p => p < 75);
            //foreach (int Grade in Grades)
            //{
            //    Console.WriteLine(Grade);
            //}

            //Console.WriteLine(Grades.Contains(100));

 
            //List<string> strings = new();
            //foreach (int i in Grades)
            //{
            //    strings.Add("Grade : " + i);
            //}
            //foreach (string s in strings)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region Q2
            
            SortedDictionary<int, string> Scores = new()
            {
                [500] = "Ahmed",
                [200]="Sara",
                [800]="Ali",
                [350]="Mona"
            };

            //foreach(var score in Scores)
            //{
            //    Console.WriteLine($"{score.Key}  {score.Value}");
            //}

            //var First=Scores.First();
            //Console.WriteLine(First.Key);
            //Console.WriteLine(First.Value);

            //Console.WriteLine(Scores.ContainsKey(500));

            //Console.WriteLine(Scores.TryGetValue(999, out string? value)); 

            //Scores.Remove(200);
            //foreach(var score in Scores)
            //{
            //    Console.WriteLine($"{score.Key} {score.Value}");
            //}

            #endregion

            #region Q3
            Dictionary<string, int> Contacts = new()
            {
                ["Kaled"] = 1234567,
                ["Safeia"] = 1234567,
                ["Mona"] = 1234,
                ["Shahd"] = 12346
            };

            Contacts["Ali"] = 1234;
            //Contacts.Add("Mona", 1234);//Exception

            //bool Ans= Contacts.TryAdd("Safeia", 1234567);
            //Console.WriteLine(Ans);

            //Console.WriteLine(Contacts.ContainsKey("Ahmed"));//does not exist

            //Console.WriteLine(Contacts.ContainsKey("Sara") ? Contacts["Sara"]:"Not Found");

            //foreach (var contact in Contacts)
            //{
            //    Console.Write($"{contact.Key} ");
            //}
            //Console.WriteLine();
            //foreach (var contact in Contacts)
            //{
            //    Console.Write($"{contact.Value} ");
            //}

            #endregion

            #region Q4
            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            //Console.WriteLine(emails.Count);// 2 because Hashset ignore duplicated values

            //HashSet<int> SetA = new(){ 1,2,3,4,5};
            //HashSet<int> SetB = new() { 4, 5, 6, 7, 8 };

            //HashSet<int> UnionSet = new(SetA);
            //UnionSet.UnionWith(SetB);
            //foreach(int i in UnionSet)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //HashSet<int> IntersetSet = new(SetA);
            //IntersetSet.IntersectWith(SetB);
            //foreach (int i in IntersetSet)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //HashSet<int> ExceptSet = new(SetA);
            //ExceptSet.ExceptWith(SetB);
            //foreach(int i in ExceptSet)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //HashSet<int> Test = new() { 1, 2 };
            //Console.WriteLine(Test.IsSubsetOf(SetA));

            #endregion

            #region Search
            /*
             * Span<T> ->بتخليني اتعامل مع جزء من الاراي من غير ما اعمل نسحة جديدة واي تغيير فيها هيسمع ف الاراي
             * int[] Numbers={1,2,3,4}
             * Span<int> span=Numbers;
             * span[0]=5;
             * 
             * SortedList<T> ->مش زي الليست العادية لكن هي بتاخدkey,value 
             * وبترتبهم تلقائي حسب الkey
             * 
             * SortedDictionary<T> ->زي الDictionary العادي
             * ولكن بيرتب حسب key
             */
            #endregion
        }
    }
}

using System.Collections;
using System.Data;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir collection yaradırsız, içərisinə proqramlaşdırma dillərini və yaradıldığı tarixləri daxil edirsiz. Proqramlaşdırma dilləri, ilə görə sıralansın
            SortedList<int, string> ProgrammingLanguanges = new SortedList<int, string>
            {
                { 2001, "C#" },
                { 1980, "C++" },
                { 1995, "Java" },
                { 1990, "Python" },
            };
            //foreach (var language in ProgrammingLanguanges)
            //{
            //    Console.WriteLine(language);
            //}

            // TASK 2
            // LinkedList
            //LinkedList elementi bitişik olmayan yerdə saxlayan xətti məlumat strukturudur. Əlaqədar siyahıdakı elementlər göstəricilərdən istifadə etməklə bir-biri ilə əlaqələndirilir. Və ya başqa sözlə, LinkedList hər bir node məlumat sahəsi və siyahıdakı növbəti node üçün istinaddan ibarətdir. C# dilində LinkedList System.Collections.Generic ümumi kolleksiya növüdür. Bu, ikiqat əlaqəli siyahıdır, buna görə də hər bir qovşaq Növbəti qovşaqı irəli və Əvvəlki qovşağı göstərir. Bu, proqramınızın ehtiyacına uyğun olaraq böyüyən dinamik kolleksiyadır. O, həmçinin elementlərin sürətli daxil edilməsini və çıxarılmasını təmin edir.

            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Leyla");
            list.AddFirst("Adil");
            list.AddLast("Nigar");
            list.AddLast("Murad");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            // HashTable
            // Hashtable key'in hash koduna əsasən düzülmüş key/value cütlərinin toplusudur. Başqa sözlə, saxlama üçün hash cədvəlindən istifadə edən kolleksiya yaratmaq üçün Hashtable istifadə olunur. O, ümumiyyətlə, hər bir açarın hash kodunu hesablamaqla və onu avtomatik olaraq başqa səbətdə saxlamaqla axtarışı optimallaşdırır və o zaman hashtable'dan dəyərə daxil olduqda o, müəyyən edilmiş key'le hashcode'a uyğun gəlir. Bu, System.Collections ad məkanında müəyyən edilmiş non-generic kolleksiya növüdür.

            Hashtable hashtable = new Hashtable();
            hashtable.Add(2003, "Leyla");
            hashtable.Add(2004, "Adil");
            hashtable.Add(2009, "Murad");
            hashtable.Add(2005, "Nigar");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}




        }
    }
}
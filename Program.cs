using System;
using System.Collections.Generic;

namespace familyDictionary {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>> ();

            Dictionary<string, string> sister = new Dictionary<string, string> ();
            Dictionary<string, string> myself = new Dictionary<string, string> ();
            Dictionary<string, string> mother = new Dictionary<string, string> ();
            Dictionary<string, string> father = new Dictionary<string, string> ();

            myself.Add ("name", "Spencer");
            myself.Add ("age", "27");
            myFamily.Add ("myself", myself);

            sister.Add ("name", "Anna");
            sister.Add ("age", "24");
            myFamily.Add ("sister", sister);

            mother.Add ("name", "Norma");
            mother.Add ("age", "56");
            myFamily.Add ("mother", mother);

            father.Add ("name", "Terry");
            father.Add ("age", "61");
            myFamily.Add ("father", father);

            foreach (KeyValuePair<string, Dictionary<string, string>> person in myFamily) {
                Console.WriteLine ("-------------------------");

                foreach (KeyValuePair<string, string> attribute in person.Value) {
                    Console.WriteLine ($"{attribute.Key}: {attribute.Value}");
                }
            }
        }
    }
}
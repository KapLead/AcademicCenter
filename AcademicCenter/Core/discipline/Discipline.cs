using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AcademicCenter
{
    /// <summary> Дисциплина </summary>
    public class Discipline
    {

        /// <summary> наименование дисциплины </summary>
        public string Name { get; set; } = "";
        
        /// <summary> заголовок дисциплины </summary>
        public string Title { get; set; } = "";

        /// <summary> заголовок дисциплины </summary>
        public string Descrition { get; set; } = "";

        /// <summary> Тесты по дисциплине </summary>
        public List<Test> Tests { get; set; } = new List<Test>();

        [JsonIgnore] public IEnumerable<Document> Documents 
        { get {
                List<Document> ret = new List<Document>();
                foreach (var test in Tests)
                    foreach(var ans in test.Items)
                        foreach(var a in ans.Answers)
                            if (a.Documents != null)
                                ret.AddRange(a.Documents);
                return Distict(ret); } 
        }

        public IEnumerable<T> Distict<T>(IEnumerable<T> source)
        {
            List<T> uniques = new List<T>();
            foreach (T item in source)
                if (!uniques.Contains(item)) uniques.Add(item);
            return uniques;
        }

        public Discipline Load(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($@"Filename not found '{filename}'");
                return this;
            }

            try
            {
                var tmp = JsonSettings.Get<Discipline>(filename);
                return tmp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return this;
        }

        public void Save(string filename)
        {
            try
            {
                JsonSettings.Save(this,filename);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}

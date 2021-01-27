using System.Collections.Generic;
using System.Linq;

namespace AcademicCenter.Core.discipline
{
    /// <summary> Дисциплина </summary>
    public class Discipline
    {

        /// <summary> наименование дисциплины </summary>
        public string Name { get; set; }

        /// <summary> Тесты по дисциплине </summary>
        public List<Test> Tests { get; set; } = new List<Test>();

        public IEnumerable<Document> Documents 
        { get
            {
                List<Document> ret = new List<Document>();
                foreach (var test in Tests)
                    foreach(var ans in test.Items)
                        foreach(var a in ans.Answers)
                            ret.AddRange(a.Documents);
                return Distict(ret);
            } 
        }

        public IEnumerable<T> Distict<T>(IEnumerable<T> source)
        {
            List<T> uniques = new List<T>();
            foreach (T item in source)
                if (!uniques.Contains(item)) uniques.Add(item);
            return uniques;
        }
    }
}

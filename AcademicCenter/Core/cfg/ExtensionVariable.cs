using System.Collections.Generic;
using System.Linq;

namespace AcademicCenter
{
    public class ExtensionVariable
    {
        public Dictionary<string,bool> Items { get; set; }

        public ExtensionVariable()
        {
            Items = new Dictionary<string, bool>();
        }

        public bool Contain(string exp)
        {
            exp = exp.ToUpper();
            if (!Items.ContainsKey(exp)) return false;
            return Items?.Where(d => d.Value && d.Key == exp)?.Count() > 0;
        }
    }
}

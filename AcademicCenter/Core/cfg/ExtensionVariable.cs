using System.Collections.Generic;

namespace AcademicCenter
{
    public class ExtensionVariable
    {
        public Dictionary<string,bool> Items { get; set; }

        public ExtensionVariable()
        {
            Items = new Dictionary<string, bool>();
        }
    }
}

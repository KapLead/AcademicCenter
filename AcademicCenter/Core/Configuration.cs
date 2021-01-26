using System.Collections.Generic;
using System.IO;
using AcademicCenter.Properties;

namespace AcademicCenter
{
    public static class Configuration
    {
        public static ExtensionVariable discourse;
        public static ExtensionVariable presentations;
        public static ExtensionVariable laboratory;
        public static ExtensionVariable books;
        public static ExtensionVariable videos;

        public static void Initialization()
        {
            init(out discourse, "ext\\discourse");
            init(out presentations, "ext\\presentations");
            init(out laboratory, "ext\\laboratory");
            init(out books, "ext\\books");
            init(out videos, "ext\\videos");
        }

        static void init(out ExtensionVariable dic,string name)
        {
            if (File.Exists(  $"{JsonSettings.FolderPath}{name}.json"))
                dic = JsonSettings.Get<ExtensionVariable>(name);
            else
            {
                dic = new ExtensionVariable { Items = DefaultDict() };
                JsonSettings.Save(dic, name);
            }
        }

        static Dictionary<string, bool> DefaultDict()
        {
            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            foreach (string extension in Settings.Default.Extensions)
                dic.Add(extension,false);
            return dic;
        }
    }
}

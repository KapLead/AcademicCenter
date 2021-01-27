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
        public static List<Discipline> Disciplines;
        public static void Initialization()
        {
            init(out discourse, "ext\\discourse");
            init(out presentations, "ext\\presentations");
            init(out laboratory, "ext\\laboratory");
            init(out books, "ext\\books");
            init(out videos, "ext\\videos");
            Disciplines=GetDisciplines();
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

        /// <summary> Все дисциплины </summary>
        public static List<Discipline> GetDisciplines()
        {
            Directory.CreateDirectory(JsonSettings.FolderPath + "\\discipline\\");
            var tmp = Directory.GetDirectories(JsonSettings.FolderPath + "\\discipline\\",
                "*", SearchOption.TopDirectoryOnly);
            List<Discipline> ret = new List<Discipline>();
            if (tmp.Length != 0)
                foreach (var s in tmp)
                    ret.Add(new Discipline().Load(Directory.GetFiles(s,"*.json", SearchOption.TopDirectoryOnly)[0]));
            else
            {
                var d = new Discipline {Name = "DefaultDiscipline", Tests = new List<Test>()};
                var test = new Test {type = Test.Type.Обучение};
                test.Items.Add(new Test.Item
                {
                    Question = "Укажите ранг сети : 192.168.0.1",
                    Answers = new List<Test.Answer>
                    {
                        new Test.Answer {Text = "/16"},
                        new Test.Answer {Text = "/24", IsCorrect = true},
                        new Test.Answer {Text = "/32"}
                    }
                });
                test.Items.Add(new Test.Item
                {
                    Question = "Укажите ранг сети : 10.99.1.2",
                    Answers = new List<Test.Answer>
                    {
                        new Test.Answer {Text = "/16"},
                        new Test.Answer {Text = "/24"},
                        new Test.Answer {Text = "/32", IsCorrect = true}
                    }
                });
                d.Tests.Add(test);
                Directory.CreateDirectory(JsonSettings.FolderPath + "\\discipline\\DEFAULT\\");
                d.Save(JsonSettings.FolderPath + "\\discipline\\DEFAULT\\default.json");
                ret.Add(d);
            }
            return ret;
        }

    }
}

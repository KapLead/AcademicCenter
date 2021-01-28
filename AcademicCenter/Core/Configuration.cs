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
            var tmp = Directory.GetFiles(JsonSettings.FolderPath + "\\discipline\\", 
                "*.json", SearchOption.TopDirectoryOnly);
            List<Discipline> ret = new List<Discipline>();
            if (tmp.Length != 0)
                foreach (var s in tmp)
                    ret.Add(new Discipline().Load(s));
            else
            {
                var d = new Discipline {Descrition = "ГКУ НСИФ факультет информатики", Title = "Компьютерные сети", Tests = new List<Test>()};
                var test = new Test { Descrition = "Ранжирование сетей", Title = "Тест №1", Type = Type.Контрольная};
                var doc = new List<Document>(new[] {new Document { }});
                test.Items.Add(new Item
                {
                    Question = "Укажите ранг сети : 192.168.0.1",
                    Answers = new List<Answer>
                    {
                        new Answer {Text = "/16", Documents = doc},
                        new Answer {Text = "/24", Documents = doc, IsCorrect = true},
                        new Answer {Text = "/32", Documents = doc}
                    }
                });
                test.Items.Add(new Item
                {
                    Question = "Укажите ранг сети : 10.99.1.2",
                    Answers = new List<Answer>
                    {
                        new Answer {Text = "/16", Documents = doc},
                        new Answer {Text = "/24", Documents = doc},
                        new Answer {Text = "/32", Documents = doc, IsCorrect = true}
                    }
                });
                d.Tests.Add(test);
                var test2 = new Test { Descrition = "Характеристики сетей", Title = "Тест №2", Type = Type.Контрольная };
                var doc2 = new List<Document>(new[] { new Document { } });
                test2.Items.Add(new Item
                {
                    Question = "Предоставляющий свои ресурсы пользователям сети компьютер – это:",
                    Answers = new List<Answer>
                    {
                        new Answer {Text = "Пользовательский", Documents = doc2},
                        new Answer {Text = "Сервер", Documents = doc2, IsCorrect = true},
                        new Answer {Text = "Клиент", Documents = doc2}
                    }
                });
                test2.Items.Add(new Item
                {
                    Question = "Центральная машина сети называется:",
                    Answers = new List<Answer>
                    {
                        new Answer {Text = "Центральным процессором", Documents = doc2},
                        new Answer {Text = "Хабом", Documents = doc2},
                        new Answer {Text = "Сервером", Documents = doc2, IsCorrect = true}
                    }
                });
                test2.Items.Add(new Item
                {
                    Question = "Обобщенная геометрическая характеристика компьютерной сети – это:",
                    Answers = new List<Answer>
                    {
                        new Answer {Text = "Сервер сети", Documents = doc2},
                        new Answer {Text = "Удаленность компьютеров сети", Documents = doc2},
                        new Answer {Text = "Топология сети", Documents = doc2, IsCorrect = true}
                    }
                });
                d.Tests.Add(test2);

                var test3 = new Test { Descrition = "Типы, виды и уровни сетей", Title = "Тест №3", Type = Type.Контрольная };
                var doc3 = new List<Document>(new[] { new Document { } });
                test3.Items.Add(new Item
                {
                    Question = "Глобальной компьютерной сетью мирового уровня является:",
                    Answers = new List<Answer>
                    {
                        new Answer {Text = "E-mail", Documents = doc3},
                        new Answer {Text = "WWW", Documents = doc3, IsCorrect = true},
                        new Answer {Text = "Интранет", Documents = doc3}
                    }
                });
                test3.Items.Add(new Item
                {
                    Question = "Основными видами компьютерных сетей являются сети:",
                    Answers = new List<Answer>
                    {
                        new Answer {Text = "социальные, развлекательные, бизнес-ориентированные", Documents = doc3},
                        new Answer {Text = "клиентские, корпоративные, международные", Documents = doc3},
                        new Answer {Text = "локальные, глобальные, региональные", Documents = doc3, IsCorrect = true}
                    }
                });
                test3.Items.Add(new Item
                {
                    Question = "Протокол компьютерной сети - совокупность:",
                    Answers = new List<Answer>
                    {
                        new Answer {Text = "Электронный журнал для протоколирования действий пользователей сети", Documents = doc3},
                        new Answer {Text = "Технических характеристик трафика сети", Documents = doc3},
                        new Answer {Text = "Правил, регламентирующих прием-передачу, активацию данных в сети", Documents = doc3, IsCorrect = true}
                    }
                });
                d.Tests.Add(test3);

                Directory.CreateDirectory(JsonSettings.FolderPath + "\\discipline\\");
                d.Save(JsonSettings.FolderPath + "\\discipline\\default.json");
                ret.Add(d);
            }
            return ret;
        }

    }
}

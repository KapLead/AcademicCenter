using System.Collections.Generic;

namespace AcademicCenter
{

    /// <summary> Виды тестов </summary>
    public enum Type { Обучение, Контрольная }
 
    /// <summary> Тест </summary>
    public class Test
    {
        
        /// <summary> заголовок дисциплины </summary>
        public string Title { get; set; } = "";

        /// <summary> заголовок дисциплины </summary>
        public string Descrition { get; set; } = "";

        /// <summary> Вид теста </summary>
        public Type Type { get; set; } = Type.Обучение;

        /// <summary> Вопросы теста </summary>
        public List<Quest> Items { get; set; } = new List<Quest>();
            

    }
}

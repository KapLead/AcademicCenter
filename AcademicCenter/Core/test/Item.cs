using System.Collections.Generic;

namespace AcademicCenter
{
    /// <summary> Вопрос-ответы </summary>
    public class Item
    {
        /// <summary> Вопрос </summary>
        public string Question { get; set; }

        /// <summary> Ответы </summary>
        public List<Answer> Answers { get; set; }

    }
}

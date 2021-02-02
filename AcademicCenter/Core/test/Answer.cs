using System.Collections.Generic;
using System.Text;

namespace AcademicCenter
{
    /// <summary> Ответ </summary>
    public class Answer
    {
        /// <summary> Текст ответа </summary>
        public string Text { get; set; } = "";

        /// <summary> Документ для ответа </summary>
        public List<Document> Documents { get; set; } = new List<Document>();

        /// <summary> Является правильным ответом </summary>
        public bool IsCorrect { get; set; } = false;
    }
}

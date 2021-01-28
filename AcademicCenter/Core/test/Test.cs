using System.Collections.Generic;

namespace AcademicCenter
{
    public class Test
    {
        /// <summary> Содержимое теста </summary>
        public List<Item> Items { get; set; } = new List<Item>();
            
        /// <summary> Вид теста </summary>
        public Type type { get; set; }
        


  
        
        
        public class Item
        {
            /// <summary> Вопрос </summary>
            public string Question { get; set; }
           
            /// <summary> Ответы </summary>
            public List<Answer> Answers { get; set; }

        }

        /// <summary> Виды тестов </summary>
        public enum Type { Обучение, Контрольная }

        /// <summary> Ответ </summary>
        public class Answer
        {
            /// <summary> Текст ответа </summary>
            public string Text { get; set; }
            
            /// <summary> Документ для ответа </summary>
            public List<Document> Documents { get; set; }
            
            /// <summary> Является правильным ответом </summary>
            public bool IsCorrect { get; set; }
        }
    }
}

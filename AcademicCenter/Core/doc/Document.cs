namespace AcademicCenter
{
    /// <summary> описание документа </summary>
    public class Document
    {
        /// <summary> расширение файла </summary>
        public string Extn { get; set; }
        
        /// <summary> относительный путь </summary>
        public string Path { get; set; }
        
        /// <summary> имя файла </summary>
        public string Name { get; set; }
        
        /// <summary> размер файла </summary>
        public long   Size { get; set; }
        
        /// <summary> префикс документа </summary>
        public string TypeDocs { get; set; }
    }
}

using System;
using System.IO;
using Newtonsoft.Json;

namespace AcademicCenter
{
    public static class JsonSettings
    {
        public static string FolderPath => Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)+@"\dat\";

        static JsonSettings()
        {
            Directory.CreateDirectory(FolderPath);
        }

        public static void Save<T>(T settings, string filename = null) where T : class
        {
            filename = string.IsNullOrEmpty(filename) ? typeof(T) + ".json" : filename+(filename.EndsWith(".json")?"":".json");
            string path = Path.Combine(FolderPath, filename);
            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine(JsonConvert.SerializeObject(settings, Formatting.Indented));
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T Get<T>(string filename = null) where T : class
        {
            filename = string.IsNullOrEmpty(filename) ? typeof(T) + ".json" : filename + (filename.EndsWith(".json") ? "" : ".json");
            string path = Path.Combine(FolderPath, filename);
             
            if (File.Exists(path))
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    try
                    {
                        var result = JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
                        return result;

                    }
                    catch (Exception ex)
                    {
                        throw new JsonSerializationException($"Cant deserialize configuration file {path}", ex);
                    }
                    finally
                    {
                        streamReader.Close();
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("File with configurations not found", path);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DrillToolWeight.Models
{
    internal class FileIOService
    {
        private readonly string PATH;

        /* Инициализация пути для сохранения файла */
        public FileIOService(string path) 
        {
            PATH = path;
        }

        /* Загрузка данных из файла */
        public List<Knbk> LoadData() 
        {
            List<Knbk> knbk = new List<Knbk>();

            bool fileExists = File.Exists(PATH);
            if (!fileExists)                     // Если такого файла нет
                File.CreateText(PATH).Dispose(); // Освобождаем ресурсы
            else 
            {
                using (var reader = File.OpenText(PATH)) // Если файл существует
                {
                    var textKnbk = reader.ReadToEnd();   // читаем его и конвертируем
                    knbk = JsonConvert.DeserializeObject<List<Knbk>>(textKnbk);
                }
            }

            return knbk;
        }

        /* Сохранение данных в файл */
        public void SaveData(List<Knbk> knbk) 
        {
            using (StreamWriter writer = File.CreateText(PATH)) 
            {
                string output = JsonConvert.SerializeObject(knbk);
                writer.Write(output);
            }
        }

    }
}

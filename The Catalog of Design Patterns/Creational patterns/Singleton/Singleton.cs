using System.Collections.Generic;

namespace Singleton
{

    /*
     Одиночка — это порождающий паттерн проектирования, 
    который гарантирует, что у класса есть только один экземпляр, 
    и предоставляет к нему глобальную точку доступа.
     */
    public class Singleton
    {
        static private Singleton instance = null;
        static public Singleton Instance
        {
            get
            {
                if (instance==null)
                    instance = new Singleton();
                
                return instance;
            }
        }
        public List<int> Data { get; set; }
        private Singleton()
        {
            Data = new List<int>();
        }
    }
}

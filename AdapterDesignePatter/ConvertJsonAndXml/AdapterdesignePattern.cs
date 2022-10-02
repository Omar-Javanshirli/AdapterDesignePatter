using AdapterDesignePatter.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignePatter.ConvertJsonAndXml
{

    interface IAdapter
    {
        void Write();
        void Read();
    }

    class JsonAdapter : IAdapter
    {
        private WriteJson _jsonWrite;

        public JsonAdapter(WriteJson jsonWrite)
        {
            _jsonWrite = jsonWrite;
        }

        public void Read()
        {
            _jsonWrite.ReadHuman();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
    class WriteJson
    {
        public  void WriteHuman(Human human)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("human.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, human);
                }
            }
        }

        public  Human ReadHuman()
        {
            Human human = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("human.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    human = serializer.Deserialize<Human>(jr);
                }
            }
            return human;
        }
    }

    public  class AdapterdesignePattern
    {
        
    }
}

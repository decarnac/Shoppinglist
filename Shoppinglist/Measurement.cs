using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Shoppinglist
{
    [Serializable()]
    public class Measurement
    {
        public Measurement(string name)
        {
            Name = name;
        }

        public Measurement(Measurement mått)
        {
            Name = mått.Name;
        }

        public string Name { get; set; }
    }

    class MåttLista
    {
        public List<Measurement> listan { get; set; }

        public MåttLista()
        {
            //Load();
        }

        public void Load()
        {
            listan = new List<Measurement>();

            Action<Exception> errorHandler = (ex) =>
            {
                // Skapa grundkategorier
                listan = new List<Measurement>{new Measurement("g"),
                                        new Measurement("hg"),
                                        new Measurement("kg"),
                                        new Measurement("tsk"),
                                        new Measurement("msk"),
                                        new Measurement("dl"),
                                        new Measurement("l"),
                                        new Measurement("pkt"),
                                        new Measurement("port"),
                                        new Measurement("st") };
            };

            try
            {
                using (Stream stream = File.Open("mått.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    listan = (List<Measurement>)bin.Deserialize(stream);  
                }
            }

            catch (IOException ex) { errorHandler(ex); }
            catch (System.Runtime.Serialization.SerializationException ex) { errorHandler(ex); }
        }

        public void Save()
        {
            try
            {
                using (Stream stream = File.Open("mått.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, listan);
                }
            }
            catch (IOException)
            {
            }

        }
    }
}

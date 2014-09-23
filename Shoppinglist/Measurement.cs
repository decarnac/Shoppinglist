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
        public List<Measurement> theList { get; set; }

        public MåttLista()
        {
            //Load();
        }

        // return all Measurements with this searchString name
        public List<Measurement> FindByName(string searchString)
        {
            List<Measurement> foundMeasurementsList = new List<Measurement>();

            foreach (Measurement iterMeasurement in theList)
            {
                if (iterMeasurement.Name == searchString)
                {
                    foundMeasurementsList.Add(new Measurement(iterMeasurement));
                }
            }
            return foundMeasurementsList;
        }

        // Get first Measurement that is contained within searchString (return Measurement and the other part of the string)
        public List<string> FindByNameSubString(string searchString)
        {
            List<string> foundMeasureAndTheRestList = new List<string>();

            foreach (Measurement iterMeasurement in theList)
            {
                if (searchString.Contains(iterMeasurement.Name))
                {
                    foundMeasureAndTheRestList.Add(iterMeasurement.Name);
                    foundMeasureAndTheRestList.Add(searchString.Replace(iterMeasurement.Name,""));
                }
            }
            return foundMeasureAndTheRestList;
        }


        public void Load()
        {
            theList = new List<Measurement>();

            Action<Exception> errorHandler = (ex) =>
            {
                // Skapa grundkategorier
                theList = new List<Measurement>{new Measurement("g"),
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
                    theList = (List<Measurement>)bin.Deserialize(stream);  
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
                    bin.Serialize(stream, theList);
                }
            }
            catch (IOException)
            {
            }

        }
    }
}

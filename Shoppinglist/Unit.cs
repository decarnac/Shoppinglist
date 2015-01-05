using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Shoppinglist
{
    [Serializable()]
    public class Unit
    {
        public Unit(string name)
        {
            m_name = name;
        }

        public Unit(Unit unit)
        {
            m_name = unit.m_name;
        }

        public string m_name { get; set; }
    }

    class UnitList
    {
        public List<Unit> theList { get; set; }

        public UnitList()
        {
            //Load();
        }

        // return all Units with this searchString name
        public List<Unit> FindByName(string searchString)
        {
            List<Unit> foundUnitsList = new List<Unit>();

            foreach (Unit iterUnit in theList)
            {
                if (iterUnit.m_name == searchString)
                {
                    foundUnitsList.Add(new Unit(iterUnit));
                }
            }
            return foundUnitsList;
        }

        // Get first Unit that is contained within searchString (return Unit and the other part of the string)
        public List<string> FindByNameSubString(string searchString)
        {
            List<string> foundUnitAndTheRestList = new List<string>();

            foreach (Unit iterUnit in theList)
            {
                if (searchString.Contains(iterUnit.m_name))
                {
                    foundUnitAndTheRestList.Add(iterUnit.m_name);
                    foundUnitAndTheRestList.Add(searchString.Replace(iterUnit.m_name,""));
                }
            }
            return foundUnitAndTheRestList;
        }


        public void Load()
        {
            theList = new List<Unit>();

            Action<Exception> errorHandler = (ex) =>
            {
                // Skapa grundkategorier
                theList = new List<Unit>{new Unit("g"),
                                        new Unit("hg"),
                                        new Unit("kg"),
                                        new Unit("tsk"),
                                        new Unit("msk"),
                                        new Unit("dl"),
                                        new Unit("l"),
                                        new Unit("pkt"),
                                        new Unit("port"),
                                        new Unit("st") };
            };

            try
            {
                using (Stream stream = File.Open("Unit.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    theList = (List<Unit>)bin.Deserialize(stream);  
                }
            }

            catch (IOException ex) { errorHandler(ex); }
            catch (System.Runtime.Serialization.SerializationException ex) { errorHandler(ex); }
        }

        public void Save()
        {
            try
            {
                using (Stream stream = File.Open("Unit.bin", FileMode.Create))
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

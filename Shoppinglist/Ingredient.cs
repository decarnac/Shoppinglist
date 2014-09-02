using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Shoppinglist
{
    [Serializable()]
    public class Ingredient
    {
        public Ingredient(string name, string nameplural, float amount, string measurement, string kat, string info)
        {
            Name            = name;
            NamePlural      = nameplural;
            Amount          = amount;
            Measurement     = measurement;
            Category        = kat;
            AdditionalInfo  = info;
        }

        public Ingredient(Ingredient ingrediens)
        {
            Name            = ingrediens.Name;
            NamePlural      = ingrediens.NamePlural;
            Amount          = ingrediens.Amount;
            Measurement     = ingrediens.Measurement;
            Category        = ingrediens.Category;
            AdditionalInfo  = ingrediens.AdditionalInfo;
        }

        public string Name
        {
            get;
            set;
        }

        public string NamePlural
        {
            get;
            set;
        }

        public float Amount
        {
            get;
            set;
            
        }

        public string Measurement
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public string AdditionalInfo
        {
            get;
            set;
        }

        public string serialize()
        {
            AdditionalInfo = (AdditionalInfo != "") ? ( "(" + AdditionalInfo + ")" ) : AdditionalInfo;
            return (Name + AdditionalInfo + " " + Amount + " " + Measurement);
        }

    }

    
    class IngrediensLista
    {
        //private List<Ingrediens> m_ingredienslistan;
        public List<Ingredient> listan{ get; set;}

        public IngrediensLista()
        {
            //listan = new List<Ingrediens>{new Ingrediens("paprika", 1, "st"),
            //                                    new Ingrediens("peppar", 20, "g"),
            //                                    new Ingrediens("persilja", 2, "l"),
            //                                    new Ingrediens("purjolök", 1, "st") };
            //Load();
            listan = new List<Ingredient>();
        }

        public void Load()
        {
            listan = new List<Ingredient>();

            Action<Exception> errorHandler = (ex) =>
            {
                // Skapa grundingredienser
                listan = new List<Ingredient>{  new Ingredient("paprika", "paprikor", 1, "st", "Grönsaker", ""),
                                                new Ingredient("peppar", "peppar", 20, "g", "Skafferi", ""),
                                                new Ingredient("persilja", "persiljor", 2, "st", "Grönsaker", ""),
                                                new Ingredient("tomat", "tomater", 2, "st", "Grönsaker", ""),
                                                new Ingredient("purjolök", "purjolökar", 1, "st", "Grönsaker", "") };
            };
            
            try
            {
                using (Stream stream = File.Open("ingredienser.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    listan = (List<Ingredient>)bin.Deserialize(stream);
                }
            }

            catch (IOException ex) { errorHandler(ex); }
            catch (System.Runtime.Serialization.SerializationException ex) { errorHandler(ex); }

        }

        public void Save()
        {
            try
            {
                using (Stream stream = File.Open("ingredienser.bin", FileMode.Create))
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

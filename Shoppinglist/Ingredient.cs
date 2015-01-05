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
        public Ingredient(string name, string nameplural, float amount, string unit, string cat, string info)
        {
            m_name            = name;
            m_namePlural      = nameplural;
            m_amount          = amount;
            m_unit            = unit;
            m_category        = cat;
            m_additionalInfo  = info;
        }

        public Ingredient(Ingredient ingrediens)
        {
            m_name            = ingrediens.m_name;
            m_namePlural      = ingrediens.m_namePlural;
            m_amount          = ingrediens.m_amount;
            m_unit            = ingrediens.m_unit;
            m_category        = ingrediens.m_category;
            m_additionalInfo  = ingrediens.m_additionalInfo;
        }

        public string m_name
        {
            get;
            set;
        }

        public string m_namePlural
        {
            get;
            set;
        }

        public float m_amount
        {
            get;
            set;
            
        }

        public string m_unit
        {
            get;
            set;
        }

        public string m_category
        {
            get;
            set;
        }

        public string m_additionalInfo
        {
            get;
            set;
        }

        public string serialize()
        {
            m_additionalInfo = (m_additionalInfo != "") ? ( "(" + m_additionalInfo + ")" ) : m_additionalInfo;
            return (m_name + m_additionalInfo + " " + m_amount + " " + m_unit);
        }
    }

    
    class IngredientList
    {
        //private List<Ingrediens> m_ingredienslistan;
        public List<Ingredient> theList{ get; set; }

        public IngredientList()
        {
            theList = new List<Ingredient>();
        }

        // Sort
        public void sortAlphabetical()
        {
            // Sort shoppinglist in alphabetical order
            var ingredients = from ingredient in theList
                              orderby ingredient.m_name
                              select ingredient;
            theList = ingredients.ToList();
        }

        // Find by exact name
        public List<Ingredient> FindByName(string searchString)
        {
            List<Ingredient> foundIngredientsList = new List<Ingredient>();

            foreach (Ingredient iterIngredient in theList)
            {
                if (iterIngredient.m_name == searchString ||
                    iterIngredient.m_namePlural == searchString)
                {
                    foundIngredientsList.Add(new Ingredient(iterIngredient));
                }
            }
            return foundIngredientsList;
        }


        public void Load()
        {
            theList = new List<Ingredient>();

            Action<Exception> errorHandler = (ex) =>
            {
                // Skapa grundingredienser
                theList = new List<Ingredient>{  new Ingredient("paprika", "paprikor", 1, "st", "Grönsaker", ""),
                                                new Ingredient("peppar", "peppar", 20, "g", "Skafferi", ""),
                                                new Ingredient("persilja", "persiljor", 2, "st", "Grönsaker", ""),
                                                new Ingredient("tomat", "tomater", 2, "st", "Grönsaker", ""),
                                                new Ingredient("purjolök", "purjolökar", 1, "st", "Grönsaker", "") };
            };
            
            try
            {
                using (Stream stream = File.Open("Ingredients.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    theList = (List<Ingredient>)bin.Deserialize(stream);
                }
            }

            catch (IOException ex) { errorHandler(ex); }
            catch (System.Runtime.Serialization.SerializationException ex) { errorHandler(ex); }

        }

        public void Save()
        {
            try
            {
                using (Stream stream = File.Open("Ingredients.bin", FileMode.Create))
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

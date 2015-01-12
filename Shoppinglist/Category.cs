using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Shoppinglist
{
    [Serializable()]
    public class Category
    {
        public Category(string name)
        {
            m_name = name;
        }

        public Category(Category kategori)
        {
            m_name = kategori.m_name;
        }

        public string m_name { get; set; }
    }

    class CategoryList
    {
        public List<Category> theList { get; set; }

        public CategoryList()
        {
            //Load();
        }

        public List<Category> FindByName(string searchString)
        {
            List<Category> foundCategoriesList = new List<Category>();

            foreach (Category iterCategory in theList)
            {
                if (iterCategory.m_name == searchString)
                {
                    foundCategoriesList.Add(new Category(iterCategory));
                }
            }
            return foundCategoriesList;
        }

        public void Load()
        {
            theList = new List<Category>();

            Action<Exception> errorHandler = ( ex ) => 
            {
                // Create base categories
                theList = new List<Category>{new Category("Apotek"),
                                            new Category("Bröd"),
                                            new Category("Chark"),
                                            new Category("Ost"),
                                            new Category("Frukt"),
                                            new Category("Grönsaker"),
                                            new Category("Mejeri"),
                                            new Category("Skafferi"),
                                            new Category("Barn"),
                                            new Category("Godis & Snacks"),
                                            new Category("Städ & Tvätt"),
                                            new Category("Hälsa & Skönhet"),
                                            new Category("Hem & Fritid"),
                                            new Category("Frysvaror"), 
                                            new Category("Övrigt"),
                                            new Category("Ignorera")};
            };

            try
            {
                using (Stream stream = File.Open("Category.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    theList = (List<Category>)bin.Deserialize(stream);
                }
            }
            catch (IOException ex) { errorHandler(ex); }
            catch (System.Runtime.Serialization.SerializationException ex) { errorHandler(ex); }
        }

        public void Save()
        {
            try
            {
                using (Stream stream = File.Open("Category.bin", FileMode.Create))
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

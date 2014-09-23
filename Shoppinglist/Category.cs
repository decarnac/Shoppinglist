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
            Name = name;
        }

        public Category(Category kategori)
        {
            Name = kategori.Name;
        }

        public string Name { get; set; }
    }

    class KategoriLista
    {
        public List<Category> theList { get; set; }

        public KategoriLista()
        {
            //Load();
        }

        public List<Category> FindByName(string searchString)
        {
            List<Category> foundCategoriesList = new List<Category>();

            foreach (Category iterCategory in theList)
            {
                if (iterCategory.Name == searchString)
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
                                            new Category("Torrvaror"),
                                            new Category("Skafferi"),
                                            new Category("Barn"),
                                            new Category("Godis & Snacks"),
                                            new Category("Städ & Tvätt"),
                                            new Category("Hälsa & Skönhet"),
                                            new Category("Hem & Fritid"),
                                            new Category("Frysvaror") };
            };

            try
            {
                using (Stream stream = File.Open("kategori.bin", FileMode.Open))
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
                using (Stream stream = File.Open("kategori.bin", FileMode.Create))
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

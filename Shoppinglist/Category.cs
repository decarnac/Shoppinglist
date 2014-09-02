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
        public List<Category> listan { get; set; }

        public KategoriLista()
        {
            //Load();
        }

        public void Load()
        {
            listan = new List<Category>();

            Action<Exception> errorHandler = ( ex ) => 
            {
                // Skapa grundkategorier
                listan = new List<Category>{new Category("Bröd"),
                                            new Category("Chark"),
                                            new Category("Frukt"),
                                            new Category("Grönsaker"),
                                            new Category("Mejeri"),
                                            new Category("Torrvaror"),
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
                    listan = (List<Category>)bin.Deserialize(stream);
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
                    bin.Serialize(stream, listan);
                }
            }
            catch (IOException)
            {
            }

        }
    }
}

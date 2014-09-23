using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shoppinglist
{
    enum returnvalue
    {
        eTrue = 0,
        eFalse,
        eStringIdentical,
        eStringSubString,
        eStringNotFound,
        eAccept,
        eCancel
    };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Ingredienslistan = new IngrediensLista();
            Kategorilistan = new KategoriLista();
            Måttlistan = new MåttLista();
            Shoppinglistan = new IngrediensLista();

            //ingrediensComboBox.Items.Add("paprika");
            //ingrediensComboBox.Items.Add("peppar");
            //ingrediensComboBox.Items.Add("persilja");
            //ingrediensComboBox.Items.Add("purjolök");

            //Ingredienslistan.theList = new List<Ingrediens>{new Ingrediens("paprika", 1, "st"),
            //                                    new Ingrediens("peppar", 20, "g"),
            //                                    new Ingrediens("persilja", 2, "l"),
            //                                    new Ingrediens("purjolök", 1, "st") };

            

            //Måttlistan.theList = new List<Mått>{new Mått("dl"),
            //                                    new Mått("g"),
            //                                    new Mått("st"),
            //                                    new Mått("l") };

            Ingredienslistan.Load();
            Ingredienslistan.Save();
            Kategorilistan.Load();
            Kategorilistan.Save();
            Måttlistan.Load();
            Måttlistan.Save();


            ingrediensComboBox.DataSource = Ingredienslistan.theList;
            ingrediensComboBox.DisplayMember = "Name";

            //mängdComboBox.DataSource = Kategorilistan.DataSource;
            //mängdComboBox.DisplayMember = "Mängd";
            mängdTextBox.Text = "1";

            måttComboBox.DataSource = Måttlistan.theList;
            måttComboBox.DisplayMember = "Name";

            //ingrediensComboBox.Text = "persilja";

            

        }
                
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            int i = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
        }

        private void ingrediensComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Ingredient selectedIngredient = ingrediensComboBox.SelectedItem as Ingredient;
                måttComboBox.Text = selectedIngredient.Measurement;
                mängdTextBox.Text = selectedIngredient.Amount.ToString();
            }
            catch (Exception ex)
            {
                måttComboBox.Text = "1";
                mängdTextBox.Text = "st";
            }
        }   

        private void mängdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void måttComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void läggtillingrediensButton_Click(object sender, EventArgs e)
        {
            Shoppinglistan.theList.Add(new Ingredient(ingrediensComboBox.Text, "", /*mängdTextBox.Text*/ 1, måttComboBox.Text, "", ""));
            inköpslistaTextBox.Clear();
            //inköpslistaTextBox.AppendText(Shoppinglist.theList.ElementAt(0).serialize());
        }

        private void läsInUrklippButton_Click(object sender, EventArgs e)
        {
            //
            // This string is also separated by Windows line breaks.
            //
            //string value = "shirt\r\ndress\r\npants\r\njacket\r\n\r\n";
            string value = läsInUrklippTextBox.Text;
            //
            // Use a new char[] array of two characters (\r and \n) to break
            // lines from into separate strings. Use "RemoveEmptyEntries"
            // to make sure no empty strings get put in the string array.
            //
            //char[] delimiters = new char[] { '\r', '\n', ' ' };
            char[] rowEndDelimiter = new char[] { '\n' };
            string[] rows = value.Split(rowEndDelimiter, StringSplitOptions.RemoveEmptyEntries);



            parseIngredientsDlg = new parseIngredientDlg();
            parseIngredientsDlg.setCategoryAlternatives(Kategorilistan.theList);
            parseIngredientsDlg.setIngredientAlternatives(Ingredienslistan.theList);
            parseIngredientsDlg.setMeasurementAlternatives(Måttlistan.theList);

            char[] splitRowDelimiter = new char[] { ' ', '(', ')', '[', ']', '.', ',', '\n' };

            Ingredient currentRow = new Ingredient("", "", 1, "st", "", "");
            
            List<string> name_and_extras = new List<string>();
            
            inköpslistaTextBox.ResetText();

            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = rows[i].ToLower();

                string[] rowParts = rows[i].Split(splitRowDelimiter, StringSplitOptions.RemoveEmptyEntries);

                bool isValidIngredient = false;
                bool foundDuplicate = false;

                if (rowParts.Length == 0)
                {
                    // Will probably never end up here
                    break;
                }
                else if (rowParts.Length == 1)
                {
                    currentRow.Amount = 1;
                    currentRow.Measurement = "st";
                    currentRow.AdditionalInfo = "";
                    currentRow.Name = rowParts[0];
                    currentRow.NamePlural = rowParts[0];
                    currentRow.Category = "";

                    List<Ingredient> ingredientSearch = Ingredienslistan.FindByName(rowParts[0]);

                    if (ingredientSearch.Count > 0)
                    {
                        currentRow.Name = ingredientSearch[0].Name;
                        currentRow.NamePlural = ingredientSearch[0].NamePlural;
                        currentRow.Category = ingredientSearch[0].Category;

                        isValidIngredient = true;
                        Shoppinglistan.theList.Add(new Ingredient(currentRow));

                    }
                }
                else if (rowParts.Length > 1)
                {
                    // Try to find Amount and Measurement
                    float ingredientAmount = 1;
                    string ingredientMeasurement = "st";

                    int partIndex = 0;
                    foreach (string part in rowParts)
                    {
                        List<Measurement> measurementSearch = Måttlistan.FindByName(part);
                        List<string> substringSearch = Måttlistan.FindByNameSubString(part);
                        
                        if( measurementSearch.Count > 0 )
                        {
                            ingredientMeasurement = part;

                            float searchAmount;
                            if(measurementSearch.Count < partIndex)
                            {
                                if (float.TryParse(rowParts[partIndex - 1], out searchAmount))
                                {
                                    ingredientAmount = searchAmount;
                                    break;
                                }
                            }
                            
                        }
                        else if (substringSearch.Count > 0)
                        {
                            float searchAmount;
                            if (float.TryParse(substringSearch[1], out searchAmount))
                            {
                                ingredientMeasurement = substringSearch[0];
                                ingredientAmount = searchAmount;
                                break;
                            }
                        }
                        else
                        {
                            float searchAmount;
                            if (float.TryParse(part, out searchAmount))
                            {
                                ingredientAmount = searchAmount;
                            }
                        }
                        partIndex++;
                    }

                    
                    // Setup some default values
                    currentRow.Name = "";
                    currentRow.Amount = ingredientAmount;
                    currentRow.Measurement = ingredientMeasurement;
                    currentRow.Category = "";
                    currentRow.NamePlural = "";
                    currentRow.AdditionalInfo = "";

                    name_and_extras.Clear();

                    // setup the array of words remaining after measurement and amount was removed.
                    for (int j = 0; j < (rowParts.Length); j++)
                    {
                        if (rowParts[j] != ingredientMeasurement &&
                            rowParts[j] != ingredientAmount.ToString() &&
                            rowParts[j] != (ingredientMeasurement + ingredientAmount.ToString()) &&
                            rowParts[j] != (ingredientAmount.ToString() + ingredientMeasurement)
                            )
                        {
                            name_and_extras.Add(rowParts[j]);
                        }
                    }

                    

                    currentRow.AdditionalInfo = "";
                    // TODO
                    // if searchstring contain more than 1 valid Ingredient then the first one will be discarded :/
                    foreach (string searchstring in name_and_extras)
                    {
                        // Find Ingredient/s with same name
                        List<Ingredient> searchIngredients = Ingredienslistan.FindByName(searchstring);

                        if (searchIngredients.Count > 0)
                        {
                            isValidIngredient = true;

                            // Also match Measurement
                            Ingredient useThisIngredient = searchIngredients[0];
                            foreach(Ingredient ingredientIter in searchIngredients)
                            {
                                if (ingredientIter.Measurement == currentRow.Measurement)
                                {
                                    useThisIngredient = ingredientIter;
                                    break;
                                }
                            }

                            currentRow.Name = useThisIngredient.Name;
                            currentRow.NamePlural = useThisIngredient.NamePlural;
                            currentRow.Category = useThisIngredient.Category;

                            foreach (Ingredient iterIngredient in Shoppinglistan.theList)
                            {
                                if (iterIngredient.Name == currentRow.Name &&
                                    iterIngredient.NamePlural == currentRow.NamePlural &&
                                    iterIngredient.Category == currentRow.Category &&
                                    iterIngredient.AdditionalInfo == currentRow.AdditionalInfo &&
                                    iterIngredient.Measurement == currentRow.Measurement)
                                {
                                    iterIngredient.Amount += currentRow.Amount;
                                    foundDuplicate = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (currentRow.AdditionalInfo != "")
                            {
                                currentRow.AdditionalInfo += " ";
                            }
                            currentRow.AdditionalInfo += searchstring;
                        }
                    }
                }

                if (isValidIngredient && !foundDuplicate)
                {
                    Shoppinglistan.theList.Add(new Ingredient(currentRow));
                }
                else if (!isValidIngredient)
                {
                    parseIngredientsDlg.resetForm();
                    parseIngredientsDlg.setUnknownIngredient(rows[i]);
                    parseIngredientsDlg.setIngredientText(currentRow.Name);
                    parseIngredientsDlg.setPluralNameText(currentRow.NamePlural);
                    parseIngredientsDlg.setCategoryText(currentRow.Category);
                    parseIngredientsDlg.setMeasurementText(currentRow.Measurement);
                    parseIngredientsDlg.setAmountValue(currentRow.Amount);
                    parseIngredientsDlg.setExtraInfo(currentRow.AdditionalInfo);

                    parseIngredientsDlg.StartPosition = FormStartPosition.CenterScreen;
                    
                    parseIngredientsDlg.ShowDialog();
                    if (parseIngredientsDlg.DialogResult == DialogResult.OK)
                    {
                        currentRow.Name             = parseIngredientsDlg.getIngredientText();
                        currentRow.NamePlural       = parseIngredientsDlg.getPluralNameText();
                        currentRow.Category         = parseIngredientsDlg.getCategoryText();
                        currentRow.Amount           = float.Parse(parseIngredientsDlg.getAmountValue());
                        currentRow.Measurement      = parseIngredientsDlg.getMeasurementText();
                        currentRow.AdditionalInfo   = parseIngredientsDlg.getExtraInfo();
                        
                        Shoppinglistan.theList.Add(new Ingredient(currentRow));

                        Ingredienslistan.theList.Add(new Ingredient(currentRow));
                    }
                    else
                    {
                        int hgjghj = 12;
                    }

                }
            }

            // Sortera inköpslistan i alfabetisk ordning
            var ingredients = from ingredient in Shoppinglistan.theList
                              orderby ingredient.Name
                              select ingredient;

            inköpslistaTextBox.Clear();
            foreach (Category category in Kategorilistan.theList)
            {
                string categoryHeader = "", ingredientsInCategory = "";
                categoryHeader = (category.Name + "\n" + "--------------------" + "\n");
                foreach (Ingredient ingredient in ingredients)
                {
                    if (ingredient.Category == category.Name)
                    {
                        ingredientsInCategory += (ingredient.serialize() + "\n");
                    }
                }
                if (ingredientsInCategory != "")
                {
                    inköpslistaTextBox.AppendText(categoryHeader + ingredientsInCategory);
                }
            }
            Shoppinglistan.theList.Clear();
            Ingredienslistan.Save();
        }

            //private returnvalue fixMeasurement(string target, ref string [] source)
            //{
            //    foreach (Measurement measureIterator1 in Måttlistan.theList)
            //    {
            //        if (target == measureIterator1.Name)
            //        {
            //            return returnvalue.eStringIdentical;
            //        }
            //        else 
            //        {
            //            if (target.Contains(measureIterator1.Name))
            //            {
            //                string temp = target.Replace(measureIterator1.Name, "");
            //                Array.Resize(ref source, source.Length + 1);
            //                source[source.Length-2] = temp;
            //                source[source.Length-1] = measureIterator1.Name;
            //                return returnvalue.eStringSubString;
            //            }
            //        }
            //    }
            //    return returnvalue.eStringNotFound;
            //}

        private void changeingredientButton_Click(object sender, EventArgs e)
        {
            parseIngredientsDlg = new parseIngredientDlg();
            parseIngredientsDlg.setCategoryAlternatives(Kategorilistan.theList);
            parseIngredientsDlg.setIngredientAlternatives(Ingredienslistan.theList);
            parseIngredientsDlg.setMeasurementAlternatives(Måttlistan.theList);

            Ingredient ingredient;

            Predicate<Ingredient> ingrediensFinder = (Ingredient p) =>
            {
                return p.Name == ingrediensComboBox.Text;
            };
            try
            {
                ingredient = Ingredienslistan.theList.Find(ingrediensFinder);

                if (ingredient != null)
                {
                    parseIngredientsDlg.setUnknownIngredient("");
                    parseIngredientsDlg.setIngredientText(ingredient.Name);
                    parseIngredientsDlg.setPluralNameText(ingredient.NamePlural);
                    parseIngredientsDlg.setCategoryText(ingredient.Category);
                    parseIngredientsDlg.setMeasurementText(ingredient.Measurement);
                    parseIngredientsDlg.setAmountValue(1);
                    parseIngredientsDlg.setExtraInfo("");
                }
                else
                {
                    parseIngredientsDlg.setUnknownIngredient("");
                    parseIngredientsDlg.setIngredientText(ingrediensComboBox.Text);
                    parseIngredientsDlg.setPluralNameText("");
                    parseIngredientsDlg.setCategoryText("");
                    parseIngredientsDlg.setMeasurementText("st");
                    parseIngredientsDlg.setAmountValue(1);
                    parseIngredientsDlg.setExtraInfo("");
                }
                
                parseIngredientsDlg.StartPosition = FormStartPosition.CenterScreen;
                parseIngredientsDlg.ShowDialog();
                
                if (parseIngredientsDlg.DialogResult == DialogResult.OK)
                {
                    Predicate<Ingredient> ingrediensFinder2 = (Ingredient p) =>
                    {
                        return p.Name == parseIngredientsDlg.getIngredientText();
                    };

                    Ingredient ingredientUpdated = Ingredienslistan.theList.Find(ingrediensFinder2);

                    if (ingredientUpdated == null)
                    {
                        ingredientUpdated = new Ingredient( parseIngredientsDlg.getIngredientText(), 
                                                            parseIngredientsDlg.getPluralNameText(), 
                                                            float.Parse(parseIngredientsDlg.getAmountValue()), 
                                                            parseIngredientsDlg.getMeasurementText(),
                                                            parseIngredientsDlg.getCategoryText(),
                                                            parseIngredientsDlg.getExtraInfo());

                        Ingredienslistan.theList.Add(ingredientUpdated);
                        
                        ingrediensComboBox.ResetText();

                        ingrediensComboBox.DataSource = null;
                        ingrediensComboBox.DataSource = Ingredienslistan.theList;
                        ingrediensComboBox.DisplayMember = "Name";
                    }
                    else
                    {
                        ingredient.Name         = parseIngredientsDlg.getIngredientText();
                        ingredient.NamePlural   = parseIngredientsDlg.getPluralNameText(); 
                        ingredient.Amount       = float.Parse(parseIngredientsDlg.getAmountValue());
                        ingredient.Measurement  = parseIngredientsDlg.getMeasurementText();
                        ingredient.Category     = parseIngredientsDlg.getCategoryText();
                        ingredient.AdditionalInfo = parseIngredientsDlg.getExtraInfo();
                    }
                    
                    Ingredienslistan.Save();
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}

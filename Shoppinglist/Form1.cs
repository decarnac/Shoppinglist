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

            //Ingredienslistan.listan = new List<Ingrediens>{new Ingrediens("paprika", 1, "st"),
            //                                    new Ingrediens("peppar", 20, "g"),
            //                                    new Ingrediens("persilja", 2, "l"),
            //                                    new Ingrediens("purjolök", 1, "st") };

            

            //Måttlistan.listan = new List<Mått>{new Mått("dl"),
            //                                    new Mått("g"),
            //                                    new Mått("st"),
            //                                    new Mått("l") };

            Ingredienslistan.Load();
            Ingredienslistan.Save();
            Kategorilistan.Load();
            Kategorilistan.Save();
            Måttlistan.Load();
            Måttlistan.Save();


            ingrediensComboBox.DataSource = Ingredienslistan.listan;
            ingrediensComboBox.DisplayMember = "Name";

            //mängdComboBox.DataSource = Kategorilistan.DataSource;
            //mängdComboBox.DisplayMember = "Mängd";
            mängdTextBox.Text = "1";

            måttComboBox.DataSource = Måttlistan.listan;
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
            Shoppinglistan.listan.Add(new Ingredient(ingrediensComboBox.Text, "", /*mängdTextBox.Text*/ 1, måttComboBox.Text, "", ""));
            inköpslistaTextBox.Clear();
            //inköpslistaTextBox.AppendText(Shoppinglistan.listan.ElementAt(0).serialize());
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
            parseIngredientsDlg.setCategoryAlternatives(Kategorilistan.listan);
            parseIngredientsDlg.setIngredientAlternatives(Ingredienslistan.listan);
            parseIngredientsDlg.setMeasurementAlternatives(Måttlistan.listan);

            char[] splitRowDelimiter = new char[] { ' ', '\n' };

            Ingredient currentRow = new Ingredient("", "", 1, "st", "", "");
            List<string> name_and_extras = new List<string>();
            inköpslistaTextBox.ResetText();

            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = rows[i].ToLower();

                string[] rowParts = rows[i].Split(splitRowDelimiter, StringSplitOptions.RemoveEmptyEntries);

                bool isValidIngredient = false;

                if (rowParts.Length == 0)
                {
                    // Will probably never end up here
                    break;
                }
                else if (rowParts.Length == 1)
                {
                    
                    foreach (Ingredient iterIngredient in Ingredienslistan.listan)
                    {
                        if (iterIngredient.Name == rowParts[0] ||
                            iterIngredient.NamePlural == rowParts[0])
                        {
                            currentRow.Name = iterIngredient.Name;
                            currentRow.NamePlural = iterIngredient.NamePlural;
                            currentRow.Category = iterIngredient.Category;
                            isValidIngredient = true;
                            Shoppinglistan.listan.Add(new Ingredient(currentRow));
                            break;
                        }
                    }
                }
                    // fix to else perhaps
                else if (rowParts.Length > 1)
                {

                    // fix me när ingrediens + amount men inte measurement finns
                    if (fixMeasurement(rowParts[rowParts.Length - 1], ref rowParts) != returnvalue.eStringNotFound)
                    {
                        //foreach (string rowPart in rowParts)
                        //{
                        //    string text1 = "21";
                        //    float num1;
                        //    bool res = float.TryParse(text1, out num1);
                        //    if (res == false)
                        //    {
                        //        int temp = 0;
                        //        // String is not a number.
                        //    }
                        //}
                        float ingredientAmount;

                        if (float.TryParse(rowParts[rowParts.Length - 2], out ingredientAmount))
                        {
                            currentRow.Name = "";
                            currentRow.Amount = ingredientAmount;
                            currentRow.Measurement = rowParts[rowParts.Length - 1];
                            currentRow.Category = "";
                            currentRow.NamePlural = "";
                            currentRow.AdditionalInfo = "";

                            name_and_extras.Clear();

                            for (int j = 0; j <= (rowParts.Length - 3); j++)
                            {
                                name_and_extras.Add(rowParts[j]);
                                //currentRow.Name += (" " + rowParts[j]);
                            }

                            foreach (Ingredient ingrediens in Ingredienslistan.listan)
                            {
                                bool isIngredientFound = false;
                                currentRow.AdditionalInfo = "";
                                foreach (string searchstring in name_and_extras)
                                {
                                    if (ingrediens.Name == searchstring || ingrediens.NamePlural == searchstring)
                                    {
                                        currentRow.Name = ingrediens.Name;
                                        currentRow.NamePlural = ingrediens.NamePlural;
                                        isIngredientFound = true;
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
                                if (isIngredientFound &&
                                    ingrediens.Measurement == currentRow.Measurement)
                                {
                                    currentRow.Category = ingrediens.Category;

                                    bool foundDuplicate = false;
                                    foreach (Ingredient iterIngredient in Shoppinglistan.listan)
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

                                    if (!foundDuplicate)
                                    {
                                        Shoppinglistan.listan.Add(new Ingredient(currentRow));
                                    }



                                    isValidIngredient = true;

                                    break;
                                }
                                else
                                {
                                    int stophere = 00;
                                }

                                //if (ingrediens.Name == currentRow.Name &&
                                //    ingrediens.Measurement == currentRow.Measurement)
                                //{
                                //    currentRow.NamePlural = ingrediens.NamePlural;

                                //    currentRow.Category = ingrediens.Category;
                                //    Shoppinglistan.listan.Add(new Ingredient(currentRow));

                                //    isValidIngredient = true;

                                //    break;
                                //}
                                //else if(currentRow.Name.Contains(ingrediens.Name) &&
                                //        ingrediens.Measurement == currentRow.Measurement)
                                //{
                                //    currentRow.AdditionalInfo = currentRow.Name.Replace(ingrediens.Name, "");

                                //    currentRow.Name = ingrediens.Name;

                                //    currentRow.NamePlural = ingrediens.NamePlural;

                                //    currentRow.Category = ingrediens.Category;

                                //    Shoppinglistan.listan.Add(new Ingredient(currentRow));

                                //    isValidIngredient = true;

                                //    break;
                                //}
                                //else if(ingrediens.NamePlural != "" &&
                                //        ingrediens.NamePlural == currentRow.Name &&
                                //        ingrediens.Measurement == currentRow.Measurement)
                                //{
                                //    currentRow.Name = ingrediens.Name;
                                //    currentRow.NamePlural = ingrediens.NamePlural;

                                //    currentRow.Category = ingrediens.Category;

                                //    Shoppinglistan.listan.Add(new Ingredient(currentRow));

                                //    isValidIngredient = true;

                                //    break;
                                //}
                                //else if (ingrediens.NamePlural != "" &&
                                //        currentRow.Name.Contains(ingrediens.NamePlural) &&
                                //        ingrediens.Measurement == currentRow.Measurement)
                                //{
                                //    try
                                //    {
                                //        currentRow.AdditionalInfo = currentRow.Name.Replace(ingrediens.NamePlural, "");
                                //    }
                                //    catch (Exception ex)
                                //    {
                                //        currentRow.AdditionalInfo = "";
                                //    }
                                //    currentRow.Name = ingrediens.Name;
                                //    currentRow.NamePlural = ingrediens.NamePlural;



                                //    currentRow.Category = ingrediens.Category;

                                //    Shoppinglistan.listan.Add(new Ingredient(currentRow));

                                //    isValidIngredient = true;

                                //    break;
                                // }
                            }
                        }
                    }
                }
                
                if (!isValidIngredient)
                {
                    parseIngredientsDlg.resetForm();
                    parseIngredientsDlg.setUnknownIngredient(rows[i]);
                    parseIngredientsDlg.setIngredientText(currentRow.Name);
                    parseIngredientsDlg.setPluralNameText(currentRow.NamePlural);
                    parseIngredientsDlg.setCategoryText(currentRow.Category);
                    parseIngredientsDlg.setMeasurementText(currentRow.Measurement);
                    parseIngredientsDlg.setAmountValue(currentRow.Amount);
                    parseIngredientsDlg.setExtraInfo("");

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
                        
                        Shoppinglistan.listan.Add(new Ingredient(currentRow));

                        Ingredienslistan.listan.Add(new Ingredient(currentRow));
                    }
                    else
                    {
                        int hgjghj = 12;
                    }

                }
            }

            // Sortera inköpslistan i alfabetisk ordning
            var ingredients = from ingredient in Shoppinglistan.listan
                              orderby ingredient.Name
                              select ingredient;

            inköpslistaTextBox.Clear();
            foreach (Category category in Kategorilistan.listan)
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
            Shoppinglistan.listan.Clear();
            Ingredienslistan.Save();
        }

        private returnvalue fixMeasurement(string target, ref string [] source)
        {
            foreach (Measurement measureIterator1 in Måttlistan.listan)
            {
                if (target == measureIterator1.Name)
                {
                    return returnvalue.eStringIdentical;
                }
                else 
                {
                    if (target.Contains(measureIterator1.Name))
                    {
                        string temp = target.Replace(measureIterator1.Name, "");
                        Array.Resize(ref source, source.Length + 1);
                        source[source.Length-2] = temp;
                        source[source.Length-1] = measureIterator1.Name;
                        return returnvalue.eStringSubString;
                    }
                }
            }
            return returnvalue.eStringNotFound;
        }

        private void changeingredientButton_Click(object sender, EventArgs e)
        {
            parseIngredientsDlg = new parseIngredientDlg();
            parseIngredientsDlg.setCategoryAlternatives(Kategorilistan.listan);
            parseIngredientsDlg.setIngredientAlternatives(Ingredienslistan.listan);
            parseIngredientsDlg.setMeasurementAlternatives(Måttlistan.listan);

            Ingredient ingredient;

            Predicate<Ingredient> ingrediensFinder = (Ingredient p) =>
            {
                return p.Name == ingrediensComboBox.Text;
            };
            try
            {
                ingredient = Ingredienslistan.listan.Find(ingrediensFinder);

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

                    Ingredient ingredientUpdated = Ingredienslistan.listan.Find(ingrediensFinder2);

                    if (ingredientUpdated == null)
                    {
                        ingredientUpdated = new Ingredient( parseIngredientsDlg.getIngredientText(), 
                                                            parseIngredientsDlg.getPluralNameText(), 
                                                            float.Parse(parseIngredientsDlg.getAmountValue()), 
                                                            parseIngredientsDlg.getMeasurementText(),
                                                            parseIngredientsDlg.getCategoryText(),
                                                            parseIngredientsDlg.getExtraInfo());

                        Ingredienslistan.listan.Add(ingredientUpdated);
                        
                        ingrediensComboBox.ResetText();

                        ingrediensComboBox.DataSource = null;
                        ingrediensComboBox.DataSource = Ingredienslistan.listan;
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

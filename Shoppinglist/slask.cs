using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shoppinglist
{
    class slask
    {
        //Predicate<Ingrediens> ingrediensFinder = (Ingrediens p) => { 
        //                                                            return p.Namn == ingrediensComboBox.Text; 
        //                                                           };
        //Ingrediens test = new Ingrediens(Ingredienslistan.listan.Find(ingrediensFinder));
        //måttComboBox.Text = test.Mått;


        //mängdComboBox.DataSource = Kategorilistan.DataSource;
        //mängdComboBox.DisplayMember = "Mängd";
    }

    //private void ParseButton_Click(object sender, EventArgs e)
    //    {
    //        // Init locals
    //        // The row currently being parsed is temporarily stored in here
    //        Ingredient currentRowIngredient = new Ingredient("", "", 1, "st", "", "");

    //        // Words remaining after unit and amount was removed from row is temporarily stored in here
    //        List<string> name_and_extras = new List<string>();

    //        // Use these chars to split row into words below.
    //        char[] splitRowDelimiter = new char[] { ' ', '(', ')', '[', ']', '.', ',', '\n' };
            
    //        // Use these chars to split text into rows below.
    //        char[] rowEndDelimiter = new char[] { '\n' };

    //        // Reset the text for the produced shoppinglist.
    //        shoppingListTextBox.ResetText();

    //        // Init Ingredient editing dialog
    //        initParseIngredientDialog();

    //        // Separate cutPasteTextBox content into separate rows.
    //        string value = cutPasteTextBox.Text;
    //        string[] rows = value.Split(rowEndDelimiter, StringSplitOptions.RemoveEmptyEntries);

    //        // Loop all rows
    //        for (int i = 0; i < rows.Length; i++)
    //        {
    //            bool isValidIngredient = false;
    //            bool foundDuplicate = false;

    //            rows[i] = rows[i].ToLower();

    //            // Split into words
    //            string[] rowParts = rows[i].Split(splitRowDelimiter, StringSplitOptions.RemoveEmptyEntries);

    //            if (rowParts.Length == 0)
    //            {
    //                // Will probably never end up here
    //                break;
    //            }
    //            // Only 1 word in row?
    //            else if (rowParts.Length == 1)
    //            {
    //                // Set some defaults
    //                currentRowIngredient.m_amount = 1;
    //                currentRowIngredient.m_unit = "st";
    //                currentRowIngredient.m_additionalInfo = "";
    //                currentRowIngredient.m_name = rowParts[0];
    //                currentRowIngredient.m_namePlural = rowParts[0];
    //                currentRowIngredient.m_category = "";

    //                // Does the 1 word match any known ingredients?
    //                List<Ingredient> ingredientSearch = m_ingredientList.FindByName(rowParts[0]);
    //                if (ingredientSearch.Count > 0)
    //                {
    //                    // Overwrite defaults with info from already known ingredient
    //                    currentRowIngredient.m_name = ingredientSearch[0].m_name;
    //                    currentRowIngredient.m_namePlural = ingredientSearch[0].m_namePlural;
    //                    currentRowIngredient.m_category = ingredientSearch[0].m_category;

    //                    isValidIngredient = true;
    //                }
    //            }
    //            // row with multiple words?
    //            else if (rowParts.Length > 1)
    //            {
    //                // Try to find Amount and Unit among the words in the row
    //                // Set defaults
    //                float ingredientAmount = 1;
    //                string ingredientUnit = "st";

    //                // check all words for matching unit name
    //                int partIndex = 0;
    //                foreach (string part in rowParts)
    //                {
    //                    List<Unit> unitSearch = m_unitList.FindByName(part);
    //                    List<string> substringSearch = m_unitList.FindByNameSubString(part);

    //                    // Unitname found, exact word match?
    //                    if( unitSearch.Count > 0 )
    //                    {
                            
    //                        ingredientUnit = part;

    //                        float searchAmount;
    //                        if (unitSearch.Count < partIndex && unitSearch.Count != 1)
    //                        {
    //                            // try to parse an amount value from the previous word
    //                            if (float.TryParse(rowParts[partIndex - 1], out searchAmount))
    //                            {
    //                                ingredientAmount = searchAmount;
    //                                break;
    //                            }
    //                        }
    //                    }
    //                    // unitname found in word substring?
    //                    else if (substringSearch.Count > 0)
    //                    {
    //                        // try to parse an amount value from the remainder of the word
    //                        float searchAmount;
    //                        if (float.TryParse(substringSearch[1], out searchAmount))
    //                        {
    //                            ingredientUnit = substringSearch[0];
    //                            ingredientAmount = searchAmount;
    //                            break;
    //                        }
    //                    }
    //                    // try to use word as amount
    //                    else
    //                    {
    //                        float searchAmount;
    //                        if (float.TryParse(part, out searchAmount))
    //                        {
    //                            ingredientAmount = searchAmount;
    //                        }
    //                    }
    //                    partIndex++;
    //                }

                    
    //                // Start assembling the ingredient with amount and unit
    //                currentRowIngredient.m_name = "";
    //                currentRowIngredient.m_amount = ingredientAmount;
    //                currentRowIngredient.m_unit = ingredientUnit;
    //                currentRowIngredient.m_category = "";
    //                currentRowIngredient.m_namePlural = "";
    //                currentRowIngredient.m_additionalInfo = "";

    //                name_and_extras.Clear();

    //                // setup the array of words remaining after unit and amount was removed.
    //                for (int j = 0; j < (rowParts.Length); j++)
    //                {
    //                    if (rowParts[j] != ingredientUnit &&
    //                        rowParts[j] != ingredientAmount.ToString() &&
    //                        rowParts[j] != (ingredientUnit + ingredientAmount.ToString()) &&
    //                        rowParts[j] != (ingredientAmount.ToString() + ingredientUnit)
    //                        )
    //                    {
    //                        name_and_extras.Add(rowParts[j]);
    //                    }
    //                }

    //                currentRowIngredient.m_additionalInfo = "";
    //                // TODO
    //                // if searchstring contain more than 1 valid Ingredient then the first one will be discarded :/
    //                foreach (string searchstring in name_and_extras)
    //                {
    //                    // Find Ingredient/s with same name
    //                    List<Ingredient> searchIngredients = m_ingredientList.FindByName(searchstring);

    //                    if (searchIngredients.Count > 0)
    //                    {
    //                        isValidIngredient = true;

    //                        // Also match Unit
    //                        Ingredient useThisIngredient = searchIngredients[0];
    //                        foreach(Ingredient ingredientIter in searchIngredients)
    //                        {
    //                            if (ingredientIter.m_unit == currentRowIngredient.m_unit)
    //                            {
    //                                useThisIngredient = ingredientIter;
    //                                break;
    //                            }
    //                        }

    //                        // Start assembling the ingredient with name, nameplural and category
    //                        currentRowIngredient.m_name = useThisIngredient.m_name;
    //                        currentRowIngredient.m_namePlural = useThisIngredient.m_namePlural;
    //                        currentRowIngredient.m_category = useThisIngredient.m_category;

    //                        // If this ingredient already have been added, just add to the amount.
    //                        foreach (Ingredient iterIngredient in m_shoppingList.theList)
    //                        {
    //                            if (iterIngredient.m_name == currentRowIngredient.m_name &&
    //                                iterIngredient.m_namePlural == currentRowIngredient.m_namePlural &&
    //                                iterIngredient.m_category == currentRowIngredient.m_category &&
    //                                iterIngredient.m_additionalInfo == currentRowIngredient.m_additionalInfo &&
    //                                iterIngredient.m_unit == currentRowIngredient.m_unit)
    //                            {
    //                                iterIngredient.m_amount += currentRowIngredient.m_amount;
    //                                foundDuplicate = true;
    //                                break;
    //                            }
    //                        }
    //                    }
    //                    // Append unused words to additional ingredient info
    //                    else
    //                    {
    //                        if (currentRowIngredient.m_additionalInfo != "")
    //                        {
    //                            currentRowIngredient.m_additionalInfo += " ";
    //                        }
    //                        currentRowIngredient.m_additionalInfo += searchstring;
    //                    }
    //                }
    //            }

    //            // Add to list if ingredient already known
    //            if (isValidIngredient && !foundDuplicate)
    //            {
    //                m_shoppingList.theList.Add(new Ingredient(currentRowIngredient));
    //                m_shoppingList.sortAlphabetical();
    //            }
    //            // if ingredient unknown, show ingredient specification dialog
    //            else if (!isValidIngredient)
    //            {
    //                initParseIngredientDialog();
    //                parseIngredientsDlg.setUnknownIngredient(rows[i]);
    //                parseIngredientsDlg.setIngredientText(currentRowIngredient.m_name);
    //                parseIngredientsDlg.setPluralNameText(currentRowIngredient.m_namePlural);
    //                parseIngredientsDlg.setCategoryText(currentRowIngredient.m_category);
    //                parseIngredientsDlg.setUnitText(currentRowIngredient.m_unit);
    //                parseIngredientsDlg.setAmountValue(currentRowIngredient.m_amount);
    //                parseIngredientsDlg.setExtraInfo(currentRowIngredient.m_additionalInfo);

    //                parseIngredientsDlg.StartPosition = FormStartPosition.CenterScreen;
                    
    //                parseIngredientsDlg.ShowDialog();
    //                if (parseIngredientsDlg.DialogResult == DialogResult.OK)
    //                {
    //                    currentRowIngredient.m_name             = parseIngredientsDlg.getIngredientText();
    //                    currentRowIngredient.m_namePlural       = parseIngredientsDlg.getPluralNameText();
    //                    currentRowIngredient.m_category         = parseIngredientsDlg.getCategoryText();
    //                    currentRowIngredient.m_amount           = float.Parse(parseIngredientsDlg.getAmountValue());
    //                    currentRowIngredient.m_unit             = parseIngredientsDlg.getUnitText();
    //                    currentRowIngredient.m_additionalInfo   = parseIngredientsDlg.getExtraInfo();

    //                    m_shoppingList.theList.Add(new Ingredient(currentRowIngredient));

    //                    m_ingredientList.theList.Add(new Ingredient(currentRowIngredient));
    //                }
    //                else
    //                {
    //                    int hgjghj = 12;
    //                }

    //            }
    //        }

    //        // Sort shoppinglist in alphabetical order
    //        var ingredients = from ingredient in m_shoppingList.theList
    //                          orderby ingredient.m_name
    //                          select ingredient;

    //        // Produce a new shoppinglist in the window
    //        shoppingListTextBox.Clear();
    //        foreach (Category category in m_categoryList.theList)
    //        {
    //            string categoryHeader = "", ingredientsInCategory = "";
    //            categoryHeader = ("--------------------" + "\n" + category.m_name + "\n" + "--------------------" + "\n");
    //            foreach (Ingredient ingredient in ingredients)
    //            {
    //                if (ingredient.m_category == category.m_name)
    //                {
    //                    ingredientsInCategory += (ingredient.serialize() + "\n");
    //                }
    //            }
    //            if (ingredientsInCategory != "")
    //            {
    //                shoppingListTextBox.AppendText(categoryHeader + ingredientsInCategory);
    //            }
    //        }

    //        // Finish up
    //        m_shoppingList.theList.Clear();
    //        m_ingredientList.sortAlphabetical();
    //        m_ingredientList.Save();
    //    }
}

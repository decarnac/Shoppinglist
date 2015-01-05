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
    public partial class parseIngredientDlg : Form
    {
        public parseIngredientDlg()
        {
            InitializeComponent();
            this.parseIngredientDlgAcceptBtn.DialogResult = DialogResult.OK;
            this.AcceptButton = this.parseIngredientDlgAcceptBtn;
            this.CancelButton = this.parseIngredientDlgDiscardBtn;
        }

        public void resetForm()
        {
            parseIngredientDlgCategoryComboBox.SelectedIndex = -1;
            parseIngredientDlgIngredientsComboBox.Text = "";

            parseIngredientDlgUnitComboBox.SelectedIndex = -1;

            parseIngredientDlgAmountComboBox.Text = "1";

            parseIngredientDlgPluralNameTextBox.Text = "";

            parseIngredientDlgCategoryComboBox.Text = "";

        }

        public void setUnknownIngredient(string Text)
        {
            parseIngredientDlgUnknownTextBox.Text = Text;
        }

        public void setCategoryText(string Text)
        {
            parseIngredientDlgCategoryComboBox.Text = Text;
        }

        public string getCategoryText()
        {
            return parseIngredientDlgCategoryComboBox.Text;
        }

        public void setCategoryAlternatives( List<Category> categories)
        {
            m_categories = new List<Category>(categories);

            parseIngredientDlgCategoryComboBox.DataSource = null;
            parseIngredientDlgCategoryComboBox.DataSource = m_categories;
            parseIngredientDlgCategoryComboBox.DisplayMember = "m_name";
            parseIngredientDlgCategoryComboBox.SelectedIndex = -1;
        }

        public void setIngredientText(string Text)
        {
            parseIngredientDlgIngredientsComboBox.Text = Text;
        }

        public string getIngredientText()
        {
            return parseIngredientDlgIngredientsComboBox.Text;
        }

        public void setIngredientAlternatives(List<Ingredient> ingredients)
        {
            m_ingredients = new List<Ingredient>(ingredients);
            parseIngredientDlgIngredientsComboBox.DataSource = null;
            parseIngredientDlgIngredientsComboBox.DataSource = m_ingredients;
            parseIngredientDlgIngredientsComboBox.DisplayMember = "m_name";
            parseIngredientDlgIngredientsComboBox.SelectedIndex = -1;
        }

        public void setUnitText(string Text)
        {
            parseIngredientDlgUnitComboBox.Text = Text;
        }

        public string getUnitText()
        {
            return parseIngredientDlgUnitComboBox.Text;
        }

        public void setUnitAlternatives(List<Unit> unit)
        {
            m_unit = new List<Unit>(unit);
            parseIngredientDlgUnitComboBox.DataSource = null;
            parseIngredientDlgUnitComboBox.DataSource = m_unit;
            parseIngredientDlgUnitComboBox.DisplayMember = "m_name";
            parseIngredientDlgUnitComboBox.SelectedIndex = -1;
        }

        public void setPluralNameText(string Text)
        {
            parseIngredientDlgPluralNameTextBox.Text = Text;
        }

        public string getPluralNameText()
        {
            return parseIngredientDlgPluralNameTextBox.Text;
        }        

        public void setAmountValue(float value)
        {
            parseIngredientDlgAmountComboBox.Text = value.ToString();
        }

        public string getAmountValue()
        {
            return parseIngredientDlgAmountComboBox.Text;
        }

        public void setExtraInfo(string Text)
        {
            parseIngredientDlgExtraInfoComboBox.Text = Text;
        }

        public string getExtraInfo()
        {
            return parseIngredientDlgExtraInfoComboBox.Text;
        }

        private void parseIngredientDlgAcceptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void parseIngredientDlgIngredientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((parseIngredientDlgIngredientsComboBox.SelectedIndex < m_ingredients.Count) && (parseIngredientDlgIngredientsComboBox.SelectedIndex >= 0))
            {
                parseIngredientDlgPluralNameTextBox.Text = m_ingredients.ElementAt(parseIngredientDlgIngredientsComboBox.SelectedIndex).m_namePlural;
            }
        }

        private void parseIngredientDlgIngredientsComboBox_Leave(object sender, EventArgs e)
        {
             parseIngredientDlgIngredientsComboBox.Text = parseIngredientDlgIngredientsComboBox.Text.Trim();
        }
        
        private void parseIngredientDlgPluralNameTextBox_Leave(object sender, EventArgs e)
        {
            parseIngredientDlgPluralNameTextBox.Text = parseIngredientDlgPluralNameTextBox.Text.Trim();
        }

        private void parseIngredientDlgExtraInfoComboBox_Leave(object sender, EventArgs e)
        {
            parseIngredientDlgExtraInfoComboBox.Text = parseIngredientDlgExtraInfoComboBox.Text.Trim();
        }

        private void parseIngredientDlgAmountComboBox_Leave(object sender, EventArgs e)
        {
            parseIngredientDlgAmountComboBox.Text = parseIngredientDlgAmountComboBox.Text.Trim();
        }
    }
}

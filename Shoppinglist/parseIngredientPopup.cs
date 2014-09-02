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

            parseIngredientDlgMeasurementComboBox.SelectedIndex = -1;

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
            
            parseIngredientDlgCategoryComboBox.DataSource = m_categories;
            parseIngredientDlgCategoryComboBox.DisplayMember = "Name";
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
            parseIngredientDlgIngredientsComboBox.DataSource = m_ingredients;
            parseIngredientDlgIngredientsComboBox.DisplayMember = "Name";
            parseIngredientDlgIngredientsComboBox.SelectedIndex = -1;
        }

        public void setMeasurementText(string Text)
        {
            parseIngredientDlgMeasurementComboBox.Text = Text;
        }

        public string getMeasurementText()
        {
            return parseIngredientDlgMeasurementComboBox.Text;
        }

        public void setMeasurementAlternatives(List<Measurement> measurement)
        {
            m_measurement = new List<Measurement>(measurement);
            parseIngredientDlgMeasurementComboBox.DataSource = m_measurement;
            parseIngredientDlgMeasurementComboBox.DisplayMember = "Name";
            parseIngredientDlgMeasurementComboBox.SelectedIndex = -1;
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
            parseIngredientDlgAmountComboBox.Text = value.ToString(); ;
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
                parseIngredientDlgPluralNameTextBox.Text = m_ingredients.ElementAt(parseIngredientDlgIngredientsComboBox.SelectedIndex).NamePlural;
            }
        }

    }
}

using System.Collections.Generic;
namespace Shoppinglist
{
    partial class parseIngredientDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.parseIngredientDlgCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.parseIngredientDlgAcceptBtn = new System.Windows.Forms.Button();
            this.parseIngredientDlgDiscardBtn = new System.Windows.Forms.Button();
            this.parseIngredientDlgIngredientsComboBox = new System.Windows.Forms.ComboBox();
            this.parseIngredientDlgMeasurementComboBox = new System.Windows.Forms.ComboBox();
            this.parseIngredientDlgAmountComboBox = new System.Windows.Forms.TextBox();
            this.parseIngredientDlgUnknownTextBox = new System.Windows.Forms.TextBox();
            this.parseIngredientDlgUnknownGroupBox = new System.Windows.Forms.GroupBox();
            this.parseIngredientDlgSpecifyGroupBox = new System.Windows.Forms.GroupBox();
            this.parseIngredientDlgPluralNameTextBox = new System.Windows.Forms.TextBox();
            this.parseIngredientCategoryLabel = new System.Windows.Forms.Label();
            this.parseIngredientExtraInfoLabel = new System.Windows.Forms.Label();
            this.parseIngredientDlgExtraInfoComboBox = new System.Windows.Forms.TextBox();
            this.parseIngredientDlgPluralNameLabel = new System.Windows.Forms.Label();
            this.parseIngredientDlgMeasurementLabel = new System.Windows.Forms.Label();
            this.parseIngredientDlgAmountLabel = new System.Windows.Forms.Label();
            this.parseIngredientDlgNameLabel = new System.Windows.Forms.Label();
            this.parseIngredientDlgUnknownGroupBox.SuspendLayout();
            this.parseIngredientDlgSpecifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // parseIngredientDlgCategoryComboBox
            // 
            this.parseIngredientDlgCategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.parseIngredientDlgCategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.parseIngredientDlgCategoryComboBox.FormattingEnabled = true;
            this.parseIngredientDlgCategoryComboBox.Location = new System.Drawing.Point(4, 157);
            this.parseIngredientDlgCategoryComboBox.Name = "parseIngredientDlgCategoryComboBox";
            this.parseIngredientDlgCategoryComboBox.Size = new System.Drawing.Size(238, 21);
            this.parseIngredientDlgCategoryComboBox.TabIndex = 5;
            // 
            // parseIngredientDlgAcceptBtn
            // 
            this.parseIngredientDlgAcceptBtn.Location = new System.Drawing.Point(250, 156);
            this.parseIngredientDlgAcceptBtn.Name = "parseIngredientDlgAcceptBtn";
            this.parseIngredientDlgAcceptBtn.Size = new System.Drawing.Size(113, 23);
            this.parseIngredientDlgAcceptBtn.TabIndex = 6;
            this.parseIngredientDlgAcceptBtn.Text = "Ok";
            this.parseIngredientDlgAcceptBtn.UseVisualStyleBackColor = true;
            this.parseIngredientDlgAcceptBtn.Click += new System.EventHandler(this.parseIngredientDlgAcceptBtn_Click);
            // 
            // parseIngredientDlgDiscardBtn
            // 
            this.parseIngredientDlgDiscardBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.parseIngredientDlgDiscardBtn.Location = new System.Drawing.Point(373, 155);
            this.parseIngredientDlgDiscardBtn.Name = "parseIngredientDlgDiscardBtn";
            this.parseIngredientDlgDiscardBtn.Size = new System.Drawing.Size(75, 23);
            this.parseIngredientDlgDiscardBtn.TabIndex = 7;
            this.parseIngredientDlgDiscardBtn.Text = "Ignore";
            this.parseIngredientDlgDiscardBtn.UseVisualStyleBackColor = true;
            // 
            // parseIngredientDlgIngredientsComboBox
            // 
            this.parseIngredientDlgIngredientsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.parseIngredientDlgIngredientsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.parseIngredientDlgIngredientsComboBox.FormattingEnabled = true;
            this.parseIngredientDlgIngredientsComboBox.Location = new System.Drawing.Point(4, 36);
            this.parseIngredientDlgIngredientsComboBox.Name = "parseIngredientDlgIngredientsComboBox";
            this.parseIngredientDlgIngredientsComboBox.Size = new System.Drawing.Size(300, 21);
            this.parseIngredientDlgIngredientsComboBox.TabIndex = 0;
            this.parseIngredientDlgIngredientsComboBox.SelectedIndexChanged += new System.EventHandler(this.parseIngredientDlgIngredientsComboBox_SelectedIndexChanged);
            // 
            // parseIngredientDlgMeasurementComboBox
            // 
            this.parseIngredientDlgMeasurementComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.parseIngredientDlgMeasurementComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.parseIngredientDlgMeasurementComboBox.FormattingEnabled = true;
            this.parseIngredientDlgMeasurementComboBox.Location = new System.Drawing.Point(369, 36);
            this.parseIngredientDlgMeasurementComboBox.Name = "parseIngredientDlgMeasurementComboBox";
            this.parseIngredientDlgMeasurementComboBox.Size = new System.Drawing.Size(79, 21);
            this.parseIngredientDlgMeasurementComboBox.TabIndex = 2;
            // 
            // parseIngredientDlgAmountComboBox
            // 
            this.parseIngredientDlgAmountComboBox.Location = new System.Drawing.Point(310, 36);
            this.parseIngredientDlgAmountComboBox.Name = "parseIngredientDlgAmountComboBox";
            this.parseIngredientDlgAmountComboBox.Size = new System.Drawing.Size(53, 20);
            this.parseIngredientDlgAmountComboBox.TabIndex = 1;
            // 
            // parseIngredientDlgUnknownTextBox
            // 
            this.parseIngredientDlgUnknownTextBox.Location = new System.Drawing.Point(6, 19);
            this.parseIngredientDlgUnknownTextBox.Name = "parseIngredientDlgUnknownTextBox";
            this.parseIngredientDlgUnknownTextBox.ReadOnly = true;
            this.parseIngredientDlgUnknownTextBox.Size = new System.Drawing.Size(444, 20);
            this.parseIngredientDlgUnknownTextBox.TabIndex = 0;
            // 
            // parseIngredientDlgUnknownGroupBox
            // 
            this.parseIngredientDlgUnknownGroupBox.Controls.Add(this.parseIngredientDlgUnknownTextBox);
            this.parseIngredientDlgUnknownGroupBox.Location = new System.Drawing.Point(13, 13);
            this.parseIngredientDlgUnknownGroupBox.Name = "parseIngredientDlgUnknownGroupBox";
            this.parseIngredientDlgUnknownGroupBox.Size = new System.Drawing.Size(461, 55);
            this.parseIngredientDlgUnknownGroupBox.TabIndex = 9;
            this.parseIngredientDlgUnknownGroupBox.TabStop = false;
            this.parseIngredientDlgUnknownGroupBox.Text = "Unknown Ingredience";
            // 
            // parseIngredientDlgSpecifyGroupBox
            // 
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgPluralNameTextBox);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientCategoryLabel);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientExtraInfoLabel);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgExtraInfoComboBox);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgPluralNameLabel);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgMeasurementLabel);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgAmountLabel);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgNameLabel);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgIngredientsComboBox);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgCategoryComboBox);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgAmountComboBox);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgAcceptBtn);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgMeasurementComboBox);
            this.parseIngredientDlgSpecifyGroupBox.Controls.Add(this.parseIngredientDlgDiscardBtn);
            this.parseIngredientDlgSpecifyGroupBox.Location = new System.Drawing.Point(13, 74);
            this.parseIngredientDlgSpecifyGroupBox.Name = "parseIngredientDlgSpecifyGroupBox";
            this.parseIngredientDlgSpecifyGroupBox.Size = new System.Drawing.Size(461, 187);
            this.parseIngredientDlgSpecifyGroupBox.TabIndex = 10;
            this.parseIngredientDlgSpecifyGroupBox.TabStop = false;
            this.parseIngredientDlgSpecifyGroupBox.Text = "Specify Ingredience";
            // 
            // parseIngredientDlgPluralNameTextBox
            // 
            this.parseIngredientDlgPluralNameTextBox.Location = new System.Drawing.Point(7, 76);
            this.parseIngredientDlgPluralNameTextBox.Name = "parseIngredientDlgPluralNameTextBox";
            this.parseIngredientDlgPluralNameTextBox.Size = new System.Drawing.Size(297, 20);
            this.parseIngredientDlgPluralNameTextBox.TabIndex = 3;
            // 
            // parseIngredientCategoryLabel
            // 
            this.parseIngredientCategoryLabel.AutoSize = true;
            this.parseIngredientCategoryLabel.Location = new System.Drawing.Point(120, 139);
            this.parseIngredientCategoryLabel.Name = "parseIngredientCategoryLabel";
            this.parseIngredientCategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.parseIngredientCategoryLabel.TabIndex = 13;
            this.parseIngredientCategoryLabel.Text = "Category";
            // 
            // parseIngredientExtraInfoLabel
            // 
            this.parseIngredientExtraInfoLabel.AutoSize = true;
            this.parseIngredientExtraInfoLabel.Location = new System.Drawing.Point(120, 100);
            this.parseIngredientExtraInfoLabel.Name = "parseIngredientExtraInfoLabel";
            this.parseIngredientExtraInfoLabel.Size = new System.Drawing.Size(52, 13);
            this.parseIngredientExtraInfoLabel.TabIndex = 12;
            this.parseIngredientExtraInfoLabel.Text = "Extra Info";
            // 
            // parseIngredientDlgExtraInfoComboBox
            // 
            this.parseIngredientDlgExtraInfoComboBox.Location = new System.Drawing.Point(5, 116);
            this.parseIngredientDlgExtraInfoComboBox.Name = "parseIngredientDlgExtraInfoComboBox";
            this.parseIngredientDlgExtraInfoComboBox.Size = new System.Drawing.Size(443, 20);
            this.parseIngredientDlgExtraInfoComboBox.TabIndex = 4;
            // 
            // parseIngredientDlgPluralNameLabel
            // 
            this.parseIngredientDlgPluralNameLabel.AutoSize = true;
            this.parseIngredientDlgPluralNameLabel.Location = new System.Drawing.Point(120, 60);
            this.parseIngredientDlgPluralNameLabel.Name = "parseIngredientDlgPluralNameLabel";
            this.parseIngredientDlgPluralNameLabel.Size = new System.Drawing.Size(64, 13);
            this.parseIngredientDlgPluralNameLabel.TabIndex = 10;
            this.parseIngredientDlgPluralNameLabel.Text = "Plural Name";
            // 
            // parseIngredientDlgMeasurementLabel
            // 
            this.parseIngredientDlgMeasurementLabel.AutoSize = true;
            this.parseIngredientDlgMeasurementLabel.Location = new System.Drawing.Point(370, 16);
            this.parseIngredientDlgMeasurementLabel.Name = "parseIngredientDlgMeasurementLabel";
            this.parseIngredientDlgMeasurementLabel.Size = new System.Drawing.Size(71, 13);
            this.parseIngredientDlgMeasurementLabel.TabIndex = 8;
            this.parseIngredientDlgMeasurementLabel.Text = "Measurement";
            // 
            // parseIngredientDlgAmountLabel
            // 
            this.parseIngredientDlgAmountLabel.AutoSize = true;
            this.parseIngredientDlgAmountLabel.Location = new System.Drawing.Point(314, 16);
            this.parseIngredientDlgAmountLabel.Name = "parseIngredientDlgAmountLabel";
            this.parseIngredientDlgAmountLabel.Size = new System.Drawing.Size(43, 13);
            this.parseIngredientDlgAmountLabel.TabIndex = 7;
            this.parseIngredientDlgAmountLabel.Text = "Amount";
            // 
            // parseIngredientDlgNameLabel
            // 
            this.parseIngredientDlgNameLabel.AutoSize = true;
            this.parseIngredientDlgNameLabel.Location = new System.Drawing.Point(124, 16);
            this.parseIngredientDlgNameLabel.Name = "parseIngredientDlgNameLabel";
            this.parseIngredientDlgNameLabel.Size = new System.Drawing.Size(35, 13);
            this.parseIngredientDlgNameLabel.TabIndex = 6;
            this.parseIngredientDlgNameLabel.Text = "Name";
            // 
            // parseIngredientDlg
            // 
            this.AcceptButton = this.parseIngredientDlgAcceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.parseIngredientDlgDiscardBtn;
            this.ClientSize = new System.Drawing.Size(487, 273);
            this.Controls.Add(this.parseIngredientDlgSpecifyGroupBox);
            this.Controls.Add(this.parseIngredientDlgUnknownGroupBox);
            this.Name = "parseIngredientDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Specify Ingredience";
            this.parseIngredientDlgUnknownGroupBox.ResumeLayout(false);
            this.parseIngredientDlgUnknownGroupBox.PerformLayout();
            this.parseIngredientDlgSpecifyGroupBox.ResumeLayout(false);
            this.parseIngredientDlgSpecifyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox parseIngredientDlgCategoryComboBox;
        private System.Windows.Forms.Button parseIngredientDlgAcceptBtn;

        private List<Category> m_categories;
        private List<Ingredient> m_ingredients;
        private List<Measurement> m_measurement;
        private int m_amount;
        private System.Windows.Forms.Button parseIngredientDlgDiscardBtn;
        private System.Windows.Forms.ComboBox parseIngredientDlgIngredientsComboBox;
        private System.Windows.Forms.ComboBox parseIngredientDlgMeasurementComboBox;
        private System.Windows.Forms.TextBox parseIngredientDlgAmountComboBox;
        private System.Windows.Forms.TextBox parseIngredientDlgUnknownTextBox;
        private System.Windows.Forms.GroupBox parseIngredientDlgUnknownGroupBox;
        private System.Windows.Forms.GroupBox parseIngredientDlgSpecifyGroupBox;
        private System.Windows.Forms.Label parseIngredientCategoryLabel;
        private System.Windows.Forms.Label parseIngredientExtraInfoLabel;
        private System.Windows.Forms.TextBox parseIngredientDlgExtraInfoComboBox;
        private System.Windows.Forms.Label parseIngredientDlgPluralNameLabel;
        private System.Windows.Forms.Label parseIngredientDlgMeasurementLabel;
        private System.Windows.Forms.Label parseIngredientDlgAmountLabel;
        private System.Windows.Forms.Label parseIngredientDlgNameLabel;
        private System.Windows.Forms.TextBox parseIngredientDlgPluralNameTextBox;
    }
}
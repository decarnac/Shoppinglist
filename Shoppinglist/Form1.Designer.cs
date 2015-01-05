using System.Collections.Generic;

namespace Shoppinglist
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.shoppingListBox = new System.Windows.Forms.GroupBox();
            this.cutPasteTextBox = new System.Windows.Forms.RichTextBox();
            this.shoppingListTextBox = new System.Windows.Forms.RichTextBox();
            this.ingredientAddBox = new System.Windows.Forms.GroupBox();
            this.cutPasteButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.ingredientLabel = new System.Windows.Forms.Label();
            this.ingredientAddButton = new System.Windows.Forms.Button();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.ingredientComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.changeIngredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientlabel2 = new System.Windows.Forms.Label();
            this.deleteingredientButton = new System.Windows.Forms.Button();
            this.changeingredientButton = new System.Windows.Forms.Button();
            this.ingredientChangeComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.shoppingListBox.SuspendLayout();
            this.ingredientAddBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.changeIngredientsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 538);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.shoppingListBox);
            this.tabPage1.Controls.Add(this.ingredientAddBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // shoppingListBox
            // 
            this.shoppingListBox.Controls.Add(this.cutPasteTextBox);
            this.shoppingListBox.Controls.Add(this.shoppingListTextBox);
            this.shoppingListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shoppingListBox.Location = new System.Drawing.Point(3, 109);
            this.shoppingListBox.Name = "shoppingListBox";
            this.shoppingListBox.Size = new System.Drawing.Size(1069, 400);
            this.shoppingListBox.TabIndex = 0;
            this.shoppingListBox.TabStop = false;
            this.shoppingListBox.Text = "Shoppinglist";
            // 
            // cutPasteTextBox
            // 
            this.cutPasteTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.cutPasteTextBox.Location = new System.Drawing.Point(528, 16);
            this.cutPasteTextBox.Name = "cutPasteTextBox";
            this.cutPasteTextBox.Size = new System.Drawing.Size(538, 381);
            this.cutPasteTextBox.TabIndex = 1;
            this.cutPasteTextBox.TabStop = false;
            this.cutPasteTextBox.Text = "";
            // 
            // shoppingListTextBox
            // 
            this.shoppingListTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.shoppingListTextBox.Location = new System.Drawing.Point(3, 16);
            this.shoppingListTextBox.Name = "shoppingListTextBox";
            this.shoppingListTextBox.ReadOnly = true;
            this.shoppingListTextBox.Size = new System.Drawing.Size(519, 381);
            this.shoppingListTextBox.TabIndex = 0;
            this.shoppingListTextBox.TabStop = false;
            this.shoppingListTextBox.Text = "";
            // 
            // ingredientAddBox
            // 
            this.ingredientAddBox.Controls.Add(this.cutPasteButton);
            this.ingredientAddBox.Controls.Add(this.amountTextBox);
            this.ingredientAddBox.Controls.Add(this.amountLabel);
            this.ingredientAddBox.Controls.Add(this.unitLabel);
            this.ingredientAddBox.Controls.Add(this.ingredientLabel);
            this.ingredientAddBox.Controls.Add(this.ingredientAddButton);
            this.ingredientAddBox.Controls.Add(this.unitComboBox);
            this.ingredientAddBox.Controls.Add(this.ingredientComboBox);
            this.ingredientAddBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ingredientAddBox.Location = new System.Drawing.Point(3, 3);
            this.ingredientAddBox.Name = "ingredientAddBox";
            this.ingredientAddBox.Size = new System.Drawing.Size(1069, 106);
            this.ingredientAddBox.TabIndex = 0;
            this.ingredientAddBox.TabStop = false;
            this.ingredientAddBox.Text = "Add ingredient";
            // 
            // cutPasteButton
            // 
            this.cutPasteButton.Location = new System.Drawing.Point(769, 46);
            this.cutPasteButton.Name = "cutPasteButton";
            this.cutPasteButton.Size = new System.Drawing.Size(63, 23);
            this.cutPasteButton.TabIndex = 7;
            this.cutPasteButton.TabStop = false;
            this.cutPasteButton.Text = "Add List";
            this.cutPasteButton.UseVisualStyleBackColor = true;
            this.cutPasteButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // unitTextBox
            // 
            this.amountTextBox.AcceptsTab = true;
            this.amountTextBox.Location = new System.Drawing.Point(314, 46);
            this.amountTextBox.Name = "unitTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(58, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(311, 29);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Amount";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(375, 29);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(26, 13);
            this.unitLabel.TabIndex = 1;
            this.unitLabel.Text = "Unit";
            // 
            // ingredientLabel
            // 
            this.ingredientLabel.AutoSize = true;
            this.ingredientLabel.Location = new System.Drawing.Point(6, 29);
            this.ingredientLabel.Name = "ingredientLabel";
            this.ingredientLabel.Size = new System.Drawing.Size(54, 13);
            this.ingredientLabel.TabIndex = 0;
            this.ingredientLabel.Text = "Ingredient";
            // 
            // ingredientAddButton
            // 
            this.ingredientAddButton.Location = new System.Drawing.Point(459, 43);
            this.ingredientAddButton.Name = "ingredientAddButton";
            this.ingredientAddButton.Size = new System.Drawing.Size(75, 23);
            this.ingredientAddButton.TabIndex = 3;
            this.ingredientAddButton.Text = "Add";
            this.ingredientAddButton.UseVisualStyleBackColor = true;
            this.ingredientAddButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // unitComboBox
            // 
            this.unitComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.unitComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(378, 45);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(75, 21);
            this.unitComboBox.TabIndex = 2;
            // 
            // ingredientComboBox
            // 
            this.ingredientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ingredientComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ingredientComboBox.FormattingEnabled = true;
            this.ingredientComboBox.Location = new System.Drawing.Point(9, 45);
            this.ingredientComboBox.Name = "ingredientComboBox";
            this.ingredientComboBox.Size = new System.Drawing.Size(299, 21);
            this.ingredientComboBox.TabIndex = 0;
            this.ingredientComboBox.SelectedIndexChanged += new System.EventHandler(this.ingredientComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.changeIngredientsGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // changeIngredientsGroupBox
            // 
            this.changeIngredientsGroupBox.Controls.Add(this.ingredientlabel2);
            this.changeIngredientsGroupBox.Controls.Add(this.deleteingredientButton);
            this.changeIngredientsGroupBox.Controls.Add(this.changeingredientButton);
            this.changeIngredientsGroupBox.Controls.Add(this.ingredientChangeComboBox);
            this.changeIngredientsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeIngredientsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.changeIngredientsGroupBox.Name = "changeIngredientsGroupBox";
            this.changeIngredientsGroupBox.Size = new System.Drawing.Size(1069, 110);
            this.changeIngredientsGroupBox.TabIndex = 0;
            this.changeIngredientsGroupBox.TabStop = false;
            this.changeIngredientsGroupBox.Text = "Modify Ingredient";
            // 
            // ingredientlabel2
            // 
            this.ingredientlabel2.AutoSize = true;
            this.ingredientlabel2.Location = new System.Drawing.Point(6, 29);
            this.ingredientlabel2.Name = "ingredientlabel2";
            this.ingredientlabel2.Size = new System.Drawing.Size(54, 13);
            this.ingredientlabel2.TabIndex = 3;
            this.ingredientlabel2.Text = "Ingredient";
            // 
            // deleteingredientButton
            // 
            this.deleteingredientButton.Location = new System.Drawing.Point(397, 45);
            this.deleteingredientButton.Name = "deleteingredientButton";
            this.deleteingredientButton.Size = new System.Drawing.Size(70, 23);
            this.deleteingredientButton.TabIndex = 2;
            this.deleteingredientButton.Text = "Delete";
            this.deleteingredientButton.UseVisualStyleBackColor = true;
            this.deleteingredientButton.Click += new System.EventHandler(this.deleteingredientButton_Click);
            // 
            // changeingredientButton
            // 
            this.changeingredientButton.Location = new System.Drawing.Point(316, 45);
            this.changeingredientButton.Name = "changeingredientButton";
            this.changeingredientButton.Size = new System.Drawing.Size(75, 23);
            this.changeingredientButton.TabIndex = 1;
            this.changeingredientButton.Text = "Change";
            this.changeingredientButton.UseVisualStyleBackColor = true;
            this.changeingredientButton.Click += new System.EventHandler(this.changeingredientButton_Click);
            // 
            // ingredientChangeComboBox
            // 
            this.ingredientChangeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ingredientChangeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ingredientChangeComboBox.FormattingEnabled = true;
            this.ingredientChangeComboBox.Location = new System.Drawing.Point(9, 45);
            this.ingredientChangeComboBox.Name = "ingredientChangeComboBox";
            this.ingredientChangeComboBox.Size = new System.Drawing.Size(299, 21);
            this.ingredientChangeComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.shoppingListBox.ResumeLayout(false);
            this.ingredientAddBox.ResumeLayout(false);
            this.ingredientAddBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.changeIngredientsGroupBox.ResumeLayout(false);
            this.changeIngredientsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox shoppingListBox;
        private System.Windows.Forms.GroupBox ingredientAddBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label ingredientLabel;
        private System.Windows.Forms.Button ingredientAddButton;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.ComboBox ingredientComboBox;
        private System.Windows.Forms.RichTextBox shoppingListTextBox;
        
        private IngredientList m_shoppingList;
        private IngredientList m_ingredientList;
        private CategoryList m_categoryList;
        private UnitList m_unitList;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.RichTextBox cutPasteTextBox;
        private System.Windows.Forms.Button cutPasteButton;

        private parseIngredientDlg parseIngredientsDlg;
        private System.Windows.Forms.GroupBox changeIngredientsGroupBox;
        private System.Windows.Forms.Label ingredientlabel2;
        private System.Windows.Forms.Button deleteingredientButton;
        private System.Windows.Forms.Button changeingredientButton;
        private System.Windows.Forms.ComboBox ingredientChangeComboBox;
    }
}


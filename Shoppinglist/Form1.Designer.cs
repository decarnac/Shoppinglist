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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inköpslistaBox = new System.Windows.Forms.GroupBox();
            this.läsInUrklippTextBox = new System.Windows.Forms.RichTextBox();
            this.inköpslistaTextBox = new System.Windows.Forms.RichTextBox();
            this.läggtillingrediensBox = new System.Windows.Forms.GroupBox();
            this.changeingredientButton = new System.Windows.Forms.Button();
            this.läsinurklippButton = new System.Windows.Forms.Button();
            this.mängdTextBox = new System.Windows.Forms.TextBox();
            this.mängdLabel = new System.Windows.Forms.Label();
            this.måttLabel = new System.Windows.Forms.Label();
            this.ingrediensLabel = new System.Windows.Forms.Label();
            this.läggtillingrediensButton = new System.Windows.Forms.Button();
            this.måttComboBox = new System.Windows.Forms.ComboBox();
            this.ingrediensComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.inköpsListaGridView = new System.Windows.Forms.DataGridView();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mått = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.inköpslistaBox.SuspendLayout();
            this.läggtillingrediensBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inköpsListaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inköpslistaBox);
            this.tabPage1.Controls.Add(this.läggtillingrediensBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // inköpslistaBox
            // 
            this.inköpslistaBox.Controls.Add(this.läsInUrklippTextBox);
            this.inköpslistaBox.Controls.Add(this.inköpslistaTextBox);
            this.inköpslistaBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inköpslistaBox.Location = new System.Drawing.Point(3, 109);
            this.inköpslistaBox.Name = "inköpslistaBox";
            this.inköpslistaBox.Size = new System.Drawing.Size(1069, 400);
            this.inköpslistaBox.TabIndex = 0;
            this.inköpslistaBox.TabStop = false;
            this.inköpslistaBox.Text = "Inköpslista";
            // 
            // läsInUrklippTextBox
            // 
            this.läsInUrklippTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.läsInUrklippTextBox.Location = new System.Drawing.Point(528, 16);
            this.läsInUrklippTextBox.Name = "läsInUrklippTextBox";
            this.läsInUrklippTextBox.Size = new System.Drawing.Size(538, 381);
            this.läsInUrklippTextBox.TabIndex = 1;
            this.läsInUrklippTextBox.TabStop = false;
            this.läsInUrklippTextBox.Text = resources.GetString("läsInUrklippTextBox.Text");
            // 
            // inköpslistaTextBox
            // 
            this.inköpslistaTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.inköpslistaTextBox.Location = new System.Drawing.Point(3, 16);
            this.inköpslistaTextBox.Name = "inköpslistaTextBox";
            this.inköpslistaTextBox.ReadOnly = true;
            this.inköpslistaTextBox.Size = new System.Drawing.Size(519, 381);
            this.inköpslistaTextBox.TabIndex = 0;
            this.inköpslistaTextBox.TabStop = false;
            this.inköpslistaTextBox.Text = "";
            // 
            // läggtillingrediensBox
            // 
            this.läggtillingrediensBox.Controls.Add(this.changeingredientButton);
            this.läggtillingrediensBox.Controls.Add(this.läsinurklippButton);
            this.läggtillingrediensBox.Controls.Add(this.mängdTextBox);
            this.läggtillingrediensBox.Controls.Add(this.mängdLabel);
            this.läggtillingrediensBox.Controls.Add(this.måttLabel);
            this.läggtillingrediensBox.Controls.Add(this.ingrediensLabel);
            this.läggtillingrediensBox.Controls.Add(this.läggtillingrediensButton);
            this.läggtillingrediensBox.Controls.Add(this.måttComboBox);
            this.läggtillingrediensBox.Controls.Add(this.ingrediensComboBox);
            this.läggtillingrediensBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.läggtillingrediensBox.Location = new System.Drawing.Point(3, 3);
            this.läggtillingrediensBox.Name = "läggtillingrediensBox";
            this.läggtillingrediensBox.Size = new System.Drawing.Size(1069, 106);
            this.läggtillingrediensBox.TabIndex = 0;
            this.läggtillingrediensBox.TabStop = false;
            this.läggtillingrediensBox.Text = "Lägg till ingrediens";
            // 
            // changeingredientButton
            // 
            this.changeingredientButton.Location = new System.Drawing.Point(527, 43);
            this.changeingredientButton.Name = "changeingredientButton";
            this.changeingredientButton.Size = new System.Drawing.Size(75, 23);
            this.changeingredientButton.TabIndex = 8;
            this.changeingredientButton.TabStop = false;
            this.changeingredientButton.Text = "Change Ingredient";
            this.changeingredientButton.UseVisualStyleBackColor = true;
            this.changeingredientButton.Click += new System.EventHandler(this.changeingredientButton_Click);
            // 
            // läsinurklippButton
            // 
            this.läsinurklippButton.Location = new System.Drawing.Point(769, 46);
            this.läsinurklippButton.Name = "läsinurklippButton";
            this.läsinurklippButton.Size = new System.Drawing.Size(63, 23);
            this.läsinurklippButton.TabIndex = 7;
            this.läsinurklippButton.TabStop = false;
            this.läsinurklippButton.Text = "Add List";
            this.läsinurklippButton.UseVisualStyleBackColor = true;
            this.läsinurklippButton.Click += new System.EventHandler(this.läsInUrklippButton_Click);
            // 
            // mängdTextBox
            // 
            this.mängdTextBox.AcceptsTab = true;
            this.mängdTextBox.Location = new System.Drawing.Point(314, 46);
            this.mängdTextBox.Name = "mängdTextBox";
            this.mängdTextBox.Size = new System.Drawing.Size(58, 20);
            this.mängdTextBox.TabIndex = 1;
            // 
            // mängdLabel
            // 
            this.mängdLabel.AutoSize = true;
            this.mängdLabel.Location = new System.Drawing.Point(311, 29);
            this.mängdLabel.Name = "mängdLabel";
            this.mängdLabel.Size = new System.Drawing.Size(40, 13);
            this.mängdLabel.TabIndex = 6;
            this.mängdLabel.Text = "Mängd";
            // 
            // måttLabel
            // 
            this.måttLabel.AutoSize = true;
            this.måttLabel.Location = new System.Drawing.Point(375, 29);
            this.måttLabel.Name = "måttLabel";
            this.måttLabel.Size = new System.Drawing.Size(28, 13);
            this.måttLabel.TabIndex = 1;
            this.måttLabel.Text = "Mått";
            // 
            // ingrediensLabel
            // 
            this.ingrediensLabel.AutoSize = true;
            this.ingrediensLabel.Location = new System.Drawing.Point(6, 29);
            this.ingrediensLabel.Name = "ingrediensLabel";
            this.ingrediensLabel.Size = new System.Drawing.Size(56, 13);
            this.ingrediensLabel.TabIndex = 0;
            this.ingrediensLabel.Text = "Ingrediens";
            // 
            // läggtillingrediensButton
            // 
            this.läggtillingrediensButton.Location = new System.Drawing.Point(446, 43);
            this.läggtillingrediensButton.Name = "läggtillingrediensButton";
            this.läggtillingrediensButton.Size = new System.Drawing.Size(75, 23);
            this.läggtillingrediensButton.TabIndex = 3;
            this.läggtillingrediensButton.Text = "Add";
            this.läggtillingrediensButton.UseVisualStyleBackColor = true;
            this.läggtillingrediensButton.Click += new System.EventHandler(this.läggtillingrediensButton_Click);
            // 
            // måttComboBox
            // 
            this.måttComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.måttComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.måttComboBox.FormattingEnabled = true;
            this.måttComboBox.Location = new System.Drawing.Point(378, 45);
            this.måttComboBox.Name = "måttComboBox";
            this.måttComboBox.Size = new System.Drawing.Size(62, 21);
            this.måttComboBox.TabIndex = 2;
            this.måttComboBox.SelectedIndexChanged += new System.EventHandler(this.måttComboBox_SelectedIndexChanged);
            // 
            // ingrediensComboBox
            // 
            this.ingrediensComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ingrediensComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ingrediensComboBox.FormattingEnabled = true;
            this.ingrediensComboBox.Location = new System.Drawing.Point(9, 45);
            this.ingrediensComboBox.Name = "ingrediensComboBox";
            this.ingrediensComboBox.Size = new System.Drawing.Size(299, 21);
            this.ingrediensComboBox.TabIndex = 0;
            this.ingrediensComboBox.SelectedIndexChanged += new System.EventHandler(this.ingrediensComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.inköpsListaGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // inköpsListaGridView
            // 
            this.inköpsListaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inköpsListaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inköpsListaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namn,
            this.Antal,
            this.Mått});
            this.inköpsListaGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.inköpsListaGridView.Location = new System.Drawing.Point(3, 3);
            this.inköpsListaGridView.Name = "inköpsListaGridView";
            this.inköpsListaGridView.Size = new System.Drawing.Size(453, 506);
            this.inköpsListaGridView.TabIndex = 2;
            // 
            // Namn
            // 
            this.Namn.HeaderText = "Namn";
            this.Namn.Name = "Namn";
            this.Namn.Width = 60;
            // 
            // Antal
            // 
            this.Antal.HeaderText = "Antal";
            this.Antal.Name = "Antal";
            this.Antal.Width = 56;
            // 
            // Mått
            // 
            this.Mått.HeaderText = "Mått";
            this.Mått.Name = "Mått";
            this.Mått.Width = 53;
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
            this.inköpslistaBox.ResumeLayout(false);
            this.läggtillingrediensBox.ResumeLayout(false);
            this.läggtillingrediensBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inköpsListaGridView)).EndInit();
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
        private System.Windows.Forms.GroupBox inköpslistaBox;
        private System.Windows.Forms.GroupBox läggtillingrediensBox;
        private System.Windows.Forms.Label mängdLabel;
        private System.Windows.Forms.Label måttLabel;
        private System.Windows.Forms.Label ingrediensLabel;
        private System.Windows.Forms.Button läggtillingrediensButton;
        private System.Windows.Forms.ComboBox måttComboBox;
        private System.Windows.Forms.ComboBox ingrediensComboBox;
        private System.Windows.Forms.RichTextBox inköpslistaTextBox;
        
        //private List<Ingrediens> Ingredienser;
        //private List<Kategori> Kategorier;
        private IngrediensLista Shoppinglistan;
        private IngrediensLista Ingredienslistan;
        private KategoriLista Kategorilistan;
        private MåttLista Måttlistan;
        private System.Windows.Forms.TextBox mängdTextBox;
        private System.Windows.Forms.RichTextBox läsInUrklippTextBox;
        private System.Windows.Forms.DataGridView inköpsListaGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mått;
        private System.Windows.Forms.Button läsinurklippButton;

        private parseIngredientDlg parseIngredientsDlg;
        private System.Windows.Forms.Button changeingredientButton;
    }
}


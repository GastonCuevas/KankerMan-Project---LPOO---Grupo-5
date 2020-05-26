namespace Vistas
{
    partial class FrmVehicleRegistration
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
            this.brandlabel = new System.Windows.Forms.Label();
            this.brandtextBox = new System.Windows.Forms.TextBox();
            this.linelabel = new System.Windows.Forms.Label();
            this.linetextBox = new System.Windows.Forms.TextBox();
            this.carNumberPlatelabel = new System.Windows.Forms.Label();
            this.carNumberPlatetextBox = new System.Windows.Forms.TextBox();
            this.modellabel = new System.Windows.Forms.Label();
            this.modeltextBox = new System.Windows.Forms.TextBox();
            this.colorlabel = new System.Windows.Forms.Label();
            this.colortextBox = new System.Windows.Forms.TextBox();
            this.doorlabel = new System.Windows.Forms.Label();
            this.doortextBox = new System.Windows.Forms.TextBox();
            this.GPSlabel = new System.Windows.Forms.Label();
            this.vehicletypelabel = new System.Windows.Forms.Label();
            this.vehicletypetextBox = new System.Windows.Forms.TextBox();
            this.vehicleclasslabel = new System.Windows.Forms.Label();
            this.vehicleclasstextBox = new System.Windows.Forms.TextBox();
            this.pricelabel = new System.Windows.Forms.Label();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.acceptbutton = new System.Windows.Forms.Button();
            this.GPScheckBox = new System.Windows.Forms.CheckBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // brandlabel
            // 
            this.brandlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.brandlabel.AutoSize = true;
            this.brandlabel.Location = new System.Drawing.Point(27, 14);
            this.brandlabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(38, 13);
            this.brandlabel.TabIndex = 0;
            this.brandlabel.Text = "Brand:";
            // 
            // brandtextBox
            // 
            this.brandtextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.brandtextBox.Location = new System.Drawing.Point(146, 10);
            this.brandtextBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.brandtextBox.Name = "brandtextBox";
            this.brandtextBox.Size = new System.Drawing.Size(168, 20);
            this.brandtextBox.TabIndex = 1;
            // 
            // linelabel
            // 
            this.linelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linelabel.AutoSize = true;
            this.linelabel.Location = new System.Drawing.Point(27, 55);
            this.linelabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.linelabel.Name = "linelabel";
            this.linelabel.Size = new System.Drawing.Size(30, 13);
            this.linelabel.TabIndex = 2;
            this.linelabel.Text = "Line:";
            this.linelabel.Click += new System.EventHandler(this.linelabel_Click);
            // 
            // linetextBox
            // 
            this.linetextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linetextBox.Location = new System.Drawing.Point(146, 51);
            this.linetextBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.linetextBox.Name = "linetextBox";
            this.linetextBox.Size = new System.Drawing.Size(168, 20);
            this.linetextBox.TabIndex = 3;
            // 
            // carNumberPlatelabel
            // 
            this.carNumberPlatelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.carNumberPlatelabel.AutoSize = true;
            this.carNumberPlatelabel.Location = new System.Drawing.Point(27, 89);
            this.carNumberPlatelabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.carNumberPlatelabel.Name = "carNumberPlatelabel";
            this.carNumberPlatelabel.Size = new System.Drawing.Size(66, 26);
            this.carNumberPlatelabel.TabIndex = 4;
            this.carNumberPlatelabel.Text = "Car Number Plate:";
            // 
            // carNumberPlatetextBox
            // 
            this.carNumberPlatetextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.carNumberPlatetextBox.Location = new System.Drawing.Point(146, 92);
            this.carNumberPlatetextBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.carNumberPlatetextBox.Name = "carNumberPlatetextBox";
            this.carNumberPlatetextBox.Size = new System.Drawing.Size(167, 20);
            this.carNumberPlatetextBox.TabIndex = 5;
            this.carNumberPlatetextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // modellabel
            // 
            this.modellabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modellabel.AutoSize = true;
            this.modellabel.Location = new System.Drawing.Point(27, 137);
            this.modellabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.modellabel.Name = "modellabel";
            this.modellabel.Size = new System.Drawing.Size(39, 13);
            this.modellabel.TabIndex = 6;
            this.modellabel.Text = "Model:";
            // 
            // modeltextBox
            // 
            this.modeltextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modeltextBox.Location = new System.Drawing.Point(146, 133);
            this.modeltextBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.modeltextBox.Name = "modeltextBox";
            this.modeltextBox.Size = new System.Drawing.Size(167, 20);
            this.modeltextBox.TabIndex = 7;
            // 
            // colorlabel
            // 
            this.colorlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.colorlabel.AutoSize = true;
            this.colorlabel.Location = new System.Drawing.Point(27, 178);
            this.colorlabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.colorlabel.Name = "colorlabel";
            this.colorlabel.Size = new System.Drawing.Size(34, 13);
            this.colorlabel.TabIndex = 8;
            this.colorlabel.Text = "Color:";
            // 
            // colortextBox
            // 
            this.colortextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.colortextBox.Location = new System.Drawing.Point(146, 174);
            this.colortextBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.colortextBox.Name = "colortextBox";
            this.colortextBox.Size = new System.Drawing.Size(166, 20);
            this.colortextBox.TabIndex = 9;
            // 
            // doorlabel
            // 
            this.doorlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.doorlabel.AutoSize = true;
            this.doorlabel.Location = new System.Drawing.Point(27, 219);
            this.doorlabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.doorlabel.Name = "doorlabel";
            this.doorlabel.Size = new System.Drawing.Size(38, 13);
            this.doorlabel.TabIndex = 10;
            this.doorlabel.Text = "Doors:";
            // 
            // doortextBox
            // 
            this.doortextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.doortextBox.Location = new System.Drawing.Point(146, 215);
            this.doortextBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.doortextBox.Name = "doortextBox";
            this.doortextBox.Size = new System.Drawing.Size(166, 20);
            this.doortextBox.TabIndex = 11;
            // 
            // GPSlabel
            // 
            this.GPSlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GPSlabel.AutoSize = true;
            this.GPSlabel.Location = new System.Drawing.Point(27, 260);
            this.GPSlabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.GPSlabel.Name = "GPSlabel";
            this.GPSlabel.Size = new System.Drawing.Size(32, 13);
            this.GPSlabel.TabIndex = 12;
            this.GPSlabel.Text = "GPS:";
            // 
            // vehicletypelabel
            // 
            this.vehicletypelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vehicletypelabel.AutoSize = true;
            this.vehicletypelabel.Location = new System.Drawing.Point(27, 301);
            this.vehicletypelabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.vehicletypelabel.Name = "vehicletypelabel";
            this.vehicletypelabel.Size = new System.Drawing.Size(72, 13);
            this.vehicletypelabel.TabIndex = 14;
            this.vehicletypelabel.Text = "Vehicle Type:";
            // 
            // vehicletypetextBox
            // 
            this.vehicletypetextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vehicletypetextBox.Location = new System.Drawing.Point(146, 297);
            this.vehicletypetextBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.vehicletypetextBox.Name = "vehicletypetextBox";
            this.vehicletypetextBox.Size = new System.Drawing.Size(166, 20);
            this.vehicletypetextBox.TabIndex = 15;
            // 
            // vehicleclasslabel
            // 
            this.vehicleclasslabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vehicleclasslabel.AutoSize = true;
            this.vehicleclasslabel.Location = new System.Drawing.Point(27, 342);
            this.vehicleclasslabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.vehicleclasslabel.Name = "vehicleclasslabel";
            this.vehicleclasslabel.Size = new System.Drawing.Size(73, 13);
            this.vehicleclasslabel.TabIndex = 16;
            this.vehicleclasslabel.Text = "Vehicle Class:";
            // 
            // vehicleclasstextBox
            // 
            this.vehicleclasstextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vehicleclasstextBox.Location = new System.Drawing.Point(146, 338);
            this.vehicleclasstextBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.vehicleclasstextBox.Name = "vehicleclasstextBox";
            this.vehicleclasstextBox.Size = new System.Drawing.Size(166, 20);
            this.vehicleclasstextBox.TabIndex = 17;
            // 
            // pricelabel
            // 
            this.pricelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(27, 383);
            this.pricelabel.Margin = new System.Windows.Forms.Padding(27, 0, 2, 0);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(34, 13);
            this.pricelabel.TabIndex = 18;
            this.pricelabel.Text = "Price:";
            // 
            // pricetextBox
            // 
            this.pricetextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pricetextBox.Location = new System.Drawing.Point(146, 379);
            this.pricetextBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(166, 20);
            this.pricetextBox.TabIndex = 19;
            // 
            // acceptbutton
            // 
            this.acceptbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.acceptbutton.BackColor = System.Drawing.Color.Aqua;
            this.acceptbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptbutton.Location = new System.Drawing.Point(206, 421);
            this.acceptbutton.Margin = new System.Windows.Forms.Padding(87, 2, 2, 2);
            this.acceptbutton.Name = "acceptbutton";
            this.acceptbutton.Size = new System.Drawing.Size(52, 25);
            this.acceptbutton.TabIndex = 20;
            this.acceptbutton.Text = "Accept";
            this.acceptbutton.UseVisualStyleBackColor = false;
            this.acceptbutton.Click += new System.EventHandler(this.acceptbutton_Click);
            // 
            // GPScheckBox
            // 
            this.GPScheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GPScheckBox.AutoSize = true;
            this.GPScheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GPScheckBox.Location = new System.Drawing.Point(146, 258);
            this.GPScheckBox.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.GPScheckBox.Name = "GPScheckBox";
            this.GPScheckBox.Size = new System.Drawing.Size(152, 17);
            this.GPScheckBox.TabIndex = 21;
            this.GPScheckBox.Text = "(select only if there is GPS)";
            this.GPScheckBox.UseVisualStyleBackColor = true;
            this.GPScheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelbutton.BackColor = System.Drawing.Color.Aqua;
            this.cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbutton.Location = new System.Drawing.Point(27, 420);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(27, 2, 2, 2);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(53, 27);
            this.cancelbutton.TabIndex = 22;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.acceptbutton, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.cancelbutton, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.brandlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GPScheckBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pricetextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.brandtextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pricelabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.linelabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.vehicleclasstextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.linetextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.vehicleclasslabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.carNumberPlatelabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.vehicletypetextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.carNumberPlatetextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.vehicletypelabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.modellabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.modeltextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.colorlabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.GPSlabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.colortextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.doortextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.doorlabel, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 457);
            this.tableLayoutPanel1.TabIndex = 23;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // FrmVehicleRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(341, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmVehicleRegistration";
            this.Text = "VehicleRegistration";
            this.Load += new System.EventHandler(this.FrmVehicleRegistration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label brandlabel;
        private System.Windows.Forms.TextBox brandtextBox;
        private System.Windows.Forms.Label linelabel;
        private System.Windows.Forms.TextBox linetextBox;
        private System.Windows.Forms.Label carNumberPlatelabel;
        private System.Windows.Forms.TextBox carNumberPlatetextBox;
        private System.Windows.Forms.Label modellabel;
        private System.Windows.Forms.TextBox modeltextBox;
        private System.Windows.Forms.Label colorlabel;
        private System.Windows.Forms.TextBox colortextBox;
        private System.Windows.Forms.Label doorlabel;
        private System.Windows.Forms.TextBox doortextBox;
        private System.Windows.Forms.Label GPSlabel;
        private System.Windows.Forms.Label vehicletypelabel;
        private System.Windows.Forms.TextBox vehicletypetextBox;
        private System.Windows.Forms.Label vehicleclasslabel;
        private System.Windows.Forms.TextBox vehicleclasstextBox;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Button acceptbutton;
        private System.Windows.Forms.CheckBox GPScheckBox;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
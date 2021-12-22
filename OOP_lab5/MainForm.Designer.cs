namespace lab6
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RectangleCheck = new System.Windows.Forms.RadioButton();
            this.TriangleCheck = new System.Windows.Forms.RadioButton();
            this.NameBox = new System.Windows.Forms.RichTextBox();
            this.RouteText = new System.Windows.Forms.RichTextBox();
            this.NameInp = new System.Windows.Forms.Label();
            this.X1TextBox = new System.Windows.Forms.RichTextBox();
            this.x1 = new System.Windows.Forms.Label();
            this.y1Text = new System.Windows.Forms.Label();
            this.Y1TextBox = new System.Windows.Forms.RichTextBox();
            this.y2Text = new System.Windows.Forms.Label();
            this.Y2TextBox = new System.Windows.Forms.RichTextBox();
            this.x1Text = new System.Windows.Forms.Label();
            this.X2TextBox = new System.Windows.Forms.RichTextBox();
            this.y3Text = new System.Windows.Forms.Label();
            this.Y3TextBox = new System.Windows.Forms.RichTextBox();
            this.x3Text = new System.Windows.Forms.Label();
            this.X3TextBox = new System.Windows.Forms.RichTextBox();
            this.y4Text = new System.Windows.Forms.Label();
            this.Y4TextBox = new System.Windows.Forms.RichTextBox();
            this.x4Text = new System.Windows.Forms.Label();
            this.X4TextBox = new System.Windows.Forms.RichTextBox();
            this.SelectFigure = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ChooseRoute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(279, 39);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(149, 32);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(725, 3);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(101, 32);
            this.MoveButton.TabIndex = 1;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(618, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 32);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RectangleCheck
            // 
            this.RectangleCheck.AutoSize = true;
            this.RectangleCheck.Location = new System.Drawing.Point(437, 47);
            this.RectangleCheck.Name = "RectangleCheck";
            this.RectangleCheck.Size = new System.Drawing.Size(72, 17);
            this.RectangleCheck.TabIndex = 3;
            this.RectangleCheck.TabStop = true;
            this.RectangleCheck.Text = "Trapezoid";
            this.RectangleCheck.UseVisualStyleBackColor = true;
            this.RectangleCheck.CheckedChanged += new System.EventHandler(this.RectangleCheck_CheckedChanged);
            // 
            // TriangleCheck
            // 
            this.TriangleCheck.AutoSize = true;
            this.TriangleCheck.Location = new System.Drawing.Point(517, 47);
            this.TriangleCheck.Name = "TriangleCheck";
            this.TriangleCheck.Size = new System.Drawing.Size(63, 17);
            this.TriangleCheck.TabIndex = 4;
            this.TriangleCheck.TabStop = true;
            this.TriangleCheck.Text = "Triangle";
            this.TriangleCheck.UseVisualStyleBackColor = true;
            this.TriangleCheck.CheckedChanged += new System.EventHandler(this.TriangleCheck_CheckedChanged);
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(379, 88);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(125, 27);
            this.NameBox.TabIndex = 10;
            this.NameBox.Text = "";
            // 
            // RouteText
            // 
            this.RouteText.Enabled = false;
            this.RouteText.Location = new System.Drawing.Point(725, 68);
            this.RouteText.Name = "RouteText";
            this.RouteText.Size = new System.Drawing.Size(101, 23);
            this.RouteText.TabIndex = 11;
            this.RouteText.Text = "";
            this.RouteText.TextChanged += new System.EventHandler(this.RouteText_TextChanged);
            this.RouteText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RouteText_KeyPress);
            // 
            // NameInp
            // 
            this.NameInp.AllowDrop = true;
            this.NameInp.AutoSize = true;
            this.NameInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameInp.Location = new System.Drawing.Point(275, 86);
            this.NameInp.Name = "NameInp";
            this.NameInp.Size = new System.Drawing.Size(62, 22);
            this.NameInp.TabIndex = 12;
            this.NameInp.Text = "Name:";
            this.NameInp.UseMnemonic = false;
            // 
            // X1TextBox
            // 
            this.X1TextBox.Enabled = false;
            this.X1TextBox.Location = new System.Drawing.Point(308, 254);
            this.X1TextBox.Name = "X1TextBox";
            this.X1TextBox.Size = new System.Drawing.Size(27, 40);
            this.X1TextBox.TabIndex = 13;
            this.X1TextBox.Text = "";
            this.X1TextBox.TextChanged += new System.EventHandler(this.X1TextBox_TextChanged);
            this.X1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1TextBox_KeyPress);
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1.Location = new System.Drawing.Point(275, 264);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(27, 22);
            this.x1.TabIndex = 14;
            this.x1.Text = "X:";
            // 
            // y1Text
            // 
            this.y1Text.AutoSize = true;
            this.y1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y1Text.Location = new System.Drawing.Point(341, 264);
            this.y1Text.Name = "y1Text";
            this.y1Text.Size = new System.Drawing.Size(27, 22);
            this.y1Text.TabIndex = 16;
            this.y1Text.Text = "Y:";
            // 
            // Y1TextBox
            // 
            this.Y1TextBox.Enabled = false;
            this.Y1TextBox.Location = new System.Drawing.Point(374, 254);
            this.Y1TextBox.Name = "Y1TextBox";
            this.Y1TextBox.Size = new System.Drawing.Size(27, 40);
            this.Y1TextBox.TabIndex = 15;
            this.Y1TextBox.Text = "";
            this.Y1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y1TextBox_KeyPress);
            // 
            // y2Text
            // 
            this.y2Text.AutoSize = true;
            this.y2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y2Text.Location = new System.Drawing.Point(483, 264);
            this.y2Text.Name = "y2Text";
            this.y2Text.Size = new System.Drawing.Size(27, 22);
            this.y2Text.TabIndex = 20;
            this.y2Text.Text = "Y:";
            // 
            // Y2TextBox
            // 
            this.Y2TextBox.Enabled = false;
            this.Y2TextBox.Location = new System.Drawing.Point(516, 254);
            this.Y2TextBox.Name = "Y2TextBox";
            this.Y2TextBox.Size = new System.Drawing.Size(27, 40);
            this.Y2TextBox.TabIndex = 19;
            this.Y2TextBox.Text = "";
            this.Y2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y2TextBox_KeyPress);
            // 
            // x1Text
            // 
            this.x1Text.AutoSize = true;
            this.x1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1Text.Location = new System.Drawing.Point(413, 264);
            this.x1Text.Name = "x1Text";
            this.x1Text.Size = new System.Drawing.Size(27, 22);
            this.x1Text.TabIndex = 18;
            this.x1Text.Text = "X:";
            // 
            // X2TextBox
            // 
            this.X2TextBox.Enabled = false;
            this.X2TextBox.Location = new System.Drawing.Point(446, 254);
            this.X2TextBox.Name = "X2TextBox";
            this.X2TextBox.Size = new System.Drawing.Size(27, 40);
            this.X2TextBox.TabIndex = 17;
            this.X2TextBox.Text = "";
            this.X2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X2TextBox_KeyPress);
            // 
            // y3Text
            // 
            this.y3Text.AutoSize = true;
            this.y3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y3Text.Location = new System.Drawing.Point(626, 264);
            this.y3Text.Name = "y3Text";
            this.y3Text.Size = new System.Drawing.Size(27, 22);
            this.y3Text.TabIndex = 24;
            this.y3Text.Text = "Y:";
            // 
            // Y3TextBox
            // 
            this.Y3TextBox.Enabled = false;
            this.Y3TextBox.Location = new System.Drawing.Point(659, 254);
            this.Y3TextBox.Name = "Y3TextBox";
            this.Y3TextBox.Size = new System.Drawing.Size(27, 40);
            this.Y3TextBox.TabIndex = 23;
            this.Y3TextBox.Text = "";
            this.Y3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y3TextBox_KeyPress);
            // 
            // x3Text
            // 
            this.x3Text.AutoSize = true;
            this.x3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x3Text.Location = new System.Drawing.Point(560, 264);
            this.x3Text.Name = "x3Text";
            this.x3Text.Size = new System.Drawing.Size(27, 22);
            this.x3Text.TabIndex = 22;
            this.x3Text.Text = "X:";
            // 
            // X3TextBox
            // 
            this.X3TextBox.Enabled = false;
            this.X3TextBox.Location = new System.Drawing.Point(593, 254);
            this.X3TextBox.Name = "X3TextBox";
            this.X3TextBox.Size = new System.Drawing.Size(27, 40);
            this.X3TextBox.TabIndex = 21;
            this.X3TextBox.Text = "";
            this.X3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X3TextBox_KeyPress);
            // 
            // y4Text
            // 
            this.y4Text.AutoSize = true;
            this.y4Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y4Text.Location = new System.Drawing.Point(767, 264);
            this.y4Text.Name = "y4Text";
            this.y4Text.Size = new System.Drawing.Size(27, 22);
            this.y4Text.TabIndex = 28;
            this.y4Text.Text = "Y:";
            // 
            // Y4TextBox
            // 
            this.Y4TextBox.Enabled = false;
            this.Y4TextBox.Location = new System.Drawing.Point(800, 254);
            this.Y4TextBox.Name = "Y4TextBox";
            this.Y4TextBox.Size = new System.Drawing.Size(27, 40);
            this.Y4TextBox.TabIndex = 27;
            this.Y4TextBox.Text = "";
            this.Y4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y4TextBox_KeyPress);
            // 
            // x4Text
            // 
            this.x4Text.AutoSize = true;
            this.x4Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x4Text.Location = new System.Drawing.Point(701, 264);
            this.x4Text.Name = "x4Text";
            this.x4Text.Size = new System.Drawing.Size(27, 22);
            this.x4Text.TabIndex = 26;
            this.x4Text.Text = "X:";
            // 
            // X4TextBox
            // 
            this.X4TextBox.Enabled = false;
            this.X4TextBox.Location = new System.Drawing.Point(734, 254);
            this.X4TextBox.Name = "X4TextBox";
            this.X4TextBox.Size = new System.Drawing.Size(27, 40);
            this.X4TextBox.TabIndex = 25;
            this.X4TextBox.Text = "";
            this.X4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X4TextBox_KeyPress);
            // 
            // SelectFigure
            // 
            this.SelectFigure.FormattingEnabled = true;
            this.SelectFigure.Location = new System.Drawing.Point(279, 10);
            this.SelectFigure.Name = "SelectFigure";
            this.SelectFigure.Size = new System.Drawing.Size(149, 21);
            this.SelectFigure.TabIndex = 34;
            this.SelectFigure.SelectedIndexChanged += new System.EventHandler(this.SelectFigure_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(257, 284);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(510, 3);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(101, 32);
            this.PrintButton.TabIndex = 37;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ChooseRoute
            // 
            this.ChooseRoute.FormattingEnabled = true;
            this.ChooseRoute.Location = new System.Drawing.Point(725, 41);
            this.ChooseRoute.Name = "ChooseRoute";
            this.ChooseRoute.Size = new System.Drawing.Size(101, 21);
            this.ChooseRoute.TabIndex = 38;
            this.ChooseRoute.SelectedIndexChanged += new System.EventHandler(this.ChooseRoute_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "-Scale";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "-Direction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "-Figure Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "1 point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "2 point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "3 point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "4 point";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(510, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(673, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 48;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 49;
            this.button2.Text = "Intersect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 32);
            this.button3.TabIndex = 50;
            this.button3.Text = "Include";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseRoute);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SelectFigure);
            this.Controls.Add(this.y4Text);
            this.Controls.Add(this.Y4TextBox);
            this.Controls.Add(this.x4Text);
            this.Controls.Add(this.X4TextBox);
            this.Controls.Add(this.y3Text);
            this.Controls.Add(this.Y3TextBox);
            this.Controls.Add(this.x3Text);
            this.Controls.Add(this.X3TextBox);
            this.Controls.Add(this.y2Text);
            this.Controls.Add(this.Y2TextBox);
            this.Controls.Add(this.x1Text);
            this.Controls.Add(this.X2TextBox);
            this.Controls.Add(this.y1Text);
            this.Controls.Add(this.Y1TextBox);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.X1TextBox);
            this.Controls.Add(this.NameInp);
            this.Controls.Add(this.RouteText);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.TriangleCheck);
            this.Controls.Add(this.RectangleCheck);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.Create);
            this.Name = "MainForm";
            this.Text = "LAB_5-6_OOP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RadioButton RectangleCheck;
        private System.Windows.Forms.RadioButton TriangleCheck;
        private System.Windows.Forms.RichTextBox NameBox;
        private System.Windows.Forms.RichTextBox RouteText;
        private System.Windows.Forms.Label NameInp;
        private System.Windows.Forms.RichTextBox X1TextBox;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label y1Text;
        private System.Windows.Forms.RichTextBox Y1TextBox;
        private System.Windows.Forms.Label y2Text;
        private System.Windows.Forms.RichTextBox Y2TextBox;
        private System.Windows.Forms.Label x1Text;
        private System.Windows.Forms.RichTextBox X2TextBox;
        private System.Windows.Forms.Label y3Text;
        private System.Windows.Forms.RichTextBox Y3TextBox;
        private System.Windows.Forms.Label x3Text;
        private System.Windows.Forms.RichTextBox X3TextBox;
        private System.Windows.Forms.Label y4Text;
        private System.Windows.Forms.RichTextBox Y4TextBox;
        private System.Windows.Forms.Label x4Text;
        private System.Windows.Forms.RichTextBox X4TextBox;
        private System.Windows.Forms.ComboBox SelectFigure;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ComboBox ChooseRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class MainForm : Form
    {

        private List<Figure> _cases = new List<Figure>();

        public MainForm()
        {
            InitializeComponent();
            ChooseRoute.Items.Add("up");
            ChooseRoute.Items.Add("down");
            ChooseRoute.Items.Add("right");
            ChooseRoute.Items.Add("left");
        }

        private void X1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void Y1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void X3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void Y3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void X2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void X4TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void Y2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void RouteText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Y4TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void RectangleCheck_CheckedChanged(object sender, EventArgs e)
        {
            NameBox.Enabled = true;
            X1TextBox.Enabled = true;
            X2TextBox.Enabled = true;
            X3TextBox.Enabled = true;
            X4TextBox.Enabled = true;
            Y1TextBox.Enabled = true;
            Y2TextBox.Enabled = true;
            Y3TextBox.Enabled = true;
            Y4TextBox.Enabled = true;

        }

        private void TriangleCheck_CheckedChanged(object sender, EventArgs e)
        {
            NameBox.Enabled = true;
            X1TextBox.Enabled = true;
            X2TextBox.Enabled = true;
            X3TextBox.Enabled = true;
            X4TextBox.Enabled = false;
            Y1TextBox.Enabled = true;
            Y2TextBox.Enabled = true;
            Y3TextBox.Enabled = true;
            Y4TextBox.Enabled = false;

        }

        private void ChooseRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            RouteText.Enabled = true;
        }

        


    private void Create_Click(object sender, EventArgs e)
        {
            int count = 0;
            Factory figureFactory = new Factory();
            if (RectangleCheck.Checked)
            {
                if (X1TextBox.TextLength == 0 || X2TextBox.TextLength == 0 || X3TextBox.TextLength == 0 || X4TextBox.TextLength == 0 || Y1TextBox.TextLength == 0 || Y2TextBox.TextLength == 0 || Y3TextBox.TextLength == 0 || Y4TextBox.TextLength == 0)
                {
                    MessageBox.Show("Enter points");
                    return;
                }
                count = 4;

            }
            if (TriangleCheck.Checked)
            {
                if (X1TextBox.TextLength == 0 || X2TextBox.TextLength == 0 || X3TextBox.TextLength == 0 ||  Y1TextBox.TextLength == 0 || Y2TextBox.TextLength == 0 || Y3TextBox.TextLength == 0 )
                {
                    MessageBox.Show("Enter points");
                    return;
                }
                count = 3;
            }
            if(NameBox.Text=="")
            {
                MessageBox.Show("Enter name");
                return;
            }


            Point[] points = new Point[count];
            RichTextBox[] textBoxesX = new RichTextBox[4] { X1TextBox, X2TextBox, X3TextBox, X4TextBox };
            RichTextBox[] textBoxesY = new RichTextBox[4] { Y1TextBox, Y2TextBox, Y3TextBox, Y4TextBox };


            for (int i = 0; i < count; i++)
            {
                points[i].x = Convert.ToDouble(textBoxesX[i].Text);
                points[i].y = Convert.ToDouble(textBoxesY[i].Text);
            }

            if(count == 3)
            {
                double aSide = Math.Sqrt(Math.Pow(points[1].x - points[0].x, 2) + Math.Pow(points[1].y - points[0].y, 2));
                double bSide = Math.Sqrt(Math.Pow(points[2].x - points[1].x, 2) + Math.Pow(points[2].y - points[1].y, 2));
                double cSide = Math.Sqrt(Math.Pow(points[2].x - points[0].x, 2) + Math.Pow(points[2].y - points[0].y, 2));

                if (aSide + bSide > cSide && aSide + cSide > bSide && cSide + bSide > aSide)
                {
                    Figure newElement = figureFactory.createFigure(points, count);
                    _cases.Add(newElement);

                    SelectFigure.Items.Add(NameBox.Text);
                    comboBox1.Items.Add(NameBox.Text);
                    comboBox2.Items.Add(NameBox.Text);

                    richTextBox1.Text = NameBox.Text + " is\n" + newElement.ToStringFigure();

                    NameBox.Text = "";


                    for (int i = 0; i < count; i++)
                    {
                        textBoxesX[i].Text = "";
                        textBoxesY[i].Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("This Triangle can`t be real!");
                }
            }

            if(count == 4)
            {
                bool IsParallel1 = false;
                bool IsParallel2 = false;
                double k1 = (points[1].y - points[0].y) / (points[1].x - points[0].x);
                double k2 = (points[3].y - points[2].y) / (points[3].x - points[2].x);

                if (k1 == k2 || (points[1].x - points[0].x) != 0 && (points[1].x - points[0].x) != 0)
                {
                    IsParallel1 = true;
                }

                double k3 = (points[2].y - points[1].y) / (points[2].x - points[1].x);
                double k4 = (points[0].y - points[3].y) / (points[0].x - points[3].x);
                if (k3 == k4 || (points[2].x - points[1].x) != 0 && (points[0].x - points[3].x) != 0)
                {
                    IsParallel2 = true;
                }

                if (IsParallel1 && IsParallel2)
                {
                    Figure newElement = figureFactory.createFigure(points, count);
                    _cases.Add(newElement);

                    SelectFigure.Items.Add(NameBox.Text);
                    comboBox1.Items.Add(NameBox.Text);
                    comboBox2.Items.Add(NameBox.Text);

                    richTextBox1.Text = NameBox.Text + " is\n" + newElement.ToStringFigure();

                    NameBox.Text = "";


                    for (int i = 0; i < count; i++)
                    {
                        textBoxesX[i].Text = "";
                        textBoxesY[i].Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("This trapezoid can`t be real!");
                }
            }

            

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (SelectFigure.Items.Count != 0 && SelectFigure.SelectedIndex != -1)
            {
                
                comboBox1.Items.RemoveAt(SelectFigure.SelectedIndex);
                comboBox1.Text = "";
                comboBox2.Items.RemoveAt(SelectFigure.SelectedIndex);
                comboBox2.Text = "";
                _cases.RemoveAt(SelectFigure.SelectedIndex);
                SelectFigure.Items.RemoveAt(SelectFigure.SelectedIndex);
                SelectFigure.Text = "";

            }
            else
            {
                MessageBox.Show("Choose something");
                return;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (SelectFigure.Items.Count != 0 && SelectFigure.SelectedIndex != -1)
            {
                richTextBox1.Text = SelectFigure.SelectedItem + " is\n" + _cases[SelectFigure.SelectedIndex].ToStringFigure();
            }
            else
            {
                MessageBox.Show("Choose something");
                return;
            }
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (SelectFigure.Items.Count == 0 && SelectFigure.SelectedIndex == -1)
            {
                MessageBox.Show("Choose something");
                return;
            }
            if (ChooseRoute.Items.Count == 0 && ChooseRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Choose route");
                return;
            }
            if (RouteText.Text == "")
            {
                MessageBox.Show("Choose scale");
                return;
            }
   
            _cases[SelectFigure.SelectedIndex].Move(ChooseRoute.SelectedItem.ToString(), Convert.ToInt32(RouteText.Text));
            richTextBox1.Text = SelectFigure.SelectedItem + " is\n" + _cases[SelectFigure.SelectedIndex].ToStringFigure();
        }

       


        private void ChooseRoute_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RouteText.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void X1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RouteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Items.Count != 0 && comboBox1.SelectedIndex != -1) && (comboBox2.Items.Count != 0 && comboBox2.SelectedIndex != -1))
            {
                Figure figure1 = _cases[comboBox1.SelectedIndex];
                Figure figure2 = _cases[comboBox2.SelectedIndex];


                double rad1 = figure1.GetRadius(figure1);
                double rad2 = figure2.GetRadius(figure2);

                Point center1 = figure1.CenterGravity();
                Point center2 = figure2.CenterGravity();

                double length = figure1.GetLength(center1, center2);

                if (length <= Math.Abs(rad1 - rad2))
                {
                    richTextBox1.Text = comboBox1.SelectedItem + " and " + comboBox2.SelectedItem + " are include\n";
                }
                else
                {
                    richTextBox1.Text = comboBox1.SelectedItem + " and " + comboBox2.SelectedItem + " are not include\n";
                }
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Choose sonething!");
                return;
            }
        }

        private void SelectFigure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectFirstFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RouteText.Text == "")
            {
                MessageBox.Show("Choose first");
                return;
            }
        }

        private void SelectSecondFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RouteText.Text == "")
            {
                MessageBox.Show("Choose second");
                return;
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((comboBox1.Items.Count != 0 && comboBox1.SelectedIndex != -1)&&(comboBox2.Items.Count != 0 && comboBox2.SelectedIndex != -1))
            {
                Figure figure1 = _cases[comboBox1.SelectedIndex];
                Figure figure2 = _cases[comboBox2.SelectedIndex];
                double area1 = figure1.Area();
                double area2 = figure2.Area();

                if (area1 > area2)
                {
                    richTextBox1.Text = comboBox1.SelectedItem + " is Bigger\n" + _cases[comboBox1.SelectedIndex].ToStringFigure();

                }
                else if (area1 < area2)
                {
                    richTextBox1.Text = comboBox2.SelectedItem + " is Bigger\n" + _cases[comboBox2.SelectedIndex].ToStringFigure(); ;
                    
                }
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Choose sonething!");
                return;
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //intersect
            if ((comboBox1.Items.Count != 0 && comboBox1.SelectedIndex != -1) && (comboBox2.Items.Count != 0 && comboBox2.SelectedIndex != -1))
            {
                Figure figure1 = _cases[comboBox1.SelectedIndex];
                Figure figure2 = _cases[comboBox2.SelectedIndex];
                

                double rad1 = figure1.GetRadius(figure1);
                double rad2 = figure2.GetRadius(figure2);

                Point center1 = figure1.CenterGravity();
                Point center2 = figure2.CenterGravity();

                double length = figure1.GetLength(center1, center2);

                if (length > rad1 + rad2 || length <= Math.Abs(rad1 - rad2))
                {
                    richTextBox1.Text = comboBox1.SelectedItem + " and " + comboBox2.SelectedItem + " are not intersect\n";
                }
                else
                {
                    richTextBox1.Text = comboBox1.SelectedItem + " and " + comboBox2.SelectedItem + " are intersect\n";
                }
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Choose sonething!");
                return;
            }

        }
    }
}


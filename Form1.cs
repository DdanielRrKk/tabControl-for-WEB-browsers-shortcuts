using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dom12
{
    public partial class Form1 : Form
    {
        TabControl tc = new TabControl()
        {
            Location = new Point(25, 90),
            Size = new Size(900, 500)
        };

        Button addBtn = new Button()
        {
            Location = new Point(25, 25),
            Size = new Size(100, 40),
            Text = "Добави"
        };

        Label info = new Label()
        {
            Location = new Point(150, 25),
            Size = new Size(200, 40),
            Text = "Изтриване на канал се получава с натискане на десен бутон върху избран обект"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 960;
            this.Height = 650;

            this.MinimumSize = new Size(200, 470);

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.Text = "Даниел Костов 18621439 КСТ 4А група";
            this.Icon = new Icon(@"C:\Users\Daniel\Pictures\Cube.ico");

            this.makeTabControl();

            addBtn.Click += new EventHandler(addBtn_Click);

            this.Controls.Add(addBtn);
            this.Controls.Add(info);
            this.Controls.Add(tc);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tc.Width = this.Width - 60;
            tc.Height = this.Height - 150;

            if(tc.Width % 9 == 0)
            {
                this.addPageData();
            }

            if (this.Width < 350)
            {
                info.Location = new Point(25, 90);
                info.Size = new Size(150, 40);

                tc.Location = new Point(25, 170);
                tc.Height = this.Height - 220;
            }
            else
            {
                info.Location = new Point(150, 25);

                tc.Location = new Point(25, 90);
            }
        }

        private void addPageData()
        {
            string[] lines = { };
            int X = 10;
            int Y = 10;

            foreach (TabPage t in tc.Controls)
            {
                if (t.Text == "Национални Канали") 
                {
                    t.Controls.Clear();

                    lines = System.IO.File.ReadAllLines(@"D:\stDom\National.txt");

                    for (int i = 0; i < lines.Length; i = i + 2)
                    {
                        CellButton cb = new CellButton(i, lines[i], lines[i + 1], new Point(X, Y));
                        cb.MouseUp += (sndr, arg) =>
                        {
                            if (arg.Button == MouseButtons.Right)
                            {
                                this.deleteOnID(cb.ID, t.Text);
                                this.addPageData();
                            }
                        };

                        t.Controls.Add(cb);

                        X = X + 110;
                        if (X > tc.Width - 120)
                        {
                            X = 10;
                            Y = Y + 110;
                        }
                    }

                    X = 10;
                    Y = 10;
                }

                if (t.Text == "Научни Канали")
                {
                    t.Controls.Clear();

                    lines = System.IO.File.ReadAllLines(@"D:\stDom\Science.txt");

                    for (int i = 0; i < lines.Length; i = i + 2)
                    {
                        CellButton cb = new CellButton(i, lines[i], lines[i + 1], new Point(X, Y));
                        cb.MouseUp += (sndr, arg) =>
                        {
                            if (arg.Button == MouseButtons.Right)
                            {
                                this.deleteOnID(cb.ID, t.Text);
                                this.addPageData();
                            }
                        };

                        t.Controls.Add(cb);

                        X = X + 110;
                        if (X > tc.Width - 120)
                        {
                            X = 10;
                            Y = Y + 110;
                        }
                    }

                    X = 10;
                    Y = 10;
                }

                if (t.Text == "Спортни Канали")
                {
                    t.Controls.Clear();

                    lines = System.IO.File.ReadAllLines(@"D:\stDom\Sports.txt");

                    for (int i = 0; i < lines.Length; i = i + 2)
                    {
                        CellButton cb = new CellButton(i, lines[i], lines[i + 1], new Point(X, Y));
                        cb.MouseUp += (sndr, arg) =>
                        {
                            if (arg.Button == MouseButtons.Right)
                            {
                                this.deleteOnID(cb.ID, t.Text);
                                this.addPageData();
                            }
                        };

                        t.Controls.Add(cb);

                        X = X + 110;
                        if (X > tc.Width - 120)
                        {
                            X = 10;
                            Y = Y + 110;
                        }
                    }

                    X = 10;
                    Y = 10;
                }

                if (t.Text == "Развлекателни Канали")
                {
                    t.Controls.Clear();

                    lines = System.IO.File.ReadAllLines(@"D:\stDom\Fun.txt");

                    for (int i = 0; i < lines.Length; i = i + 2)
                    {
                        CellButton cb = new CellButton(i, lines[i], lines[i + 1], new Point(X, Y));
                        cb.MouseUp += (sndr, arg) =>
                        {
                            if (arg.Button == MouseButtons.Right)
                            {
                                this.deleteOnID(cb.ID, t.Text);
                                this.addPageData();
                            }
                        };

                        t.Controls.Add(cb);

                        X = X + 110;
                        if (X > tc.Width - 120)
                        {
                            X = 10;
                            Y = Y + 110;
                        }
                    }

                    X = 10;
                    Y = 10;
                }

                if (t.Text == "Детски Канали")
                {
                    t.Controls.Clear();

                    lines = System.IO.File.ReadAllLines(@"D:\stDom\Kids.txt");

                    for (int i = 0; i < lines.Length; i = i + 2)
                    {
                        CellButton cb = new CellButton(i, lines[i], lines[i + 1], new Point(X, Y));
                        cb.MouseUp += (sndr, arg) =>
                        {
                            if (arg.Button == MouseButtons.Right)
                            {
                                this.deleteOnID(cb.ID, t.Text);
                                this.addPageData();
                            }
                        };

                        t.Controls.Add(cb);

                        X = X + 110;
                        if (X > tc.Width - 120)
                        {
                            X = 10;
                            Y = Y + 110;
                        }
                    }

                    X = 10;
                    Y = 10;
                }
            }
        }

        private void makeTabControl()
        {
            TabPage t1 = new TabPage()
            {
                Text= "Национални Канали",
                AutoScroll = true
            };
            tc.Controls.Add(t1);

            TabPage t2 = new TabPage()
            {
                Text = "Научни Канали",
                AutoScroll = true
            };
            tc.Controls.Add(t2);

            TabPage t3 = new TabPage()
            {
                Text = "Спортни Канали",
                AutoScroll = true
            };
            tc.Controls.Add(t3);

            TabPage t4 = new TabPage()
            {
                Text = "Развлекателни Канали",
                AutoScroll = true
            };
            tc.Controls.Add(t4);

            TabPage t5 = new TabPage()
            {
                Text = "Детски Канали",
                AutoScroll = true
            };
            tc.Controls.Add(t5);

            this.addPageData();
        }

        private void deleteOnID(int id, string tPage)
        {
            if(DialogResult.No == (MessageBox.Show("Сигурни ли сте че искате да изтриете този канал?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)))
            {
                return;
            }

            if (tPage == "Национални Канали")
            {
                string[] lines = System.IO.File.ReadAllLines(@"D:\stDom\National.txt");
                File.WriteAllText(@"D:\stDom\National.txt", String.Empty);

                for (int i = 0; i < lines.Length; i = i + 2)
                {
                    if (i != id)
                    {
                        using (StreamWriter sw = File.AppendText(@"D:\stDom\National.txt"))
                        {
                            sw.WriteLine(lines[i]);
                            sw.WriteLine(lines[i + 1]);
                        }
                    }
                }
            }

            if (tPage == "Научни Канали")
            {
                string[] lines = System.IO.File.ReadAllLines(@"D:\stDom\Science.txt");
                File.WriteAllText(@"D:\stDom\Science.txt", String.Empty);

                for (int i = 0; i < lines.Length; i = i + 2)
                {
                    if (i != id)
                    {
                        using (StreamWriter sw = File.AppendText(@"D:\stDom\Science.txt"))
                        {
                            sw.WriteLine(lines[i]);
                            sw.WriteLine(lines[i + 1]);
                        }
                    }
                }
            }

            if (tPage == "Спортни Канали")
            {
                string[] lines = System.IO.File.ReadAllLines(@"D:\stDom\Sports.txt");
                File.WriteAllText(@"D:\stDom\Sports.txt", String.Empty);

                for (int i = 0; i < lines.Length; i = i + 2)
                {
                    if (i != id)
                    {
                        using (StreamWriter sw = File.AppendText(@"D:\stDom\Sports.txt"))
                        {
                            sw.WriteLine(lines[i]);
                            sw.WriteLine(lines[i + 1]);
                        }
                    }
                }
            }

            if (tPage == "Развлекателни Канали")
            {
                string[] lines = System.IO.File.ReadAllLines(@"D:\stDom\Fun.txt");
                File.WriteAllText(@"D:\stDom\Fun.txt", String.Empty);

                for (int i = 0; i < lines.Length; i = i + 2)
                {
                    if (i != id)
                    {
                        using (StreamWriter sw = File.AppendText(@"D:\stDom\Fun.txt"))
                        {
                            sw.WriteLine(lines[i]);
                            sw.WriteLine(lines[i + 1]);
                        }
                    }
                }
            }

            if (tPage == "Детски Канали")
            {
                string[] lines = System.IO.File.ReadAllLines(@"D:\stDom\Kids.txt");
                File.WriteAllText(@"D:\stDom\Kids.txt", String.Empty);

                for (int i = 0; i < lines.Length; i = i + 2)
                {
                    if (i != id)
                    {
                        using (StreamWriter sw = File.AppendText(@"D:\stDom\Kids.txt"))
                        {
                            sw.WriteLine(lines[i]);
                            sw.WriteLine(lines[i + 1]);
                        }
                    }
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.addCellMenu();
        }

        private void addCellMenu()
        {
            Label lUrl = new Label()
            {
                Text = "Въведи URL към сайт",
                AutoSize = true,
                Location = new Point(10, 10)
            };
            TextBox tUrl = new TextBox()
            {
                Location = new Point(10, 30),
                Size = new Size(350, 20),
                Text = ""
            };


            RadioButton rb1 = new RadioButton()
            {
                Text = "Национален Канал",
                Location = new Point(10, 20),
                Size = new Size(150, 20),
                Name = "rb1"
            };

            RadioButton rb2 = new RadioButton()
            {
                Text = "Научен Канал",
                Location = new Point(10, 40),
                Size = new Size(150, 20),
                Name = "rb2"
            };
            RadioButton rb3 = new RadioButton()
            {
                Text = "Спортен Канал",
                Location = new Point(10, 60),
                Size = new Size(150, 20),
                Name = "rb3"
            };
            RadioButton rb4 = new RadioButton()
            {
                Text = "Развлекателен Канал",
                Location = new Point(10, 80),
                Size = new Size(150, 20),
                Name = "rb4"
            };
            RadioButton rb5 = new RadioButton()
            {
                Text = "Детски Канал",
                Location = new Point(10, 100),
                Size = new Size(150, 20),
                Name = "rb5"
            };
            GroupBox gb = new GroupBox()
            {
                Location = new Point(10, 60),
                Size = new Size(350, 130),
                Text = "Вид Канал:"
            };
            gb.Controls.AddRange(new Control[] { rb1, rb2, rb3, rb4, rb5 });


            string imagePath = "";

            Label lImage = new Label()
            {
                Text = "Изберете снимка",
                AutoSize = true,
                Location = new Point(10, 230)
            };
            Button browse = new Button()
            {
                Location = new Point(10, 290),
                Text = "Качи"
            };
            PictureBox pb = new PictureBox()
            {
                Location = new Point(150, 200),
                Size = new Size(200, 200)
            };

            browse.Click += (sndr, args) =>
            {
                OpenFileDialog open = new OpenFileDialog()
                {
                    Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"
                };
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = (Image)new Bitmap(Image.FromFile(open.FileName), new Size(200, 200)); ;
                    imagePath = open.FileName;
                }
            };


            Button bOK = new Button()
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new Point(100, 420)
            };

            Button bCANCEL = new Button()
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(200, 420)
            };


            Form form = new Form()
            {
                Width = 400,
                Height = 500,
                Text = "Добави Нов Бутон",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false,
                AcceptButton = bOK,
                CancelButton = bCANCEL
            };
            form.Controls.AddRange(new Control[] { lUrl, tUrl, gb, lImage, browse, pb, bOK, bCANCEL });

            bCANCEL.Click += (sndr, arg) =>
            {
                if (DialogResult.No == (MessageBox.Show("Сигурни ли сте че искате да затворите този прозорец?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)))
                {
                    form.DialogResult = DialogResult.None;
                }
            };

            bool flagOKerror = false;

            bOK.Click += (sndr, arg) =>
            {
                bool flag = false;
                foreach (RadioButton rb in gb.Controls)
                {
                    if (rb.Checked)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Не е избран канал!", "Грешка", MessageBoxButtons.OK);
                    flagOKerror = true;
                    form.DialogResult = DialogResult.None;
                }

                if (tUrl.Text != "")
                {
                    if (CheckURL(tUrl.Text) == false)
                    {
                        MessageBox.Show("Линкът не е валиден!", "Грешка", MessageBoxButtons.OK);
                        flagOKerror = true;
                        form.DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    MessageBox.Show("Не сте въвели линк!", "Грешка", MessageBoxButtons.OK);
                    flagOKerror = true;
                    form.DialogResult = DialogResult.None;
                }

                foreach(TabPage t in tc.Controls)
                {
                    foreach(CellButton cb in t.Controls)
                    {
                        if(cb.URL_Location == tUrl.Text)
                        {
                            MessageBox.Show("Вече има създаден бутон към този сайт в "+t.Text+"!", "Грешка", MessageBoxButtons.OK);
                            flagOKerror = true;
                            form.DialogResult = DialogResult.None;
                        }
                    }
                }

                if (imagePath == "")
                {
                    MessageBox.Show("Не е избрана снимка!", "Грешка", MessageBoxButtons.OK);
                    flagOKerror = true;
                    form.DialogResult = DialogResult.None;
                }
            };

            DialogResult btnRes = form.ShowDialog();

            if (flagOKerror == false && btnRes == DialogResult.OK) 
            {
                string uVal = tUrl.Text;
                string iVal = imagePath;

                if (rb1.Checked == true)
                {
                    foreach (TabPage tp in tc.Controls)
                    {
                        if (tp.Text == "Национални Канали")
                        {
                            using (StreamWriter sw = File.AppendText(@"D:\stDom\National.txt"))
                            {
                                sw.WriteLine(uVal);
                                sw.WriteLine(iVal);
                            }

                            tc.SelectedTab = tp;
                            this.addPageData();
                        }

                    }
                }

                if (rb2.Checked == true)
                {
                    foreach (TabPage tp in tc.Controls)
                    {
                        if (tp.Text == "Научни Канали")
                        {
                            using (StreamWriter sw = File.AppendText(@"D:\stDom\Science.txt"))
                            {
                                sw.WriteLine(uVal);
                                sw.WriteLine(iVal);
                            }

                            tc.SelectedTab = tp;
                            this.addPageData();
                        }
                    }
                }

                if (rb3.Checked == true)
                {
                    foreach (TabPage tp in tc.Controls)
                    {
                        if (tp.Text == "Спортни Канали")
                        {
                            using (StreamWriter sw = File.AppendText(@"D:\stDom\Sports.txt"))
                            {
                                sw.WriteLine(uVal);
                                sw.WriteLine(iVal);
                            }

                            tc.SelectedTab = tp;
                            this.addPageData();
                        }
                    }
                }

                if (rb4.Checked == true)
                {
                    foreach (TabPage tp in tc.Controls)
                    {
                        if (tp.Text == "Развлекателни Канали")
                        {
                            using (StreamWriter sw = File.AppendText(@"D:\stDom\Fun.txt"))
                            {
                                sw.WriteLine(uVal);
                                sw.WriteLine(iVal);
                            }

                            tc.SelectedTab = tp;
                            this.addPageData();
                        }
                    }
                }

                if (rb5.Checked == true)
                {
                    foreach (TabPage tp in tc.Controls)
                    {
                        if (tp.Text == "Детски Канали")
                        {
                            using (StreamWriter sw = File.AppendText(@"D:\stDom\Kids.txt"))
                            {
                                sw.WriteLine(uVal);
                                sw.WriteLine(iVal);
                            }

                            tc.SelectedTab = tp;
                            this.addPageData();
                        }
                    }
                }


            }
        }

        private bool CheckURL(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

    }
}

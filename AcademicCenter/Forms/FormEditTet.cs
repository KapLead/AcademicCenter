using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AcademicCenter
{
    public partial class FormEditTet : Form
    {
        private Discipline d = Configuration.Disciplines.First();

        public FormEditTet()
        {
            InitializeComponent();
            listTest.SizeChanged += (sender, args) => listTest.Invalidate();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Type)));
        }
        private void listTest_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            Test t = (Test)listTest.Items[e.Index];
            if (t == null) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                    e.Font,
                    e.Bounds,
                    e.Index,
                    e.State ^ DrawItemState.Selected,
                    e.ForeColor,
                    Color.Silver);
            e.DrawBackground();
            e.Graphics.DrawString(t.Title ?? "..",
                new Font(listTest.Font.FontFamily, 13f, FontStyle.Bold),
                Brushes.Black, new Point(e.Bounds.X + 10, e.Bounds.Y - 2));
            e.Graphics.DrawString(t.Descrition ?? "?",
                new Font(listTest.Font.FontFamily, 11f, FontStyle.Regular), Brushes.DimGray,
                new RectangleF(e.Bounds.X + 10, e.Bounds.Y + 14, e.Bounds.Width - 14, e.Bounds.Height),
                new StringFormat { LineAlignment = StringAlignment.Near, Alignment = StringAlignment.Near });
            e.Graphics.DrawString(t.Type.ToString(),
                new Font(listTest.Font.FontFamily, 13f, FontStyle.Regular),
                t.Type == 0 ? Brushes.RoyalBlue : Brushes.Green, new Point(e.Bounds.Right - 120, e.Bounds.Y + 5));
        }

        private void FormEditTet_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            d = Configuration.Disciplines?[0];
            listTest.Items.AddRange(d.Tests.ToArray());
            if (listTest.Items.Count > 0)
                listTest.SelectedIndex = 0;
        }

        #region listQuestion

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             if (listQuestion.SelectedIndex < 0) return;
            Quest q = d.Tests[listTest.SelectedIndex].Items[listQuestion.SelectedIndex];
            if (q == null) return;
            d.Tests[listTest.SelectedIndex].Items[listQuestion.SelectedIndex].Question = q.Question = textBox4.Text;
            listQuestion.Items[listQuestion.SelectedIndex] = q;
            listQuestion.Invalidate(listQuestion.GetItemRectangle(listQuestion.SelectedIndex));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            d.Tests[listTest.SelectedIndex].Items.Add(new Quest
            {
                Question = "Новый вопрос",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "Ответ 1",
                        IsCorrect = false,
                        Documents = new List<Document>()
                    }
                }
            });
            listQuestion.Items.Add(d.Tests[listTest.SelectedIndex].Items.Last());
            listQuestion.SelectedIndex = listQuestion.Items.Count - 1;
            listQuestion.Invalidate(listQuestion.GetItemRectangle(listQuestion.SelectedIndex));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listQuestion.SelectedIndex < 0) return;
            d.Tests[listTest.SelectedIndex].Items.RemoveAt(listQuestion.SelectedIndex);
            listQuestion.Items.RemoveAt(listQuestion.SelectedIndex);
            if (listQuestion.Items.Count > 0) listQuestion.SelectedIndex = 0;
        }

        #endregion

        #region ListTest
        private void listTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTest.SelectedIndex < 0)
            {
                textBox1.Text = textBox2.Text = "";
                comboBox1.SelectedIndex = -1;
                return;
            }
            Test t = d.Tests[listTest.SelectedIndex];
            textBox1.Text = t.Title;
            textBox2.Text = t.Descrition;
            comboBox1.SelectedIndex = (int)t.Type;
            listQuestion.Items.Clear();
            listQuestion.Items.AddRange(t.Items.ToArray());
            if (listQuestion.Items.Count > 0) listQuestion.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var t = new Test();
            d.Tests.Add(t);
            listTest.Items.Add(t);
            listTest.SelectedIndex = listQuestion.Items.Count - 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listTest.SelectedIndex < 0) return;
            d.Tests.RemoveAt(listTest.SelectedIndex);
            listTest.Items.RemoveAt(listTest.SelectedIndex);
            if (listTest.Items.Count > 0)
                listTest.SelectedIndex = 0;
            else
            {
                listTest.Invalidate();
                listQuestion.Items.Clear();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (listTest.SelectedIndex < 0) return;
            Test t = d.Tests[listTest.SelectedIndex];
            if (t == null) return;
            d.Tests[listTest.SelectedIndex].Title = textBox1.Text;
            listTest.Items[listTest.SelectedIndex] = d.Tests[listTest.SelectedIndex];
            listTest.Invalidate(listTest.GetItemRectangle(listTest.SelectedIndex));
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (listTest.SelectedIndex < 0) return;
            Test t = d.Tests[listTest.SelectedIndex];
            if (t == null) return;
            d.Tests[listTest.SelectedIndex].Descrition = textBox2.Text;
            listTest.Items[listTest.SelectedIndex] = t;
            listTest.Invalidate(listTest.GetItemRectangle(listTest.SelectedIndex));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTest.SelectedIndex < 0) return;
            Test t = d.Tests[listTest.SelectedIndex];
            if (t == null) return;
            d.Tests[listTest.SelectedIndex].Type = (Type)comboBox1.SelectedIndex;
            listTest.Items[listTest.SelectedIndex] = t;
            listTest.Invalidate(listTest.GetItemRectangle(listTest.SelectedIndex));
        }

        #endregion

        private void listAnswer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listAnswer.SelectedIndex < 0) return;
            Answer a = (Answer)listAnswer.Items[listAnswer.SelectedIndex];
            if (a == null) return;
            textBox3.TextChanged -= textBox3_TextChanged;
            dataGridView1.CurrentCellChanged -= dataGridView1_CurrentCellChanged;
            textBox3.Text = a.Text;
            checkBox1.Checked = a.IsCorrect;
            try
            {
                dataGridView1.Rows.Clear();
            }
            catch { }
            foreach (Document d in a.Documents)
            {
                try
                {
                    dataGridView1.Rows.Add(d.Name, d.Path);
                }
                catch { }
            }
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
            textBox3.TextChanged += textBox3_TextChanged;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (listAnswer.SelectedIndex < 0) return;
            Answer a = (Answer)listAnswer.Items[listAnswer.SelectedIndex];
            if (a == null) return;
            a.IsCorrect = checkBox1.Checked;
            listAnswer.Items[listAnswer.SelectedIndex] = a;
            listAnswer.Invalidate(listAnswer.GetItemRectangle(listAnswer.SelectedIndex));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (listAnswer.SelectedIndex < 0) return;
            Answer a = (Answer)listAnswer.Items[listAnswer.SelectedIndex];
            if (a == null) return;
            a.Text = textBox3.Text;
            listAnswer.Items[listAnswer.SelectedIndex] = a;
            listAnswer.Invalidate(listAnswer.GetItemRectangle(listAnswer.SelectedIndex));
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
        }

        private void save_Click(object sender, EventArgs e)
        {
            Discipline d = new Discipline();
            for (var i = 0; i < listTest.Items.Count; i++)
            {
                listTest.SelectedIndex = i;
                var test = (Test)listTest.Items[i];
                d.Tests.Add(test);
            }
            d.Save(Application.StartupPath + @"\dat\discipline\default.json");
        }

        private void listQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listQuestion.SelectedIndex < 0) return;
            Quest q = d.Tests[listTest.SelectedIndex].Items[listQuestion.SelectedIndex];
            listAnswer.Items.Clear();
            if (q == null) return;
            textBox4.Text = q.Question;
            if(q.Answers.Count>0)
            {
                listAnswer.Items.Clear();
                listAnswer.Items.AddRange(q.Answers.ToArray());
                listAnswer.SelectedIndex = 0;
                listAnswer.Refresh();
            }

        }

        private void answerDel_Click(object sender, EventArgs e)
        {
            if (listAnswer.SelectedIndex < 0) return;
            d.Tests[listTest.SelectedIndex].Items[listQuestion.SelectedIndex].Answers.RemoveAt(listAnswer.SelectedIndex);
            listAnswer.Items.RemoveAt(listAnswer.SelectedIndex);
        }

        private void answerAdd_Click(object sender, EventArgs e)
        {
            d.Tests[listTest.SelectedIndex].Items[listQuestion.SelectedIndex].Answers.Add(new Answer());
            listAnswer.Items.Add(d.Tests[listTest.SelectedIndex].Items[listQuestion.SelectedIndex].Answers.Last());
            listAnswer.SelectedIndex = listAnswer.Items.Count - 1;
        }

        private void listQuestion_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            Quest t = d.Tests[listTest.SelectedIndex]
                .Items[e.Index< d.Tests[listTest.SelectedIndex].Items.Count?e.Index: d.Tests[listTest.SelectedIndex].Items.Count-1];
            if (t == null) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index,
                    e.State ^ DrawItemState.Selected, e.ForeColor, Color.Silver);
            e.DrawBackground();
            e.Graphics.DrawString(t.Question, DefaultFont, Brushes.Black, e.Bounds.X + 10, e.Bounds.Y + 9);
        }

        private void listAnswer_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            Answer t = d.Tests[listTest.SelectedIndex].Items[listQuestion.SelectedIndex].Answers[e.Index];
            if (t == null) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index,
                    e.State ^ DrawItemState.Selected, e.ForeColor, Color.Silver);
            e.DrawBackground();
            CheckBoxRenderer.DrawCheckBox(e.Graphics,
                new Point(e.Bounds.X + 15, e.Bounds.Y + 8),
                t.IsCorrect ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal);
            e.Graphics.DrawString(t.Text, DefaultFont, Brushes.Black, e.Bounds.X + 40, e.Bounds.Y + 9);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (listAnswer.SelectedIndex < 0) return;
            Answer a = (Answer)listAnswer.Items[listAnswer.SelectedIndex];
            if (a == null) return;
            a.Documents = new List<Document>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                a.Documents.Add(new Document
                {
                    Name = row.Cells[0].Value?.ToString() ?? "",
                    Path = row.Cells[1].Value?.ToString() ?? ""
                });
            }
            Quest q = (Quest)listQuestion.Items[listQuestion.SelectedIndex];
            if (q == null) return;
            q.Answers[listAnswer.SelectedIndex].Documents = a.Documents;
            q.Answers[listAnswer.SelectedIndex].Text = a.Text;
            listQuestion.Items[listQuestion.SelectedIndex] = q;
            Test t = (Test)listTest.Items[listTest.SelectedIndex];
            if (t == null) return;
            t.Items[listTest.SelectedIndex].Question = q.Question;
            t.Items[listTest.SelectedIndex].Answers = q.Answers;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (button5.Visible=(e.ColumnIndex == 1))
            {
                button5.Left = dataGridView1.Right - button5.Width - (dataGridView1.Controls.OfType<VScrollBar>().First()?.Visible??false ? 16 : 0);
                button5.Top = dataGridView1.ColumnHeadersHeight+ dataGridView1.Top+e.RowIndex*dataGridView1.RowTemplate.Height;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
            if (File.Exists(dataGridView1.SelectedCells[0].Value.ToString()))
            {
                openFileDialog1.InitialDirectory =
                    Path.GetDirectoryName(dataGridView1.SelectedCells[0].Value.ToString());
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.SelectedCells[0].Value = openFileDialog1.FileName;
            }
            Application.DoEvents();
            Answer a = (Answer)listAnswer.Items[listAnswer.SelectedIndex];
            a.Documents.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                a.Documents.Add(new Document
                {
                    Name = row.Cells[0].Value?.ToString() ?? "",
                    Path = row.Cells[1].Value?.ToString() ?? ""
                });
            }

            d.Tests[listTest.SelectedIndex].Items[listQuestion.SelectedIndex].Answers[listAnswer.SelectedIndex] = a;
            listAnswer.Items[listAnswer.SelectedIndex] = d.Tests[listTest.SelectedIndex]
                .Items[listQuestion.SelectedIndex].Answers[listAnswer.SelectedIndex];
            dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                 
            button5.Left = dataGridView1.Right - button5.Width - (dataGridView1.Controls.OfType<VScrollBar>().First()?.Visible ?? false ? 16 : 0);
       }
    }
}

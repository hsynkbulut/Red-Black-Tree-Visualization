using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBlackTreeUygulama
{
    public partial class MainForm : Form
    {
        private VisualizationBox RedBlackBox;
        public NodeManager _nodeManager = new NodeManager();
        private int Counter;
        private List<double> ValueList = new List<double>();
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.tabControl1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Counter = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            RedBlackBox = new VisualizationBox
            {
                Dock = DockStyle.Fill
            };

            Tbp_RedBlack.Controls.Add(RedBlackBox);
        }
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (Counter > 15)
            {
                MessageBox.Show("Bu noktada en fazla 16 değer girebilirsiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Txt_Value.Text))
            {
                MessageBox.Show("Lütfen bir değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(Txt_Value.Text, out int value))
            {
                MessageBox.Show("Ağaca sadece sayı ekleyebilirsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _nodeManager.Record(Convert.ToDouble(Txt_Value.Text));
            RedBlackBox.Print();
            Counter++;
            Txt_Value.Text = "";
        }

        private void Txt_Insert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Counter > 15)
                {
                    MessageBox.Show("Bu noktada en fazla 16 değer girebilirsiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(Txt_Value.Text))
                {
                    MessageBox.Show("Lütfen bir değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(Txt_Value.Text, out double check))
                {
                    MessageBox.Show("Ağaca sadece sayı ekleyebilirsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ValueList.Contains(Convert.ToDouble(Txt_Value.Text)))
                {
                    MessageBox.Show("Ağaçta zaten bu değer var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _nodeManager.Record(Convert.ToDouble(Txt_Value.Text));
                RedBlackBox.Print();
                Counter++;
                ValueList.Add(Convert.ToDouble(Txt_Value.Text));
                Txt_Value.Text = "";
            }

        }
        //TODO
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Value.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz değeri giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(Txt_Value.Text, out int check))
            {
                MessageBox.Show("Ağaçtan sadece sayıları kaldırabilirsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _nodeManager.DeleteNode(Convert.ToDouble(Txt_Value.Text));
            RedBlackBox.Print();
            if (Counter > 0)
            {
                Counter--;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchValue;
            if (int.TryParse(Txt_Value.Text, out searchValue))
            {
                // Arama işlemi
                if (_nodeManager.Search(searchValue))
                {
                    MessageBox.Show("Aranan değer, ağaçta mevcut.");
                }
                else
                {
                    MessageBox.Show("Aranan değer ağaçta bulunamadı. Böyle bir değer yok !", "Arama Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir tam sayı değeri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            _nodeManager.PreorderTraversal(listBox1);
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            _nodeManager.InorderTraversal(listBox1);
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            _nodeManager.PostorderTraversal(listBox1);
        }


    }
}

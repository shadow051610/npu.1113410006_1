using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 檢查輸入框是否為空
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                // 將 TextBox 的內容加入 CheckedListBox
                checkedListBox1.Items.Add(textBox4.Text);

                // 清空輸入框以便下次輸入
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("請輸入興趣名稱！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("請輸入姓名！"); // 提示出錯欄位 
                return; // 中斷程式，不執行後續顯示邏輯
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("請選擇性別！");
                return;
            }
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("請至少勾選一項興趣！");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇國籍！");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("請輸入通訊地址！"); // 提示出錯欄位 
                return; // 中斷程式，不執行後續顯示邏輯
            }
            string summary = "";
            summary += "姓名：" + textBox1.Text + Environment.NewLine; // [cite: 15]
            summary += "性別：" + (radioButton1.Checked ? "男" : "女") + Environment.NewLine;
            summary += "通訊地址：" + textBox2.Text + Environment.NewLine;
            summary += "出生年月日：" + dateTimePicker1 + Environment.NewLine;
            summary += "入職日期：" + dateTimePicker2 + Environment.NewLine;
            // 興趣需要用迴圈把勾選的抓出來
            summary += "興趣：";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                summary += item.ToString() + " ";
            }
            summary += Environment.NewLine;
            summary += "通訊地址：" + textBox2.Text + Environment.NewLine;
            summary += "備註：" + textBox3.Text + Environment.NewLine;
            // 最後一次顯示在大的 Multiline TextBox
            textBox6.Text = summary; // [cite: 15]
        }
    }
}

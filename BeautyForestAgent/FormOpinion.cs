using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class FormOpinion : Form
    {
        public FormOpinion()
        {
            InitializeComponent();
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fontDialog1.ShowDialog(); // 사용자입력 대기, 코드 멈춤
            switch (result)
            {
                case DialogResult.OK:
                    this.richTextBox1.SelectionFont = this.fontDialog1.Font;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("폰트변경을 취소하셨습니다");
                    break;
            }
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = this.colorDialog1.ShowDialog();  // 사용자입력 대기, 코드 멈춤
            switch (result)
            {
                case DialogResult.OK:
                    this.richTextBox1.SelectionColor = this.colorDialog1.Color;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("색 변경을 취소하셨습니다", "알림");
                    break;
            }

        }
    }
}

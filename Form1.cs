using System;
using System.Windows.Forms;

namespace Calculator5
{
    public partial class Form1 : Form
    {
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button btnCong;
        

        public Form1()
        {
            InitializeComponent();
            InitializeCalculator();
        }

        private void InitializeCalculator()
        {
            this.Text = "Tính Toán";
            

            Label lblA = new Label() { Text = "Số A:" };
            txtA = new TextBox() ;

            Label lblB = new Label() { Text = "Số B:" };
            txtB = new TextBox() ;

            Label lblKetQua = new Label() { Text = "Kết Quả:" };
            txtKetQua = new TextBox() ;

            btnCong = new Button() { Text = "Cộng" };
            btnCong.Click += btnCong_Click;

            

            this.Controls.Add(lblA);
            this.Controls.Add(txtA);
            this.Controls.Add(lblB);
            this.Controls.Add(txtB);
            this.Controls.Add(lblKetQua);
            this.Controls.Add(txtKetQua);
            this.Controls.Add(btnCong);
            
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a + b;
            txtKetQua.Text = c.ToString();
        }

        


    }
}


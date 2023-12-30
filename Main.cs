using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            string min = min_txt.Text;
            string max = max_txt.Text;

            if(!String.IsNullOrEmpty(min) && !String.IsNullOrEmpty(max) && IsNumberic(min) && IsNumberic(max))
            {
                Random random = new Random();
                var randomNumber = random.Next(Convert.ToInt32(min), Convert.ToInt32(max));
                result_txt.Text = randomNumber.ToString();
            }
            else
            {
                result_txt.Text = "None";
            }
        }

        private bool IsNumberic(string number)
        {
            return int.TryParse(number, out int n);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            min_txt.Text = "";
            max_txt.Text = "";
            result_txt.Text = "None";
        }
    }
}

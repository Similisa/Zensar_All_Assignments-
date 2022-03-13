using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Assignment2
{
    public partial class Electronic_Store : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select ", "Realme 8i", "Samsung", "Xiomi", "Vivo", "Iphone", "Redmi" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/pics/" + str + ".jfif";
                
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Iphone")
            {
                TextBox1.Text = "60000";
            }
            else if (DropDownList1.Text == "Realme 8i")
            {
                TextBox1.Text = "17000";
            }
            else if (DropDownList1.Text == "Redmi")
            {
                TextBox1.Text = "7000";
            }
            else if (DropDownList1.Text == "Samsung")
            {
                TextBox1.Text = "15000";
            }
            else if (DropDownList1.Text == "Vivo")
            {
                TextBox1.Text = "7000";
            }

            else
            {
                TextBox1.Text = "10000";
            }
        }
    }
}
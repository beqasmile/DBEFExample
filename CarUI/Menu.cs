using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            txtCompanyName.Text = ConfigurationManager.AppSettings["CompanyName"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarBlankForm carBlankForm = new CarBlankForm();
            carBlankForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarList carList = new CarList();
            carList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String x = "Hello World";

            int Leng = x.Length;
            String subX = x.Substring(3);
            String subX2 = x.Substring(3, 2);
            String xUpper = x.ToUpper();
            String xLower = x.ToLower();

            String x2 = "   Hello World";
            String xTrim = x2.Trim(); //"   Hello World   " == "Hello World"
            String xTrimStart = x2.TrimStart();
            String xTrimEnd = x2.TrimEnd();

            String x3 = "Hello World World World World World";
            String xReplace = x3.Replace("World", "Morning");

            String xRemove = x3.Remove(5, 10); // "Hello World World World World World" => "Hello World World World World World"

            String x4 = "Hello World World World World World";

            
            int xIndexOf = x4.IndexOf("World");//  xIndex

            string world = "World";

            String x5 = x4.Remove(x4.IndexOf("World"), "World".Length);



            String x6 = "Hello World";
            string xHelloWithoutBlank = x6.Substring(0, "Hello".Length) + x6.Substring(x6.IndexOf("World"), "World".Length);



            String x7 = "Hello World Split";
            string[] arrayOfWorld = x4.Split(' ');

            if (x5!=x6)
            {

            }

            if  (String.IsNullOrEmpty(x7) && x7.Length==0 && x7.Contains("Split"))
            {

            }


            if (String.IsNullOrWhiteSpace(x7) && x7.Length == 0 && x7.Contains("Split"))
            {

            }

            String xHello = "Hello";
            String xWorld = "World";
            String xHelloWorld = String.Concat(xHello, " " , xWorld, " ", xHello, " ", xWorld);

            String xHelloWorldCopy = String.Copy(xHelloWorld);
            string str1 = "ppp";
            object objClone = str1.Clone();
            Console.WriteLine("Clone :" + objClone.ToString());  
            // C# is a Case Sensitive language!!! "Hello World" != "Hello WOrld"
            int leng = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object data = "my very important text to nofify";
            CarObserver.GetInstance().MakeNotification(data);
        }
    }
}

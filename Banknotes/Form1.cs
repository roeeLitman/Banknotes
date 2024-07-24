using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Banknotes
{
    public partial class Form1 : Form
    {
        string pathName = Directory.GetCurrentDirectory() + "\\rabanot.xml";

        XmlDocument xmlDocument = new XmlDocument();

        XmlNode Query;
        public Form1()
        {
            InitializeComponent();

            LoadXmlDirectory();
        }

        private void LoadXmlDirectory()
        {
            // בדיקה שהקובץ במיקום כל שהוא קיים
            if (File.Exists(pathName))
            {
                // במקרה שקיים תנסה ליטעון את הקובץ
                try
                {
                    xmlDocument.Load(pathName);
                    MessageBox.Show(pathName);
                }
                // במקרה שלא קיים שלח הודעת שגיאה מתאימה
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //במקרה שהקובץ לא קיים תתחיל בתהליך היצירה שלו
            else
            {
                XmlNode root = xmlDocument.CreateElement("Queries");
                xmlDocument.AppendChild(root);
                xmlDocument.Save(pathName);
            }

        }

        private string DayWeek()
        {
            Query = xmlDocument.CreateElement("Query"); 

            Query.AppendChild(xmlDocument.CreateElement("DAY")).InnerText = txtDateWeek.Text;

            return "ב" + txtDateWeek.Text + " " + "בשבת";
        }

        private string NumberOfManth()
        {
            Query.AppendChild(xmlDocument.CreateElement("DayManth")).InnerText = combNumWeek.Text;
            string numManth = "";
            switch (int.Parse(combNumWeek.Text))
            {
                case 1:
                    numManth = "יום אחד";
                    break;
                case 2:
                    numManth = "שני ימים";
                    break;
                case 3:
                    numManth = "שלשה ימים";
                    break;
                case 4:
                    numManth = "ארבעה ימים";
                    break;
                case 5:
                    numManth = "חמשה ימים";
                    break;
                case 6:
                    numManth = "ששה ימים";
                    break;
                case 7:
                    numManth = "שבעה ימיםד";
                    break;
                case 8:
                    numManth = "שמנה ימים";
                    break;
                case 9:
                    numManth = "תשעה ימים";
                    break;
                case 10:
                    numManth = "עשרה ימים";
                    break;
                case 11:
                    numManth = "אחד עשר יום";
                    break;
                case 12:
                    numManth = "שנים עשר יום";
                    break;
                case 13:
                    numManth = "שלושה עשר יום";
                    break;
                case 14:
                    numManth = "ארבעה עשר יום";
                    break;
                case 15:
                    numManth = "חמשה עשר יום";
                    break;
                case 16:
                    numManth = "ששה עשר יום";
                    break;
                case 17:
                    numManth = "שבעה עשר יום";
                    break;
                case 18:
                    numManth = "שמונה עשר יום";
                    break;
                case 19:
                    numManth = "תשעה עשר יום";
                    break;
                case 20:
                    numManth = "עשרים יום";
                    break;
                case 21:
                    numManth = "אחד ועשרים יום";
                    break;
                case 22:
                    numManth = "שנים ועשרים יום";
                    break;
                case 23:
                    numManth = "שלושה ועשרים יום";
                    break;
                case 24:
                    numManth = "ארבעה ועשרים יום";
                    break;
                case 25:
                    numManth = "חמשה ועשרים יום";
                    break;
                case 26:
                    numManth = "ששה ועשרים יום";
                    break;
                case 27:
                    numManth = "שבעה ועשרים יום";
                    break;
                case 28:
                    numManth = "שמונה ועשרים יום";
                    break;
                case 29:
                    numManth = "תשעה ועשרים יום";
                    break;
                case 30:
                    numManth = "שלןשים לחודש";
                    break;
            } 

            return numManth;
        }

        private string WhereManth()
        {
            Query.AppendChild(xmlDocument.CreateElement("Manth")).InnerText = combManth.Text;

            return "לירח " + combManth.Text;
        }

        private string Year() 
        {
            Query.AppendChild(xmlDocument.CreateElement("Year")).InnerText = combYear.Text;
            string year = "";
            switch (combYear.Text)
            {
                case "תשפד":
                    year = " בשנת חמשת אלפים שבע מאות וארבע לבריאת העולם"; 
                    break;
                case "תשפה":
                    year = " בשנת חמשת אלפים שבע מאות ןחמש לבריאת העולם";
                    break;
                case   "תשפו":
                    year = " בשנת חמשת אלפים שבע מאות לבריאת העולם";
                    break;
            }


            return year;
        }

        private void btmCreate_Click(object sender, EventArgs e)
        {
            textBox1.Text = DayWeek() + " " + "ב" + NumberOfManth() +" "+ WhereManth() + " " + Year();
            Query.AppendChild(xmlDocument.CreateElement("Rusolt")).InnerText = textBox1.Text;
            xmlDocument.FirstChild.AppendChild(Query);
            xmlDocument.Save(pathName);
            
        }


    }
}

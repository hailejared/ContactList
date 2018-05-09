using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class fromContactList : Form
    {
        private Contact[] phoneBookList = new Contact[1];

        public fromContactList()
        {
            InitializeComponent();
        }

        private void Write(Contact obj)
        {
            StreamWriter sw = new StreamWriter("Contacts.txt");

            sw.WriteLine(phoneBookList.Length + 1);
            sw.WriteLine(obj.FirstName);
            sw.WriteLine(obj.LastName);
            sw.WriteLine(obj.Phone);

            for (int x = 0; x < phoneBookList.Length; x++)
            {
                sw.WriteLine(phoneBookList[x].FirstName);
                sw.WriteLine(phoneBookList[x].LastName);
                sw.WriteLine(phoneBookList[x].Phone);
            }

            sw.Close();

        }

        private void Read()
        {
            StreamReader sr = new StreamReader("Contacts.txt");
            phoneBookList = new Contact[Convert.ToInt32(sr.ReadLine())];

            for (int x = 0; x < phoneBookList.Length; x++)
            {
                phoneBookList[x] = new Contact();
                phoneBookList[x].FirstName = sr.ReadLine();
                phoneBookList[x].LastName = sr.ReadLine();
                phoneBookList[x].Phone = sr.ReadLine();
            }

            sr.Close();

        }

        private void Display()
        {
            listboxContacts.Items.Clear();
            for(int x = 0; x < phoneBookList.Length; x++)
            {
                listboxContacts.Items.Add(phoneBookList[x].ToString());
            }
        }

        private void ClearForm()
        {
            textboxFirstName.Text = string.Empty;
            textboxLastName.Text = string.Empty;
            textboxPhone.Text = string.Empty;

        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            Contact obj = new Contact();
            obj.FirstName = textboxFirstName.Text;
            obj.LastName = textboxLastName.Text;
            obj.Phone = textboxPhone.Text;

            Write(obj);
            Read();
            BubbleSort();
            Display();
            ClearForm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            Display();
        }

        private void buttonSortList_Click(object sender, EventArgs e)
        {
            BubbleSort();
            Display();
        }

        private void BubbleSort()
        {
            Contact temp;
            bool swap;
            do
            {
                swap = false;

                for (int x = 0; x < (phoneBookList.Length - 1); x++)
                {
                    if(phoneBookList[x].LastName.CompareTo(phoneBookList[x+1].LastName) > 0)
                    {
                        temp = phoneBookList[x];
                        phoneBookList[x] = phoneBookList[x + 1];
                        phoneBookList[x + 1] = temp;
                        swap = true;
                    }
                }

            } while (swap == true);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkLib
{
    public partial class Form1 : Form
    {
        maindb db = new maindb();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MKhan	Masud Khan	08A2400374733E49507554ED2E33903315222CB8Wqtr6	mkhan@dualaustralia.com.au	2	292486317	0	2099-01-01 00:00:00.000	255	Masud Khan	2011-11-01 08:41:40.000	1	0	0	NULL	NULL
            if (db.Users.Count() == 0)
            {
                User u = new User();
                u.Logon = "wudi";
                u.Name = "wudi";
                u.Password = "08A2400374733E49507554ED2E33903315222CB8Wqtr6";
                u.Email = "wudi@asdf.com";
                u.Role = 2;
                u.Phone = "000000000";
                u.BatchSize = 0;
                u.Expiry = DateTime.Now;
                u.Active = 0;
                u.Comment = "wudi";
                u.LastModified = DateTime.Now;
                u.ModifiedBy = 1;
                u.STPUW = false;
                u.RNLUW = false;

                db.Users.Add(u);
                db.SaveChanges();
            }

            MessageBox.Show("User Number is: " + db.Users.Count().ToString());

        }
    }
}

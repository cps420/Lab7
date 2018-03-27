using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab7.Models;
using Lab7.Data;

namespace Lab7AspNetDisplay
{
    public partial class Display : System.Web.UI.Page
    {
        public List<Student> Students {
            get {
                return Storage.StudentStorage;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Storage.InstantiateStudentsHardCoded();
            grdStudents.DataSource = Students;
            grdStudents.DataBind();
        }
    }
}
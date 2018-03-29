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
        public void Source(IEnumerable<Student> list)
        {
            Storage.InstantiateStudentsHardCoded();
            grdStudents.DataSource = list;
            grdStudents.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Storage.InstantiateStudentsHardCoded();
            grdStudents.DataSource = Storage.StudentStorage;
            grdStudents.DataBind();
        }

        protected void btnHighAvgs_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> source = from student in Storage.StudentStorage
                                                   where student.Average > 90
                                                   select student;
            Source(source);
        }

        protected void btnLowAvg_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> source = from student in Storage.StudentStorage
                                                  where student.Average < 90
                                                  select student;
            Source(source);
        }

        protected void btnPerfects_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> source = from student in Storage.StudentStorage
                                                  where student.Scores.Contains(100)
                                                  select student;
            Source(source);
        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> source = Storage.StudentStorage;
            Source(source);
        }
    }
}
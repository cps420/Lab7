using Lab7.Data;
using Lab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7AspNetDisplay
{
    public partial class Books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Storage.InstantiateBooksHardCoded();
            Storage.InstantiateSalesDataHardCoded();
            lstBooks.DataSource = Storage.BookStorage;
            lstBooks.DataBind();
            lstRealBooks.DataSource = from b in Storage.BookStorage
                                      where b.Title.Contains("Programming")
                                      select b;
            lstRealBooks.DataBind();
        }

        protected void btnPopulateBooks_Click(object sender, EventArgs e)
        {
            lblBooks.Text = "";
            foreach (Book book in Storage.BookStorage)
            {
                lblBooks.Text += $"{book.Title} <br/>";
            }
        }

        protected void btnJoin_Click(object sender, EventArgs e)
        {
            var sales = from b in Storage.BookStorage join s in Storage.SalesDataStorage
                        on b.ID equals s.ID
                        select new { Name = b.Title, Student = (s.Customer.FirstName + s.Customer.LastName)};

            lblJoin.Text = "";
            foreach (var sale in sales)
            {
                lblJoin.Text += $"{sale.Student} bought {sale.Name} <br/>";
            }
        }
    }
}
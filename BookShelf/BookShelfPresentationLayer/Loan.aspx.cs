using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuisnessLayer;
using BuisnessObjects;

namespace BookShelfPresentationLayer
{
    public partial class Loan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        protected void btnLoan_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            IBookshelf bookShelf = new BookShelf();

            book.ISBN = txtISBN.Text;
            bool IsValid = bookShelf.Loan(book);
            if (IsValid)
            {
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Book '" + book.ISBN + "' has been  Loaned sucessfully ";
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Some problem occurred while loaning the book " + book.ISBN;
            }

        }
    }
}
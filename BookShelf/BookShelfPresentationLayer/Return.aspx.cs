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
    public partial class Return : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            IBookshelf bookShelf = new BookShelf();

            book.ISBN = txtISBN.Text;
            bool IsValid =   bookShelf.Return(book);

            if (IsValid)
            {
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Book '" + book.ISBN + "' has been  Returned sucessfully ";
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Some problem occurred while returning the book '" + book.ISBN + "'";
            }

        }
    }
}
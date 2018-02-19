using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuisnessLayer;

namespace BookShelfPresentationLayer
{
    public partial class BookShelfView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    IBookshelf bookShelf = new BuisnessLayer.BookShelf();
                    grdBooks.DataSource = bookShelf.GetBooks();
                    grdBooks.DataBind();
                }
                catch(Exception exp)
                {
                    //Log Exception
                    lblError.Text = "Some Error Occured while showing all books";
                }
            }
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppLINQ2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create an object of the context class.
            DataClasses1DataContext dataContext = new DataClasses1DataContext();

            // store the data in variableNameEmployee.
            GridView1.DataSource = from variableNameEmployee in dataContext.Employees
            // filter the data using the "where" clause Age=30..
                                   where variableNameEmployee.Age == 30                                  
                                   //then select the data to display.
                                   select variableNameEmployee;
            //bind the data to the gridView.
            GridView1.DataBind();
        }
    }
}

// 1. Install the package LINQ.
// 2. RC Project, add, new item, Data tab, LINQ to SQL classes. Makes: DataClasses1.dbml
// 2. RC DataConnections on the left, add, use wizard to make con string to your table.
// 3. Drag and drop your table onto the page: DataClasses1.dbml
// 4. Write your LINQ query and bind to a GridView.

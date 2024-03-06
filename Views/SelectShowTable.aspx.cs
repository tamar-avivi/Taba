using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taba.Helpers;

namespace Taba.Views
{
    public partial class SelectShowTable : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sqlSelect = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "usersDB.mdf";
            string tableName = "Users";
            sqlSelect = "SELECT * FROM " + tableName;

            DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

            int length = table.Rows.Count;
            if (length == 0)
                msg = "no registrants";
            else
            {
                st += "<tr>";
                st += "<th>user name</th>";
                st += "<th>first name</th>";
                st += "<th>last name</th>";
                st += "<th>email</th>";
                st += "<th>gender</th>";
                st += "<th>prefix</th>";
                st += "<th>phone</th>";
                st += "<th>year Born</th>";
                st += "<th>city</th>";
                st += "<th>hob1</th>";
                st += "<th>hob2</th>";
                st += "<th>hob3</th>";
                st += "<th>hob4</th>";
                st += "<th>password</th>";
                st += "<th>cPassword</th>";
                st += "</tr>";
                for (int i = 0; i < length; i++)
                {
                    st += "<tr>";
                    st += "<td>" + table.Rows[i]["uName"] + "</td>";
                    st += "<td>" + table.Rows[i]["fName"] + "</td>";
                    st += "<td>" + table.Rows[i]["lName"] + "</td>";
                    st += "<td>" + table.Rows[i]["email"] + "</td>";
                    st += "<td>" + table.Rows[i]["gender"] + "</td>";
                    st += "<td>" + table.Rows[i]["prefix"] + "</td>";
                    st += "<td>" + table.Rows[i]["phone"] + "</td>";
                    st += "<td>" + table.Rows[i]["yearBorn"] + "</td>";
                    st += "<td>" + table.Rows[i]["city"] + "</td>";
                    st += "<td>" + table.Rows[i]["hob1"] + "</td>";
                    st += "<td>" + table.Rows[i]["hob2"] + "</td>";
                    st += "<td>" + table.Rows[i]["hob3"] + "</td>";
                    st += "<td>" + table.Rows[i]["hob4"] + "</td>";
                    st += "<td>" + table.Rows[i]["password"] + "</td>";
                    st += "<td>" + table.Rows[i]["cpassword"] + "</td>";
                    st += "</tr>";
                }
                msg = length + " people registered";
            }
        }
    }
}
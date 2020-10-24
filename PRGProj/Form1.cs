/*Programmer's Block
 * 
 *Name: Gabriel Chan 
 * Version 1.0
 * Description: This program is a ticket purchasing system. This is the first form to allow the customer to search for their event.
 * Date: August 5,2019
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PRGProj
{
    public partial class Form1 : Form
    {
        int searchPrice;
        String constr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = TicketsReservationDatabase.accdb";
        DataTable vtEvents = new DataTable();
        public static int eventID;
        string search;

        void searchfun()
        {
            cbSearch.Items.Clear();
            cbSearch.Visible = true;
            searchPrice = 0;
            cbSearch.Visible = true;
            lblSearch.Visible = true;
            lblEventID.Visible = true;
            txtEventID.Visible = true;
            btnSub.Visible = true;
            txtSearch.Visible = false;
            String sqlSelect = "SELECT * FROM Events";
            OleDbCommand command = new OleDbCommand();
            OleDbConnection conobj = new OleDbConnection(constr);
            command.Connection = conobj;
            command.CommandText = sqlSelect;
            conobj.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbSearch.Items.Add(reader[search]);
            }
            conobj.Close();
        }

        public Form1()
        {
            InitializeComponent();
            String sqlstr = "SELECT * FROM Events";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            da.Fill(vtEvents);
            da.Dispose();
            dgvEvents.DataSource = vtEvents;
            dgvEvents.Columns["Price"].DefaultCellStyle.Format = "c";
        }

        private void PriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchPrice = 1;
            lblSearch.Visible = true;
            lblEventID.Visible = true;
            txtEventID.Visible = true;
            txtSearch.Visible = true;
            btnSub.Visible = true;
            cbSearch.Visible = false;

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (searchPrice == 1)
            {
                if (txtSearch.Text != "")
                {
                    try
                    {
                        String sqlstr = "SELECT* FROM Events WHERE Price <= " + txtSearch.Text;
                        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
                        vtEvents.Clear();
                        da.Fill(vtEvents);
                        da.Dispose();
                        dgvEvents.DataSource = vtEvents;
                        dgvEvents.Columns["Price"].DefaultCellStyle.Format = "c";
                    }
                    catch (FormatException exc)
                    {
                        MessageBox.Show("Wrong format, try again");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error has occured, try again");
                    }
                }
            }

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                OleDbConnection conobj = new OleDbConnection(constr);
                eventID = Convert.ToInt32(txtEventID.Text);
                String sqlstr = "SELECT EventID FROM Events WHERE EventID = " + eventID;
                OleDbCommand command = new OleDbCommand();
                command.Connection = conobj;
                command.CommandText = sqlstr;
                conobj.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["EventID"]) == eventID)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                conobj.Close();
                if (flag)
                {
                    frmTick tickobj = new frmTick();
                    Hide();
                    tickobj.Show();
                }
                else
                {
                    MessageBox.Show("Event does not exist");
                }
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Not valid ID");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Please enter the Event ID");
            }
        }

        private void CmsExplain_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("To search please choose a way of filtering through the menu " +
                "to search price type in the search textbox and when an event is found, type in the ID into the EventID "
                + "textbox before pressing the submit button to purchase tickets for the event");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = "DateAndTime";
            searchfun();
        }

        private void LocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = "Location";
            searchfun();
        }

        private void CbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSearch != null)
                {
                    String sqlstr = "SELECT * FROM Events WHERE " + search + " = '" + cbSearch.Text + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
                    vtEvents.Clear();
                    da.Fill(vtEvents);
                    da.Dispose();
                    dgvEvents.DataSource = vtEvents;
                    dgvEvents.Columns["Price"].DefaultCellStyle.Format = "c";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void EventTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = "EventTitle";
            searchfun();
        }
    }
}





/*Programmer's Block
 * 
 *Name: Gabriel Chan 
 * Version 1.0
 * Description: This program is a ticket purchasing system. This form is to show the reciept to the Customer after purchase.
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
    public partial class frmReceipt : Form
    {
        String constr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = TicketsReservationDatabase.accdb";
        DataTable vtEvents = new DataTable();
        DataTable vtCus = new DataTable();
        public frmReceipt()
        {
            InitializeComponent();
            String sqlstr = "SELECT * FROM Events WHERE EventID = " + Form1.eventID;
            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            da.Fill(vtEvents);
            da.Dispose();
            dgvEvents.DataSource = vtEvents;
            dgvEvents.Columns["Price"].DefaultCellStyle.Format = "c";
            sqlstr = "SELECT Customers.CustomerID, Customers.FirstName, Customers.LastName, Customers.Telephone, TicketPurchases.ticketsPurchased, TicketPurchases.TotalCost FROM Customers " +
                        "INNER JOIN TicketPurchases ON Customers.CustomerID = TicketPurchases.CustomerID WHERE TicketPurchases.EventID = " + Form1.eventID + "AND Customers.CustomerID = " + frmTick.CusID;
            OleDbDataAdapter da2 = new OleDbDataAdapter(sqlstr, constr);
            da2.Fill(vtCus);
            da2.Dispose();
            dgvCus.DataSource = vtCus;
            dgvCus.Columns["TotalCost"].DefaultCellStyle.Format = "c";
            switch (Form1.eventID)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources._4;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources._5;
                    break;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

/*Programmer's Block
 * 
 *Name: Gabriel Chan 
 * Version 1.0
 * Description: This program is a ticket purchasing system. This form allows the customer to purchase tickets for the event.
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
using System.IO;

namespace PRGProj
{
    public partial class frmTick : Form
    {
        String constr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = TicketsReservationDatabase.accdb";
        DataTable vtEvents = new DataTable();
        int newCus;
        int ConfirmID;
        int ConfirmName;
        public static int CusID = 0;
        public frmTick()
        {
            InitializeComponent();
            try
            {
                String sqlstr = "SELECT * FROM Events WHERE EventID = " + Form1.eventID;
                OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
                vtEvents.Clear();
                da.Fill(vtEvents);
                da.Dispose();
                dgvCustomerInfo.DataSource = vtEvents;
                dgvCustomerInfo.Columns["Price"].DefaultCellStyle.Format = "c";
            }
            catch (Exception exc)
            {
                MessageBox.Show("out of range");
            }

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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 frm1obj = new Form1();
            Hide();
            frm1obj.Show();
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            int price = 0;
            int seatsAva = 0;
            int seatsSold = 0;
            bool flag = false;
            String sqlSelect;
            String sqlstr;
            OleDbCommand command;
            String sqlAdd;
            OleDbDataReader reader;
            OleDbConnection conobj = new OleDbConnection(constr);
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = conobj.CreateCommand();
            try
            {
                conobj.Open();
                int ticks = Convert.ToInt32(txtTickets.Text);
                if (newCus == 1)
                {
                    sqlAdd = "INSERT INTO Customers (FirstName,LastName,Telephone,Creditcard) VALUES ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtPhone.Text + "','" + txtCC.Text + "')";
                    da.InsertCommand = new OleDbCommand(sqlAdd, conobj);
                    da.InsertCommand.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    CusID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else if (ConfirmID == 1)
                {
                    CusID = Convert.ToInt32(txtPhone.Text);
                }
                else if (ConfirmName == 1)
                {
                    sqlstr = "SELECT CustomerID FROM Customers WHERE FirstName = '" + txtFirstName.Text + "' AND LastName = '" + txtLastName.Text + "'";
                    command = new OleDbCommand();
                    command.Connection = conobj;
                    command.CommandText = sqlstr;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CusID = Convert.ToInt32(reader.GetValue(0));
                    }
                }
                sqlstr = "SELECT CustomerID FROM Customers WHERE CustomerID = " + CusID;
                command = new OleDbCommand();
                command.Connection = conobj;
                command.CommandText = sqlstr;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["CustomerID"]) == CusID)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    sqlSelect = "SELECT SeatsAvailable FROM Events WHERE EventID =" + Form1.eventID;
                    command = new OleDbCommand();
                    command.Connection = conobj;
                    command.CommandText = sqlSelect;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        seatsAva = Convert.ToInt32(reader.GetValue(0));
                    }
                    sqlSelect = "SELECT SeatsSold FROM Events WHERE EventID =" + Form1.eventID;
                    command = new OleDbCommand();
                    command.Connection = conobj;
                    command.CommandText = sqlSelect;
                    reader = command.ExecuteReader();
                    if (seatsAva >= ticks)
                    {
                        while (reader.Read())
                        {
                            seatsSold = Convert.ToInt32(reader.GetValue(0));
                        }


                        sqlSelect = "SELECT Price FROM Events WHERE EventID =" + Form1.eventID;
                        command = new OleDbCommand();
                        command.Connection = conobj;
                        command.CommandText = sqlSelect;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            price = Convert.ToInt32(reader.GetValue(0));
                        }

                        String sqlSearch = "SELECT * FROM Customers Where CustomerID = " + CusID;
                        da.SelectCommand = new OleDbCommand(sqlSearch, conobj);
                        da.SelectCommand.ExecuteNonQuery();

                        sqlAdd = "INSERT INTO TicketPurchases (ticketsPurchased,CustomerID,EventID,TotalCost) VALUES ('" + ticks + "','" + CusID + "','" + Form1.eventID + "','" + (ticks * price) + "')";
                        da.InsertCommand = new OleDbCommand(sqlAdd, conobj);
                        da.InsertCommand.ExecuteNonQuery();

                        String sqlUpdate = " UPDATE Events SET SeatsAvailable = " + (seatsAva - ticks) + ", SeatsSold = " + (seatsSold + ticks) + " WHERE EventID = " + Form1.eventID;
                        da.UpdateCommand = new OleDbCommand(sqlUpdate, conobj);
                        da.UpdateCommand.ExecuteNonQuery();
                        conobj.Close();
                        Hide();
                        frmReceipt receobj = new frmReceipt();
                        receobj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Not enough tickets for you to purchase");
                        txtTickets.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Customer does not Exist");
                }
            }
            catch (IOException exc)
            {
                MessageBox.Show("File Error, Please Try Again");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unexpected Error, Please Try Again");
            }
        }



        private void ConfirmByCustomerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmID = 1;
            newCus = 0;
            ConfirmName = 0;
            lblCusID.Visible = true;
            txtPhone.Visible = true;
            btnPurchase.Visible = true;
            txtTickets.Visible = true;
            lblTicks.Visible = true;
            txtCC.Visible = false;
            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblPhone.Visible = false;
            lblCC.Visible = false;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newCus = 1;
            ConfirmName = 0;
            ConfirmID = 0;
            txtCC.Visible = true;
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtPhone.Visible = true;
            txtTickets.Visible = true;
            lblCC.Visible = true;
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblPhone.Visible = true;
            lblTicks.Visible = true;
            btnPurchase.Visible = true;
            lblCusID.Visible = false;
        }

        private void ConfirmByNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfirmName = 1;
            newCus = 0;
            ConfirmID = 0;
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblTicks.Visible = true;
            txtTickets.Visible = true;
            btnPurchase.Visible = true;
            lblCC.Visible = false;
            txtCC.Visible = false;
            lblCusID.Visible = false;
            lblPhone.Visible = false;
            txtPhone.Visible = false;
        }
    }
}


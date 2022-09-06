using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7AB
{
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelTotalYTDSalesResult.Text = string.Empty;
            labelCreditHoldCountResult.Text = string.Empty;
            clientVM = new ClientViewModel(ClientRepository.GetClients);

            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clientVM.Clients;
            labelTotalYTDSalesResult.Text = $"${clientVM.Clients.TotalYTDSales:N2}";
            labelCreditHoldCountResult.Text = $"{clientVM.Clients.TotalCreditHold}";
            setupDataGridView();
        }

        private void setupDataGridView()
        {
            // configure for readonly 
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = true;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn();
            companyName.Name = "companyName";
            companyName.DataPropertyName = "CompanyName";
            companyName.HeaderText = "Company Name";
            companyName.Width = 160;
            companyName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            companyName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            companyName.DefaultCellStyle.Format = "N0";
            companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(companyName);

            DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
            address1.Name = "address1";
            address1.DataPropertyName = "Address1";
            address1.HeaderText = "Address1";
            address1.Width = 160;
            address1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            address1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address1.DefaultCellStyle.Format = "N0";
            address1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address1);

            DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
            address2.Name = "address2";
            address2.DataPropertyName = "Address2";
            address2.HeaderText = "Address2";
            address2.Width = 60;
            address2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            address2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address2.DefaultCellStyle.Format = "N0";
            address2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address2);

            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
            city.Name = "city";
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.Width = 70;
            city.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
            province.Name = "province";
            province.DataPropertyName = "Province";
            province.HeaderText = "Prov";
            province.Width = 40;
            province.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            province.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            province.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(province);

            DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
            postalCode.Name = "postalCode";
            postalCode.DataPropertyName = "PostalCode";
            postalCode.HeaderText = "Postal Code";
            postalCode.Width = 60;
            postalCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            postalCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postalCode);

            DataGridViewTextBoxColumn YTDsales = new DataGridViewTextBoxColumn();
            YTDsales.Name = "YTDsales";
            YTDsales.DataPropertyName = "YTDSales";
            YTDsales.HeaderText = "YTD Sales";
            YTDsales.Width = 70;
            YTDsales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            YTDsales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            YTDsales.DefaultCellStyle.Format = "N2";
            YTDsales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(YTDsales);

            DataGridViewCheckBoxColumn creditHold = new DataGridViewCheckBoxColumn();
            creditHold.Name = "creditHold";
            creditHold.DataPropertyName = "CreditHold";
            creditHold.HeaderText = "Credit Hold?";
            creditHold.Width = 50;
            creditHold.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            creditHold.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(creditHold);

            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 100;
            notes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            notes.DefaultCellStyle.Format = "N0";
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);

        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            clientVM.SetDisplayClient(clientVM.Clients[index]);

            Dialog newDialog = new Dialog();
            newDialog.ClientVM = clientVM;

            if (newDialog.ShowDialog() == DialogResult.OK)
            {
                clientVM.Clients = ClientRepository.GetClients;
                dataGridViewClients.DataSource = clientVM.Clients;
                labelTotalYTDSalesResult.Text = $"${clientVM.Clients.TotalYTDSales}";
                labelCreditHoldCountResult.Text = $"{clientVM.Clients.TotalCreditHold}";
            }
            newDialog.Dispose();
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            Client client = clientVM.Clients[index];
            clientVM.SetDisplayClient(client);
            clientVM.SetDisplayClient(clientVM.Clients[index]);
        }

   
    }
}

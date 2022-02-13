using System;
using System.Linq;
using System.Windows.Forms;
using WinFormShopBridge.ShopBridgeService;

namespace WinFormShopBridge
{
    public partial class FormInventory : Form
    {
        ShopBridgeServiceClient shopBridgeClient = new ShopBridgeServiceClient();
        bool isUpdateRecord = false, isInitialLoad = true;
        int? inventoryId;
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            GetInventoryDetail();
        }

        private void GetInventoryDetail()
        {           
            GridViewInventory.DataSource = shopBridgeClient.GetInventoryDetail();

            if (GridViewInventory.DataSource != null)
            {
                GridViewInventory.Columns["Id"].Visible = false;
                GridViewInventory.Columns["IsDeleted"].Visible = false;
            }

            ClearData();

            isInitialLoad = false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxInventoryName.Text))
            {
                MessageBox.Show("Item name cannot be blank.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBoxPrice.Text))
            {
                MessageBox.Show("Item price cannot be blank.");
                return;
            }

            bool respone = false;

            if (inventoryId != null && isUpdateRecord)
            {
                respone = shopBridgeClient.UpdateInventoryDetail(new InventoryDetail()
                {
                    Id = inventoryId.Value,
                    ItemName = TextBoxInventoryName.Text,
                    ItemDescription = TextBoxDescription.Text,
                    ItemPrice = Convert.ToDecimal(TextBoxPrice.Text),
                    IsDeleted = false
                });
            }
            else
            {
                respone = shopBridgeClient.UpdateInventoryDetail(new InventoryDetail()
                {
                    ItemName = TextBoxInventoryName.Text,
                    ItemDescription = TextBoxDescription.Text,
                    ItemPrice = Convert.ToDecimal(TextBoxPrice.Text),
                    IsDeleted = false
                });
            }
            

            if (respone)
            {
                if (isUpdateRecord)
                {
                    MessageBox.Show("Inventory details updated successfully.");
                }
                else
                {
                    MessageBox.Show("Inventory details save successfully.");
                }
                inventoryId = null;
                isUpdateRecord = false;
                GetInventoryDetail();
            }
        }

        private void GridViewInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (!isInitialLoad)
            {
                var rowsCount = GridViewInventory.SelectedRows.Count;
                if (rowsCount == 0 || rowsCount > 1)
                {
                    return;
                };

                var row = GridViewInventory.SelectedRows[0];
                if (row == null)
                {
                    return;
                }
                ResolveActionsForRow(row);
            }            
        }

        private void ResolveActionsForRow(DataGridViewRow row)
        {
            isUpdateRecord = true;
            inventoryId = Convert.ToInt32(row.Cells[0].Value.ToString());

            ButtonSave.Visible = false;
            ButtonUpdate.Visible = true;
            ButtonDelete.Visible = true;

            TextBoxInventoryName.Text = row.Cells[3].Value.ToString();
            TextBoxDescription.Text = row.Cells[2].Value.ToString();
            TextBoxPrice.Text = row.Cells[4].Value.ToString();
        }

        private void GridViewInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridViewInventory.ClearSelection();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void ClearGridSelection()
        {
            GridViewInventory.ClearSelection();
        }

        private void ClearData()
        {
            TextBoxInventoryName.Text = null;
            TextBoxDescription.Text = null;
            TextBoxPrice.Text = null;

            inventoryId = null;
            isUpdateRecord = false;

            ButtonSave.Visible = true;
            ButtonUpdate.Visible = false;
            ButtonDelete.Visible = false;

            ClearGridSelection();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                DeleteRecord();
            }
            else
            {
                ClearData();
            }
        }

        private void DeleteRecord()
        {
            bool respone = shopBridgeClient.DeleteInventoryDetail(inventoryId.Value);
            if (respone)
            {
                MessageBox.Show("Record deleted successfully.");
                GetInventoryDetail();
            }
        }
    }
}

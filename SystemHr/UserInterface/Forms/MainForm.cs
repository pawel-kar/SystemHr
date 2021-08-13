using System;
using System.Drawing;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Contracts;
using SystemHR.UserInterface.Forms.Employees;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms
{
    public partial class MainForm : Form
    {

        #region Fields

        private TabPage _tpEmployees;
        private TabPage _tpContracts;

        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Events
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (EmployeesForm.IsNull)
            {
                _tpEmployees = new TabPage();
                showFormInTabPage(_tpEmployees, EmployeesForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpEmployees;
            }
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            if (ContractsForm.IsNull)
            {
                _tpContracts = new TabPage();
                showFormInTabPage(_tpContracts, ContractsForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpContracts;
            }
        }

        private void tcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTabs.TabPages[e.Index];
                var tabRect = this.tcTabs.GetTabRect(e.Index);

                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var form = tcTabs.TabPages[i].Controls[0] as Form;
                    form.Close();
                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        #endregion

        #region Private Methods
        private void showFormInTabPage(TabPage tpTab, Form form)
        {
            tcTabs.Controls.Add(tpTab);

            tpTab.Text = form.Text;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tpTab.Controls.Add(form);
            tcTabs.SelectedTab = tpTab;
        }

        #endregion
    }
}

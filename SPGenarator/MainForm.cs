using Microsoft.Data.ConnectionUI;
using System;
using System.Windows.Forms;

namespace SPGenarator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateCrud_Click(object sender, EventArgs e)
        {
            using (SqlHelper ado = new SqlHelper(txtConnectionString.Text))
            {

                var obj = ado.GetRecordInfo(cmbTable.Text);

                Generator gn = new Generator(cmbTable.Text, obj.ToArray());

                if (chbSpName.Checked)
                {
                    gn.ListPreFix = txtListName.Text;
                    gn.InsertPreFix = txtInsertName.Text;
                    gn.UpdatePreFix = txtUpdateName.Text;
                    gn.DeletePreFix = txtDeleteName.Text;
                }

                ado.Execute(gn.CreateIns());
                ado.Execute(gn.CreateList());
                ado.Execute(gn.CreateDel());
                ado.Execute(gn.CreateUpd());
            }
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text))
            {
                MessageBox.Show("Please Set a Valid Connection String!");
                return;
            }

            SqlHelper ado = new SqlHelper(txtConnectionString.Text);
            cmbTable.DataSource = ado.GetTableName();
        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            using (var dialog = new DataConnectionDialog())
            {
                DataSource.AddStandardDataSources(dialog);

                dialog.DataSources.Add(DataSource.SqlDataSource);
                dialog.DataSources.Add(DataSource.SqlFileDataSource);

                DialogResult userChoice = DataConnectionDialog.Show(dialog);

                if (userChoice == DialogResult.OK)
                {
                    txtConnectionString.Text = dialog.ConnectionString;
                }
                else
                {
                    txtConnectionString.Text = null;
                }
            }
        }

        private void btnScriptForm_Click(object sender, EventArgs e)
        {
            using (SqlHelper ado = new SqlHelper(txtConnectionString.Text))
            {
                string script = "";
                var obj = ado.GetRecordInfo(cmbTable.Text);

                Generator gn = new Generator(cmbTable.Text, obj.ToArray());

                if (chbSpName.Checked)
                {
                    gn.ListPreFix = txtListName.Text;
                    gn.InsertPreFix = txtInsertName.Text;
                    gn.UpdatePreFix = txtUpdateName.Text;
                    gn.DeletePreFix = txtDeleteName.Text;
                }

                script += $"{gn.CreateIns()}{Environment.NewLine}{Environment.NewLine}";
                script += $"{gn.CreateList()}{Environment.NewLine}{Environment.NewLine}";
                script += $"{gn.CreateDel()}{Environment.NewLine}{Environment.NewLine}";
                script += $"{gn.CreateUpd()}{Environment.NewLine}{Environment.NewLine}";

                ScriptForm scriptFrm = new ScriptForm(script);
                scriptFrm.ShowDialog();
            }
        }

        private void chbSpName_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSpName.Checked)
            {
                gbSpName.Enabled = true;
            }
            else
            {
                gbSpName.Enabled = false;
            }
        }
    }
}

using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Net;
using System.IO;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RelixCore\source\repos\WinFormsApp2\SurveyData.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into SurveyTable(nSurveyorname,nSurveyTitle, nEastings, nNorthings, nElevations, nClientNo, nDate, nAddress) values (@nSurveyorname,@nSurveyTitle,@nEastings,@nNorthings,@nElevations,@nClientNo,@nDate,@nAddress);", conn);
            try
            {
                cmd.Parameters.AddWithValue("@nSurveyorname", tbSurveyorname.Text);
                cmd.Parameters.AddWithValue("@nSurveyTitle", comboBox1.Text);
                cmd.Parameters.AddWithValue("@nEastings", tbEastings.Text);
                cmd.Parameters.AddWithValue("@nNorthings", tbNorthings.Text);
                cmd.Parameters.AddWithValue("@nElevations", tbElevations.Text);
                cmd.Parameters.AddWithValue("@nClientNo", tbClientNo.Text);
                cmd.Parameters.AddWithValue("@nDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@nAddress", tbAddress.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Successfully Uploaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Input the Correct Data");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbSurveyorname.Clear();
            tbEastings.Clear();
            tbNorthings.Clear();
            tbElevations.Clear();
            tbAddress.Clear();
            tbClientNo.Clear();
            comboBox1.SelectedIndex = -1;

        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pdfViewerControl1.Load(openFileDialog.FileName);



        }
    }
}
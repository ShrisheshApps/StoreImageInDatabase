using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StoreImageInDatabase
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            this.LoadImages();
        }

        private void ImageSelectorButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|JPEG files (*.jpeg)|*.jpeg";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                ImagePathTextBox.Text = openFileDialog.FileName;
                MyPictureBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string text = "INSERT INTO tblImage(PersonName, Images) VALUES(@PersonName, @Images)";
                    using (SqlCommand cmd = new SqlCommand(text, con))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@PersonName", NameTextBox.Text);
                        byte[] imgbytes = GetImageBytes(ImagePathTextBox.Text);
                        cmd.Parameters.AddWithValue("@Images", imgbytes);
                        con.Open();
                        int rowsAffeted = cmd.ExecuteNonQuery();
                        if (rowsAffeted > 0)
                        {
                            MessageBox.Show(" Image Saved in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] GetImageBytes(string imagePath)
        {
            byte[] data;
            // open FileStream and read all the bytes of the image file
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    data = br.ReadBytes((int)fs.Length);
                }

            }
            return data;
        }

        private void ImagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedtext = ImagesComboBox.SelectedItem.ToString();
            if (selectedtext != null)
            {
                FetchImageFromDatabase(selectedtext);
            }
        }
        private void FetchImageFromDatabase(string value)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string text = "SELECT Top 1 Images from tblImage where Id=@ImageId";
                    using (SqlCommand cmd = new SqlCommand(text, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ImageId", value);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        if (ds.Tables[0].Rows.Count>0)
                        {
                            int i = Convert.ToInt32(value)-1;
                            MyPictureBox.Image = new Bitmap(new MemoryStream((byte[])ds.Tables[0].Rows[0]["Images"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //private void FetchImageFromDatabase(string value)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(cs))
        //        {
        //            string text = "SELECT Top 1 Images from tblImage Where Id=@imageId";
        //            using (SqlCommand cmd = new SqlCommand(text, con))
        //            {
        //                cmd.CommandType = CommandType.Text;
        //                cmd.Parameters.Clear();
        //                cmd.Parameters.AddWithValue("@imageId", value);
        //                con.Open();
        //                var data = cmd.ExecuteScalar().ToString();
        //                byte[] bytes = Encoding.UTF8.GetBytes(data);
        //                MyPictureBox.Image = GetImageFromByteArray(bytes);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private System.Drawing.Image GetImageFromByteArray(byte[] bytes)
        //{
        //    using (MemoryStream ms = new MemoryStream(bytes,0,bytes.Length))
        //    {
        //        return System.Drawing.Image.FromStream(ms);
        //    }
        //}

        private void LoadImages()
        {
            ImagesComboBox.Items.Clear();
            using (SqlConnection con = new SqlConnection(cs))
            {
                string text = "SELECT Id from tblImage";
                using (SqlCommand cmd = new SqlCommand(text, con))
                {
                    cmd.CommandType= CommandType.Text;
                    con.Open(); 
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ImagesComboBox.Items.Add(reader[0].ToString());
                        }
                    }
                }
            }
        }
    }
}

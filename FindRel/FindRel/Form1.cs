using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.Runtime.Intrinsics.Arm;

namespace FindRel
{
    public partial class Form1 : Form
    {
        DataBase data = new();
        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.openConnection();
            DisplayProducts();
            DisplayCategories();
        }


        private void DisplayProducts()
        {
            SqlCommand command = new("select * from Products", data.sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                productsList.Items.Add(reader.GetValue(0) + " " + reader.GetValue(1));
            }
            reader.Close();
        }

        private void DisplayCategories()
        {
            SqlCommand command = new("select * from Categories", data.sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                categoriesList.Items.Add(reader.GetValue(0) + " " + reader.GetValue(1));
            }
            reader.Close();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SelectFunc();
        }

        private void SelectFunc()
        {
            if (input.Text.IsNullOrEmpty())
            {
                return;
            }
            string query = input.Text;
            SqlCommand command = new(query, data.sqlConnection);
            SqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
            }
            catch { MessageBox.Show("Не корректный запрос", "Data Reader", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            int cellsInRow = reader.FieldCount;
            object[] getRead = new object[cellsInRow];

            List<object> result = new();

            string columns = string.Empty;
            for (int i = 0; i < cellsInRow; i++)
            {
                columns += reader.GetName(i) + "\t";
            }
            resList.Items.Add(columns);

            while (reader.Read())
            {
                reader.GetValues(getRead);
                string str = string.Empty;
                for (int i = 0; i < getRead.Length; i++)
                {
                    str += getRead[i].ToString() + " ";
                }
                result.Add(str);
            }
            reader.Close();

            if (query.Contains("Relations"))
            {
                WriteItemsToList(result);
            }
            else
            {
                WriteOtherItems(result);
            }  
        }

        private void WriteOtherItems(List<object> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                string id = (i + 1).ToString();
                string t = id + "\t" + result[i].ToString().Substring(1, result[i].ToString().Length - 1);
                resList.Items.Add(t);
            }
            resList.Items.Add("");
        }


        private void WriteItemsToList(List<object> result)
        {
            SqlCommand temp = null;
            for (int i = 0; i < result.Count; i++)
            {
                string[] findRow = result[i].ToString().Split(" ");
                result[i] = findRow[0] + "\t";
                for (int j = 1; j < findRow.Length; j++)
                {
                    switch (j)
                    {
                        case 1:
                            temp = new($"select Product from Products where id = {findRow[j]}", data.sqlConnection);
                            using (SqlDataReader r = temp.ExecuteReader())
                            {
                                r.Read();
                                string val = r.GetValue(0).ToString().Replace(" ", "");
                                val += val.Length < 9 ? "\t\t" : "\t";
                                result[i] += findRow[j].Replace(findRow[j], val);
                            }
                            break;
                        case 2:
                            temp = new($"select Category from Categories where id = {findRow[j]}", data.sqlConnection);
                            using (SqlDataReader r = temp.ExecuteReader())
                            {
                                r.Read();
                                string val = r.GetValue(0).ToString().Replace(" ", "");
                                val += val.Length < 9 ? "\t\t" : "\t";
                                result[i] += findRow[j].Replace(findRow[j], r.GetValue(0).ToString());
                            }
                            break;
                    }
                }
                
                resList.Items.Add(result[i]);
            }
            resList.Items.Add("");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            input.Text = comboBox1.Text;
        }
    }
}
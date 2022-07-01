using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QL_Karaoke
{
    public partial class Frm_ThongKeVatLieu : Form
    {
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtDoanhThu;
        // string ketnoi = ;
        SqlConnection connect = new SqlConnection(@"Data Source = ELNINO\ELNINO; Initial catalog=DB_QLKaraoke; User ID= sa; Password = 123;");

        public Frm_ThongKeVatLieu()
        {
            InitializeComponent();
        }

        private void Frm_ThongKeVatLieu_Load(object sender, EventArgs e)
        {

        }

        private void btn_DT_Click(object sender, EventArgs e)
        {
            String NgayCuoi = dpk_ngaycuoi.Value.ToString("yyyy-MM-dd");
            String NgayDau = dpk_ngaydau.Value.ToString("yyyy-MM-dd");
            showDoanhThu(NgayDau, NgayCuoi);
        }
        public void showDoanhThu(string ngaybd, String ngaykt)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart3.Series)
            {
                series.Points.Clear();
            }
            dataGridView2.AutoGenerateColumns = false;
            string sql = "select * from View_DS_DichVu('"+ngaybd+"','"+ngaykt+"')";
            dtDoanhThu = db.LayDuLieu(sql);
            dataGridView2.DataSource = dtDoanhThu;
            dataGridView2.Columns[0].DataPropertyName = "TenDV";
            dataGridView2.Columns[2].DataPropertyName = "sl";
            dataGridView2.Columns[1].DataPropertyName = "tongtien";
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                connect.Open();
                da.Fill(dt);
                connect.Close();
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ten DV";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "TongTien";
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Ten DV";
                chart2.ChartAreas["ChartArea1"].AxisY.Title = "TongTien";
                chart2.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                chart3.ChartAreas["ChartArea1"].AxisX.Title = "Ten DV";
                chart3.ChartAreas["ChartArea1"].AxisY.Title = "TongTien";
                chart3.ChartAreas["ChartArea1"].AxisX.Interval = 1;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["Tong"].Points.AddXY(dt.Rows[i]["TenDV"].ToString(), dt.Rows[i]["tongtien"]);
                    chart2.Series["Tong"].Points.AddXY(dt.Rows[i]["TenDV"].ToString(), dt.Rows[i]["sl"]);
                    chart3.Series["Tong"].Points.AddXY(dt.Rows[i]["TenDV"].ToString(), dt.Rows[i]["sl"]);

                }
                // tron 
                 chart3.Series["Tong"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                //
               // chart2.Series["Tong"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            }
            catch (Exception)
            {
                MessageBox.Show("No");

            }
        }

    }
}

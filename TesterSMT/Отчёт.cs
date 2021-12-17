using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuleConnect;



namespace TesterSMT
{
    public partial class Counter : Form
    {
        public Counter()
        {
            InitializeComponent();
        }

        void ЗагрузкаОтчёта(string date1, string date2, string userName)
        {
            Class1.loadgrid(GridRem, @"USE FAS SELECT *  FROM[FAS].[dbo].[Tester_Caden] as cad   left join M_Users as us on cad.UserID = us.UserID  "+
                                   " where DateReg between('" + date1 + "') and ('" + date2 + "') and  us.UserName = '"+ userName +"'");
            }

        void ЗагрузкаОтчёта(string date1, string date2)
        {
            Class1.loadgrid(GridRem, @"USE FAS SELECT TRID,PASS,FAIL,DateReg,Us.Username,ErrorCodeID,Description  FROM[FAS].[dbo].[Tester_Caden] as cad   left join M_Users as us on cad.UserID = us.UserID  " +
                                   " where DateReg between('" + date1 + "') and ('" + date2 + "')");

            Count(date1, date2, ПерваяФорма.LabelNick);

        }

        private void Count(string date1, string date2, string name)
        {
            Counters.Text = Class1.SelectStringInt(@"USE FAS SELECT count(*)  FROM[FAS].[dbo].[Tester_Caden] as cad   left join M_Users as us on cad.UserID = us.UserID  " +
                                   " where DateReg between('" + date1 + "') and ('" + date2 + "') and userName = '"+ name +"' ").ToString();
        }

        private void Отчёт_Load(object sender, EventArgs e)
        {
            UserCombo.Text = ПерваяФорма.LabelNick;
            От.Value = DateTime.Now;
            До.Value = DateTime.Now.AddDays(1);
            Class1.loadgrid(СписокИмён, @"USE FAS SELECT distinct us.UserName	  FROM[FAS].[dbo].[Tester_Caden] as cad  left join M_Users as us on cad.UserID = us.UserID where us.UserID != 211 ");

            

            for (int i = 0; i < СписокИмён.RowCount ; i++)
            {
                UserCombo.Items.Add(СписокИмён.Rows[i].Cells[0].Value);
            }
            ЗагрузкаОтчёта(От.Value.ToString("yyyy-MM-dd"), До.Value.ToString("yyyy-MM-dd"));
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            Count(От.Value.ToString("yyyy-MM-dd"), До.Value.ToString("yyyy-MM-dd"), ПерваяФорма.LabelNick);

                        ЗагрузкаОтчёта(От.Value.ToString("yyyy-MM-dd"), До.Value.ToString("yyyy-MM-dd"), UserCombo.Text);
          
         }
    }
}

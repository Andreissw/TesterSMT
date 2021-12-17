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
    public partial class ПерваяФорма : Form
    {
        public ПерваяФорма()
        {
            InitializeComponent();
        }

        void ЗагрузкаЭкрана(GroupBox GR, GroupBox GR2, bool видимость = false, int width = 1027, int height = 780, bool автоскрол = true)
        {       //Функция загрузки экрана/, то есть подгон размеров формы под групповой контроллер
            var p = new Point(6, 6);
            var sz = new Size(0, 0);
            var pt = new Size(width, height);
            GR.Visible = видимость;
            GR.Location = Point.Add(p, sz);

            GR2.Visible = false;

            this.Size = Size.Add(sz, pt);
            this.AutoScroll = автоскрол;


        }
        string база, Текст;

        string UNIT(string Barcode)
        {
            

            if (Class1.SelectString(@"USE FAS SELECT *  FROM [FAS].[dbo].[Tester_Caden]  where TRID =  '" + Barcode + "'").ToString() == "")
            {
                Текст = "Не найден номер";
                база = "в базе UNIT";
                return Class1.SelectString(@"USE [PSIGMA.FLAT] SELECT Barcode  FROM[PSIGMA.FLAT].[dbo].[TRC_Unit]  where Barcode = '" + Barcode + "'   and id <> 5533499").ToString();
               
            }
            Текст = "Ранее уже был добавлен номер";
            база = "в базе TesterSMT";
            return "";

            
        }

        bool РежимДобавления = false;

        private void SNTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                //if ( UnitCheck.Checked == true)
                //{
                //    Update.Text = $"{Текст} {SNTbox.Text}  {база}";
                //    Update.ForeColor = Color.Red;
                //    DG_Packing.BackgroundColor = Color.Red;
                //    SNTbox.Clear();
                //    SNTbox.Select();
                //    PASSBT.Checked = true;
                //}
                //else
                //{
                    if (PASSBT.Checked == true)
                    {
                        РежимДобавления = true;
                        FailPass.BackColor = Color.WhiteSmoke;
                        Update.Text = "";
                        ДобавлениеБазуPASS();
                        SNTbox.Select();
                        
                    }
                    else if (FAILBT.Checked == true)
                    {
                        SNTbox.Enabled = false;
                        МетодВыводаошибок();
                    }
                    
                    //SNTbox.Enabled = false;
                    //МетодЦвета(Color.Green, Color.Red, Color.Goldenrod);
                    
                //}
              
            }
        }

        //DataGridView erorrGrid = new DataGridView();

        void SpisokErrorCode()
        {

         Class1.loadgrid(ErrorGrid, "USE FAS SELECT concat(Category,code), id FROM [FAS].[dbo].[M_ErrorCode] union SELECT [NameDefect], id  FROM[QA].[dbo].[1C_Defect]");


            for (int i = 0; i < ErrorGrid.RowCount- 1; i++)
            {
                ComboError.Items.Add(ErrorGrid.Rows[i].Cells[0].Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PASSBT.Checked = true;
            SpisokErrorCode();
            ЗагрузкаЭкрана(Вход, Инфо, true);
            NickLabel.Text = "";
            МетодЦвета(Color.Gray);

            Update.Text = "";
            ВводНомера.Enabled = false;
            DG_Packing.Enabled = false;
        }

        private void МетодЦвета(Color cr)
        {
            PASSBT.BackColor = cr;
            FAILBT.BackColor = cr;
            DG_Packing.BackgroundColor = cr;
        }

        private void МетодЦвета(Color cr, Color crRed)
        {
            PASSBT.BackColor = cr;
            FAILBT.BackColor = crRed;
            DG_Packing.BackgroundColor = cr;
        }

        private void МетодЦвета(Color cr, Color crRed, Color crGrid)
        {
            PASSBT.BackColor = cr;
            FAILBT.BackColor = crRed;
            DG_Packing.BackgroundColor = crGrid;
        }

        public static string LabelNick;
        private void RFIDTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ЛоггинМетод();
            }
        }


        private void ЛоггинМетод() //Заходит в базу, проверяет наличие RFID в базе
        {
            Class1.Loggin(RFIDTB, NickLabel, Update);
          
            if (NickLabel.Text == "")
            {

            }
            else
            {
                LabelNick = NickLabel.Text;
                ЗагрузкаЭкрана(Инфо, Вход, true);
                РежимВозвращениеТекстБокса(Color.Gray, Color.Gray, Color.Goldenrod);
                МетодЦвета(Color.Green, Color.Red, Color.Goldenrod);
                button3.Visible = true;
                label5.Text = "Отчёт";
                FailPass.Enabled = true;
                ВводНомера.Enabled = true;
                PASSBT.Checked = true;

                //DG_Packing.Enabled = true;
                //SNTbox.Enabled = true;
                SNTbox.Select();

            }

        }

        private void ЛоггинКнопка_Click(object sender, EventArgs e)
        {
            ЗагрузкаЭкрана(Вход, Инфо, true);
            ВводНомера.Enabled = false;
            DG_Packing.Enabled = false ;
            Update.Text = "";
            МетодЦвета(Color.Gray, Color.Gray, Color.Gray);
            FailPass.Enabled = false;
            RFIDTB.Enabled = true;
            RFIDTB.Clear();
            SNTbox.Clear();
            NickLabel.Text = "";
            ComboError.Text = "";
            button3.Visible = false;
            label5.Text = "";
            Description.Clear();
            FAILGROUP.Visible = false;
            RFIDTB.Select();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SNTbox.Text != "")
            {
                РежимВозвращениеТекстБокса(Color.Gray, Color.Gray, Color.Gray);
                PASSBT.Checked = true;
                SNTbox.Enabled = true;
            }
            else
            {
                SNTbox.Select();
            }


        }

        private void РежимВозвращениеТекстБокса(Color cr, Color cr2, Color crgrid)
        {
            SNTbox.Clear();

            //МетодЦвета(cr,cr2,crgrid);
            //FailPass.Enabled = false;
            //РежимДобавления = false;

            ВводНомера.Enabled = true;
            ComboError.Text = "";
            Description.Clear();
            FAILGROUP.Visible = false;
            SNTbox.Select();
        }

        private void Pass_Click(object sender, EventArgs e)
        {
            ДобавлениеБазуPASS();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)

        {
                      

            if (e.KeyValue == (Char)Keys.Enter && e.Control)
                          if (ComboError.Text != "")
                               ДобавлениВБазуFAIL();
         
        }

        private void Fail_Click(object sender, EventArgs e)
        {
            МетодВыводаошибок();
        }

        private void МетодВыводаошибок()
        {
            FAILGROUP.Visible = true;
            ComboError.Select();
            РежимДобавления = false;


        }

        private void ComboError_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (Char)Keys.Enter)
            {
                if (ComboError.Text != "")
                {
                    Description.Select();
                }
               
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ДобавлениВБазуFAIL();
        }

        private void ДобавлениВБазуFAIL()
        {
            if (ComboError.Text == "")
            {
                ComboError.Select();
            }
            else
            {
                ПоискIDErrorCode();
                if (UnitCheck.Checked == true)
                    ДобавлениеВБазуFAil(",1");
                else
                    ДобавлениеВБазуFAil(",0");

                Update.ForeColor = Color.Green;
                Update.Text = $"Приемник успешно добавлен с кодом отказа {ComboError.Text} - {SNTbox.Text}";
                DG_Packing.Rows.Add(SNTbox.Text, "NOK", DateTime.Now, NickLabel.Text, ComboError.Text, Description.Text);
                DG_Packing.BackgroundColor = Color.Red;
                try { DG_Packing.Sort(DG_Packing.Columns[2], System.ComponentModel.ListSortDirection.Descending); } catch (Exception) { Update.Text = "проблема при сортировке"; }
                РежимВозвращениеТекстБокса(Color.Gray, Color.Gray, Color.Green);
                PASSBT.Checked = true;
                SNTbox.Enabled = true;
                SNTbox.Select();

            }
        }

        private void ДобавлениеВБазуFAil(string line)
        {
            Class1.SelectString(@"use FAS INSERT INTO [FAS].[dbo].[Tester_Caden] (TRID,  PASS,  FAIL, DateReg, UserID,ErrorCodeID,Description,checkunit) VALUES ('" + SNTbox.Text + "',  null,  1,  CURRENT_TIMESTAMP,  '" + Class1.LogginID(NickLabel.Text) + "', '" + idErrorCode + "', '" + Description.Text + "' "+ line +")");
        }

        string idErrorCode;
        private void ComboError_Leave(object sender, EventArgs e)
        {
            ПоискIDErrorCode();

        }

        private void ПоискIDErrorCode()
        {
            for (int i = 0; i < ErrorGrid.RowCount - 1; i++)
            {
                if (ComboError.Text == ErrorGrid.Rows[i].Cells[0].Value.ToString())
                {
                    idErrorCode = ErrorGrid.Rows[i].Cells[1].Value.ToString();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Counter отчёт = new Counter();
            отчёт.Show();
        }

        private void FAILBT_CheckedChanged(object sender, EventArgs e)
        {
            if (PASSBT.Checked == true)
            {
                РежимВозвращениеТекстБокса(Color.Gray, Color.Gray, Color.Gray);
            }
            if (FAILBT.Checked == true)
            {
                SNTbox.Select();
            }
        }

        private void ДобавлениеБазуPASS()
        {
            if (UnitCheck.Checked == true)
              ЗапросНаДобавлениеPass(",1");
            else
              ЗапросНаДобавлениеPass(",0");

            Update.ForeColor = Color.Green;
            Update.Text = $"Приемник успешно добавлен! {SNTbox.Text}";
            DG_Packing.Rows.Add(SNTbox.Text, "OK", DateTime.Now, NickLabel.Text);
            DG_Packing.BackgroundColor = Color.Green;
            try { DG_Packing.Sort(DG_Packing.Columns[2], System.ComponentModel.ListSortDirection.Descending); } catch (Exception) { Update.Text = "проблема при сортировке"; }
            РежимВозвращениеТекстБокса(Color.Gray, Color.Gray, Color.Green);

        }

        private void ЗапросНаДобавлениеPass(string check)
        {
            Class1.SelectString(@"use FAS INSERT INTO [FAS].[dbo].[Tester_Caden] (TRID,  PASS,  FAIL, DateReg, UserID ,checkunit) VALUES ('" + SNTbox.Text + "',  1,  null,  CURRENT_TIMESTAMP,  '" + Class1.LogginID(NickLabel.Text) + "' "+ check+")");
        }
    }

}

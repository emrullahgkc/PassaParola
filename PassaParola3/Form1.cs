using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace PassaParola3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglantisi conn = new SqlBaglantisi();
        int soruno = 1, passcvp = 24, sayacdk = 2, sayacsn = 60, dgrcvp = 0, ynlscvp = 0;
        string cvp;
        public void sorugetir()
        {
            switch (soruno)
            {
                case 1:
                    if (yuvarlakBtn1.BackColor == Color.Yellow)
                    {
                        SqlCommand komut1 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'A%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr1 = komut1.ExecuteReader();
                        while (dr1.Read())  {
                            richTextBox1.Text = dr1[0].ToString();
                            yuvarlakBtn25.Text = "A";
                            cvp = dr1[1].ToString();
                            yuvarlakBtn1.BackColor = Color.Yellow;   }  }
                    else  {   soruno++;  }  ; break;
                case 2:
                    if (yuvarlakBtn2.BackColor == Color.Yellow)
                    {
                        SqlCommand komut2 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'B%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr2 = komut2.ExecuteReader();
                        while (dr2.Read())
                        {
                            richTextBox1.Text = dr2[0].ToString();
                            yuvarlakBtn25.Text = "B";
                            cvp = dr2[1].ToString();
                            yuvarlakBtn2.BackColor = Color.Yellow;
                        }   }
                    else { soruno++;                }; break;
                case 3:
                    if (yuvarlakBtn3.BackColor == Color.Yellow)
                    {    SqlCommand komut3 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'C%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr3 = komut3.ExecuteReader();
                        while (dr3.Read())
                        {
                            richTextBox1.Text = dr3[0].ToString();
                            yuvarlakBtn25.Text = "C";
                            cvp = dr3[1].ToString();
                            yuvarlakBtn3.BackColor = Color.Yellow;
                        }
                    }
                    else           {     soruno++;  }       ; break;
                case 4:
                    if (yuvarlakBtn4.BackColor == Color.Yellow)
                    {
                        SqlCommand komut4 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'D%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr4 = komut4.ExecuteReader();
                        while (dr4.Read())
                        {
                            richTextBox1.Text = dr4[0].ToString();
                            yuvarlakBtn25.Text = "D";
                            cvp = dr4[1].ToString();
                            yuvarlakBtn4.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 5:
                    if (yuvarlakBtn5.BackColor == Color.Yellow)
                    {
                        SqlCommand komut5 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'E%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr5 = komut5.ExecuteReader();
                        while (dr5.Read())
                        {
                            richTextBox1.Text = dr5[0].ToString();
                            yuvarlakBtn25.Text = "E";
                            cvp = dr5[1].ToString();
                            yuvarlakBtn5.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 6:
                    if (yuvarlakBtn6.BackColor == Color.Yellow)
                    {
                        SqlCommand komut6 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'F%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr6 = komut6.ExecuteReader();
                        while (dr6.Read())
                        {
                            richTextBox1.Text = dr6[0].ToString();
                            yuvarlakBtn25.Text = "F";
                            cvp = dr6[1].ToString();
                            yuvarlakBtn6.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 7:
                    if (yuvarlakBtn7.BackColor == Color.Yellow)
                    {
                        SqlCommand komut7 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'G%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr7 = komut7.ExecuteReader();
                        while (dr7.Read())
                        {
                            richTextBox1.Text = dr7[0].ToString();
                            yuvarlakBtn25.Text = "G";
                            cvp = dr7[1].ToString();
                            yuvarlakBtn7.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 8:
                    if (yuvarlakBtn8.BackColor == Color.Yellow)
                    {
                        SqlCommand komut8 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'H%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr8 = komut8.ExecuteReader();
                        while (dr8.Read())
                        {
                            richTextBox1.Text = dr8[0].ToString();
                            yuvarlakBtn25.Text = "H";
                            cvp = dr8[1].ToString();
                            yuvarlakBtn8.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 9:
                    if (yuvarlakBtn9.BackColor == Color.Yellow)
                    {
                        SqlCommand komut9 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'I%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr9 = komut9.ExecuteReader();
                        while (dr9.Read())
                        {
                            richTextBox1.Text = dr9[0].ToString();
                            yuvarlakBtn25.Text = "I";
                            cvp = dr9[1].ToString();
                            yuvarlakBtn9.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 10:
                    if (yuvarlakBtn10.BackColor == Color.Yellow)
                    {
                        SqlCommand komut10 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'İ%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr10 = komut10.ExecuteReader();
                        while (dr10.Read())
                        {
                            richTextBox1.Text = dr10[0].ToString();
                            yuvarlakBtn25.Text = "İ";
                            cvp = dr10[1].ToString();
                            yuvarlakBtn10.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 11:
                    if (yuvarlakBtn11.BackColor == Color.Yellow)
                    {
                        SqlCommand komut11 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'J%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr11 = komut11.ExecuteReader();
                        while (dr11.Read())
                        {
                            richTextBox1.Text = dr11[0].ToString();
                            yuvarlakBtn25.Text = "J";
                            cvp = dr11[1].ToString();
                            yuvarlakBtn11.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 12:
                    if (yuvarlakBtn12.BackColor == Color.Yellow)
                    {
                        SqlCommand komut12 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'K%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr12 = komut12.ExecuteReader();
                        while (dr12.Read())
                        {
                            richTextBox1.Text = dr12[0].ToString();
                            yuvarlakBtn25.Text = "K";
                            cvp = dr12[1].ToString();
                            yuvarlakBtn12.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 13:
                    if (yuvarlakBtn13.BackColor == Color.Yellow)
                    {
                        SqlCommand komut13 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'L%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr13 = komut13.ExecuteReader();
                        while (dr13.Read())
                        {
                            richTextBox1.Text = dr13[0].ToString();
                            yuvarlakBtn25.Text = "L";
                            cvp = dr13[1].ToString();
                            yuvarlakBtn13.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 14:
                    if (yuvarlakBtn14.BackColor == Color.Yellow)
                    {
                        SqlCommand komut14 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'M%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr14 = komut14.ExecuteReader();
                        while (dr14.Read())
                        {
                            richTextBox1.Text = dr14[0].ToString();
                            yuvarlakBtn25.Text = "M";
                            cvp = dr14[1].ToString();
                            yuvarlakBtn14.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 15:
                    if (yuvarlakBtn15.BackColor == Color.Yellow)
                    {
                        SqlCommand komut15 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'N%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr15 = komut15.ExecuteReader();
                        while (dr15.Read())
                        {
                            richTextBox1.Text = dr15[0].ToString();
                            yuvarlakBtn25.Text = "N";
                            cvp = dr15[1].ToString();
                            yuvarlakBtn15.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 16:
                    if (yuvarlakBtn16.BackColor == Color.Yellow)
                    {
                        SqlCommand komut16 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'O%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr16 = komut16.ExecuteReader();
                        while (dr16.Read())
                        {
                            richTextBox1.Text = dr16[0].ToString();
                            yuvarlakBtn25.Text = "O";
                            cvp = dr16[1].ToString();
                            yuvarlakBtn16.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 17:
                    if (yuvarlakBtn17.BackColor == Color.Yellow)
                    {
                        SqlCommand komut1 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'P%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr17 = komut1.ExecuteReader();
                        while (dr17.Read())
                        {
                            richTextBox1.Text = dr17[0].ToString();
                            yuvarlakBtn25.Text = "P";
                            cvp = dr17[1].ToString();
                            yuvarlakBtn17.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 18:
                    if (yuvarlakBtn18.BackColor == Color.Yellow)
                    {
                        SqlCommand komut18 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'R%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr18 = komut18.ExecuteReader();
                        while (dr18.Read())
                        {
                            richTextBox1.Text = dr18[0].ToString();
                            yuvarlakBtn25.Text = "R";
                            cvp = dr18[1].ToString();
                            yuvarlakBtn18.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 19:
                    if (yuvarlakBtn19.BackColor == Color.Yellow)
                    {
                        SqlCommand komut19 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'S%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr19 = komut19.ExecuteReader();
                        while (dr19.Read())
                        {
                            richTextBox1.Text = dr19[0].ToString();
                            yuvarlakBtn25.Text = "S";
                            cvp = dr19[1].ToString();
                            yuvarlakBtn19.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 20:
                    if (yuvarlakBtn20.BackColor == Color.Yellow)
                    {
                        SqlCommand komut20 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'T%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr20 = komut20.ExecuteReader();
                        while (dr20.Read())
                        {
                            richTextBox1.Text = dr20[0].ToString();
                            yuvarlakBtn25.Text = "T";
                            cvp = dr20[1].ToString();
                            yuvarlakBtn20.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 21:
                    if (yuvarlakBtn21.BackColor == Color.Yellow)
                    {
                        SqlCommand komut21 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'U%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr21 = komut21.ExecuteReader();
                        while (dr21.Read())
                        {
                            richTextBox1.Text = dr21[0].ToString();
                            yuvarlakBtn25.Text = "U";
                            cvp = dr21[1].ToString();
                            yuvarlakBtn21.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 22:
                    if (yuvarlakBtn22.BackColor == Color.Yellow)
                    {
                        SqlCommand komut22 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'V%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr22 = komut22.ExecuteReader();
                        while (dr22.Read())
                        {
                            richTextBox1.Text = dr22[0].ToString();
                            yuvarlakBtn25.Text = "V";
                            cvp = dr22[1].ToString();
                            yuvarlakBtn22.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 23:
                    if (yuvarlakBtn23.BackColor == Color.Yellow)
                    {
                        SqlCommand komut23 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'Y%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr23 = komut23.ExecuteReader();
                        while (dr23.Read())
                        {
                            richTextBox1.Text = dr23[0].ToString();
                            yuvarlakBtn25.Text = "Y";
                            cvp = dr23[1].ToString();
                            yuvarlakBtn23.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;

                case 24:
                    if (yuvarlakBtn24.BackColor == Color.Yellow)
                    {
                        SqlCommand komut24 = new SqlCommand("Select  TOP 1 SORU,CEVAP FROM SORU    Where CEVAP LIKE 'Z%' ORDER BY NEWID()", conn.baglanti());
                        SqlDataReader dr24 = komut24.ExecuteReader();
                        while (dr24.Read())
                        {
                            richTextBox1.Text = dr24[0].ToString();
                            yuvarlakBtn25.Text = "Z";
                            cvp = dr24[1].ToString();
                            yuvarlakBtn24.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        soruno++;
                    }

                    ; break;



            }


        }
        void sorgu()
        {            switch (soruno)
            {
                case 1:                    
                    if (cvp == textBox1.Text)
                    {
                        dgrcvp++;
                     
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn1.BackColor = Color.Green;
                        yuvarlakBtn2.BackColor = Color.Yellow;
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        soruno++;
                        sorugetir();                    }                    
                    else                    {
                        ynlscvp++;                       
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn1.BackColor = Color.Red;
                        yuvarlakBtn2.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();                    };
                    break;
                case 2:
                    if (cvp == textBox1.Text)                    {
                        dgrcvp++; 
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn2.BackColor = Color.Green;
                        yuvarlakBtn3.BackColor = Color.Yellow;
                        soruno++;       sorugetir();                    }
                    else                    {                       
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn2.BackColor = Color.Red;
                        yuvarlakBtn3.BackColor = Color.Yellow;
                        soruno++;   sorugetir();                    };
                    break;
                case 3:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn3.BackColor = Color.Green;
                        yuvarlakBtn4.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn3.BackColor = Color.Red;
                        yuvarlakBtn4.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 4:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn4.BackColor = Color.Green;
                        yuvarlakBtn5.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn4.BackColor = Color.Red;
                        yuvarlakBtn5.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 5:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn5.BackColor = Color.Green;
                        yuvarlakBtn6.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn5.BackColor = Color.Red;
                        yuvarlakBtn6.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 6:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn6.BackColor = Color.Green;
                        yuvarlakBtn7.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn6.BackColor = Color.Red;
                        yuvarlakBtn7.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 7:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn7.BackColor = Color.Green;
                        yuvarlakBtn8.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn7.BackColor = Color.Red;
                        yuvarlakBtn8.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 8:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn8.BackColor = Color.Green;
                        yuvarlakBtn9.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn8.BackColor = Color.Red;
                        yuvarlakBtn9.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 9:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn9.BackColor = Color.Green;
                        yuvarlakBtn10.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn9.BackColor = Color.Red;
                        yuvarlakBtn10.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 10:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn10.BackColor = Color.Green;
                        yuvarlakBtn11.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn10.BackColor = Color.Red;
                        yuvarlakBtn11.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 11:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn11.BackColor = Color.Green;
                        yuvarlakBtn12.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn11.BackColor = Color.Red;
                        yuvarlakBtn12.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 12:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn12.BackColor = Color.Green;
                        yuvarlakBtn13.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn12.BackColor = Color.Red;
                        yuvarlakBtn13.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 13:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn13.BackColor = Color.Green;
                        yuvarlakBtn14.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn13.BackColor = Color.Red;
                        yuvarlakBtn14.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 14:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn14.BackColor = Color.Green;
                        yuvarlakBtn15.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn14.BackColor = Color.Red;
                        yuvarlakBtn15.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 15:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn15.BackColor = Color.Green;
                        yuvarlakBtn16.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn15.BackColor = Color.Red;
                        yuvarlakBtn16.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 16:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn16.BackColor = Color.Green;
                        yuvarlakBtn17.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn16.BackColor = Color.Red;
                        yuvarlakBtn17.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 17:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn17.BackColor = Color.Green;
                        yuvarlakBtn18.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn17.BackColor = Color.Red;
                        yuvarlakBtn18.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 18:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn18.BackColor = Color.Green;
                        yuvarlakBtn19.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn18.BackColor = Color.Red;
                        yuvarlakBtn19.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 19:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn19.BackColor = Color.Green;
                        yuvarlakBtn20.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn19.BackColor = Color.Red;
                        yuvarlakBtn20.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 20:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn20.BackColor = Color.Green;
                        yuvarlakBtn21.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn20.BackColor = Color.Red;
                        yuvarlakBtn21.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 21:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn21.BackColor = Color.Green;
                        yuvarlakBtn22.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn21.BackColor = Color.Red;
                        yuvarlakBtn22.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 22:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn22.BackColor = Color.Green;
                        yuvarlakBtn23.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn22.BackColor = Color.Red;
                        yuvarlakBtn23.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 23:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn23.BackColor = Color.Green;
                        yuvarlakBtn24.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn23.BackColor = Color.Red;
                        yuvarlakBtn24.BackColor = Color.Yellow;
                        soruno++;
                        sorugetir();
                    };
                    break;
                case 24:



                    if (cvp == textBox1.Text)
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        dgrcvp++;
                        lbldogru.Text = dgrcvp.ToString();
                        yuvarlakBtn24.BackColor = Color.Green;
                        soruno = 1;
                        sorugetir();

                    }

                    else
                    {
                        passcvp--;
                        label11.Text = passcvp.ToString();
                        ynlscvp++;
                        lblynls.Text = ynlscvp.ToString();
                        yuvarlakBtn24.BackColor = Color.Red;
                        soruno = 1;
                        sorugetir();
                    };
                    break;
            }
        }
        void pass()
        {
       
            soruno++;
            switch (soruno)
            {
                case 1:
                    yuvarlakBtn1.BackColor = Color.Yellow;
                    sorugetir();
                    ; break;
                case 2:
                    yuvarlakBtn2.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 3:
                    yuvarlakBtn3.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 4:
                    yuvarlakBtn4.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 5:
                    yuvarlakBtn5.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 6:
                    yuvarlakBtn6.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 7:
                    yuvarlakBtn7.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 8:
                    yuvarlakBtn8.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 9:
                    yuvarlakBtn9.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 10:
                    yuvarlakBtn10.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 11:
                    yuvarlakBtn11.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 12:
                    yuvarlakBtn12.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 13:
                    yuvarlakBtn13.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 14:
                    yuvarlakBtn14.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 15:
                    yuvarlakBtn15.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 16:
                    yuvarlakBtn16.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 17:
                    yuvarlakBtn17.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 18:
                    yuvarlakBtn18.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 19:
                    yuvarlakBtn19.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 20:
                    yuvarlakBtn20.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 21:
                    yuvarlakBtn21.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 22:
                    yuvarlakBtn22.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 23:
                    yuvarlakBtn23.BackColor = Color.Yellow; sorugetir();
                    ; break;
                case 24:
                    yuvarlakBtn24.BackColor = Color.Yellow; sorugetir();
                    soruno = 0;
                    ; break;



            }


        }
        private void YbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnPass.Enabled = false;
            BtnCvp.Enabled = false;

        }
          private void BtnPass_Click(object sender, EventArgs e)
        {            pass();   }

        private void YbtnYeniSoru_Click(object sender, EventArgs e)
        {            SoruEkleme fr = new SoruEkleme();            fr.Show();        }

        private void BtnCvp_Click(object sender, EventArgs e)
        {
            label11.Text = (passcvp - 1).ToString();
            if (passcvp != 1)
            {
                sorgu();
             //   label11.Text = (passcvp-1).ToString();
            }
            else
            {
                timer1.Stop();
                if (MessageBox.Show("Dogru Cevap Sayısı : " + " " + dgrcvp.ToString() + Environment.NewLine + "Yanlış Cevap Sayısı : "
               + ynlscvp.ToString() + Environment.NewLine + "Boş Bırakılan Soru Sayısı : " + (passcvp - 1).ToString(),
               "SORULAR BİTTİ..!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry)
                {
                    gerisayim fr = new gerisayim();
                    fr.Show();
                }
                else { }

            }
            
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//HARFLERİ KÜÇÜLTME
            textBox1.Text = textBox1.Text.ToLower();
            textBox1.SelectionStart = textBox1.Text.Length;        }
        private void timer1_Tick(object sender, EventArgs e)
        {            timer1.Interval = 1000;
            sayacsn = sayacsn - 1;
            label5.Text = sayacsn.ToString();
            label3.Text = (sayacdk - 1).ToString();           
            if (sayacsn == 0)            {               
                sayacdk = sayacdk - 1;
                label3.Text = sayacdk.ToString();
                sayacsn = 60;         }
            if (label3.Text == "-1"){  
                timer1.Stop();
                label3.Text = "00";
                label5.Text = "00";
                BtnPass.Enabled = false;
                BtnCvp.Enabled = false;
                if (MessageBox.Show("Dogru Cevap Sayısı : " + " " + dgrcvp.ToString() + Environment.NewLine + "Yanlış Cevap Sayısı : "
                  + ynlscvp.ToString() + Environment.NewLine + "Boş Bırakılan Soru Sayısı : " + passcvp.ToString(),
                  "SÜRE DOLDU..!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry)  
                {
                    gerisayim fr = new gerisayim();    fr.Show();
                }                else                { }  } }
        public void otobaslat ()
        {
            sayacdk = 2;  sayacsn = 60;  soruno = 1;
            ynlscvp = 0;dgrcvp = 0; passcvp = 24;
            sorugetir();
            BtnPass.Enabled = true;
            BtnCvp.Enabled = true;
            label11.Text = passcvp.ToString();        }
                private void YbtnBaslat_Click(object sender, EventArgs e)
        {            label11.Text = passcvp.ToString();
            BtnPass.Enabled = true;
            BtnCvp.Enabled = true;
            YbtnBaslat.Enabled = false;
            YbtnYeniSoru.Enabled = false;
            textBox1.TabIndex = 0;
            sorugetir();
            timer1.Start();
        }

      
        



    }
}




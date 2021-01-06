using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double KQ = 0;
        double a = 0;
        int i = 0;
        const string divideByZero = "Err!";
        const string syntaxErr = "SYNTAX ERROR!";
        bool decimalPointActive = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void PreCheck_ButtonClick()
        {
            if (rtbox_Nhap.Text == divideByZero || rtbox_Nhap.Text == syntaxErr)
                rtbox_Nhap.Text = "0";
            /*if (previousOperation != Operation.None)
            {
                EnableOperatorButtons();
            }*/
        }

        enum Operation
        {
            Add,
            Sub,
            Mul,
            Div,
            None
        }

        Operation previousOperation = Operation.None;
        Operation currentOperation = Operation.None;

        private void btNum_Click(object sender, EventArgs e)
        {
            if (rtbox_Nhap.Text == syntaxErr || rtbox_Nhap.Text == divideByZero)
            {
                rtbox_Nhap.Text = string.Empty;
            }
            //EnableOperatorButtons();
            PreCheck_ButtonClick();
            rtbox_Nhap.Text += (sender as Button).Text;

            if (i > 1)
            {
                if (Convert.ToDouble(rtbox_KetQua.Text) == KQ)
                {
                    rtbox_KetQua.Text = "";
                    rtbox_KetQua.Text += (sender as Button).Text;
                }
                else
                {
                    rtbox_KetQua.Text += (sender as Button).Text;
                }


            }

        }

        private void bt_Xoa(object sender, EventArgs e)
        {

            decimalPointActive = false;
            PreCheck_ButtonClick();
            if (rtbox_Nhap.Text.Length > 0)
            {
                double d;
                if (!double.TryParse(rtbox_Nhap.Text[rtbox_Nhap.Text.Length - 1].ToString(), out d))
                {
                    previousOperation = Operation.None;
                }

                rtbox_Nhap.Text = rtbox_Nhap.Text.Remove(rtbox_Nhap.Text.Length - 1, 1);
                if (rtbox_KetQua.Text.Length != 0)
                {
                    if (Convert.ToDouble(rtbox_KetQua.Text) != KQ)
                    {
                        rtbox_KetQua.Text = rtbox_KetQua.Text.Remove(rtbox_KetQua.Text.Length - 1, 1);
                    }



                }


            }
            if (rtbox_KetQua.Text.Length == 0)
            {
                /*List<double> lstNums = null;
                if (a == 0)
                {
                    lstNums = rtbox_Nhap.Text.Split().Select(double.Parse).ToList();
                    KQ = lstNums[0];
                    
                    rtbox_KetQua.Text = KQ.ToString();

                }
                else
                {
                    rtbox_KetQua.Text = KQ.ToString();
                }*/
                if (i == 1)
                {
                    i--;



                }
                if (i > 1)
                {
                    rtbox_KetQua.Text = KQ.ToString();
                }

            }
            if (rtbox_Nhap.Text.Length == 0)
            {
                previousOperation = Operation.None;
            }
            if (previousOperation != Operation.None)
            {
                currentOperation = previousOperation;
            }
        }

        private void bt_Del_Click(object sender, EventArgs e)
        {
            decimalPointActive = false;
            PreCheck_ButtonClick();
            previousOperation = Operation.None;
            rtbox_Nhap.Clear();
            rtbox_KetQua.Clear();
            i = 0;
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (rtbox_Nhap.TextLength == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Add;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            //EnableOperatorButtons(false);
            rtbox_Nhap.Text += (sender as Button).Text;
            i++;

        }
        private void Phann()
        {

        }
        private void PerformCalculation(Operation previousOperation)
        {
            try
            {
                if (previousOperation == Operation.None)
                    return;
                List<double> lstNums = null;

                switch (previousOperation)
                {
                    case Operation.Add:
                        /*if (currentOperation == Operation.Sub)
                        {
                            currentOperation = Operation.Add;
                            return;
                        }*/
                        lstNums = rtbox_Nhap.Text.Split('-', '+', 'x', '/').Select(double.Parse).ToList();
                        if (rtbox_KetQua.Text.Length == 0)
                        {


                            KQ = lstNums[0] + lstNums[1];
                            rtbox_KetQua.Text = KQ.ToString();
                        }
                        else
                        {
                            a = Convert.ToDouble(rtbox_KetQua.Text);
                            KQ = KQ + a;
                            a = KQ;
                            if (i > 1)
                            {
                                rtbox_KetQua.Text = KQ.ToString();
                            }

                        }


                        break;
                    case Operation.Sub:
                        /*int idx = rtbox_Nhap.Text.LastIndexOf('-'); // To handle ex: -9-2
                        if (idx > 0)
                        {
                            var op1 = Convert.ToDouble(rtbox_Nhap.Text.Substring(0, idx));
                            var op2 = Convert.ToDouble(rtbox_Nhap.Text.Substring(idx + 1));
                            if (rtbox_KetQua.Text.Length == 0)
                            {


                                KQ = op1 - op2;
                                rtbox_KetQua.Text = KQ.ToString();
                            }
                            
                            //rtbox_Nhap.Text = (op1 - op2).ToString();
                        }
                        else
                        {
                            a = Convert.ToDouble(rtbox_KetQua.Text);
                            KQ = KQ + a;
                            a = KQ;
                            rtbox_KetQua.Text = KQ.ToString();
                        }*/
                        lstNums = rtbox_Nhap.Text.Split('-', '+', 'x', '/').Select(double.Parse).ToList();
                        if (rtbox_KetQua.Text.Length == 0)
                        {


                            KQ = lstNums[0] - lstNums[1];
                            rtbox_KetQua.Text = KQ.ToString();
                        }
                        else
                        {
                            a = Convert.ToDouble(rtbox_KetQua.Text);
                            KQ = KQ - a;
                            a = KQ;
                            rtbox_KetQua.Text = KQ.ToString();
                        }
                        break;
                    case Operation.Mul:
                        if (currentOperation == Operation.Sub)
                        {
                            currentOperation = Operation.Mul;
                            return;
                        }
                        lstNums = rtbox_Nhap.Text.Split('-', '+', 'x', '/').Select(double.Parse).ToList();
                        //rtbox_Nhap.Text = (lstNums[0] * lstNums[1]).ToString();
                        if (rtbox_KetQua.Text.Length == 0)
                        {


                            KQ = lstNums[0] * lstNums[1];
                            rtbox_KetQua.Text = KQ.ToString();
                        }
                        else
                        {
                            a = Convert.ToDouble(rtbox_KetQua.Text);
                            KQ = KQ * a;
                            a = KQ;
                            rtbox_KetQua.Text = KQ.ToString();
                        }
                        break;
                    case Operation.Div:
                        /*if (currentOperation == Operation.Sub)
                        {
                            currentOperation = Operation.Div;
                            return;
                        }*/
                        try
                        {
                            lstNums = rtbox_Nhap.Text.Split('-', '+', 'x', '/').Select(double.Parse).ToList();
                            if (lstNums[1] == 0 )
                            {
                                throw new DivideByZeroException();
                            }
                            if (rtbox_KetQua.Text.Length == 0)
                            {


                                KQ = lstNums[0] / lstNums[1];
                                rtbox_KetQua.Text = KQ.ToString();
                            }
                            else
                            {
                                a = Convert.ToDouble(rtbox_KetQua.Text);
                                KQ = KQ / a;
                                a = KQ;
                                rtbox_KetQua.Text = KQ.ToString();
                            }
                            //rtbox_Nhap.Text = (lstNums[0] / lstNums[1]).ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            rtbox_KetQua.Text = divideByZero;
                        }
                        break;
                    case Operation.None:
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                rtbox_KetQua.Text = syntaxErr;
            }
        }



        private void btChia_Click(object sender, EventArgs e)
        {
            if (rtbox_Nhap.Text.Length == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Div;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            //EnableOperatorButtons(false);
            rtbox_Nhap.Text += (sender as Button).Text;
            i++;
        }

        private void btBang_Click(object sender, EventArgs e)
        {
            if (rtbox_Nhap.TextLength == 0) return;
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.None;
        }

        private void btThapPhan_Click(object sender, EventArgs e)
        {
            if (decimalPointActive) return;
            if (rtbox_Nhap.Text == syntaxErr || rtbox_Nhap.Text == divideByZero)
            {
                rtbox_Nhap.Text = string.Empty;
            }
            //EnableOperatorButtons();
            PreCheck_ButtonClick();
            rtbox_Nhap.Text += (sender as Button).Text;
            decimalPointActive = true;
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            if (rtbox_Nhap.TextLength == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Mul;
            PerformCalculation(previousOperation);
            previousOperation = currentOperation;
            //EnableOperatorButtons(false);
            rtbox_Nhap.Text += (sender as Button).Text;
            i++;
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            if (rtbox_Nhap.TextLength == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Sub;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            //EnableOperatorButtons(false);
            rtbox_Nhap.Text += (sender as Button).Text;
            i++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rtbox_Nhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbox_KetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

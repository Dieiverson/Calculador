using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2;
        bool podeApagar = false;
        double memoria1, memoria2, memoria3, memoria4;
        char operacao;
        bool total = false;

		private void btn_Limpar_Click(object sender, EventArgs e)
		{
			Application.Restart();//reinicia a app
			

		}
		private void button1_Click(object sender, EventArgs e)//escreve numero 1
        {
            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }

            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)//bt virgula
        {

            if (podeApagar)
            {
                textBox1.Text = "";
                podeApagar = false;
            }
            textBox1.Text = textBox1.Text + ",";
        }

        private void button12_Click(object sender, EventArgs e) //botao diminuir
        {
            if (total)
            {
                textBox1.Text = "";
                total = false;
            }
            else
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                }
                else
                {
                    num2 = Convert.ToDouble(textBox1.Text);
                    switch (operacao)
                    {
                        case '+':

                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 + num2;
                             
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }



                            break;
                        case '-':
                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 - num2;
                            
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }




                            break;
                        case '/':
                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 / num2;
                               
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }


                            break;
                        case '*':
                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 * num2;
                             
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }


                            break;

                        default:
                            MessageBox.Show("ERROR 404");
                            break;

                    }

                  
                    
                }
            }
            
            operacao = '-';
            textBox1.Text = Convert.ToString(num1);
            podeApagar = true;
           
        }

        private void button13_Click(object sender, EventArgs e) //bt dividir
        {
            if (total )
            {
                textBox1.Text = "";
                total = false;
            }
            else
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                }
                else
                {
                    switch (operacao)
                    {
                        case '+':

                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 + num2;
                               
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }



                            break;
                        case '-':
                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 - num2;
                               
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }




                            break;
                        case '/':
                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 / num2;
                               
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }


                            break;
                        case '*':
                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 * num2;
                                
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }


                            break;

                        default:
                            MessageBox.Show("ERROR 404");
                            break;

                    }
                   
                    
                  
                }
				

			}

			
			podeApagar = true;
			textBox1.Text = Convert.ToString(num1);
			operacao = '/';
		}

        private void button14_Click(object sender, EventArgs e) //bt multiplicar
        {
            if (total)
            {
                textBox1.Text = "";
                total= false;
            }
            else
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                }
                else
                {

                    switch (operacao)
                    {
                        case '+':

                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 + num2;
                                
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }



                            break;
                        case '-':
                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 - num2;
                                
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }




                            break;
                        case '/':
                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 / num2;
                                
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }


                            break;
                        case '*':
                            if (num1 != 0)
                            {
                                num2 = Convert.ToDouble(textBox1.Text);
                                num1 = num1 * num2;
                               
                                textBox1.Text = Convert.ToString(num1);
                                total = true;
                            }


                            break;

                        default:
                            MessageBox.Show("ERROR 404");
                            break;

                    }
                    
                 
                }
            }
            textBox1.Text = Convert.ToString(num1);
            podeApagar = true;
            operacao = '*';

            
        }

        private void btn_memoria2_Click(object sender, EventArgs e)//A partir daqui, consta as consfigurações da memórias
        {
            if (memoria2 == 0)
            {
                if (textBox1.Text != "")
                {
                    memoria2 = Convert.ToDouble(textBox1.Text);
                    btn_memoria2.Text = "USAR MEMÓRIA";
                }
                else
                {
                    MessageBox.Show("Você precisa inserir um valor!");
                }
            }
            else
            {
                textBox1.Text = Convert.ToString(memoria2);
            }

        }

        private void btn_memoria3_Click(object sender, EventArgs e)
        {
            if (memoria3 == 0)
            {
                if (textBox1.Text != "")
                {
                    memoria3 = Convert.ToDouble(textBox1.Text);
                    btn_memoria3.Text = "USAR MEMÓRIA";
                }
                else
                {
                    MessageBox.Show("Você precisa inserir um valor!");
                }
            }
            else
            {
                textBox1.Text = Convert.ToString(memoria3);
            }

        }

        private void btn_memoria4_Click(object sender, EventArgs e)
        {
            if (memoria4 == 0)
            {
                if (textBox1.Text != "")
                {
                    memoria4 = Convert.ToDouble(textBox1.Text);
                    btn_memoria4.Text = "USAR MEMÓRIA";
                }
                else
                {
                    MessageBox.Show("Você precisa inserir um valor!");
                }
            }
            else
            {
                textBox1.Text = Convert.ToString(memoria4);
            }

        }

        private void button15_Click(object sender, EventArgs e)//botão limpar
        {
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e) //bt igual
        {


            switch (operacao)
            {
                case '+':

                    if (num1 != 0)
                    {
                        num2 = Convert.ToDouble(textBox1.Text);
                        num1 = num1 + num2;
                        
                        textBox1.Text = Convert.ToString(num1);
                        total = true;
                    }
                       
                    
                    
                    break;
                case '-':
                    if (num1 != 0)
                    {
                        num2 = Convert.ToDouble(textBox1.Text);
                        num1 = num1 - num2;
                  
                        textBox1.Text = Convert.ToString(num1);
                        total = true;
                    }
                    
                       
                    

                    break;
                case '/':
                    if (num1 != 0)
                    {
                        num2 = Convert.ToDouble(textBox1.Text);
                        num1 = num1 / num2;
                     
                        textBox1.Text = Convert.ToString(num1);
                        total = true;
                    }
                   

                    break;
                case '*':
                    if (num1 != 0)
                    {
                        num2 = Convert.ToDouble(textBox1.Text);
                        num1 = num1 * num2;
                    
                        textBox1.Text = Convert.ToString(num1);
                        total = true;
                    }
                   

                    break;

                default:
                    MessageBox.Show("ERROR 404");
                    break;
            }
            textBox1.Text = Convert.ToString(num1);
            podeApagar = true;
        }

        

        private void btn_Memoria1_Click(object sender, EventArgs e)
        {


            if (memoria1 == 0)
            {
                if (textBox1.Text != "")
                {
                    memoria1 = Convert.ToDouble(textBox1.Text);
                    btn_Memoria1.Text = "USAR MEMÓRIA";
                }
                else
                {
                    MessageBox.Show("Você precisa inserir um valor!");
                }
            }
            else
            {
                textBox1.Text = Convert.ToString(memoria1);
            }
            




        }

        private void btn_Somar_Click(object sender, EventArgs e)//bt somar
        {
            if (total)
            {
                textBox1.Text = "";
                total = false;
            }
            else
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                }
                else
                {
                    num2 = Convert.ToDouble(textBox1.Text);
                   
                    
                        switch (operacao)
                        {
                            case '+':

                               
                                   
                                    num1 = num1 + num2;
                                    
                                    textBox1.Text = Convert.ToString(num1);
                                    total = true;
                                



                                break;
                            case '-':
                                if (num1 != 0)
                                {
                                   
                                    num1 = num1 - num2;
                                   
                                    textBox1.Text = Convert.ToString(num1);
                                    total = true;
                                }




                                break;
                            case '/':
                                if (num1 != 0)
                                {
                                    
                                    num1 = num1 / num2;
                                  
                                    textBox1.Text = Convert.ToString(num1);
                                    total = true;
                                }


                                break;
                            case '*':
                                if (num1 != 0)
                                {
                                    
                                    num1 = num1 * num2;
                                    
                                    textBox1.Text = Convert.ToString(num1);
                                    total = true;
                                }


                                break;

                            default:
                                MessageBox.Show("ERROR 404");
                                break;
                        
                    }
                   
                   


                }

            }

            textBox1.Text = Convert.ToString(num1);
            podeApagar = true;
            operacao = '+';
         
           
        }
    }
}

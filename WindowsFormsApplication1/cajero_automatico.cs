using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class cajero_automatico : Form
    {
        public cajero_automatico()
        {
            InitializeComponent();
    

        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 0.5, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(txtcantidad.Text) ;
            double efectivo = double.Parse(txtcantidad2.Text);
            sbyte n = 0;
            double n2=0;
            string respuesta = "respuesta: \n"; 
            foreach (double denominacion in denominaciones)
            
            {
              
                n2 = efectivo - cantidad;
            while (denominacion<= Math.Round(cantidad ,2))
                {
                    n++;
                    cantidad -= denominacion;
                }
            if (n > 0) {
                    respuesta += " vuelto "+n2 +"\n"+n + (denominacion > 1 ? " billetes  " : " monedas ") + n2  + "\n";
                        }
                n = 0;
                
            }
            lblrespuesta.Text = respuesta;
        }

        private void btnprimo_Click(object sender, EventArgs e)
        {
       int numero, i, cont ;
            string respuesta = "El numero  : \n";
            cont = 0;
            numero = int.Parse(txtNum.Text);
            for (i = 1; i <= numero; i++) 
            {
                if (numero % i == 0)
                { cont = cont + 1; }
            }

            if (cont > 2) 

                {  respuesta +=  numero +(" no primo"); }

                    else
            {  respuesta += numero + (" es primo") ;   }

            lblres.Text = respuesta;
           }

        private void btnfibo_Click(object sender, EventArgs e)
        {
            // int (txtNum.Text);
            //  sbyte num2 = 1;
            //  lblres.Text = "respuesta:\n" + (num1 - num2);
            //   int sult = 0;
            // sult = num1 - num2;
            //   lblres.Text = " Respuesta: \n" + sult ;
            /*
            int cantidad = 25;
            int[] fibo = new int[2];
            string respuesta = " \n";
            fibo[0] = 0;
            fibo[1] = 1;
            int num = 0;
            while (num <= cantidad)
            {
                respuesta += fibo[0];
                int temp = fibo[1] + fibo[0];
                fibo[0] = fibo[1];
                fibo[1] = temp;
                num++;
                lblres.Text += respuesta;*/

            int n = int.Parse(txtNum.Text), x = 0, y = 1, xy, i;
            string respuesta = "";
            for (i = 0; i < n; i++)
            {
                xy = x;
                x = y;
                y = xy + x;
                respuesta +=  " es " + x + " la suma  " + y +"\n" ;
                lblres.Text = respuesta;
            }

        }
    }
     }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = original.Text;
            int indice = 0;
            int estado = 0;
            int estadoFinal = -1;
            string lexema = "";
            string token;
           
            tabla.Columns.Add("ID", "ID");
            tabla.Columns.Add("Lexema", "Lexema");
            tabla.Columns.Add("Token", "Token");

            while ((indice <= (frase.Length - 1)) && (estadoFinal == -1))
            {
                lexema = " ";
                token = "error";
                while ((indice <= (frase.Length - 1)) && (estadoFinal != 25))
                {
                    if (estadoFinal == -1)
                    {
                        if (char.IsWhiteSpace(frase[indice]))
                        {
                            estadoFinal = -1;
                        }
                        else if (char.IsLetter(frase[indice]) || frase[indice] == '_')
                        {
                            estado = 0;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "identificador";
                        }
                        else if (char.IsDigit(frase[indice]))
                        {
                            estado = 1;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "entero";
                        }
                        else
                        {
                            estadoFinal = 25;
                            lexema = frase[indice].ToString();
                            token = "error";
                        }
                        indice++;
                    }
                    else if (estadoFinal == -1)
                    {
                        estadoFinal = 25; 
                    }
                    else if (estadoFinal == 0)
                    {
                        if (char.IsLetter(frase[indice]) || frase[indice] == '_')
                        {
                            estado = 0;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "identificador";
                            indice++;
                        }
                        else if (char.IsDigit(frase[indice]))
                        {
                            estado = 0;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "identificador";
                            indice++;
                        }
                        else
                        {
                            estadoFinal = 25;
                        }
                    }
                    else if (estadoFinal == 1)
                    {
                        if (char.IsDigit(frase[indice]))
                        {
                            estado = 1;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "entero";
                            indice++;
                        }
                        else if (frase[indice] == '.')
                        {
                            estado = 24;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "punto";
                            indice++;
                        }
                        else
                        {
                            estadoFinal = 25;
                        }
                    }
                    else if (estadoFinal == 24)
                    {
                        if (char.IsDigit(frase[indice]))
                        {
                            estado = 1;
                            estadoFinal = estado;
                            lexema += frase[indice];
                            token = "Numero real";
                            indice++;
                        }
                        else
                        {
                            estadoFinal = 25;
                        }
                    }

                }
                tabla.Rows.Add(estado, lexema, token);
                estadoFinal = -1;
            }
        }
    }
}
















/* Pruebas:

int main(){

int isla = 0;

if (a==b){
  cout<<"Hola, Mundo$"<<endl;
}else{
  cout<<"Adios, Mundo$"<<endl;
}

while( (a==b) && (c==d) ){
  cout<<"Ciclo"<<endl;
  a = b+c;
  a = b-c;
  a = b*c;
  a = b/c;
}

}
return 0;
}*/

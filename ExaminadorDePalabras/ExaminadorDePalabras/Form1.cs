using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminadorDePalabras {
    public partial class Form1 : Form {
        string filePath;
        public Form1() {
            InitializeComponent();
            txtRuta.Enabled = false;
            txtContenidoTexto.Enabled = false;
        }



        private void button1_Click(object sender, EventArgs e) {
            OpenFile1.DefaultExt = "txt";
            OpenFile1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";


            if (OpenFile1.ShowDialog() == DialogResult.OK) {
                txtContenidoTexto.Clear();
                filePath = OpenFile1.FileName;
                Console.WriteLine(filePath);
                txtRuta.Text = filePath;

                String content = "";
                //cargar el texto y contar lineas
                int lineasDeTexto = 0;
                try {
                    using (StreamReader lector = new StreamReader(filePath)) {

                        while (lector.Peek() > -1) {
                            string linea = lector.ReadLine();
                            if (!String.IsNullOrEmpty(linea)) {

                                content = txtContenidoTexto.Text + linea + "\n";
                                txtContenidoTexto.Text = txtContenidoTexto.Text + linea + "\r\n";
                                lineasDeTexto++;
                            }
                        }
                    }
                } catch (Exception ex) {
                    Console.WriteLine("Error: " + ex.Message);
                }

                lblLineas.Text = lineasDeTexto.ToString();

                //Contar tabulaciones y espacios
                int tab = 0;
                int espacios = 0;
                for (int i = 0; i < content.Length; i++) {
                    if (content[i].Equals('\t')) {
                        tab++;

                    } else if (content[i].Equals(' ')) {
                        espacios++;

                    }
                }
                lblTabs.Text = tab.ToString();
                lblEspBlancos.Text = espacios.ToString();
                //Contar caracteres
                string textoSinEspacios = content.Replace(" ", "");
                int x = 0;


                int caracteres = 0;
                for (int i = 0; i < content.Length; i++) {

                    caracteres++;
                    Console.WriteLine("caracter contado: " + content[i]);
                    Console.WriteLine("codigo ASCII: " + (int)content[i]);
                }
                lblCaracteres.Text = caracteres.ToString();

                //contar vocales y consonantes

                int vocales = 0;
                string textoSinEspaciosMinuscula = textoSinEspacios.ToLower();
                int consonante = 0;
                for (int i = 0; i < textoSinEspaciosMinuscula.Length; i++) {
                    if (textoSinEspaciosMinuscula[i].Equals('a') | textoSinEspaciosMinuscula[i].Equals('e') | textoSinEspaciosMinuscula[i].Equals('i') |
                        textoSinEspaciosMinuscula[i].Equals('o') | textoSinEspaciosMinuscula[i].Equals('u')) {
                        vocales++;
                        Console.WriteLine("vocal contada: " + textoSinEspaciosMinuscula[i]);

                    } else if (!(int.TryParse(textoSinEspaciosMinuscula[i].ToString(), out x)) & ((int)textoSinEspaciosMinuscula[i]) > 31) {
                        consonante++;
                        Console.WriteLine("consonante contada: " + textoSinEspaciosMinuscula[i]);
                    }
                }



                lblVocales.Text = vocales.ToString();
                lblConsonantes.Text = consonante.ToString();


                string[] palabras = content.Split(' ');
                lblPalabras.Text = palabras.Length.ToString();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            saveFile1.DefaultExt = "txt";
            saveFile1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            //escribir texto de "txtContenido" a archivo
            if (saveFile1.ShowDialog() == DialogResult.OK) {
                System.IO.File.WriteAllText(saveFile1.FileName, txtContenidoTexto.Text);
            }



        }

        private void btnProcesar_Click(object sender, EventArgs e) {

            string textoFinal = txtContenidoTexto.Text;

            string textoSinEspacios = txtContenidoTexto.Text.Replace(" ", "");
            string textoSinTabNiEspacios = textoSinEspacios.Replace("\t", "");

            int itemCmb = cmbQuitar.SelectedIndex;



            switch (cmbQuitar.SelectedIndex) {
                case 0:
                    //Espacios en blanco
                    txtContenidoTexto.Text = textoSinTabNiEspacios;
                    textoFinal = textoSinTabNiEspacios;

                    break;
                case 1:
                    //vocales
                    string textoSinVocales = "";
                    for (int i = 0; i < textoFinal.Length; i++) {
                        if (!(textoFinal[i].Equals('a') |
                            textoFinal[i].Equals('e') |
                            textoFinal[i].Equals('i') |
                            textoFinal[i].Equals('o') |
                            textoFinal[i].Equals('u'))) {
                            textoSinVocales += textoFinal[i].ToString();
                        }
                    }
                    Console.WriteLine(textoSinVocales);
                    textoFinal = textoSinVocales;
                    txtContenidoTexto.Text = textoFinal;
                    break;
                case 2:
                    //consonantes
                    int x = 0;
                    string textoSinConsonantes = "";
                    for (int i = 0; i < textoFinal.Length; i++) {
                        if (textoFinal[i].Equals('a') |
                            textoFinal[i].Equals('e') |
                            textoFinal[i].Equals('i') |
                            textoFinal[i].Equals('o') |
                            textoFinal[i].Equals('u')) {


                            textoSinConsonantes += textoFinal[i].ToString();



                        }
                    }
                    Console.WriteLine(textoSinConsonantes);
                    textoFinal = textoSinConsonantes;
                    txtContenidoTexto.Text = textoFinal;


                    break;
                default:
                    Console.WriteLine("no admitido");
                    break;
            }


        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}

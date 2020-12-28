using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoProvaFortes
{
    public partial class btnJson : Form
    {
        DBProvaFortesEntities db = new DBProvaFortesEntities();
        public int itensPersistindos = 0;

        public btnJson()
        {
            InitializeComponent();
        }

        public void LerTxt()
        {
            string path = "NFSe.txt";
            
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        
                        string[] fields = sr.ReadLine().Split('|');
                        string code = fields[0];

                        
                        if (fields[0] == "P")
                        {
                            tbPrestador prestador = new tbPrestador(
                                fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8], fields[9]);



                            db.tbPrestador.Add(prestador);


                            db.SaveChanges();

                            itensPersistindos++;

                        }

                        if (fields[0] == "T")
                        {
                            tbTomador tomador = new tbTomador(fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8]);

                            db.tbTomador.Add(tomador);
                            db.SaveChanges();
                            itensPersistindos++;


                        }
                        if (fields[0] == "R")
                        {
                            tbNota nota = new tbNota(fields[1], fields[2],fields[3]);
                            db.tbNota.Add(nota);
                            db.SaveChanges();
                            itensPersistindos++;

                        }

                        if (fields[0] == "K")
                        {
                            tbItem itens = new tbItem(fields[1], fields[2], fields[3], fields[4], fields[5]);
                            db.tbItem.Add(itens);
                            db.SaveChanges();
                            itensPersistindos++;



                        }
                        
                    }
                }
                MessageBox.Show("Total de Itens Persistidos :" + itensPersistindos);
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                MessageBox.Show(e.Message);
            }
        }


        public void CriarJson()
        {
            string pathJson = "JSON.txt";
            using (var repo = new DBProvaFortesEntities())
            {
                IList<tbPrestador> prestador = repo.tbPrestador.ToList();
                IList<tbTomador> tomador = repo.tbTomador.ToList();
                IList<tbNota> nota = repo.tbNota.ToList();
                IList<tbItem> item = repo.tbItem.ToList();

                foreach (var p in prestador)
                {
                    string x = "";
                    x = "Prestador   {" + Environment.NewLine 

                        + "\"CNPJ\" : \"" + p.CNPJ + "\"," + Environment.NewLine 
                        + "\"Nome\" : \"" + p.NOME + "\"," + Environment.NewLine 
                        + "\"RazaoSocial\" : \"" + p.RAZAOSOCIAL + "\"," + Environment.NewLine 
                        + "\"Rua\" : \"" + p.RUA + "\"," + Environment.NewLine 
                        + "\"Numero\" : \"" + p.NUMERO + "\"," + Environment.NewLine
                        + "\"Bairro\" : \"" + p.BAIRRO + "\"," + Environment.NewLine
                        + "\"UF\": \"" + p.UF + "\"," + Environment.NewLine
                        + "\"CEP\" : \"" + p.CEP + "\"," + Environment.NewLine
                        + "\"Telefone\" : \"" + p.TELEFONE + "\"," + Environment.NewLine + "}";

                    using (StreamWriter sw = File.AppendText(pathJson))
                    {
                        sw.WriteLine(x);
                    }
                   

                }

                foreach (var t in tomador)
                {
                    string x = "";
                    x = "Tomador   {" + Environment.NewLine
                        + "\"CNPJ\" : \"" + t.CNPJ+ "\"," + Environment.NewLine
                        + "\"Nome\" : \"" + t.NOME + "\"," + Environment.NewLine
                        + "\"Rua\" : \"" + t.RUA + "\"," + Environment.NewLine
                        + "\"Numero\" : \"" + t.NUMERO + "\"," + Environment.NewLine
                        + "\"Bairro\" : \"" + t.BAIRRO + "\"," + Environment.NewLine
                        + "\"UF\": \"" + t.UF + "\"," + Environment.NewLine
                        + "\"Telefone\" : \"" + t.TELEFONE + "\"," + Environment.NewLine 
                        +"\"Email\" : \"" + t.EMAIL + "\"," + Environment.NewLine + "}";
                    using (StreamWriter sw = File.AppendText(pathJson))
                    {
                        sw.WriteLine(x);
                    }


                }

                foreach (var n in nota)
                {
                    string x = "";
                    x = "Nota   {" + Environment.NewLine
                        + "\"Numero\" : \"" + n.NUMERO + "\"," + Environment.NewLine
                        + "\"Data\" : \"" + n.DATA + "\"," + Environment.NewLine
                         + "\"Valor\" : \"" + n.VALOR + "\"," + Environment.NewLine + "}";

                    using (StreamWriter sw = File.AppendText(pathJson))
                    {
                        sw.WriteLine(x);
                    }



                }

                foreach (var i in item)
                {
                    string x = "";
                    x = "Item   {" + Environment.NewLine
                         + "\"Matricula\" : \"" + i.MATRICULA + "\"," + Environment.NewLine
                        + "\"Numero\" : \"" + i.NUMERO + "\"," + Environment.NewLine
                        + "\"Nome\" : \"" + i.NOME + "\"," + Environment.NewLine
                        + "\"Quantidade\" : \"" + i.QUANTIDADE + "\"," + Environment.NewLine
                        + "\"Valor\" : \"" + i.VALOR + "\"," + Environment.NewLine + "}";
                    ;

                    using (StreamWriter sw = File.AppendText(pathJson))
                    {
                        sw.WriteLine(x);
                    }

                }
            }

        }
        public void CriarXML()
        {
            string pathJson = "XML.txt";
            using (var repo = new DBProvaFortesEntities())
            {
                IList<tbPrestador> prestador = repo.tbPrestador.ToList();
                IList<tbTomador> tomador = repo.tbTomador.ToList();
                IList<tbNota> nota = repo.tbNota.ToList();
                IList<tbItem> item = repo.tbItem.ToList();

                foreach (var p in prestador)
                {
                    string x = "";
                    x = " CNPJ : " + p.CNPJ
                        + " Nome : " + p.NOME
                        + " RazaoSocial : " + p.RAZAOSOCIAL
                        + " Rua : " + p.RUA
                        + " Numero : " + p.NUMERO
                        + " Bairro : " + p.BAIRRO
                        + " UF : " + p.UF
                        + " CEP : " + p.CEP
                        + " Telefone : " + p.TELEFONE;

                    using (StreamWriter sw = File.AppendText(pathJson))
                    {
                        sw.WriteLine(x);
                    }


                }

                foreach (var t in tomador)
                {
                    string x = "";
                    x = " CNPJ : " + t.CNPJ
                        + " Nome : " + t.NOME
                        + " Rua : " + t.RUA
                        + " Numero : " + t.NUMERO
                        + " Bairro : " + t.BAIRRO
                        + " UF : " + t.UF
                        + " Telefone : " + t.TELEFONE
                        + " Email : " + t.EMAIL;
                    using (StreamWriter sw = File.AppendText(pathJson))
                    {
                        sw.WriteLine(x);
                    }


                }

                foreach (var n in nota)
                {
                    string x = "";
                    x = " Numero : " + n.NUMERO
                        + " Data : " + n.DATA
                        + " Valor : " + n.VALOR;

                    using (StreamWriter sw = File.AppendText(pathJson))
                    {
                        sw.WriteLine(x);
                    }



                }

                foreach (var i in item)
                {
                    string x = "";
                    x = " Matricula : " + i.MATRICULA
                        + " Numero : " + i.NUMERO
                        + " Nome : " + i.NOME
                        + " Quantidade : " + i.QUANTIDADE
                        + " Valor : " + i.VALOR
                        ;

                    using (StreamWriter sw = File.AppendText(pathJson))
                    {
                        sw.WriteLine(x);
                    }

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LerTxt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CriarJson();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            CriarXML();
        }
    }
}

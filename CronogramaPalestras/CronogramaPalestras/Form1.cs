using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CronogramaPalestras
{
    public partial class FormCronograma : Form
    {
        private readonly string arq = $@"{Environment.CurrentDirectory}/Palestras.txt";

        List<Palestra> listaPalestras = new List<Palestra>();

        public FormCronograma()
        {
            InitializeComponent();
        }

        private void FormCronograma_Load(object sender, EventArgs e)
        {
            File.ReadAllLines(arq).ToList().ForEach(x => 
                    listaPalestras.Add(
                        new Palestra(x.Split(';')[0], Convert.ToInt16(x.Split(';')[1]))
            ));

            RealizarCronograma.Cronograma(listaPalestras.OrderByDescending(x => x.Duracao).ToList());
        }
    }
}

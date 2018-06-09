using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColombOS
{
    public partial class PhotoViewer : Form
    {
        public PhotoViewer()
        {
            InitializeComponent();
        }

        private void PhotoViewer_Load(object sender, EventArgs e)
        {
            finestraImmagine.Image = new Bitmap(Cartella.programmaCompleto);
            ControlExtension.Draggable(panelImmagini, true);
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nsga2win {
    public partial class AcercaDe : Form {
        public AcercaDe() {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

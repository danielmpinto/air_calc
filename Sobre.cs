﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APH_e_PV
{
    public partial class Sobre : Toolbox
    {
        public Sobre()
        {
            InitializeComponent();
            //Cancela o fechamento da janela e só "esconde"
            FormClosing += new FormClosingEventHandler(CancelaX);
        }
    }
}

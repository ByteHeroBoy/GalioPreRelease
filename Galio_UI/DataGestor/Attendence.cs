using BLL;
using ETL.DataGen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galio_UI.DataGestor
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void Start()
        {
            //mala practica
            ListGroup("7-1");
        }

        private void ListGroup(string Group)
        {
            Logic logic = new Logic();
            List<Estudiante> est = logic.ListGroup(Group);
        }
    }
}

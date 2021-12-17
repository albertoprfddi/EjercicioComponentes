using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjercicioComponentes.ControlesPropios
{
    /// <summary>
    /// Lógica de interacción para InfoAlumno.xaml
    /// </summary>
    public partial class InfoAlumno : UserControl
    {
        public int CodigoAlumno { get; set; }
        public int CodigoAsignatura { get; set; }
        public InfoAlumno()
        {
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SomaDeDoisApp
{
    public partial class MainPage : ContentPage
    {
        void Somar(Object sender, EventArgs e){
            int resultado = Int32.Parse(N1.Text) + Int32.Parse(N2.Text);
            Result.Text = resultado.ToString();
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}

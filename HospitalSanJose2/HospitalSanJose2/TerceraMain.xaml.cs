using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HospitalSanJose2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TerceraMain : ContentPage
    {
        public TerceraMain()
        {
            InitializeComponent();
            Inicializar();
        }
        private void Inicializar()
        {
            irAOtraPagina.Clicked += OnButtonIrAOtraPagina;
            pickerSexo.SelectedIndexChanged += pickerSexo_SelectedIndexChanged;
            pickerEspecialidad.SelectedIndexChanged += pickerEspecialidad_SelectedIndexChanged;

        }
        private void pickerSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pickerEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void OnButtonIrAOtraPagina(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CuartaMain4());
        }

    }
}
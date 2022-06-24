using Xamarin.Forms;

namespace DataBinding
{
    public partial class MainPage : ContentPage
    {
        public Empleado NuevoEmpleado { get; set; }
        public MainPage()
        {
            NuevoEmpleado = new Empleado();
            NuevoEmpleado.NombreCompleto = "Vivian Munguía";
            NuevoEmpleado.Email = "vivian.munguia.mtz@gmail.com";
            BindingContext = NuevoEmpleado;
            InitializeComponent();
        }
    }
}

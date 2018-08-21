using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App06_Cell.Modelo;

namespace App06_Cell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewButtonPage : ContentPage
	{
		public ListViewButtonPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Professor" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Lutadora" });
            Lista.Add(new Funcionario() { Nome = "Ana", Cargo = "Analista" });
            Lista.Add(new Funcionario() { Nome = "Luana", Cargo = "Estudante" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void FeriasAction(object sender, EventArgs args)
        {
            Button btnFerias = (Button)sender;
            Funcionario func = (Funcionario)btnFerias.CommandParameter;

            DisplayAlert("Férias", "Funcionario: " + func.Nome, "OK");
        }
	}
}
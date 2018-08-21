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
	public partial class ViewCellPage : ContentPage
	{
		public ViewCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Professor" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Lutadora" });
            Lista.Add(new Funcionario() { Nome = "Ana", Cargo = "Analista" });
            Lista.Add(new Funcionario() { Nome = "Luana", Cargo = "Estudante" });

            ListaFuncionario.ItemsSource = Lista;
        }
	}
}
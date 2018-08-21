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
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Professor" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Lutadora" });
            Lista.Add(new Funcionario() { Nome = "Ana", Cargo = "Analista" });
            Lista.Add(new Funcionario() { Nome = "Luana", Cargo = "Estudante" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args)
        {
            Funcionario func = (Funcionario)args.SelectedItem;

            Navigation.PushAsync(new Detalhe.DetailPage(func));
        }

        private void FeriasAction(object sender, EventArgs args)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert("Título: " + func.Nome, "Mensagem: " + func.Nome + " - " + func.Cargo, "OK");
        }

        private void AbonoAction(object sender, EventArgs args)
        {

        }

    }
}
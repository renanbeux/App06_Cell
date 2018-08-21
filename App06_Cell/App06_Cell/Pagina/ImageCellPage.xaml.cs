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
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "1.jpg", Nome = "José", Cargo = "Professor" });
            Lista.Add(new Funcionario() { Foto = "2.png", Nome = "Maria", Cargo = "Lutadora" });
            Lista.Add(new Funcionario() { Foto = "3.jpg", Nome = "Ana", Cargo = "Analista" });
            Lista.Add(new Funcionario() { Foto = "4.png", Nome = "Marcos", Cargo = "Estudante" });

            ListaFuncionario.ItemsSource = Lista;
        }
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMvvm.ViewModels
{
     public partial class SumaMvvm : ObservableObject
    {
        [ObservableProperty]
        public double valor1;

        [ObservableProperty]
        public double valor2;

        [ObservableProperty]
        public double resultado;


        [RelayCommand]
        public void Sumar() 
        {
            Resultado = Valor1 + Valor2;         
        }
    }
}

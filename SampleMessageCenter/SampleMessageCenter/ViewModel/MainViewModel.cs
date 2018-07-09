using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleMessageCenter.ViewModel
{
    //para notificar los eventos a la vista
    public class MainViewModel: BindableObject 
    {
        private int _age;
        public int Age {
            get => _age;
            set
            {
                _age = value;

                OnPropertyChanged(); //metodo heredado de BindableObject
                if(_age > 90)
                {
                    MessagingCenter.Send(this, "LimitAge");
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using pocExample.ViewModel;
using Xamarin.Forms;

namespace pocExample.View
{
    public partial class PlanejamentoCambioDesgasteView : ContentPage
    {
        public PlanejamentoCambioDesgasteView()
        {
            InitializeComponent();

            this.BindingContext = new PlanejamentoCambioDesgasteViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((PlanejamentoCambioDesgasteViewModel)BindingContext).ThisOnAppearing();
        }

    }
}

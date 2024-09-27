using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class MoviePage : ContentPage
{
    public MoviePage()
    {
        InitializeComponent();
        Title = "Movie Input";
    }
    
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        App.dateCalc.MovieCost = txtMovie.Text;
    }
}
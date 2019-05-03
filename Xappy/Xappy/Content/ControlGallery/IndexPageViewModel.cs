﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using Xappy.Content;

namespace Xappy.ControlGallery
{
    public class IndexPageViewModel : BaseViewModel
    {
        public ControlType SelectedControl { get; set; }

        public ICommand SelectCommand { get; set; }

        public List<ControlType> Layouts { get; set; }

        public IndexPageViewModel()
        {
            Layouts = new List<ControlType>
            {
                new ControlType{ Title = "StackLayout"},
                new ControlType{ Title = "Grid"},
                new ControlType{ Title = "FlexLayout"},
                new ControlType{ Title = "AbsoluteLayout"},
                new ControlType{ Title = "RelativeLayout"},
                new ControlType{ Title = "ContentPresenter"},
                new ControlType{ Title = "ContentView"},
                new ControlType{ Title = "ScrollView"},
                new ControlType{ Title = "TemplatedView"}
            };


            SelectCommand = new Command(ControlSelected);
        }

        private async void ControlSelected()
        {
            // navigate to the control page
            if (SelectedControl == null)
                return;

            await Shell.Current.GoToAsync($"control?control={SelectedControl.Title}");

            SelectedControl = null;
        }
    }

    public class ControlType
    {
        public string Title { get; set; }
    }
}
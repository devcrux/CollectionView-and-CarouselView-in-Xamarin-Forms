using BurgerSpot.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BurgerSpot.ViewModel
{
    public class DetailsViewModel : BaseViewModel
    {
        ObservableCollection<Burger> burgers;
        public ObservableCollection<Burger> Burgers
        {
            get { return burgers; }
            set
            {
                burgers = value;
                OnPropertyChanged();
            }
        }

        private Burger selectedBurger;
        public Burger SelectedBurger
        {
            get { return selectedBurger; }
            set
            {
                selectedBurger = value;
                OnPropertyChanged();
            }
        }

        private int position;
        public int Position
        {
            get
            {
                if (position != burgers.IndexOf(selectedBurger))
                    return burgers.IndexOf(selectedBurger);

                return position;
            }
            set
            {
                position = value;
                selectedBurger = burgers[position];

                OnPropertyChanged();
                OnPropertyChanged(nameof(SelectedBurger));
            }
        }

        public ICommand ChangePositionCommand => new Command(ChangePosition);

        private void ChangePosition(object obj)
        {
            string direction = (string)obj;

            if (direction == "L")
            {
                if (position == 0)
                {
                    Position = burgers.Count - 1;
                    return;
                }

                Position -= 1;
            }
            else if (direction == "R")
            {
                if (position == burgers.Count - 1)
                {
                    Position = 0;
                    return;
                }

                Position += 1;
            }

        }

    }
}

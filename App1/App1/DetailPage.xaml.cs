using App1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string name, string weight, List<AbilitySlot> abilities, Uri frontUrl, Uri backUrl)
        {
            InitializeComponent();
            this.Name = name;
            this.Weight = weight;
            this.Abilities = abilities;
            this.frontDefaultValue = frontUrl;
            this.BackDefault = backUrl;
            BindingContext = this;
        }

        private string NameValue;
        public string Name {
            get => NameValue;
            set {
                NameValue = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string WeightValue;
        public string Weight {
            get => WeightValue;
            set {
                WeightValue = value;
                OnPropertyChanged(nameof(Weight));
            }
        }

        private Uri frontDefaultValue;
        public Uri FrontDefault {
            get => frontDefaultValue;
            set {
                frontDefaultValue = value;
                OnPropertyChanged(nameof(FrontDefault));
            }
        }

        private Uri backDefaultValue;
        public Uri BackDefault {
            get => backDefaultValue;
            set {
                backDefaultValue = value;
                OnPropertyChanged(nameof(BackDefault));
            }
        }

        private List<AbilitySlot> AbilitiesValue;
        public List<AbilitySlot> Abilities {
            get => AbilitiesValue;
            set {
                AbilitiesValue = value;
                OnPropertyChanged(nameof(Abilities));
            }
        }
    }
}
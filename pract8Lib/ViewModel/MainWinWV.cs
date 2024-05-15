using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvLib;
using MVVMLib;

namespace pract8Lib.ViewModel
{
    internal class MainWinWV : BindingHelp
    {
        Conv conv = new Conv();

        public BindingCliki  Ser_Click {  get; set; }
        public BindingCliki Desir_CLi { get; set; }

        private string tip;

        public string Tip
        {
            get { return tip; }
            set { tip = value; OnPropertyChanged(); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string napol;

        public string Napol
        {
            get { return napol; }
            set { napol = value; OnPropertyChanged(); }
        }

        public MainWinWV() 
        {
            Ser_Click = new BindingCliki(_ => Ser());
            Desir_CLi = new BindingCliki(_ => Desir());
        }

        public void Desir()
        {
            ChoToType choToType = conv.Jsonviser<ChoToType>("cho-to.json");
            Tip = choToType.tip.ToString();
            Napol = choToType.name.ToString();
            Name = choToType.napol.ToString();
        }

        public void Ser()
        {
            ChoToType choToType = new ChoToType(tip, napol, name);
            conv.Jsonser(choToType, "cho-to.json");
            Tip = "";
            Napol = "";
            Name = "";
        }
    }
}

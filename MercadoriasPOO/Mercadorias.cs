using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MercadoriasPOO
{
    public partial class Mercadorias : Component
    {
        public Mercadorias()
        {
            InitializeComponent();

             
        }

     

        public Mercadorias(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string nome;
        public double preco,total;
        public int qte;


        public void Atualiza_Preco(double porcentagem)
        {
            preco = preco + (preco * porcentagem / 100);
        }

        public void Soma_Valores()
        {
            total = preco * qte;
        }
    }
}

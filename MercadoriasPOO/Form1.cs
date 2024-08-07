using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoriasPOO
{
    public partial class Frm_mercadorias : Form
    {
        public Frm_mercadorias()
        {
            InitializeComponent();
        }

        Mercadorias produto1 = new Mercadorias();
        Mercadorias produto2 = new Mercadorias();
        Mercadorias produto3 = new Mercadorias();


        public void Btn_reajuste_Click(object sender, EventArgs e)
        {
            //Receber os nomes das produtos e os seus valores digitados armazenando nas variaveis da classe
            produto1.nome = Txt_Produto1.Text; // Atribuindo o campo digitado dentro da variavel
            produto1.preco = double.Parse(Txt_Valor1.Text);// atribuindo o valor convertendo de string para double

            produto2.nome = Txt_Produto2.Text;
            produto2.preco = double.Parse(Txt_Valor2.Text);

            produto3.nome = Txt_Produto3.Text;
            produto3.preco = double.Parse(Txt_Valor3.Text);


            Lbl_resultado.Text = "Produto 1 :" + produto1.nome + "\n" +
                "Preço inicial: " + produto1.preco.ToString("c2") + "\n";
            //produto1.Atualiza_Preco(10);
            Lbl_resultado.Text += "Novo preço: " + produto1.preco.ToString("c2") + "\n\n";
            produto1.total = produto1.Soma_Valores;

            Lbl_resultado.Text += "Produto 2 :" + produto2.nome + "\n" +
                "Preço inicial: " + produto2.preco.ToString("c2") + "\n";
            //produto2.Atualiza_Preco(10);
            Lbl_resultado.Text += "Novo preço: " + produto2.preco.ToString("c2") + "\n\n";

            Lbl_resultado.Text += "Produto 3:" + produto3.nome + "\n" +
                "Preço inicial: " + produto3.preco.ToString("c2") + "\n";
            //produto3.Atualiza_Preco(10);
            Lbl_resultado.Text += "Novo preço: " + produto3.preco.ToString("c2") + "\n\n";

        }

        
    }
}

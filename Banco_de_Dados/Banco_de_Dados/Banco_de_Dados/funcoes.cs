using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Banco_de_Dados
{
    public partial class funcoes : Form
    {
        public string[] todas_informacoes = new string[14];
        public funcoes()
        {
            InitializeComponent();
        }

        Funcionario funcionario = new Funcionario();

        private void AtualizarInformacoes()
        {
            todas_informacoes[0] = "Nome:" + funcionario.nome;
            todas_informacoes[1] = "Idade:" + funcionario.idade;
            todas_informacoes[2] = "Profissão:" + funcionario.profissao;
            todas_informacoes[3] = "Sexo:" + funcionario.sexo;
            todas_informacoes[4] = "CPF:" + funcionario.cpf;
            todas_informacoes[5] = "CEP:" + funcionario.cep;
            todas_informacoes[6] = "RG:" + funcionario.rg;
            todas_informacoes[7] = "Religião:" + funcionario.religiao;
            todas_informacoes[8] = "Estado Civil:" + funcionario.estado_civil;
            todas_informacoes[9] = "Telefone:" + funcionario.telefone;
            todas_informacoes[10] = "Celular:" + funcionario.celular;
            todas_informacoes[11] = "País:" + funcionario.pais;
            todas_informacoes[12] = "Número de filhos:" + funcionario.numero_filhos;
            todas_informacoes[13] = "Tipo sanguíneo:" + funcionario.tipo_sanguineo;
        }

        List<Funcionario> pessoas = new List<Funcionario>();

        private void adicionar(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario() { nome = nome.Text, idade = idade.Text, profissao = profissao.Text, endereco = endereco.Text,
            cep = cep.Text, cpf = cpf.Text,rg = rg.Text,religiao = religiao.Text,telefone = telefone.Text,celular = celular.Text,
            pais = pais.Text, numero_filhos = numero_filhos.Text, tipo_sanguineo = tipo_sanguineo.Text, id = funcionario.nome };

            pessoas.Add(f);

            funcionarios_lista.Items.Add(f.nome);
            
            nome.Text = "";
            idade.Text = "";
            profissao.Text = "";
            endereco.Text = "";
            cep.Text = "";
            cpf.Text = "";
            religiao.Text = "";
            telefone.Text = "";
            celular.Text = "";
            pais.Text = "";
            rg.Text = "";
            masculin.Checked = false;
            feminim.Checked = false;
            solter.Checked = false;
            casad.Checked = false;
            numero_filhos.Text = "";
            tipo_sanguineo.Text = "";

            

            /*informacoes.Text = funcionario.nome + "," + funcionario.rg + "," + funcionario.idade + "," + 
            funcionario.profissao + "," + funcionario.endereco + "," + funcionario.cep + "," + 
            funcionario.cpf + "," + funcionario.religiao + "," + funcionario.telefone + "," + 
            funcionario.celular + "," + funcionario.pais + "," + funcionario.sexo + "," + funcionario.estado_civil;*/
            AtualizarInformacoes();
            System.IO.File.WriteAllLines(@"C:\Users\Matheus\Desktop\Informações.txt", todas_informacoes);
        }

        private void Remover(object sender, EventArgs e)
        {
            /*funcionario.nome = "";
            funcionario.idade = "";
            funcionario.profissao = "";
            funcionario.endereco = "";
            funcionario.cep = "";
            funcionario.cpf = "";
            funcionario.religiao = "";
            funcionario.telefone = "";
            funcionario.celular = "";
            funcionario.pais = "";
            funcionario.rg = "";*/
            //informacoes.Text = "";
            funcionario.informacoes = "";
        }

        private void Masculino(object sender, EventArgs e)
        {
            funcionario.sexo = "masculino";
        }

        private void Feminino(object sender, EventArgs e)
        {
            funcionario.sexo = "feminino";
        }

        private void Solteiro(object sender, EventArgs e)
        {
            funcionario.estado_civil = "solteiro(a)";
        }

        private void Casado(object sender, EventArgs e)
        {
            funcionario.estado_civil = "casado(a)";
        }

        private void Impede(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Selecionar_funcionario(object sender, EventArgs e)
        {
            /*int index = funcionarios_lista.SelectedIndex;
            if (index >= 0)
            {
                Funcionario f = pegar_Index(index);

                Selecionar_funcionario(f);
            }
            nome.Text = f.nome;
            idade.Text = f.idade;
            profissao.Text = f.profissao;
            endereco.Text = f.endereco;
            cep.Text = f.cep;
            cpf.Text = f.cpf;
            religiao.Text = f.religiao;
            telefone.Text = f.telefone;
            celular.Text = f.celular;
            pais.Text = f.pais;
            rg.Text = f.rg;*/
        }
        //private Funcionario pegar_Index(int index)
        //{
            //return funcionarios.ElementAt(index);
        //}
    }
}

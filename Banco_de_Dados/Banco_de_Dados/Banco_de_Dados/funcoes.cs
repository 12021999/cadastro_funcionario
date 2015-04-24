using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Banco_de_Dados
{
    public partial class funcoes : Form
    {
        List<Funcionario> pessoas = new List<Funcionario>();
        public string[] todas_informacoes = new string[15];
        bool error = false;
        bool cadastrou = false;
        public funcoes()
        {
            InitializeComponent();
            carrega_do_txt();
            carrega_no_listbox();
        }

        void AtualizarInformacoes(Funcionario f)
        {
            todas_informacoes[0] = f.nome;
            todas_informacoes[1] = f.profissao;
            todas_informacoes[2] = f.idade;
            todas_informacoes[3] = f.sexo;
            todas_informacoes[4] = f.endereco;
            todas_informacoes[5] = f.cep;
            todas_informacoes[6] = f.cpf;
            todas_informacoes[7] = f.rg;
            todas_informacoes[8] = f.religiao;
            todas_informacoes[9] = f.estado_civil;
            todas_informacoes[10] = f.telefone;
            todas_informacoes[11] = f.celular;
            todas_informacoes[12] = f.pais;
            todas_informacoes[13] = f.numero_filhos;
            todas_informacoes[14] = f.tipo_sanguineo;
        }

        private void adicionar(object sender, EventArgs e)
        {
            if (!cadastrou)
            {
                nome.Text = Regex.Replace(Convert.ToString(nome.Text), "(?i)[^a-z À-ÿ]", "");
                profissao.Text = Regex.Replace(Convert.ToString(profissao.Text), "(?i)[^a-z À-ÿ]", "");
                religiao.Text = Regex.Replace(Convert.ToString(religiao.Text), "(?i)[^a-z À-ÿ]", "");
                idade.Text = Regex.Replace(Convert.ToString(idade.Text), "[^0-9]", "");
                telefone.Text = Regex.Replace(Convert.ToString(telefone.Text), "[^0-9]", "");
                celular.Text = Regex.Replace(Convert.ToString(celular.Text), "[^0-9]", "");
                pais.Text = Regex.Replace(Convert.ToString(pais.Text), "(?i)[^a-z À-ÿ]", "");
                cep.Text = Regex.Replace(Convert.ToString(cep.Text), "[^0-9]", "");
                cpf.Text = Regex.Replace(Convert.ToString(cpf.Text), "[^0-9]", "");
                rg.Text = Regex.Replace(Convert.ToString(rg.Text), "[^0-9]", "");

                Funcionario f = new Funcionario()
                {
                    nome = nome.Text,
                    idade = idade.Text,
                    profissao = profissao.Text,
                    endereco = endereco.Text,
                    cep = cep.Text,
                    cpf = cpf.Text,
                    rg = rg.Text,
                    religiao = religiao.Text,
                    telefone = telefone.Text,
                    celular = celular.Text,
                    pais = pais.Text,
                    numero_filhos = numero_filhos.Text,
                    tipo_sanguineo = tipo_sanguineo.Text,
                    sexo = getSexoFromForm(),
                    estado_civil = getEstadoCivilFromForm()
                   // id = f.nome
                };
                if (nome.Text == "" || profissao.Text == "" || idade.Text == "" || endereco.Text == "" || cep.Text == "" || pais.Text == ""
                    || cpf.Text == "" || rg.Text == "" || religiao.Text == "" || telefone.Text == "" || celular.Text == "")
                {
                    error = true;
                }
                else
                {
                    error = false;
                }
                if (nome.Text == "")
                {
                    nomeAster.Text = "*";
                }
                else
                {
                    nomeAster.Text = "";
                }
                if (profissao.Text == "")
                {
                    profissaoAster.Text = "*";
                }
                else
                {
                    profissaoAster.Text = "";
                }
                if (idade.Text == "")
                {
                    idadeAster.Text = "*";
                }
                else
                {
                    idadeAster.Text = "";
                }
                if (endereco.Text == "")
                {
                    enderecoAster.Text = "*";
                }
                else
                {
                    enderecoAster.Text = "";
                }
                if (cpf.Text == "")
                {
                    cpfAster.Text = "*";
                }
                else
                {
                    cpfAster.Text = "";
                }
                if (cep.Text == "")
                {
                    cepAster.Text = "*";
                }
                else
                {
                    cepAster.Text = "";
                }
                if (masculin.Checked == false && feminim.Checked == false)
                {
                    sexoAster.Text = "*";
                }
                else
                {
                    sexoAster.Text = "";
                }
                if (casad.Checked == false && solter.Checked == false)
                {
                    EstadoCivilAster.Text = "*";
                }
                else
                {
                    EstadoCivilAster.Text = "";
                }
                if (numero_filhos.Text == "")
                {
                    NumeroFilhosAster.Text = "*";
                }
                else
                {
                    NumeroFilhosAster.Text = "";
                }
                if (tipo_sanguineo.Text == "")
                {
                    TipoSanguineoAster.Text = "*";
                }
                else
                {
                    TipoSanguineoAster.Text = "";
                }
                if (religiao.Text == "")
                {
                    religiaoAster.Text = "*";
                }
                else
                {
                    religiaoAster.Text = "";
                }
                if (telefone.Text == "")
                {
                    telefoneAster.Text = "*";
                }
                else
                {
                    telefoneAster.Text = "";
                }
                if (celular.Text == "")
                {
                    celularAster.Text = "*";
                }
                else
                {
                    celularAster.Text = "";
                }
                if (pais.Text == "")
                {
                    paisAster.Text = "*";
                }
                else
                {
                    paisAster.Text = "";
                }
                if (rg.Text == "")
                {
                    rgAster.Text = "*";
                }
                else
                {
                    rgAster.Text = "";
                }
                if (!error)
                {
                    pessoas.Add(f);
                    funcionarios_lista.Items.Add(f.nome);
                    cadastrou = true;
                }
            }
            if (cadastrou)
            {
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
                cadastrou = false;
                MessageBox.Show("Você realizou seu cadastro com sucesso!");
            }
        }

        private void SalvaInformacoes(List<Funcionario> lista)
        {
            //foreach (string i in lista)
            //{

            //}
        }

        private string getSexoFromForm()
        {
            return (masculin.Checked) ? "masculino" : "feminino";
        }

        private string getEstadoCivilFromForm()
        {
            return (casad.Checked) ? "casado(a)" : "solteiro(a)";
        }

        private void Remover(object sender, EventArgs e)
        {
            int index_remover = funcionarios_lista.SelectedIndex;
            if (index_remover >= 0)
            {
                Funcionario func = pegar_Index(index_remover);
                funcionarios_lista.Items.RemoveAt(index_remover);
            }
        }

        private void Impede(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void carrega_do_txt()
        {
            if (!System.IO.File.Exists("./informacoes.txt"))
            {
                return;
            }
            string[] informacoes = System.IO.File.ReadAllLines("./informacoes.txt");

            foreach (string line in informacoes)
            {
                Funcionario func = new Funcionario();
                func.fromString(line);
                pessoas.Add(func);
                Console.WriteLine(func.nome);
            }

        }

        private void carrega_no_listbox()
        {
            funcionarios_lista.Items.Clear();
            foreach (Funcionario f in pessoas)
            {
                funcionarios_lista.Items.Add(f.nome);
            }
        }


        private void carrega_informacoes(Funcionario f)
        {
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
            rg.Text = f.rg;
            numero_filhos.Text = f.numero_filhos;
            tipo_sanguineo.Text = f.tipo_sanguineo;
            if (f.sexo == "masculino")
            {
                masculin.Checked = true;
            }
            else
            {
                feminim.Checked = true;
            }

            if (f.estado_civil == "casado(a)")
            {
                casad.Checked = true;
            }
            if (f.estado_civil == "solteiro(a)")
            {
                solter.Checked = true;
            }
        }        
        private void Selecionar_funcionario(object sender, EventArgs e)
        {
            int index = funcionarios_lista.SelectedIndex;
            if (index >= 0)
            {
                Funcionario func = pegar_Index(index);
                carrega_informacoes(func);
            }
        }
        private Funcionario pegar_Index(int index)
        {
            return pessoas.ElementAt(index);
        }

        private void ApagarTexto(object sender, EventArgs e)
        {
            nome.Text = "";
            profissao.Text = "";
            idade.Text = "";
            endereco.Text = "";
            cep.Text = "";
            cpf.Text = "";
            rg.Text = "";
            religiao.Text = "";
            telefone.Text = "";
            celular.Text = "";
            pais.Text = "";
            numero_filhos.Text = "";
            tipo_sanguineo.Text = "";
            masculin.Checked = false;
            feminim.Checked = false;
            casad.Checked = false;
            solter.Checked = false;
        }

        private void SairApp(object sender, EventArgs e)
        {
            AtualizarInformacoes(pessoas[0]);
            string informacoes = "";
            informacoes += todas_informacoes[0] + "#";
            informacoes += todas_informacoes[1] + "#";
            informacoes += todas_informacoes[2] + "#";
            informacoes += todas_informacoes[3] + "#";
            informacoes += todas_informacoes[4] + "#";
            informacoes += todas_informacoes[5] + "#";
            informacoes += todas_informacoes[6] + "#";
            informacoes += todas_informacoes[7] + "#";
            informacoes += todas_informacoes[8] + "#";
            informacoes += todas_informacoes[9] + "#";
            informacoes += todas_informacoes[10] + "#";
            informacoes += todas_informacoes[11] + "#";
            informacoes += todas_informacoes[12] + "#";
            informacoes += todas_informacoes[13] + "#";
            informacoes += todas_informacoes[14] + "#";
           // System.IO.File.WriteAllLines("./informacoes.txt", new string[] { informacoes });
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("./informacoes2.txt", true))
            {
                System.IO.File.WriteAllLines("./informacoes2.txt", new string[] { informacoes });
            }
            Application.Exit();
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                flowLayoutPanel1.BackColor = colorDialog1.Color;
                label1.BackColor = colorDialog1.Color;
                label2.BackColor = colorDialog1.Color;
                label3.BackColor = colorDialog1.Color;
                label4.BackColor = colorDialog1.Color;
                label5.BackColor = colorDialog1.Color;
                label6.BackColor = colorDialog1.Color;
                label7.BackColor = colorDialog1.Color;
                label8.BackColor = colorDialog1.Color;
                label9.BackColor = colorDialog1.Color;
                label10.BackColor = colorDialog1.Color;
                label11.BackColor = colorDialog1.Color;
                label12.BackColor = colorDialog1.Color;
                label13.BackColor = colorDialog1.Color;
                label14.BackColor = colorDialog1.Color;
                label15.BackColor = colorDialog1.Color;
                nomeAster.BackColor = colorDialog1.Color;
                profissaoAster.BackColor = colorDialog1.Color;
                idadeAster.BackColor = colorDialog1.Color;
                sexoAster.BackColor = colorDialog1.Color;
                enderecoAster.BackColor = colorDialog1.Color;
                cepAster.BackColor = colorDialog1.Color;
                cpfAster.BackColor = colorDialog1.Color;
                rgAster.BackColor = colorDialog1.Color;
                religiaoAster.BackColor = colorDialog1.Color;
                EstadoCivilAster.BackColor = colorDialog1.Color;
                telefoneAster.BackColor = colorDialog1.Color;
                celularAster.BackColor = colorDialog1.Color;
                paisAster.BackColor = colorDialog1.Color;
                NumeroFilhosAster.BackColor = colorDialog1.Color;
                TipoSanguineoAster.BackColor = colorDialog1.Color;
                panel1.BackColor = colorDialog1.Color;
                panel2.BackColor = colorDialog1.Color;
            }
        }
    }
}

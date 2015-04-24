using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Banco_de_Dados
{
    class Funcionario
    {
        public string nome;
        public string profissao;
        public string idade;
        public string endereco;
        public string cep;
        public string cpf;
        public string rg;
        public string religiao;
        public string telefone;
        public string celular;
        public string pais;
        public string informacoes;
        public string sexo;
        public string estado_civil;
        public string numero_filhos;
        public string tipo_sanguineo;
        public string id;

        public string toString()
        {
            // Antoanne#professor#32#Rua ubiraci
            return nome + "#" + profissao + "#" + idade + "#" + sexo + "#" + endereco + "#" + cep + "#" + cpf + "#" + rg + "#" + religiao + "#" + estado_civil + "#" + telefone + "#" + celular + "#" + pais + "#" + numero_filhos + "#" + tipo_sanguineo + "#";
        }

        public void fromString(string linha)
        {
            // Antoanne#professor#32#Rua Ubiraci
            // AhhhMarinho#músico#8#Na casa dele

            string[] info = linha.Split('#');
            nome = info[0];
            profissao = info[1];
            idade = info[2];
            sexo = info[3];
            endereco = info[4];
            cep = info[5];
            cpf = info[6];
            rg = info[7];
            religiao = info[8];
            estado_civil = info[9];
            telefone = info[10];
            celular = info[11];
            pais = info[12];
            numero_filhos = info[13];
            tipo_sanguineo = info[14];
        }
    }
}

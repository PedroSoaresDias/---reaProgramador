namespace winFormProgramador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cmdProcurar_Click(object sender, EventArgs e)
        {
            string name, linguagem, cargo;
            int timeExperience;

            name = txtName.Text;
            linguagem = txtLinguagemProgramacao.Text;
            timeExperience = Convert.ToInt16(txtTime.Text);
            cargo = txtCargoProgramacao.Text;

            switch (linguagem) 
            {
                case "C#":
                    txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem compilada. \n" +
                       " Com o " + linguagem + ", você pode fazer qualquer tipo de programação com ela. \n " +
                       " O " + linguagem + " é indicado tanto na parte de back-end e quanto front-end. \n" +
                       " Ele possui suporte a orientação a objetos. \n" +
                       " Ela pode ser usada para (desenvolvimento web, software, jogos, aplicativos e etc.).";
                    break;

                case "C++":
                          txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem compilada. \n" +
                         " Com o " + linguagem + ", você pode fazer qualquer tipo de programação com ela. \n " +
                         " O " + linguagem + " é indicado tanto na parte de back-end e quanto front-end. \n" +
                         " Possui suporte a orientação a objetos. \n" +
                         " Ela pode ser usada para (desenvolvimento web, software, jogos, aplicativos, sistemas operacionais e etc.).";
                    break;

                case "Java":
                    txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem compilada. \n" +
                        " Com o " + linguagem + ", você pode fazer aplicações em rede, como jogos e programas. \n" +
                        " O " + linguagem + " é indicado para o desenvolvimento em back-end. \n" +
                        " Possui suporte a orientação a objetos. \n" +
                        " Além de ser bom no desenvolvimento web, também é bom em projetos desktop, mobile e até IoT.";
                    break;

                case "Python":  
                    txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem interpretada de alto nível. \n" +
                    " Sendo considerada uma linguagem fácil de aprender e é focada na legibilidade e produtividade. \n" +
                    " O " + linguagem + " é uma linguagem de código-aberto para próposito em geral. \n" +
                    " Com ele, pode fazer na parte de data science, machine learning, automação de tarefas, desenvolvimento web e aplicativos, " +
                    " E o " + linguagem + " é indicado para o desenvolvimento em back-end.";
                    break;

                case "JavaScript":
                    txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem interpretada estruturada de auto nível. \n" +
                        " Ele permite a inplementação de itens complexos em páginas web, se atualiza em um intervalo de tempo,\n" +
                        " mapas interativos ou gráficos 2D/3D animados. \n" +
                        " O " + linguagem + " é indicado no desenvolvimento de front-end.";
                    break;

                case "PHP":
                    txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem interpretada. \n" +
                     " É utilizada para criar sites dinâmicos, extensões de integração de aplicações e agilizar no desenvolvimento de sistemas. \n" +
                     " O " + linguagem + " é indicado no desenvolvimento de back-end.";
                    break ;

                case "HTML":
                    txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem de marcação. \n" +
                        " É utilizada na construção de páginas da Web e montar estruturas na tela do usuário. \n" +
                        " Possui uma definição de menus, criação de botões, textos, entrada de dados e etc. \n" +
                        " O " + linguagem + " é utilizada por todos os sites ao redor do mundo. \n" +
                        " E é indicada no desenvolvimento de front-end." +
                        " OBS: o " + linguagem + " é uma linguagem de marcação, não de programação.";
                    break;

                case "Lua":
                    txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem interpretada de auto nível. \n" +
                     " A " + linguagem + " é poderosa, eficiente e leve, foi projetada para estender as aplicações. \n" +
                     " Ela permite fazer programação procedural, programção orientada a objetos e etc. \n" +
                     " Uma curiosidade sobre a " + linguagem + ", ela é uma linguagem de programação brasileira e foi usada por empresas estrangeiras.";
                    break;

                case "CSS":
                    txtResultadoLinguagem.Text = "O " + linguagem + " é um mecanismo para adicionar estilo a um documento web. \n" +
                        " Com essa linguagem, o desenvolvedor pode define cores, alinhamento, tamanhos de fonte, animações e etc. \n" +
                        " A maior parte dos sites ao redor do mundo contam com o " + linguagem + ", sem essa linguagem, os sites ficam com a aparência simples demais. \n" +
                        " O " + linguagem + " é indicado no desenvolvimento de front-end.";
                    break;

                case "TypeScript":
                    txtResultadoLinguagem.Text = "O " +linguagem + " é uma linguagem de código-aberto desenvolvida pela Microsoft. \n" +
                        " O " + linguagem + " foi construída em cima do JavaScript, foi criado para adicionar recursos de tipagem estática à linguagem original. \n" +
                        " Embora " + linguagem + " seja um superset do Javascript, na hora de compilar o código, \n" +
                        " todo " + linguagem + " é convertido para Javascript. \n" + 
                        " Como o " + linguagem + " é baseada no JavaScript, ele é indicado no desenvolvimento de front-end.";
                    break;

                case "Cobol":
                    txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem orientada a processamento de banco de dados. \n" +
                        " O " + linguagem + " foi usado no Departamento de Defesa norte-americano sobre direção da contra-almirante Grace Murray Hopper. \n" +
                        " Essa linguagem por mais ter uma idade avançada, nos dias de hoje ele ainda é usado. \n" +
                        " O " + linguagem + " foi usado nos bancos tradicionais tanto décadas atrás e continua sendo usado nos dias atuais, \n" +
                        "hoje nos bancos tradicionais é considerado como software legado pela sua confiabilidade. \n" +
                        " E não só os bancos usam " + linguagem + ", também por seguradoras e organizações governamentais para pagar o seguro-desemprego ou tirar o dinheiro do caixa eletrônico.";
                    break;

                case "SQL":
                    txtResultadoLinguagem.Text = "O " + linguagem + " é uma linguagem de programação indicada para o banco de dados. \n" +
                        " O " + linguagem + " é estável e consegue se adaptar com a evolução de outras linguagens no mercado. \n" +
                        " Além dele se adaptar com outras linguagens, ele não precisa ficar fazendo alterações para acompanhar o mercado. \n" +
                        " O " + linguagem + " é indicado para quem quer trabalhar na área de banco de dados e também para o back-end.";
                    break ;

                default:
                    txtResultadoLinguagem.Text = "Infelizmente a linguagem " + linguagem + " pode não está incluida na lista. \n" +
                        " Sobre a linguagem " + linguagem + ", não há registros sobre ela. \n" +
                        " pode ser que ela não esteja registrada no banco de dados, foi descontinuada por isso não foi incluida, \n" +
                        " ela pode não ser liberada para o uso civil por isso só pode ser usada para uso militar ou policial e não está incluida, \n" +
                        " pode está em fase de desenvolvimento e sendo testada e ainda não chegou a versão final para ser disponibilizada ao usuário final. \n" +
                        " pode ter outros motivos para a linguagem " + linguagem + " não está na lista, pode ser que no futuro ela pode ser adicionada na lista.";
                    break;
            }

            switch (cargo) 
            {
                case "Junior":
                    if (timeExperience <= 2)
                    {
                        txtResultadoVaga.Text = "Sobre o cargo ao usuário: " + name + ". \n\n" +
                          " Sobre a linguagem mencionada: " + linguagem + ". \n\n" +
                          " Com o tempo de experiência informado: " + timeExperience + " anos. \n\n";
                         txtSalarial.Text = " A média salarial do cargo " + cargo + " é de R$:2.000,00 até R$:4.000,00 por mês"
                          + " dependendo da localidade, linguagem e área de programção.";
                    }
                    else 
                    {
                        txtResultadoVaga.Text = "Infelizmente o cargo " + cargo + " não está disponível." + "\n\n" +
                        " Pode ser que o cargo não está na lista ou foi preenchido de forma incorreta.";
                    }
                    break;

                case "Pleno":
                    if (timeExperience > 2 && timeExperience <= 5) 
                    {
                        txtResultadoVaga.Text = "Sobre o cargo ao usuário: " + name + ". \n\n" +
                         " Sobre a linguagem mencionada: " + linguagem + ". \n\n" +
                         " Com o tempo de experiência informado: " + timeExperience + " anos. \n\n";
                        txtSalarial.Text = " A média salarial do cargo " + cargo + " é de R$:4.000,00 até R$:7.000,00 por mês"
                          + " dependendo da localidade, linguagem e da área de programação.";
                    }
                    else 
                    {
                        txtResultadoVaga.Text = "Infelizmente o cargo " + cargo + " não está disponível." + "\n\n" +
                        " Pode ser que o cargo não está na lista ou foi preenchido de forma incorreta.";
                    }
                    break;

                case "Senior":
                    if (timeExperience > 5 && timeExperience <= 10) 
                    {
                        txtResultadoVaga.Text = "Sobre o cargo ao usuário: " + name + ". \n\n" +
                         " Sobre a linguagem mencionada: " + linguagem + ". \n\n" +
                         " Com o tempo de experiência informado: " + timeExperience + " anos. \n\n";
                        txtSalarial.Text = " A média salarial do cargo " + cargo + " é de R$:7.000,00 até R$:12.000,00 por mês"
                        +  " dependendo da localidade, linguagem e área de programção.";
                    }
                    else 
                    {
                        txtResultadoVaga.Text = "Infelizmente o cargo " + cargo + " não está disponível." + "\n\n" +
                        " Pode ser que o cargo não está na lista ou foi preenchido de forma incorreta.";
                    }
                    break;

                    default:
                    txtResultadoVaga.Text = "Infelizmente o cargo " + cargo + " não está disponível." + "\n\n" +
                    " Pode ser que o cargo não está na lista ou foi preenchido de forma incorreta.";
                    break;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
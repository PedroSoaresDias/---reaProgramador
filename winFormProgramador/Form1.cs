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
                    txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem compilada. \n" +
                       " Com o " + linguagem + ", voc� pode fazer qualquer tipo de programa��o com ela. \n " +
                       " O " + linguagem + " � indicado tanto na parte de back-end e quanto front-end. \n" +
                       " Ele possui suporte a orienta��o a objetos. \n" +
                       " Ela pode ser usada para (desenvolvimento web, software, jogos, aplicativos e etc.).";
                    break;

                case "C++":
                          txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem compilada. \n" +
                         " Com o " + linguagem + ", voc� pode fazer qualquer tipo de programa��o com ela. \n " +
                         " O " + linguagem + " � indicado tanto na parte de back-end e quanto front-end. \n" +
                         " Possui suporte a orienta��o a objetos. \n" +
                         " Ela pode ser usada para (desenvolvimento web, software, jogos, aplicativos, sistemas operacionais e etc.).";
                    break;

                case "Java":
                    txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem compilada. \n" +
                        " Com o " + linguagem + ", voc� pode fazer aplica��es em rede, como jogos e programas. \n" +
                        " O " + linguagem + " � indicado para o desenvolvimento em back-end. \n" +
                        " Possui suporte a orienta��o a objetos. \n" +
                        " Al�m de ser bom no desenvolvimento web, tamb�m � bom em projetos desktop, mobile e at� IoT.";
                    break;

                case "Python":  
                    txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem interpretada de alto n�vel. \n" +
                    " Sendo considerada uma linguagem f�cil de aprender e � focada na legibilidade e produtividade. \n" +
                    " O " + linguagem + " � uma linguagem de c�digo-aberto para pr�posito em geral. \n" +
                    " Com ele, pode fazer na parte de data science, machine learning, automa��o de tarefas, desenvolvimento web e aplicativos, " +
                    " E o " + linguagem + " � indicado para o desenvolvimento em back-end.";
                    break;

                case "JavaScript":
                    txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem interpretada estruturada de auto n�vel. \n" +
                        " Ele permite a inplementa��o de itens complexos em p�ginas web, se atualiza em um intervalo de tempo,\n" +
                        " mapas interativos ou gr�ficos 2D/3D animados. \n" +
                        " O " + linguagem + " � indicado no desenvolvimento de front-end.";
                    break;

                case "PHP":
                    txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem interpretada. \n" +
                     " � utilizada para criar sites din�micos, extens�es de integra��o de aplica��es e agilizar no desenvolvimento de sistemas. \n" +
                     " O " + linguagem + " � indicado no desenvolvimento de back-end.";
                    break ;

                case "HTML":
                    txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem de marca��o. \n" +
                        " � utilizada na constru��o de p�ginas da Web e montar estruturas na tela do usu�rio. \n" +
                        " Possui uma defini��o de menus, cria��o de bot�es, textos, entrada de dados e etc. \n" +
                        " O " + linguagem + " � utilizada por todos os sites ao redor do mundo. \n" +
                        " E � indicada no desenvolvimento de front-end." +
                        " OBS: o " + linguagem + " � uma linguagem de marca��o, n�o de programa��o.";
                    break;

                case "Lua":
                    txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem interpretada de auto n�vel. \n" +
                     " A " + linguagem + " � poderosa, eficiente e leve, foi projetada para estender as aplica��es. \n" +
                     " Ela permite fazer programa��o procedural, program��o orientada a objetos e etc. \n" +
                     " Uma curiosidade sobre a " + linguagem + ", ela � uma linguagem de programa��o brasileira e foi usada por empresas estrangeiras.";
                    break;

                case "CSS":
                    txtResultadoLinguagem.Text = "O " + linguagem + " � um mecanismo para adicionar estilo a um documento web. \n" +
                        " Com essa linguagem, o desenvolvedor pode define cores, alinhamento, tamanhos de fonte, anima��es e etc. \n" +
                        " A maior parte dos sites ao redor do mundo contam com o " + linguagem + ", sem essa linguagem, os sites ficam com a apar�ncia simples demais. \n" +
                        " O " + linguagem + " � indicado no desenvolvimento de front-end.";
                    break;

                case "TypeScript":
                    txtResultadoLinguagem.Text = "O " +linguagem + " � uma linguagem de c�digo-aberto desenvolvida pela Microsoft. \n" +
                        " O " + linguagem + " foi constru�da em cima do JavaScript, foi criado para adicionar recursos de tipagem est�tica � linguagem original. \n" +
                        " Embora " + linguagem + " seja um superset do Javascript, na hora de compilar o c�digo, \n" +
                        " todo " + linguagem + " � convertido para Javascript. \n" + 
                        " Como o " + linguagem + " � baseada no JavaScript, ele � indicado no desenvolvimento de front-end.";
                    break;

                case "Cobol":
                    txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem orientada a processamento de banco de dados. \n" +
                        " O " + linguagem + " foi usado no Departamento de Defesa norte-americano sobre dire��o da contra-almirante Grace Murray Hopper. \n" +
                        " Essa linguagem por mais ter uma idade avan�ada, nos dias de hoje ele ainda � usado. \n" +
                        " O " + linguagem + " foi usado nos bancos tradicionais tanto d�cadas atr�s e continua sendo usado nos dias atuais, \n" +
                        "hoje nos bancos tradicionais � considerado como software legado pela sua confiabilidade. \n" +
                        " E n�o s� os bancos usam " + linguagem + ", tamb�m por seguradoras e organiza��es governamentais para pagar o seguro-desemprego ou tirar o dinheiro do caixa eletr�nico.";
                    break;

                case "SQL":
                    txtResultadoLinguagem.Text = "O " + linguagem + " � uma linguagem de programa��o indicada para o banco de dados. \n" +
                        " O " + linguagem + " � est�vel e consegue se adaptar com a evolu��o de outras linguagens no mercado. \n" +
                        " Al�m dele se adaptar com outras linguagens, ele n�o precisa ficar fazendo altera��es para acompanhar o mercado. \n" +
                        " O " + linguagem + " � indicado para quem quer trabalhar na �rea de banco de dados e tamb�m para o back-end.";
                    break ;

                default:
                    txtResultadoLinguagem.Text = "Infelizmente a linguagem " + linguagem + " pode n�o est� incluida na lista. \n" +
                        " Sobre a linguagem " + linguagem + ", n�o h� registros sobre ela. \n" +
                        " pode ser que ela n�o esteja registrada no banco de dados, foi descontinuada por isso n�o foi incluida, \n" +
                        " ela pode n�o ser liberada para o uso civil por isso s� pode ser usada para uso militar ou policial e n�o est� incluida, \n" +
                        " pode est� em fase de desenvolvimento e sendo testada e ainda n�o chegou a vers�o final para ser disponibilizada ao usu�rio final. \n" +
                        " pode ter outros motivos para a linguagem " + linguagem + " n�o est� na lista, pode ser que no futuro ela pode ser adicionada na lista.";
                    break;
            }

            switch (cargo) 
            {
                case "Junior":
                    if (timeExperience <= 2)
                    {
                        txtResultadoVaga.Text = "Sobre o cargo ao usu�rio: " + name + ". \n\n" +
                          " Sobre a linguagem mencionada: " + linguagem + ". \n\n" +
                          " Com o tempo de experi�ncia informado: " + timeExperience + " anos. \n\n";
                         txtSalarial.Text = " A m�dia salarial do cargo " + cargo + " � de R$:2.000,00 at� R$:4.000,00 por m�s"
                          + " dependendo da localidade, linguagem e �rea de program��o.";
                    }
                    else 
                    {
                        txtResultadoVaga.Text = "Infelizmente o cargo " + cargo + " n�o est� dispon�vel." + "\n\n" +
                        " Pode ser que o cargo n�o est� na lista ou foi preenchido de forma incorreta.";
                    }
                    break;

                case "Pleno":
                    if (timeExperience > 2 && timeExperience <= 5) 
                    {
                        txtResultadoVaga.Text = "Sobre o cargo ao usu�rio: " + name + ". \n\n" +
                         " Sobre a linguagem mencionada: " + linguagem + ". \n\n" +
                         " Com o tempo de experi�ncia informado: " + timeExperience + " anos. \n\n";
                        txtSalarial.Text = " A m�dia salarial do cargo " + cargo + " � de R$:4.000,00 at� R$:7.000,00 por m�s"
                          + " dependendo da localidade, linguagem e da �rea de programa��o.";
                    }
                    else 
                    {
                        txtResultadoVaga.Text = "Infelizmente o cargo " + cargo + " n�o est� dispon�vel." + "\n\n" +
                        " Pode ser que o cargo n�o est� na lista ou foi preenchido de forma incorreta.";
                    }
                    break;

                case "Senior":
                    if (timeExperience > 5 && timeExperience <= 10) 
                    {
                        txtResultadoVaga.Text = "Sobre o cargo ao usu�rio: " + name + ". \n\n" +
                         " Sobre a linguagem mencionada: " + linguagem + ". \n\n" +
                         " Com o tempo de experi�ncia informado: " + timeExperience + " anos. \n\n";
                        txtSalarial.Text = " A m�dia salarial do cargo " + cargo + " � de R$:7.000,00 at� R$:12.000,00 por m�s"
                        +  " dependendo da localidade, linguagem e �rea de program��o.";
                    }
                    else 
                    {
                        txtResultadoVaga.Text = "Infelizmente o cargo " + cargo + " n�o est� dispon�vel." + "\n\n" +
                        " Pode ser que o cargo n�o est� na lista ou foi preenchido de forma incorreta.";
                    }
                    break;

                    default:
                    txtResultadoVaga.Text = "Infelizmente o cargo " + cargo + " n�o est� dispon�vel." + "\n\n" +
                    " Pode ser que o cargo n�o est� na lista ou foi preenchido de forma incorreta.";
                    break;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
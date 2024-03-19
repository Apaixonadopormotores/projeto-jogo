namespace projetinho;

public partial class Contentpage : gamepage
{
  //------------------------------------------------------------------------------------------------

  List<historystep> historia = new List<HistoryStep>();
  historystep historyStepAtual;

  //------------------------------------------------------------------------------------------------

	public gamepage()
	{
		InitializeComponent();

    historia.Add(new HistoryStep()
    {
      Id = 0,
      Texto = "Olá, velho amigo tudo bem parece que você não pilota a muito tempo Vamos de pressa uma gangue rival esta vindo...",
      TemResposta=false
    });
     historia.Add(new HistoryStep()
    {
      Id = 1,
      Texto = "O vento cortante varre as ruas estreitas da cidade, levando consigo o cheiro de óleo e fumaça. Você e seu velho amigo, Raul, estão em uma motocicleta roubada, acelerando pelas vielas escuras. As luzes dos postes piscam como olhos ameaçadores, e o ronco dos motores ecoa entre os prédios decrépitos.\nRaul olha para você com olhos cansados, a barba por fazer escondendo cicatrizes antigas. Parece que você não pilota há muito tempo, ele diz, a voz rouca pelo vento. “Mas não temos escolha. A gangue rival está atrás de nós.\nVocê aperta o guidão, sentindo a adrenalina correr pelas veias. A noite está fria, mas o medo aquece seu corpo. A gangue rival, conhecida como Os Corvos, é implacável. Eles querem vingança pelo último confronto, quando vocês roubaram o carregamento de drogas que eles estavam transportando.",
      TemResposta=true,
      TextoDaResposta01="Continua em alta velocidade, tentando despistar os Corvos pelas ruas estreitas.",
      TextoDaResposta02="Arrisca um atalho perigoso, saltando sobre uma pilha de entulho e entrando em um beco escuro.",
      TextoDaResposta03="Procura um esconderijo, talvez um prédio abandonado onde possam se esconder",
      IdLevelResposta01=2,
      IdLevelResposta02=4998,
      IdLevelResposta03=5000
    });

  }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

using Xamarin.Forms;

namespace InfoNews
{
	public partial class ListaInformacaoPage : ContentPage
	{
		public ListaInformacaoPage()
		{
			InitializeComponent();

			if (InfoNewsPage.btnPlantaoClicked)
			{
				this.Title = "Plantão";

				lstInformacoes.ItemsSource = getListPlantao();

				InfoNewsPage.btnPlantaoClicked = false;
				InfoNewsPage.btnEsporteClicked = false;
				InfoNewsPage.btnEconomiaClicked = false;
				InfoNewsPage.btnTecnologiaClicked = false;
				InfoNewsPage.btnMundoClicked = false;
			}
			else if (InfoNewsPage.btnEsporteClicked)
			{
				this.Title = "Esporte";

				lstInformacoes.ItemsSource = getListEsporte();
				//CarregaXML("esporte");

				InfoNewsPage.btnPlantaoClicked = false;
				InfoNewsPage.btnEsporteClicked = false;
				InfoNewsPage.btnEconomiaClicked = false;
				InfoNewsPage.btnTecnologiaClicked = false;
				InfoNewsPage.btnMundoClicked = false;
			}
			else if (InfoNewsPage.btnEconomiaClicked)
			{
				this.Title = "Economia";

				lstInformacoes.ItemsSource = getListEconomia();

				InfoNewsPage.btnPlantaoClicked = false;
				InfoNewsPage.btnEsporteClicked = false;
				InfoNewsPage.btnEconomiaClicked = false;
				InfoNewsPage.btnTecnologiaClicked = false;
				InfoNewsPage.btnMundoClicked = false;
			}
			else if (InfoNewsPage.btnTecnologiaClicked)
			{
				this.Title = "Tecnologia";

				lstInformacoes.ItemsSource = getListTecnologia();

				InfoNewsPage.btnPlantaoClicked = false;
				InfoNewsPage.btnEsporteClicked = false;
				InfoNewsPage.btnEconomiaClicked = false;
				InfoNewsPage.btnTecnologiaClicked = false;
				InfoNewsPage.btnMundoClicked = false;
			}
			else if (InfoNewsPage.btnMundoClicked)
			{
				this.Title = "Mundo";

				lstInformacoes.ItemsSource = getListMundo();

				InfoNewsPage.btnPlantaoClicked = false;
				InfoNewsPage.btnEsporteClicked = false;
				InfoNewsPage.btnEconomiaClicked = false;
				InfoNewsPage.btnTecnologiaClicked = false;
				InfoNewsPage.btnMundoClicked = false;
			}
		}


		List<Informacao> getListPlantao()
		{
			return new List<Informacao>
			{
				new Informacao()
				{
					Titulo="Corrida arrecada fundos para menino com síndrome rara em Varginha, MG", 
					DataHora="26/10/2016 11:09",
					Corpo="Você se lembra do Gabriel Souza? Após uma campanha para cadastro de doadores de medula, feita em março deste ano, agora é a vez de uma corrida arrecadar fundos para ajudar o menino. Gabriel, de três anos, tem a rara síndrome de Chediak-Higash e precisa de doações para fazer o transplante da medula compatível. A “1ª Corrida pela Vida – Todos Juntos pelo Gabriel” será no próximo domingo (30), às 9h em Varginha (MG). Menino de apenas 3 anos sofre de síndrome rara em Campo Belo (Foto: Reprodução EPTV) A largada será no pátio externo do Batalhão da Polícia Militar, e o trajeto passa em frente a Unifenas, segue sentido Proluminas, vai até a porta da fazenda experimental e retorna, pelo mesmo caminho, até o batalhão, totalizando 5 km. Para os três primeiros colocados masculinos e femininos e também nas categorias por idade, melhor Varginhense e Militar, haverá premiação em troféus. Além da corrida tradicional, as crianças com idades entre 2 e 15 anos poderão participar da Corrida Kids. A inscrição para as crianças deverá ser feita na hora e é gratuita. A síndrome de Chediak-Higashi é uma alteração genética ainda sem causa definida, que afeta e enfraquece o sistema imunológico. Quando atacado por um vírus ou bactéria, reage contra o próprio organismo. A doença se caracteriza pelo albinismo parcial e por isso é conhecida também como síndrome do cabelo prateado. Toda a verba adquirida na corrida será encaminhada para a família do Gabriel, que vive em Campo Belo (MG), para que ele consiga fazer a cirurgia de transplante de medula e salvar sua vida. O dinheiro será usado principalmente no pós-operatório, uma vez que seu tratamento é feito em São Paulo (SP). A expectativa é que cerca de 200 atletas participem da corrida. O valor da inscrição é R$ 30 e pode ser feita até essa quinta-feira (27) pelo site Portal das Corridas. Ação em Campo Belo (MG) vai tentar encontrar doadores de medula para o menino (Foto: Reprodução EPTV)",
					Editoria="Sul de minas"
				},
				
				new Informacao()
				{
					Titulo="CIDH condena mortes em presídio de RR e exige investigação: 'fato grave'", 
					DataHora="26/10/2016 11:06",
					Corpo="Agentes fazem policiamento da unidade minutos após reféns serem liberados (Foto: Valéria Oliveira/G1 RR) A Comissão Interamericana de Direitos Humanos (CIDH) da Organização dos Estados Americanos (OEA) condenou nesta terça-feira (25) o assassinato de dez detentos na Penitenciária Agricola de Monte Cristo, a maior prisão de Roraima, e exigiu que o governo investigue as mortes.   No dia 16 de outubro, dez presos morreram e seis ficaram feridos durante um confronto entre integrantes de uma facção rival. Dos mortos, quatro foram decapitados e sete carbonizados. Durante o confronto entre as facções, 100 familiares de presos foram feitos reféns na unidade. Após as mortes, o governo transferiu presos, mas no sábado (21) outro presidiário foi assassinado na penitenciária. A Comissão Interamericana diz no documento que as mortes precisam ser investigadas pelo governo, uma vez que é dever do estado garantir os direitos à segurança, à integridade e à vida dos presos. \"Estas investigações não somente devem procurar determinar os responsáveis materiais dos fatos, mas também os possíveis autores intelectuais e as autoridades que poderiam ser responsáveis por ação ou omissão\", defende a Comissão. Na segunda-feira (24), a Delegacia Geral de Homicídios informou que 50 presos são suspeitos de envolvimento nas mortes que ocorreram na penitenciária. Todos estão sob investigação. O posicionamento da CIDH menciona o número de 25 presos mortos, uma vez que na noite do massacre, um capitão do Batalhão de Operações Especiais informou à imprensa que 25 detentos haviam morrido no confronto. O governo nega o dado. A CIDH adverte que o caso é grave e cita a superlotação da penitenciária que tem capacidade para receber até 700 detentos, mas que hoje abriga 1400 homes. O estado deve ainda, segundo a CIDH, adotar todas as medidas legais, institucionais e administrativas que forem necessárias para garantir que casos como esses não se repitam. Governo diz investigar mortes Em nota, o estado informou nesta quarta-feira (26) que lamenta e condena o ocorrido, gerado pela rivalidade entre detentos que culminou nesta tragédia e diz investigar o caso. \"Ressalta que todas as unidades de segurança estadual vêm trabalhando com o objetivo de elucidar o ocorrido e responsabilizar os envolvidos nas mortes que ocorreram na Penitenciária\", finaliza. Leia a íntegra do comunicado da CIDH:A CIDH condena mortes violentas em uma penitenciária do Brasil25 de outubro de 2016 Washington, D.C. – A Comissão Interamericana de Direitos Humanos (CIDH) expressa preocupação perante os fatos de violência ocorridos na Penitenciária Agrícola de Monte Cristo no Estado de Roraima, Brasil. A CIDH insta o Estado do Brasil a investigar e esclarecer as circunstâncias em que ocorreram estes fatos e, se cabível, identificar e punir os responsáveis. Além disso, o Estado deve adotar as medidas necessárias para impedir que voltem a ocorrer incidentes deste tipo. Em conformidade com informações de conhecimento público, em 17 de outubro de 2016 houve um motim na Penitenciária Agrícola de Monte Cristo, situada em Boa Vistax, capital do Estado de Roraima, Brasil. Segundo informado pelo Batalhão de Operações Especiais da Polícia, o motim teria ocorrido quando um grupo de detentos entrou em uma seção da penitenciária ocupada por membros de uma facção diferente. O Senhor Uziel Castro, Secretário da Justiça e Cidadania de Roraima, informou que cerca de 100 familiares dos detentos foram tomados como reféns no enfrentamento que ocorreu no horário de visita. O episódio deixou um saldo de pelo menos 25 mortos, dos quais sete foram encontrados decapitados e outros seis carbonizados, segundo relatórios jornalísticos. A Comissão Interamericana adverte que este fato grave se enquadra em um contexto de violência que prevalece nas penitenciárias brasileiras, as quais geralmente têm problemas de superpopulação. Estima-se que a prisão de Boa Vista tenha 1.400 detentos, apesar de sua capacidade ser para 740. Os Estados, como avalistas dos direitos fundamentais das pessoas privadas de liberdade, têm o dever jurídico ineludível de adotar ações concretas para garantir os direitos à vida, integridade pessoal e segurança dos detentos. Esta obrigação inclui garantir as condições de detenção requeridas pelas normas internacionais em matéria de direitos humanos. A CIDH recorda também que o Estado tem a obrigação de investigar ex officio e com a devida diligência todas as mortes de pessoas sob sua custódia. Estas investigações não somente devem procurar determinar os responsáveis materiais dos fatos, mas também os possíveis autores intelectuais e as autoridades que poderiam ser responsáveis por ação ou omissão. A Comissão Interamericana de Direitos Humanos insta o Estado brasileiro a adotar todas as medidas necessárias para prevenir a repetição de fatos semelhantes, em particular a implementação de ações destinadas a adequar as condições de detenção da Penitenciária Agrícola de Monte Cristo e outros centros de reclusão aos padrões internacionais, a fim de garantir a vida e a integridade das pessoas privadas de liberdade. O Estado deve manter a segurança interna dos centros penais e controlar a entrada nas prisões de armas e substâncias ilícitas, bem como a distribuição de dinheiro. Além disso, a CIDH insta o Brasil a criar e implementar mecanismos para reduzir a superpopulação das prisões e demais centros de detenção do país. A CIDH é um órgão principal e autônomo da Organização dos Estados Americanos (OEA), cujo mandato surge a partir da Carta da OEA e da Convenção Americana sobre Direitos Humanos. A Comissão Interamericana tem como mandato promover a observância dos direitos humanos na região e atua como órgão consultivo da OEA na temática. A CIDH é composta por sete membros independentes, que são eleitos pela Assembleia Geral da OEA a título pessoal, sem representarem seus países de origem ou de residência.",
					Editoria="Roraima"
				},

				new Informacao()
				{
					Titulo="Morador de rua é encontrado morto no Centro de Manaus", 
					DataHora="26/10/2016 11:05",
					Corpo="Morador de rua chegou a pedir socorro em posto de combustíveis (Foto: Adneison Severiano/G1 AM) Um homem ainda não identificado foi morto a facadas na noite de terça-feira (25), no Centro de Manaus. Ele era morador de rua e chegou a pedir socorro em um posto de combustíveis antes de morrer. O crime ocorreu na rua Quintino Bocaiúva. Testemunhas relataram à Polícia Civil que a vítima dormia nas imediações do posto, quando foi esfaqueada. saiba maisHomens são mortos em troca de tiros na rodovia Manoel Urbano, no AMDupla é presa por tráfico de drogas e porte ilegal de arma de fogo, no AM  De acordo com a Delegacia Especializada em Homicídios e Sequestros (DEHS), os golpes de faca atingiram o homem no pescoço. Mesmo ferido, o morador de rua correu até um posto de combustíveis nas proximidades onde pediu socorro. No entanto, ele não resistiu aos ferimentos e morreu dentro do estacionamento. O estabelecimento não funciona à noite e não havia funcionários. O agressor não foi visto por testemunhas e a Polícia Civil não identificou nenhum suspeito até o momento. A motivação do crime ainda é desconhecida. A Polícia Militar esteve no local do crime e fez o isolamento da área até chegada de peritos do Instituto de Criminalística. O morador de rua teve anemia aguda hemorrágica com ruptura de grandes vasos sanguíneos do pescoço. O corpo foi recolhido pelo Instituto Médico-Legal (IML) e aguarda reconhecimento de familiares. A vítima não portava documentos. O lML informou que o homem tem entre 35 e 40 anos de idade, cor parda, cabelos crespos e 1,60 de altura. A vítima tinha uma tatuagem no ombro esquerdo, usava camisa verde e bermuda estampada quando foi assassinada.",
					Editoria="Amazonas"
				},

				new Informacao()
				{
					Titulo="Raio-x de Viracopos flagra e dois são presos com cocaína no estômago", 
					DataHora="26/10/2016 11:04",
					Corpo="Raio-x mostra cápsulas com droga no estômago e intestino dos brasileiros presos (Foto: PF / Divulgação) Dois brasileiros foram presos em flagrante por tráfico de entorpecentes no embarque do Aeroporto Internacional de Viracopos com, pelo menos, 100 cápsulas contendo cocaína dentro do estômago, de acordo com a Polícia Federal (PF). A tentativa de tráfico foi descoberta quando eles passavam pelo equipamento de raio-x, nesta terça-feira (25). A informação foi divulgada pela PF nesta quarta (26). Os presos iriam viajar para Portugal. Na semana passada, outro brasileiro também foi preso com droga no estômago no aeroporto, e tinha o mesmo destino. A pena para esse tipo de tráfico vai de cinco a 15 anos de reclusão, além de multa. Parte das cápsulas engolidas  já foram expelidas e apreendidas (Foto: PF Campinas / Divulgação) Agentes suspeitaram Os suspeitos do caso desta terça foram abordados por agentes da PF no embarque. Os policiais desconfiaram dos brasileiros e os levaram para passar pelo raio-x. saiba maisHomem é preso com cápsulas de cocaína no estômago em Viracopos  Imediatamente foi confirmada a presença de diversas cápsulas de cocaína no abdômen deles. \" (...) acreditando-se que sejam mais de cem cápsulas em cada um\", diz a nota enviada pela Polícia Federal. A Guarda Municipal deu apoio à ação e os presos foram encaminhados para um hospital de Campinas, onde foram ouvidos, para expelir as cápsulas. Assim que tiverem alta, serão encaminhados para um presídio da região, ainda não divulgado.",
					Editoria="Campinas e região"
				},

				new Informacao()
				{
					Titulo="Confira a agenda desta quarta-feira dos candidatos a prefeito de Cuiabá", 
					DataHora="26/10/2016 11:03",
					Corpo="Confira a agenda para esta quarta-feira (26) dos dois candidatos que disputam à Prefeitura de Cuiabáx no segundo turno das eleições. A lista está em ordem alfabética e as informações dos compromissos foram enviadas pelas assessorias dos concorrentes. Emanuel Pinheiro (PMDB) - 6h30: Entrevista à Rádio Comunitária do Bairro Pedra 90 - 8h: Entrevista à TV Comunitária do Bairro Pedra 90 - 8h30: Caminhada no Bairro Voluntários da Pátria - 15h: Visita a unidade de saúde no Bairro Pascoal Ramos - 16h: Caminhada no Bairro Jardim Industriário II - 18h: Entrevista a programa de TV - 19h30: Reunião com os coordenadores de campanha da região sul - 20h30: Reunião no Bairro Pedra 90 Wilson Santos (PSDB) Agenda não informada",
					Editoria="Eleições 2016 em mato grosso"
				},

				new Informacao()
				{
					Titulo="NAT tem vagas para áreas de vendas, beleza, alimentação e marketing", 
					DataHora="26/10/2016 11:01",
					Corpo="O Núcleo de Apoio ao Trabalho (NAT) divulgou nesta quarta-feira (26) as oportunidades de emprego formal disponíveis para Aracaju (SE). As oportunidades são para supervisor de vendas e vendedor pracista com ensino médio e experiência de seis meses. saiba maisFeirão Liquida Dívida Banese e Banese Card continua até novembro  Para as funções de barbeiro e manicure é necessário ter ensino fundamental e seis meses de experiência. As vagas para pessoas com deficiência são para merendeiro, leiturista, operador de telemarketing e auxiliar de produção, todas com ensino médio, mas não é exigida experiência. Para o preenchimento das vagas, o cadastro deve ser aprovado. É preciso apresentar carteira de trabalho, CPF, RG e comprovante de residência em qualquer posto de atendimento do NAT ou na sede que fica na Rua Santa Luzia, 680, no Bairro São José, em Aracaju. Os telefones de contato são: (79) 3198-0505 e final 0507.",
					Editoria="Sergipe"
				},
			};
		}

		List<Informacao> getListEsporte()
		{
			return new List<Informacao>
			{
				new Informacao()
				{
					Titulo="Trio de boxeadores do AM disputará seletiva para o Campeonato Brasileiro", 
					DataHora="26/10/2016 11:05",
					Corpo="Três dos melhorespugilistas do Amazonas viajam nesta quarta-feira, dia 26, para Salvador, Bahia,para participar da Seletiva Nacional de Boxe Olímpico, categoria Elite,que acontecerá de 26 a 30 de outubro. O evento vale vaga para o CampeonatoBrasileiro de Boxe, marcado para novembro. Para o presidenteda Federação Amazonense de Boxe (FAB), Luis Rocha, os pugilistas podemsurpreender na competição. - Eles foram os atletas que mais se destacaram nascompetições desse ano. O Cleberson ainda não perdeu desde o ano passado. ORodrigo vem se destacando bastante e o João Lenon dispensa comentários. Só nãotem tido sorte no Brasileiro, mas agora pode ser diferente - acredita. Rodrigo Queiroz, João Lenon e Cleberson Serrão representarão o Amazonas (Foto: Mauro Neto/Sejel) Rodrigo Queiroz, de 32 anos, que pratica boxe desde os 18. Com cartel de 30 lutas e apenas cinco derrotas, o atleta da academia Pantera Negra disputará na categoria até 56 kg.Parceiro deacademia de Rodrigo, o pugilista Cleberson Serrão, 32, está invicto desde 2015. Essa será a primeira competição fora do Amazonas do lutador da categoria 51 kg. Considerada uma daspromessas do time amazonense, João Lenon, de 23, já conquistou tudo nascompetições de boxe do Amazonas. Sem sorte nos últimos Brasileiros, o jovemnascido em Santarém-PA, que viveu em Roraima e há três anos mora e treina naVila Olímpica de Manaus, pretende virar os últimos ‘capítulos’ e ter um finalfeliz.   Para ir à competição, os atletasrecebem apoio do Governo do Amazonas, via Secretaria de Estado de Juventude,Esporte e Lazer (Sejel).",
					Editoria="Am"
				},
				new Informacao()
				{
					Titulo="Na reta decisiva da LNF, Cidão diz sentir falta de jogar em Orlândia", 
					DataHora="26/10/2016 11:05",
					Corpo="Cidão lamenta ter de disputar quartas de final longe do ginásio Maurício Leite de Morais, em reforma (Foto: Reprodução EPTV) Com a necessidade de reverter a vantagem conquistada pelo Sorocaba no jogode ida das quartas de final da Liga Nacional de Futsal, o técnico Cidãolamentou o fato de não poder atuar no ginásio Maurício Leite de Moraes nestareta decisiva da LNF. Com o ginásio em reforma desde junho deste ano, o timetem atuado em Bebedouro e na Arena João Mambrini, em São Sebastião do Paraíso(MG), local que receberá a partida contra o time sorocabano, no dia 5 denovembro. - Isso foi o ano todo, infelizmente. São Sebastião do Paraíso faz o quepode, mas nós sentimos falta realmente do nosso ginásio, do calor do nossotorcedor. Se o jogo fosse em Orlândia, eu teria absoluta certeza que nóspassaríamos de fase. Temos chances lá [em São Sebastião do Paraíso] também,vamos para cima, mas com certeza em casa seria mais fácil - comentou Cidão. + Jogo do Orlândia na Copa Paulista alivia ansiedade da LNF + Orlândia inicia troca de ingressos para jogo contra Sorocaba Na atual Liga, o Orlândia realizou duas partidas no Mauricião e venceu asduas, contra Joinville (5 a 1) e São José (3 a 1). Na Arena Olímpica, o timegrená tem duas derrotas e cinco vitórias na LNF, incluindo a classificaçãosobre o Minas, na fase anterior. Não é a primeira vez que Cidão lamenta o fato de o Orlândia não poderutilizar sua casa. No fim de junho, o técnico reclamou da falta de locais paratreino . Em agosto, porém, a agremiação inaugurou um centro de treinamento nacidade.",
					Editoria="Futsal"
				},
				
				new Informacao()
				{
					Titulo="Pedra no sapato: defesa do Inter tem prova de fogo contra carrasco Pratto", 
					DataHora="26/10/2016 11:05",
					Corpo="Lucas Pratto causa transtorno cada vez que enfrenta o Inter (Foto: Bruno Cantini/ Atlético-MG) A evolução do sistema defensivo do Inter terá uma prova de fogo nesta quarta-feira, a partir das 21h45, no Beira-Rio. Se Fred está fora do confronto pela semifinal da Copa do Brasil, o Atlético-MG segue poderoso, com Cazares, Robinho e Lucas Pratto. Principalmente o centroavante. Enfrentá-lo costuma causar transtornos ao Colorado. LEIA MAIS Fabinho vê Inter motivado por título Roth encaminha Inter com 5 titulares Carvalho anuncia Anderson na equipe Pratto virou um carrasco colorado. Em cinco partidas, fez os gaúchos saírem derrotados em três ocasiões. Tem ainda um empate e uma vitória do Inter, que possui aproveitamento de apenas 26% quando depara com o argentino. Com um detalhe: ele soma três gols. Na última vez, lá estava Pratto a atormentar o Inter. No dia 25 de setembro, pela 27ª rodada do Brasileirão, o gringo entrou na etapa final na vaga de Fred, quando o Galo já vencia por 2 a 1. E precisou de apenas 17 minutos para deixar sua marca. Ao receber de Robinho, tabelou com Dátolo até mandar no ângulo de Danilo Fernandes. O volante Fabinho sabe a qualidade do centroavante e pede marcação forte. – Temos que chegar firme, mas sem violência. Não podemos dar espaço. É um ataque muito qualificado – resumiu.       na tabela Pratto recebe de Dátolo e faz 3 a 1 no Inter de pênalti Argentino marca em Galo 2 x 1 Inter pelo Brasileiro de 2015 na libertadores Inter elimina Atlético-MG na vitória por 3 a 1, mas Pratto desconta O retrospecto é ainda mais alarmante pela fórmula da Copa do Brasil. Caso marque no Beira-Rio, Pratto complica a situação do Inter para o confronto de volta, no Independência.  O duelo com o Atlético-MG surge em um dos melhores momentos do sistema defensivo , principalmente pela postura no Gre-Nal. O Inter não se assustou em atuar na Arena contra atacantes como Bolaños e Luan e conteve os avanços, garantindo o 0 a 0.   A soberania defensiva ocorreu sem a necessidade de faltas. Ernando deixou o clássico zerado, enquanto Paulão cometeu apenas uma. Ocorre que, como o Inter prioriza o Brasileirão para fugir do rebaixamento, Celso Roth mandará a campo uma equipe alternativa nesta quarta.  Pratto x Inter 5 jogos 3 vitórias do Atlético-MG 1 vitória do Inter 1 empate 3 gols marcados O jogo foi o segundo seguido que o time não levou gol. Antes, passou invicto na vitória por 2 a 0 sobre o Santos. O retrospecto mostra a nova fase do sistema defensivo. Nas últimas seis partidas, o Colorado sofreu apenas dois tentos – na derrota por 1 a 0 para o Botafogo e triunfo por 2 a 1 sobre o Flamengo –, o que dá uma média de 0,33 por partida. Para tentar segurar o Galo, o Inter entra em campo a partir das 21h45 desta quarta-feira no Beira-Rio. O jogo de volta está marcado para o dia 2 de novembro, no mesmo horário, no Independência. INTER X ATLÉTICO-MG - SEMIFINAL DA COPA DO BRASIL Local: Beira-Rio, em Porto Alegre. Data e horário: quarta-feira, às 21h45 (de Brasília). Escalação provável: Danilo Fernandes; Fabinho, Paulão, Alan Costa e Geferson; Rodrigo Dourado, Eduardo Henrique, William, Anderson e Alex; Aylon Pendurado: Fernando Bob Desfalques: Eduardo, Ariel, Fernando Bob, Nico López, Diego, Marcelo Lomba e Anselmo Arbitragem: Marcelo de Lima Henrique (PE), auxiliado por Rodrigo Henrique Correa (Fifa/RJ) e Bruno Boschilia (Fifa/PR) Transmissão:  TV Globo (para o RS), com Luciano Périco, Maurício Saraiva e Márcio Chagas, e SporTV, com Milton Leite e Maurício Noriega Confira todas as notícias do esporte gaúcho em www.globoesporte.",
					Editoria="Internacional"
				},

				new Informacao()
				{
					Titulo="Grêmio desafia tabu em mata-matas contra o Cruzeiro por título em 2016", 
					DataHora="26/10/2016 11:05",
					Corpo="há 50 anos valeu taça pela libertadores sem vitória O Grêmio fita seu futuro e entra em campo nesta quarta-feira, às 21h45, no Mineirão, decidido a manter vivas as chances de um título em 2016 ao encarar o Cruzeiro, no jogo de ida da semifinal da Copa do Brasil. Mas o confronto com o rival mineiro também serve como um acerto de contas para o passado gremista. Para chegar à final, o Tricolor de Renato Gaúcho depara com o desafio de romper o tabu de nunca ter vencido a Raposa em duelos de mata-mata. LEIA MAIS  Renato explica diferenças de Pedro Rocha e Everton Renato vê Cruzeiro menos cansado: \"Sai na frente\" Grêmio encerra preparação com treino fechado Ao todo, as duas equipes se enfrentaram quatro vezes em confrontos eliminatórios. Além de levar a melhor em todos as chaves, o clube mineiro sagrou-se campeão em três oportunidades, com direito a vitória na final da Copa do Brasil, em 1993. Relembre abaixo os confrontos: 01 há 50 anos Cruzeiro foi campeão da Taça Brasil de 1966 (Foto: Reprodução SporTV) O tabu iniciou no longínquo 1966, nas quartas de final da Taça Brasil. Na ocasião, o Tricolor segurou um empate em 0 a 0 no jogo da ida, no Olímpico, e até saiu na frente na volta, com gol de Vieira. Marco Antonio e Tostão viraram a partida no Mineirão e selaram a vaga. O time mineiro ainda superou o Fluminense e o Santos, na final, para ficar com seu primeiro título nacional. 01 valeu taça   Em  1993, Grêmio e Cruzeiro voltaram a se cruzar na grande final da Copa do Brasil. E repetiram os placares do primeiro encontro. Após o 0 a 0 no Estádio Olímpico, a Raposa venceu o Grêmio por 2 a 1 no Mineirão. Na ocasião, Roberto Gaúcho abriu o placar para os mineiros em chute de fora da área, graças a um frango histórico do goleiro Eduardo Heuser. Pingo empatou ainda no primeiro tempo para o Tricolor, mas Cleison anotou o gol do título, de cabeça, no começo da segunda etapa. 01 pela libertadores   Quatro anos mais tarde, as duas equipes se enfrentaram nas quartas de final da Libertadores. O Cruzeiro venceu o jogo de ida, no Mineirão, por 2 a 0, com gols de Elivélton e Alex Mineiro. Na volta, o Tricolor foi valente para buscar o triunfo por 2 a 1 sem quatro titulares – Rivarola, Dinho, Carlos Miguel e Paulo Nunes. Fabinho abriu o placar para a Raposa. Mauro Galvão e Zé Alcino até viraram para o Grêmio, mas o escore foi insuficiente para o Tricolor. 01 sem vitória   O último duelo entre as duas equipes ocorreu em 2009, na semifinal da Libertadores. O Cruzeiro aplicou 3 a 1 no jogo da ida, no Mineirão, e largou com boa vantagem contra o Tricolor, dono da melhor campanha na competição. Na volta, o Grêmio saiu atrás, mas arrancou um empate em 2 a 2, longe de ser o suficiente para garantir a vaga na grande final. Não bastasse o tabu em mata-matas, o Tricolor depara ainda com um jejum de 14 anos sem triunfos no Mineirão contra o Cruzeiro. O Grêmio desafia o histórico e a equipe de Mano Menezes a partir das 21h45 desta quarta-feira, no jogo de ida da semifinal da Copa do Brasil. CRUZEIRO X GRÊMIO - SEMIFINAL - COPA DO BRASIL  Local: Mineirão, em Belo Hozironte (MG).  Data e horário: Quarta-feira (26/10), às 21h45 (de Brasília).  Provável escalação: Marcelo Grohe; Edílson, Geromel, Kannemann e Marcelo Oliveira; Walace, Maicon, Ramiro, Douglas e Pedro Rocha; Luan. Desfalques: Bruno Grassi, Fred, Negueba, Wallace Reise Henrique Almeida.  Pendurados: não há.  Arbitragem: Péricles Bassols (Fifa/PE), auxiliado por Kleber Lucio Gil (SC) e Nadine Câmara Bastos (SC) Transmissão: TV Globo (para todo o Brasil, menos RS, SC, RJ e Curitiba), com Cleber Machado, Casagrande, Caio Ribeiro e Paulo César Oliveira (para MG, com Rogério Corrêa, Bob Faria e Márcio Rezende de Freitas), e SporTV 2, com Luiz Carlos Jr e Roger Flores. Confira todas as notícias do esporte gaúcho em www.globoesporte.",
					Editoria="Grêmio"
				},

				new Informacao()
				{
					Titulo="Colorado apressa corrida para liberar Arena Ytacoatiara no Piauiense 2017", 
					DataHora="26/10/2016 11:04",
					Corpo="Arena Ytacoatiara (Foto: Emanuele Madeira/GloboEsporte.com) A definição da data de abertura do Campeonato Piauiense 2017serviu de farol para que o 4 de Julho determinasse o início da execução dosplanos para a nova temporada. Além de se debruçar sobre a contratação de elencoe técnico, a diretoria colorada terá que correr para garantir a liberação daArena Ytacoatiara, em Piripiri, que deverá ser palco dos seus jogos no estadual a partir dodia 4 de fevereiro. De acordo com o estipulado pela Federação de Futebol doPiauí (FFP) no arbitral de clubes realizado na terça, em Teresina , o Gavião tematé o dia 14 de janeiro para entregar toda a papelada que garantirá a livreutilização da praça esportiva. - A grande dificuldade que temos no momento é em relação aoestádio. Temos que apresentar os laudos até a data que foi determinada. Nãopodemos mexer no estádio porque ele é da Prefeitura. Vamos tentar viabilizar asituação, principalmente a do Corpo de Bombeiro, para que a gente tenhacondição de jogo e possa disputar o Campeonato – destacou Sergil Araújo,presidente do Colorado. Arena Ytacoatiara (Foto: Josiel Martins) A casa oficial do 4 de Julho recebeu jogos da campanha doclube na busca bem sucedida do acesso à elite este ano. Contudo, existe aexpectativa dos dirigentes de quem sejam feitas reformas pontuais antes da bolarolar no Piauiense 2017 . Uma das situações mais delicadas é no setor dascadeiras, onde parte do teto está bastante comprometida e ameaça cair.Vestiários e banco de reservas também precisam de melhorias imediatas. Construído em meados dos anos 60, o estádio foi inauguradocom o nome de Helvídio Nunes de Barros. Depois de uma grande intervenção em 2008,passou a se chamar Arena Ytacoatiara. Atualmente, a praça esportiva tem capacidadepara quatro mil torcedores. - Nossa situação é jogar em Piripiri. Nossa identificação écom a torcida colorada é lá. Não podemos abrir mão disso para jogar em outrapraça de esporte. Até porque não existe outra da maneira como a ArenaYtacoatiara. Então, vamos tentar dessa maneira – completou o dirigentecolorado. Arena Ytacoatiara, em Piripiri (Foto: Josiel Martins)  Os estádios Lindolfo Monteiro e Albertão (Teresina), Felipão(Altos), Arena Ytacoatiara (Piripiri), Deusdeth de Melo (Campo Maior) e HelvídioNunes (Picos) deverão ser utilizados no estadual. O Parnahyba, por outro lado, aindanão definiu em qual estádio mandará seu jogos em 2017. - Eles (clubes) têm obrigações de entregar as certidões negativasaté o dia 25 de novembro, mas temos que ter a coerência em ver que algumascidades mudaram os prefeitos. Então, ele pode apresentar até 20 dias antes dojogo, ou seja, dia 14 de janeiro se não me engano. Tem bastante tempo para queisso seja possível – avaliou Cesarino Oliveira, presidente da FFP.",
					Editoria="4 de julho"
				},
				new Informacao()
				{
					Titulo="Por lesão, atacante e zagueirodo Paysandu estão fora da Série B", 
					DataHora="26/10/2016 11:01",
					Corpo="Jobinho tem lesão de grau 3 na coxa e fica fora do restante da temporada (Foto: Fernando Torres / Ascom Paysandu) O departamento médico do Paysandu divulgou os resultados dos exames feitos pelos três jogadores que estão no DM do clube. Segundo Vitor Sampaio, diretor de futebol do Papão, o zagueiro Gualberto e o atacante Jobinho sofreram uma lesão de grau 3 na coxa e estão fora do restante da Série B do Brasileiro. Já Gilvan teve um estiramento na panturrilha e segue tratamento. Na equipe de Dado Cavalcanti, Jobinho vinha sendo utilizado como titular. Com a baixa, Bruno Veiga deve ganhar a posição no ataque bicolor, jogando ao lado de Leandro Cearense. Alexandro, Maílson e Rivaldinho também estão à disposição do técnico. Com Gilvan em tratamento e sem tempo de recuperação para a partida diante do Sampaio Corrêa, no próximo sábado, no Mangueirão, em Belém, Dado tem as opções de Domingues e Pablo para formarem a zaga titular com Fernando Lombardi. O volante Rodrigo Andrade, que recebeu o terceiro cartão amarelo, cumprirá suspensão contra os maranhenses. Ilaílson, recuperado de lesão, disputa a vaga. Além dele, Lucas também é uma alternativa no meio-campo do Papão. Ricardo Capanema ainda realiza trabalhos de transição entre treinos combola e preparação física, e não deve ter condições de jogo. *Colaborou Kaio Rodrigues, com supervisão de Gustavo Pêna. saiba mais Novidade: Parazão 2017 terá apenas um turno. Confira os grupos: Paysandu x Sampaio Corrêa: venda de ingressos inicia nesta quarta-feira Papão foi o último clube de Carlos Alberto Torres como técnico. Robgol relembra",
					Editoria="Paysandu"
				},

				new Informacao()
				{
					Titulo="Bisping diz que fez acordo verbal para enfrentar GSP, mas Dana desmente", 
					DataHora="26/10/2016 11:00",
					Corpo="Michael Bisping disse que aceitou verbalmente luta contra GSP em Toronto (Foto: Evelyn Rodrigues) Campeão peso-médio do Ultimate, Michael Bisping usou a sua conta do Twitter para revelar que aceitou verbalmente um duelo contra Georges St-Pierre no UFC 206, previsto para 10 de dezembro, em Toronto, no Canadá. \"@GeorgesStPierre todos nós queremos mais dinheiro, mas vamos lá, assine o contrato. Dê às pessoas de Toronto o que elas querem, seja um herói! Vamos lá campeão\" - escreveu o inglês, explicando a seus seguidores que concordou verbalmente com o duelo e que o combate vinha sendo negociado há alguns dias. Apesar das declarações de Bisping, o presidente do UFC, Dana White, disse ao site \"MMA Junkie\" que a luta não iria acontecer: - Não existe isso de GSP x Bisping em Toronto. Sei que é isso que o Mike quer, mas essa luta não vai acontecer - garantiu. Os comentários do lutador inglês acontecem uma semana depois que Georges St-Pierre anunciou o fim de seu contrato com o Ultimate . Apesar do canadense afirmar que está livre para negociar com outras organizações, o UFC emitiu um comunicado na semana passada afirmando que ele ainda estava sob contrato com a companhia . Assine o Combate e assista ao vivo e com exclusividade a todos os eventos do UFC saiba mais   Home Combate.com: saiba tudo sobre MMA Blog UltiMMAto: bastidores e curiosidades Clique aqui e assista a vídeos de lutas Assine o Combate Play e veja mais de 1.500 lutas",
					Editoria="Combate"
				},

				new Informacao()
				{
					Titulo="Libertadores, Real Madrid... Róger Guedes quer Brasileiro como 1º passo", 
					DataHora="26/10/2016 10:56",
					Corpo="Róger Guedes posa para foto em evento de fornecedora esportiva (Foto: Divulgação) Contratado pelo Palmeiras em abril deste ano, Róger Guedes podeconquistar seu primeiro título brasileiro com apenas 20 anos idade. Apósestrear como profissional pelo Criciúma em 2014, o atacante tem diversos sonhospara a carreira, ainda precoce. Levantar a taça da competição nacional emdezembro daqui a algumas semanas é o primeiro. VEJA A TABELA DO BRASILEIRÃO Gaúcho da cidade de Ibirubá, no interior do Rio Grande do Sul, RógerGuedes vive, desde os primeiros anos de idade, dentro do futebol. Até os 3,morava embaixo de uma arquibancada, já que o pai era presidente de um clubeamador no local. Aos 9, foi para as categorias de base do Grêmio. Agora,pode ser campeão pelo Palmeiras. – Neste momento (meu objetivo) é conquistar o Campeonato Brasileiro como Palmeiras, será um momento marcante na minha carreira. Tenho o sonho de jogarlá fora também, atuar pelo Real Madrid seria sensacional. Isso vem desdepequeno, por conta do time dos Galácticos. Mas, claro, não descarto outrostimes como Manchester City ou Barcelona, por exemplo – contou Róger, em entrevistadurante evento de uma fornecedora esportiva.  LEIA TAMBÉM: Oferecido, meia do Atlético Nacional, volta a entrar no radar do Palmeiras Guedes não sentiu o peso da camisa palmeirense. Rapidamente se adaptouao clube e virou titular com o técnico Cuca. Na campanha do Brasileirão,disputou 26 dos 32 jogos até aqui. O estilo baseado na velocidade encaixou bemno perfil da equipe desejado pelo treinador.  Com o Verdão garantido na Taça Libertadores da América de 2017, RógerGuedes quer ter a chance de encarar um time argentino e também levantar otroféu continental. Neste ano, ele não teve a chance de jogar o torneio peloPalmeiras: o clube acabou eliminado ainda na primeira fase.  – Tenho muita vontade de jogar a Libertadores, jogar contra um timeargentino. Quando vim para o Palmeiras isso quase foi possível, mas nãoconseguimos passar adiante. Vencer a taça Libertadores seria incrível. Lá fora,a Champions League é um grande sonho também – contou. E MAIS: O que Gabriel Jesus ainda pode fazer antes de se despedir do Palmeiras Róger Guedes brinca com a bola em evento de um patrocinador (Foto: Divulgação) – Estou onde estou graças a Deus e minha família, meus pais, minhaesposa que me ajuda muito e meu filho recém-nascido (dez meses). Quando olhopra trás e vejo tudo que passei, toda dedicação, fico feliz. Tenho apenas 20anos, ainda tem muita bola pela frente e espero conquistar vários títulos. Para conquistar o Brasileirão, o Palmeiras depende somente de si. Com 67 pontos, a equipe enfrentará o Santos, no próximo sábado, às 19h30 (horário de Brasília), na Vila Belmiro.",
					Editoria="Palmeiras"
				},

				new Informacao()
				{
					Titulo="Defesa em alta: Jackson avalia sistema defensivo tricolor na era Guto Ferreira", 
					DataHora="26/10/2016 10:45",
					Corpo="Jackson avaliou o desempenho da defesa do Bahia (Foto: Felipe Oliveira/EC Bahia/Divulgação) Motivo de preocupação no início da temporada, a defesa doBahia se tornou um dos pontos fortes do time na Série B do Campeonato Brasileiro.Com 27 gols sofridos, a retaguarda tricolor é a terceira menos vazada daSegunda Divisão, atrás apenas de Londrina (23) e Atlético-GO (25). Setor dedestaque, o sistema defensivo chegou a ser questionado no início da competição.Mas ganhou nova cara e números mais positivos a partir da chegada do técnicoGuto Ferreira, em junho.  Antes de Guto, o Bahia disputou dez jogos na SérieB e foi vazado 14 vezes, média de 1,16 gol sofrido por partida. Com a chegadado treinador, o time entrou em campo em 20 oportunidades, com 12 gols sofridos,média de 0,6 por jogo.  O zagueiro Jackson participou das duas fases da defesa doBahia e comentou o assunto nesta terça-feira. Segundo o defensor tricolor, os treinos sob ocomando de Guto Ferreira foram fundamentais para o time subir de produção nosetor defensivo e passar a ter mais eficiência em parar as jogadas adversárias.  - Ele [Guto] trabalha muito bem a linha de quatro,defensiva. Isso é o principal motivo para que a gente tome poucos gols. (...) Posicionamento,na ação. Ele nos indica o momento certo da ação. E principalmenteposicionamento. Isso é o mais importante - avaliou. Jackson apontou treinos como motivo de evolução do setor defensivo (Foto: Felipe Oliveira/EC Bahia/Divulgação) Jackson conta que outro ponto importante para o bomdesempenho da retaguarda tricolor está no entrosamento dos jogadores do setor.Ele diz que conversa constantemente com Lucas Fonseca e Éder, reservas dadefesa, e também com Tiago, com quem faz dupla na equipe titular.  - Não só o entendimento entre eu e o Tiago. Mastodos os zagueiros. Converso bastante com o Lucas, o Éder, para manter o nívelde atuação, um ajudando o outro. Para que o Bahia seja o maior beneficiado.  A defesa tricolor será colocada à prova no próximo sábado, napartida contra o Ceará, marcada para as 16h (horário de Salvador), na ArenaFonte Nova. Jackson espera um jogo aberto, no qual defesa e ataque terãobastante trabalho. E ele até prefere que seja assim.  - Eu mesmo acho melhor jogar com um time desse, que joga edeixa a gente jogar. Isso é bem melhor. Acredito que será um bom jogo. Esperoque o torcedor possa estar na Arena para nos ajudar – finalizou o defensor.SAIBA MAIS Com Renê Junior no meio e Moisés à parte, elenco treina no Fazendão Expulso contra o Oeste, Guto Ferreira não fica no banco contra o Ceará Em súmula, árbitro relata xingamento de Guto: “Trio catarinense de m...” Luiz Antônio e Misael recebem o terceiro amarelo e não enfrentam o Paraná Fique por dentro das notícias do esporte baiano Clique aqui e assista a vídeos do Bahia",
					Editoria="Bahia"
				},
			};
		}

		List<Informacao> getListEconomia()
		{
			return new List<Informacao>
			{
				new Informacao()
				{
					Titulo="Confiança do consumidor tem alta de 2,4% em outubro, diz CNC",
					DataHora="26/10/2016 10:32",
					Corpo="Segundo a CNC, consumidor ainda tem cautela nas compras (Foto: Marcelo Camargo/Agência Brasil) O indicador que mede a intenção de consumo das famílias (ICF) teve aumento de 2,4% em outubro na comparação com setembro, segundo a Confederação Nacional do Comérciox de Bens, Serviços e Turismo (CNC). Já na comparação anual, o índice registra queda de 5,7%. O ICF em outubro ficou em 73,9 pontos na escala que vai de 0 a 200. Em setembro, o índice foi de 72,1. Segundo a CNC, o resultado indica que o consumidor ainda mantém cautela na hora das compras, já que segue bem abaixo da chamada zona de indiferença, que é de 100 pontos. “A inflação e a recuperação do mercado de trabalho ainda são os principais motivos que justificam essa cautela do consumidor”, explicou Juliana Serapio, assessora Econômica da CNC. Dentre os sete componentes da pesquisa, o único a ultrapassar a zona de indiferença foi o “Emprego Atual”, que ficou em 105,6 pontos. Na comparação com setembro, este índice subiu 0,8%, mas teve queda de 0,4% em relação a outubro do ano passado.Queda no consumo Segundo a CNC, 63,6% das famílias declarou estar com nível de consumo menor que em 2015. Na comparação com o ano passado, o índice teve retração de 17,6%. Entre setembro e outubro, porém, registou ligeira alta de 2,3%. Também na comparação anual segue em queda o índice das compras a prazo. Ante outubro de 2015, a queda foi de 11,7%. Em relação a setembro, houve alta de 2,2%.Perspectivas profissionais Quase metade das famílias (46,2%) considera negativo o cenário profissional para os próximos seis meses, segundo a pesquisa. Ainda assim, o índice que mede as perspectivas profissionais registrou aumento tanto na comparação mensal como na anual – respectivamente 1,4% e 0,8%.",
					Editoria="Economia"
				},
				new Informacao()
				{
					Titulo="Confiança do consumidor atinge maior patamar em quase 2 anos", 
					DataHora="26/10/2016 09:49",
					Corpo="A confiança do consumidor subiu pelo sexto mês seguido e atingiu em outubro o maior nível em quase dois anos, segundo dados divulgados nesta quarta-feira (26) pela Fundação Getúlio Vargas (FGVx). Segundo a pesquisa, o índice que mede a confiança dos consumidores atingiu 86,6 pontos no mês, uma alta de 1,8 pontos em relação a outubro de 2015. É o maior patamar desde dezembro de 2014. “A recuperação da confiança dos consumidores continua a ser comandada pelas expectativas”, disse em nota Viviane Seda Bittencourt, coordenadora da sondagem do consumidor. “Apesar da tendência ainda declinante do mercado de trabalho, as perspectivas de desaceleração da inflação e de queda das taxas de juros parecem contribuir para previsões menos pessimistas em relação à evolução das finanças familiares e para as perspectivas de compras de duráveis no curto prazo. ” O levantamento aponta recuperação da confiança entre os consumidores de todas as faixas de renda, mas, entre os que têm menor poder aquisitivo, a alta foi mais expressiva.",
					Editoria="Economia"
				},

				new Informacao()
				{
					Titulo="Índice de Preços ao Produtor sobe 0,47% em setembro, diz IBGE", 
					DataHora="26/10/2016 09:02",
					Corpo="Atividades extrativistas como mineração tiveram registraram o maior avanço de preços entre as demais analisadas pelo IBGE (Foto: Agência Vale/Agência Pará) Em setembro, os preços da indústria tiveram variação positiva de 0,47% na comparação com o mês anterior, segundo dados divulgados nesta quarta-feira (26) pelo Instituto Brasileiro de Geografia e Estatística (IBGEx). Em agosto, houve queda de 0,25%. O IPP das Indústrias Extrativas e de Transformação mede a evolução dos preços de produtos \"na porta de fábrica\", sem impostos e fretes. Ele abrange informações por grandes categorias econômicas, ou seja, bens de capital, bens intermediários e bens de consumo (duráveis e semiduráveis e não duráveis). No ano, o indicador acumula queda de 0,46% e em 12 meses tem alta de 0,52%. Entre as 24 atividades das indústrias extrativas e de transformação, 14 apresentaram variações positivas de preços, contra 11 do mês anterior. As maiores influências vieram de indústrias extrativas (0,24 ponto percentual), alimentos (0,20 p.p.), metalurgia (-0,09 p.p.) e outros produtos químicos (0,07 p.p.). Atividades industriais De acordo com o IBGE, em setembro, as indústrias extrativas registraram o maior avanço de preços: 8,19%, segunda alta mensal consecutiva. O IBGE destacou a retomada da demanda na siderurgia chinesa e a recuperação dos preços do minério ao longo do ano. Os preços dos alimentos subiram 0,94%, após queda em agosto (-0,69%). A alta de setembro foi menor do que as observadas entre maio e julho (superiores a 1%). Segundo o IBGE, o resultado foi influenciado pelo período de entressafra da soja, baixa disponibilidade de bois para abate e oferta interna reduzida e demanda mais alta por carnes e miudezas de aves congeladas. Metalurgia registrou queda de -1,24% em relação a agosto, a mais intensa entre as atividades da pesquisa, quebrando a série de quatro aumentos consecutivos nos meses anteriores. Papel e celulose teve a 8ª queda seguida (- 0,36%) em relação ao mês anterior. Desde dezembro de 2015, apenas o resultado de janeiro foi positivo (2,28%), segundo o IBGE. O setor de refino de petróleo e produtos do álcool apresentou variação de preços de -0,16%, depois de -0,75% em agosto. Neste ano, apenas duas taxas mensais foram positivas - em junho, de 1,61%; e em julho, de 0,25%. A indústria química (outros produtos químicos) teve em setembro uma variação positiva de 0,76% em relação a agosto, invertendo as quedas dos dois meses anteriores. E o setor de veículos automotores teve variação positiva de 0,58%.",
					Editoria="Economia"
				},

				new Informacao()
				{
					Titulo="'Desaposentação' volta nesta quarta à pauta do Supremo", 
					DataHora="26/10/2016 05:00",
					Corpo="O Supremo Tribunal Federal (STF) incluiu na pauta de julgamentos desta quarta-feira (26) a possibilidade de uma pessoa aposentada que continua a trabalhar receber pensões maiores com base nas novas contribuições à previdência pública, a chamada \"desaposentação\". Na sessão, a Corte voltará a analisar três ações, cujo julgamento começou em 2010. Ao todo, dos 11 ministros do STF, quatro proferiram seus votos, mas ainda faltam os demais. Para esta quarta é esperado, por exemplo, o voto da ministra Rosa Weberx, especialista em causas trabalhistas. A \"desaposentação\" é foco de preocupação do governo federal, que administra o Instituto Nacional do Seguro Social (INSS). Em 2014, o então representante do órgão, Marcelo de Siqueira Freitas, informou que havia em andamento na Justiça 123 mil processos sobre o assunto e que o impacto para os cofres públicos, caso aprovada a \"desaposentação\", seria de até R$ 70 bilhões, ao longo de 20 anos. Quando o STF concluir o julgamento dessas ações, a decisão a ser tomada terá a chamada repercussão geral, ou seja, deverá ser seguida por todas as demais instâncias judiciais. 'Desaposentação'O que é? A \"desaposentação\" é utilizada por quem continuou a trabalhar depois de aposentado, mantendo contribuições à Previdência Social. Ao fazer as contas anos depois, a pessoa percebe que seu benefício teria sido superior consideradas as condições atuais. O beneficiário, então, pede à Justiça para renunciar à aposentadoria anterior e requerer uma nova, com base em cálculo atualizado da idade e tempo de contribuição. Na última segunda (24), duas entidades que defendem a \"desaposentação\" – o Instituto Brasileiro de Direito Previdenciário (IBDP) e a Confederação Brasileira de Aposentados e Pensionistas (Cobap) – pediram para o STF adiar o julgamento, sob a justificativa de que o tema deverá ser discutido na reforma da Previdência a ser analisada no Congresso Nacional. Caberá à presidente do STF, Cármen Lúcia, decidir se adia novamente a análise das ações na Corte. Pedidos As ações a serem julgadas pelo STF envolvem várias situações. Numa delas, se discute se o aposentado que já recebe pensões da previdência é obrigado a continuar contribuindo para o INSSx, sem direito a aumentar o valor do que recebe mensalmente. Em outro caso, um aposentado busca transformar sua aposentadoria parcial em integral, com base nas novas contribuições. Na ação, o INSS argumenta que, para isso, ele teria de devolver todas as pensões já recebidas a partir da primeira aposentadoria. Há ainda o caso de uma aposentada que renunciou ao benefício por tempo de contribuição para obter a aposentadoria por idade pelo fato de ter continuado recolhendo para o INSS. Todas essas situações estão sendo analisadas pelos ministros para formular uma regra comum, com base no que prevê a Constituição Federal. saiba maisEm meio a impasse dos vetos, Câmara aprova 'desaposentadoria'Desaposentadoria continua incerta na Justiça em meio a 'chuva' de pedidosMinistra pede vista, e decisão sobre desaposentação é novamente adiadaNo Supremo, relator vota a favor da validade da 'desaposentadoria'STJ define critério para cálculo da 'desaposentadoria'  Votos Até o momento, quatro ministros já votaram no caso: Marco Aurélio Mellox e Luís Roberto Barrosox, ambos relatores das ações, além de Dias Toffolix e Teori Zavasckix. Primeiro a se manifestar, ainda em 2010, Marco Aurélio teve uma posição mais favorável aos aposentados. Em seu voto, propôs um  recálculo no valor das pensões sem que a pessoa precisasse de abrir mão do benefício que já recebe. Em 2014, ao votar, Dias Toffoli foi contra a \"desaposentação\". Para ele, a aposentadoria é \"irrenunciável\", e pedir uma nova com base nas últimas contribuições derrubaria o fator previdenciário, mecanismo que beneficia quem espera mais tempo para se aposentar. Na mesma ocasião, Luís Roberto Barroso votou a favor da \"desaposentação\", mas de forma diferente de Marco Aurélio. Para o ministro, a pessoa que \"desaposentar\" não precisaria devolver os valores já recebidos, mas deverá ter o novo benefício calculado de forma distinta daquele realizado para a primeira aposentadoria, de modo a aumentar menos o valor final. Por fim, Teori Zavascki, o último a votar, foi contra a \"desaposentação\". Para ele, ao legislar sobre o tema, o Congresso já deixou claro que o aposentado que continua a trabalhar não pode ter as contribuições posteriores levadas em conta. Além disso, argumentou que a contribuição do aposentado teria a única finalidade de ajudar a custear o sistema. Para a decisão, faltam agora os votos de Rosa Weber, Edson Fachin, Luiz Fuxx, Ricardo Lewandowskix, Gilmar Mendesx, Celso de Mellox e Cármen Lúciax.",
					Editoria="Economia"
				},
			};
		}

		List<Informacao> getListMundo()
		{
			return new List<Informacao>
			{
				new Informacao()
				{
					Titulo="Estado Islâmico contém Exército do Iraque ao sul de Mossul", 
					DataHora="26/10/2016 11:10",
					Corpo="Civis passam por Tob Zawa, a 9 km de Mossul, durante ofensiva expulsar o EI (Foto: Khalid Mohammed/AP) Combatentes do Estado Islâmicox mantiveram nesta quarta-feira (26) sua defesa feroz contra as investidas ao sul da cidade de Mossul, segundo a Reuters. A resistência dos jihadistas conteve as tropas iraquianas que atuavam nessa frente de batalha e obrigou uma unidade de elite do Exército no leste da cidade a adiar um avanço mais rápido. Dez dias após o início da ofensiva, o Exército do Iraquex e unidades da polícia federal iraquiana estão tentando desalojar os militantes de vilarejos na região de Shora, 30 km ao sul da segunda maior cidade do Iraque. As frentes de batalha de outras áreas se aproximaram muito mais dos limites de Mosul, a última grande cidade do país sob controle dos militantes, que a ocupam desde 2014. A unidade de elite do Exército que se aproximou pelo leste freou seu avanço ao se acercar de áreas construídas, esperando as outras forças de ataque para preencher a lacuna. \"À medida que as forças iraquianas chegam mais perto de Mossul, vemos que a resistência do Estado Islâmico está ficando mais forte\", disse o major Chris Parker, porta-voz da coalizão na base aérea de Qayyara, ao sul de Mossul, que serve como foco da campanha. Refugiados O combate adiante provavelmente será mais difícil e mortífero porque 1,5 milhão de moradores permanecem na cidade, e as projeções mais pessimistas estimam que até um milhão deles podem ser obrigadas a fugir, de acordo com a Organização das Nações Unidas (ONUx). Agências de assistência da ONU disseram que até agora os confrontos forçaram cerca de 10.600 mil pessoas a deixar seus lares. Segundo a France Presse, só na terça, autoridades registraram o maior número de deslocados em apenas um dia desde o início da ofensiva com mais de 3.300 pessoas atendidas. Lise Grande, coordenadora humanitária da ONU para o Iraque, disse à Reuters na terça-feira que um êxodo em massa pode ocorrer, talvez já nos próximos dias. Refugiada iraquiana observa tendas do acampamento de refugiados de Al-Hol , na Síria, na terça-feira (25) (Foto: Delil Souleiman / AFP) No pior dos cenários, Lisa disse que também é possível que combatentes do Estado Islâmico que controlaram Mossul durante mais de quatro anos recorram a \"armas químicas rudimentares\" para conter o ataque iminente. A batalha pode se tornar a maior dos 13 anos de tormento desencadeados pela invasão do Iraque liderada pelos Estados Unidos em 2003, e a queda de Mossul marcaria a derrota efetiva do grupo no país. Foi de sua Grande Mesquita que o líder do Estado Islâmico, Abu Bakr al-Baghdadi, declarou um \"califado\" que ainda engloba partes da Síria. O secretário de Defesa dos EUA, Ashton Carter, disse na terça-feira que o ataque a Raqqa, principal bastião do Estado Islâmico na Síria, irá começar enquanto a batalha de Mossulx transcorre. Uma autoridade norte-americana de alto escalão disse que cerca de 50 mil tropas terrestres iraquianas estão participando da ofensiva -- uma força principal de 30 mil soldados das Forças Armadas do governo, 10 mil combatentes curdos e 10 mil policiais e voluntários locais. Unidades do Exército do Iraque estão no sul e no leste, e os combatentes curdos estão atacando do leste e do norte da cidade, onde entre 5 e 6 mil jihadistas estão entrincheirados, de acordo com estimativas dos militares iraquianos. Cerca de 5 mil forças dos EUA também estão no Iraque. Mais de 100 delas estão aconselhando comandantes de forças iraquianas e curdas peshmerga e ajudando os aviões da coalizão a atingirem seus alvos, mas não estão atuando nas frentes de batalha.",
					Editoria="Mundo"
				},

				new Informacao()
				{
					Titulo="Afegã famosa por capa de revista é presa no Paquistão", 
					DataHora="26/10/2016 10:47",
					Corpo="Gula foi imortalizada em capa da revista National Geographic em 1985 (Foto: Reprodução/ National Geographic) A menina afegã que ficou famosa por seus olhos verdes em uma capa da revista National Geographic em 1985 foi detida nesta quarta-feira (26) no Paquistãox por posse ilegal de um documento de identidade nacional desse país, onde vive em um campo de refugiados. Sharbat Gula, imortalizada pelo fotógrafo Steve McCurry, obteve supostamente documentos de identidade paquistaneses para ela e dois supostos filhos após subornar três funcionários, disse à Agência Efe um agente da Agência de Investigação Federal (FIA). A refugiada afegã de 46 anos, que não tem nacionalidade paquistanesa, será levada para uma prisão para mulheres, onde esperará até que um tribunal veja seu caso, e pode pegar uma pena de prisão de até sete anos. \"Ela pode ser expulsa do país\", disse a FIA. A polícia procura, além disso, os dois supostos filhos de Gula para detê-los. A agência federal começou a investigar seu caso em fevereiro de 2015, em um momento no qual foram revelados vários casos de refugiados afegãos que tratavam de obter documentos paquistaneses para não ser expulsos do país. Sharbat Gula foi detida por posse documento de identidade falso (Foto: FIA/AFP) O Paquistão abriga 1,4 milhão de afegãos registrados legalmente e outros 900 mil em situação ilegal, o que os transforma em uma das maiores e mais antigas comunidades de deslocados do mundo que começou a chegar a território paquistanês com a invasão soviética em 1979. Cerca de 456 mil desses refugiados retornaram ao Afeganistãox neste ano, a grande maioria nos últimos três meses, perante o ultimato do governo paquistanês para que abandonem o país. Gula foi imortalizada pelo fotógrafo americano Steve McCurry em um campo de refugiados da cidade de Peshawar em 1985. Seu rosto envolvido em um lenço vermelho e seus poderosos olhos verdes transformaram a imagem da menina em um ícone da fotografia contemporânea. McCurry voltou a fotografar Gula 17 anos mais tarde no Afeganistão e descobriu que a mulher, que então tinha 30 anos, desconhecia sua fama internacional.",
					Editoria="Mundo"
				},
				new Informacao()
				{
					Titulo="Espanha sob pressão para que negue escala da frota russa em Ceuta", 
					DataHora="26/10/2016 10:33",
					Corpo="Para Otan, Rússia pretende usar porta-aviões para lançar ataques na Síria (Foto: Gareth Fuller/PA Wire/AP)   A Espanhax está nesta quarta-feira (26) sob pressão de seus aliados para que negue a uma frota russa a caminho da Síria a possibilidade de reabastecer em seu porto de Ceuta, depois de ter autorizado esta ação. \"As últimas escalas solicitadas estão sendo revisadas neste momento em função da informação que estamos recebendo de nossos aliados e das próprias autoridades russas\", indicou o ministério espanhol de Relações Exteriores em um e-mail. Esta declaração confirma implicitamente as informações de que estes navios têm permissão para reabastecer em Ceuta, um enclave espanhol em território marroquino em frente a Gibraltar. O ministério acrescentou que embarcações russas fazem escala há vários anos em portos da Espanha, integrante da Otan, embora elas sejam autorizadas caso a caso, levando-se em conta - em primeiro lugar - \"a segurança do entorno, da população e do porto\". A Rússia anunciou em meados de outubro que seu porta-aviões \"Almirante Kuznetsov\" se dirigia à Síria, com aviões e helicópteros de combate, para reforçar sua presença militar na zona. O secretário-geral da Otan, Jens Stoltenberg, demonstrou sua preocupação na terça-feira sobre a possibilidade da participação desta frota em bombardeios na Síria. \"Cada país deve decidir se estes barcos podem obter provisões e combustível em diferentes portos em sua rota em direção ao leste do Mediterrâneo\", indicou. Mas \"acredito que todos os aliados da Otan estão cientes de que este grupo de combate pode ser usado para realizar ataques aéreos contra Aleppo e Síria\", acrescentou. Por sua vez, o Reino Unido indicou que \"o governo de sua Majestade expressou previamente suas preocupações ao governo espanhol sobre sua hospitalidade à marinha de guerra russa\" através de um porta-voz britânico na noite de terça-feira. No entanto, também indicou que cabe a Madri decidir quem dá acesso aos seus portos. 57 embarcações russas Para o presidente do grupo liberal no Parlamento europeu, Guy Verhofstadt, \"é chocante que a Espanha, integrante da Otan e da UE, permita que a frota russa do (porta-aviões) Kuznetsov abasteça e receba assistência técnica em território espanhol\", escreveu no Twitter. \"A Espanha assinou a declaração sobre os crimes de guerra russos em Aleppo na semana passada e esta quarta-feira ajuda a reabastecer sua frota em seu caminho para cometer mais atrocidades. É sério?\", se perguntou. De acordo com a consultoria estratégica americano Heritage Foundation, até agosto de 2015 um total de 57 embarcações russas fizeram escala em portos espanhóis. O \"think tank\" denunciou o fato de as escalas terem continuado após a anexação da Crimeia por parte de Moscou em 2014, ao mesmo tempo em que indicou que a Grécia, outro sócio da Otan, e Malta, membro da União Europeia, mas não da Aliança Atlântica, também abriram seus portos à marinha de guerra russa.",
					Editoria="Mundo"
				},

				new Informacao()
				{
					Titulo="Quatro criminosos brasileiros escapam de cadeia no Paraguai", 
					DataHora="26/10/2016 10:00",
					Corpo="Criminosos brasileiros fugiram da cadeia de Emboscada, no Paraguai (Foto: Reprodução/Ministerio de la Defensa Pública) Quatro criminosos brasileiros, entre eles um que pertenceria a uma facção que atua dentro e fora de presídios no Brasil, fugiram durante a madrugada desta quarta-feira (26) da cadeia de Emboscada, no Paraguai, segundo a imprensa paraguaia. Um dos fugitivos já foi capturado. Julio Agüero, diretor do Sistema Penitenciário do Paraguai, confirmou, em entrevista à emissora de rádio 780 AM, que quatro detentos fugiram da cadeia e que todos eram de nacionalidade brasileira. Os presos que fugiram foram identificados como Valdecir Gonçalves, Mario Monteiro, Jhonatan Rodrigues Lima e Alan Lucena. “Todos os detentos que fugiram são brasileiros, mas o integrante da facção seria Valdecir Gonçalves”, disse Agüero. A fuga ocorreu por volta das 3h desta quarta-feira, mas a ausência só foi percebida pelos guardas da prisão às 6h, Segundo o diretor da penitenciária de Emboscada, Sergio Ruiz Diaz, um dos fugitivos foi capturado nas proximidades da cidade. Diaz disse foi aberta uma investigação para apurar se agentes penitenciários facilitaram a fuga. A prisão de Emboscada conta atualmente com 918 internos, acima de sua capacidade máxima que é de 700 presos.",
					Editoria="Mundo"
				},
			};
		}

		List<Informacao> getListTecnologia()
		{
			return new List<Informacao>
			{
				new Informacao()
				{
					Titulo="Apple dá 'spoiler' e revela nova barra sensível ao toque no MacBook Pro", 
					DataHora="26/10/2016 10:25",
					Corpo="Imagem divulgada pela Apple mostra MacBook Pro barra sensível ao toque no lugar de teclas de controle. (Foto: Divulgação/Apple) A Applex furou seu próprio lançamento e mostrou nesta terça-feira (25) os novos MacBooks Pro, que só deveriam ser apresentados ao mundo na quinta-feira (27). A novidade é que os computadores portáteis da empresa deixarão de ter teclas de controle, substituídas por uma barra sensível ao toque e um leitor de digitais. Saem botões como o “escape”, “liga/desliga” e os de regulação do volume. O “spoiler” da Apple do design do novo MacBook Pro foi dado por meio de imagens presentes na atualização do macOS Sierra, o sistema operacional que roda nos computadores da empresa. saiba maisApple anuncia iOS 10 e macOS Sierra no lugar do OS X; veja detalhes  As imagens mostram que a barra sensível ao toque poderá apresentar várias botões conforme o contexto de uso do computador. A imagem que mostra o leitor de digitais aparece na sessão de instruções para uso do Apple Pay, o sistema de pagamento da Apple. Aparentemente, os usuários poderão autorizar os transações financeiras online apenas tocando as digitais no aparelho –ações como essa já são feitas em iPhones e iPads, que possuem sensor de digitais. Só que, segundo essas imagens, o MacBook Pro também receberá a tecnologia de TouchID, que exibe mais opções de função conforme o usuário pressiona com mais força.",
					Editoria="Tecnologia e games"
				},

				new Informacao()
				{
					Titulo="Apple registra 1ª queda na receita em 15 anos", 
					DataHora="26/10/2016 09:31",
					Corpo="iPhones 7 Plus (modelos pretos) e 7 (rosa, dourado e prateado) foram revelados nesta quarta-feira (7) (Foto: Divulgação / Apple) A Apple anunciou nesta terça-feira (25) uma queda de 19% no lucro registrado no terceiro trimestre deste ano, devido a uma queda nas vendas de iPhone. A receita, por sua vez, sofreu a primeira queda desde 2001 no acumulado dos últimos 12 anos. O lucro líquido da empresa caiu para US$ 9,01 bilhões (US$ 1,67 por ação), ante US$ 11,12 bilhões (US$ 1,96 por ação) um ano antes. saiba maisiPhone 7, iPhone 7 Plus e Apple Watch 2 são anunciados; veja detalhes  A empresa de maior valor no mercado financeiro mundial informou que, entre julho e setembro, sua receita foi de US$ 46,9 bilhões, 9% inferior aos US$ 51,5 bilhões registrados no mesmo período do ano anterior. Quando considerado o ano fiscal, fechado em 24 de setembro, a Apple faturou US$ 215,6 bilhões, 8% abaixo dos US$ 233,7 bilhões registrados um ano. Essa é a primeira queda no faturamento em 15 anos. Os resultados se alinharam com as expectativas do mercado e mostraram que as vendas do iPhone -- principal fonte de renda da empresa -- caíram 5%, para 45,5 milhões de unidades nos trimestre. A Apple vendeu 48,05 milhões de smartphones no mesmo período do ano anterior. Foi o terceiro trimestre consecutivo de queda nas vendas de iPhone. O informe trimestral deu informação limitada sobre a recepção dos aparelhos iPhone 7 e 7 Plus, lançados no começo de setembro. Apesar disso, o diretor-executivo da Apple, Tim Cook, disse estar otimista com os novos modelos. \"Estamos contentes com a resposta dos clientes ao iPhone 7, iPhone 7 Plus e Apple Watch Serie 2 e também pelo incrível impulso dos nossos serviços de negócios, cujos ganhos aumentaram 24% para marcar outro recorde\", disse Cook, em um comunicado. Ele ainda considerou positivos os resultados e disse que \"coroam um bem sucedido ano fiscal de 2016\" para a companhia.",
					Editoria="Tecnologia e games"
				},

				new Informacao()
				{
					Titulo="Zenfone 3: celular tem boa câmera, mas Android modificado confunde", 
					DataHora="26/10/2016 06:00",
					Corpo="A Asus lançou no Brasil o Zenfone 3, smartphone que costuma bater de frente com iPhones e os aparelhos top de linha das famílias Galaxy e Moto. O novo celular da taiwanesa ganhou design mais moderno, uma câmera melhor --filma e fotografa bem, além de dispor de recursos profissionais--, e processador mais potente, o que deve agradar os gamers. O ponto negativo é o Android modificado e sua profusão de serviços, capaz de deixar perdido quem só está procurando o ícone da galeria de fotos. O G1 testou a versão padrão do Zenfone 3 (há ainda a Deluxe e a Max). Veja vídeo acima A Asus fez ainda duas novas adições importantes. Uma delas é a do sensor de digitais, posicionado na parte traseira do aparelho. Ele não só destrava o aparelho, como também aciona a câmera, tira fotos e atende ligações. saiba maisZenfone 3, novo top de linha da Asus, custa a partir de R$ 1,5 mil no Brasil  A outra é a do Game Genie, plataforma feita para jogadores de games móveis. Funcionando como uma camada rodando sobre a ação de jogos, o sistema permite a transmissão de partidas online no YouTube e Twitch e até melhora o desempenho do smartphone durante o gameplay. O Game Genie faz do Zenfone um candidato a queridinho de gamers viciados em aplicativos, em disputa acirrada com os Galaxy S7 e S7, que possuem o Game Launcher. A tela do Zenfone 3 permanece com tamanho de 5,5 polegadas e resolução Full HD do antecessor. O processador, no entanto, deu um pulo e agora é o Snapdragon 625 --um octa-core e com 2 GHz de velocidade, mais potente que o quad-core do Zenfone 2. As câmeras também deram um salto, de capacidade e nas funções. A traseira pode registrar fotos de 16 MP e a dianteira, de 8 MP. Só que acionando o modo Super Resolução, as imagens saem com até 64 MP. As filmagens feitas com o smartphone também evoluíram. Agora, pode ser registradas com resolução de 4K (ultra alta-definição, de 3840 x 2160 pixels) e possuem ajuste HDR em tempo real. O foco a laser ficou mais rápido: demora 0,03 segundo para deixar o objeto nítido. O design também mudou. Antes, o chassi era de plástico, e as costas do aparelho possuíam uma lombada que se encaixava na mão. O Zenfone 3 é feito em uma peça única de liga de alumínio, e a traseira é lisa e de vidro. A falta de encaixe pode deixar os desastrados de mãos abanando. O ponto negativo do Zenfone 3 é o software. A empresa aplicou a interface ZenUi ao Android 6.0. Em algumas situações, a modificação deixa o funcionamento do sistema confusa e esconde alguns recursos –onde estão minhas capturas de tela? Quem foi que tirou o modo Super Resolução do menu de configurações da câmera?. Com vários programas pré-instalados, o Zenfone 3 traz apps sobressalentes, como, por exemplo, os navegadores Puffin e Chrome, os de captura de imagem (Câmera e ZenFlash S Camera, de armazenamento (Drive e ASUS WebStorage). Com isso, o smartphone tem potencial para fazer os mais desavisados gastarem todo o tempo ganho com processamento e recursos eficientes em buscas por apps que não irão usar.",
					Editoria="Tecnologia e games"
				},

				new Informacao()
				{
					Titulo="Zenfone 3, novo top de linha da Asus, custa a partir de R$ 1,5 mil no Brasil", 
					DataHora="25/10/2016 21:22",
					Corpo="Zenfone 3, smartphone da Asus. (Foto: Divulgação/Asus) A Asus lançou seu novo smartphone Zenfone 3 nesta terça-feira (25) no Brasil, cinco meses após apresentar ao mundo o seu novo celular top de linha. O aparelho chega em duas versões. Uma com tela de 5,2 polegadas e 32 GB de armazenamento, por R$ 1,5 mil. E outra com display de 5,5 polegadas e 64 GB de armazenamento, por R$ 1,8 mil. O processador é o Snapdragon 625, um octa-core com 2 GHz de velocidade. As câmeras têm resolução de 16 MP (traseira) e 8 MP (dianteira). Diferentemente de seu antecessor, o Zenfone 3 é feito em uma peça única de liga de alumínio, e a traseira é lisa e de vidro. saiba maisZenfone 3: celular tem boa câmera, mas Android modificado confunde  Também foram apresentadas outras duas linhas de smartphones da Asus. O Zenfone 3 Max, mais simples, custa entre R$ 1 mil e R$ 1,3 mil, de acordo com o tamanho do espaço em disco. Já o Zenfone 3 Deluxe, modelo premium da família de celulares da Asus, tem um processador mais potente (Snapdragon 821) e câmera traseira de maior resolução, com 21 MP. Ele vai custar de R$ 3,6 mil a R$ 4,6 mil, também de acordo com a capacidade de armazenamento. Os aparelhos Zenfone geralmente rivalizam com iPhone (Apple) e Galaxy (Samsung) em aspectos técnicos, mas deixam os rivais para trás quando o assunto é fazer o consumidor coçar o bolso. As mudanças em relação ao Zenfone 2, lançado em 2015, são o design mais moderno, a câmera – que filma e fotografa bem e dispõe de recursos profissionais – e o processador mais potente. O novo smartphone também ganhou um sensor de digitais posicionado na parte traseira do aparelho e responsável por destravá-lo, acionar a câmera, tirar fotos e atender ligações. A Asus adicionou ainda a Game Genie, plataforma que transmite as partidas jogadas nos apps no YouTube e Twitch e até melhora o desempenho do smartphone durante o gameplay.",
					Editoria="Tecnologia e games"

				},
			};
		}

		private void CarregaXML(string tipo)
		{
			var rawData = new List<Informacao>();

			XDocument doc = XDocument.Load("http://www.connexweb.com.br/infonews/infonews.xml");

			IEnumerable<Informacao> informacoes =
				from item in doc.Descendants(tipo)
				select new Informacao()
				{
					Titulo = (string)item.Element("noticia").Element("titulo"),
					Corpo = (string)item.Element("noticia").Element("corpo"),
					Editoria = (string)item.Element("noticia").Element("editoria"),
					DataHora = (string)item.Element("noticia").Element("data_hora")
				};

			informacoes.ToList();

			foreach (var p in informacoes)
			{
				rawData.Add(new Informacao() { Titulo = p.Titulo, Corpo = p.Corpo, Editoria = p.Editoria });
			}

			lstInformacoes.ItemsSource = rawData;
		}

		void InfoSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var info = (Informacao)e.SelectedItem;
			var infoPage = new DetalheInformacaoPage();
			infoPage.BindingContext = info;

			Navigation.PushAsync(infoPage);
		}
	}
}
# Solucao Comitada

Arquivo (Linha, Posição) - Descrição
IOS:

    Pasta View - Mudança para a forma correta Views
    LoginPage.xaml (8,14) - adição x:Static
    HomePage.xaml(9,14) - adição x:Static
    DashboardItemTemplate.xaml(21,20) - adição x:Static local:
    DashboardItemTemplate.xaml(37,28) - adição x:Static local:AppConstants.
    DashboardItemTemplate.xaml(45,28) - adição x:Static local:
    DashboardItemTemplate.xaml(51,24) - adição x:Static local:
    MainActivity.cs(25) - Error CS0012: The type `Prism.Unity.PrismApplication' is defined in an assembly that is not referenced - Adição da dependência Prism.Unity.Forms`
    Foundation.MonoTouchException - Registro das páginas e serviços, troca de página no onInitialized


Android:

    Adição das bibliotecas do SQLite (Ao tentar iniciar a app gerava erro sem essa biblioteca)
    Criação do arquivo de conexão SQLiteConnection_Droid
    Adição da Biblioteca Arc.UserDialogs
    Adição das imagens a pasta Resources

# App Final - MIT Infnet

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

Boa noite pessoal. Aqui esta o nosso App, nele foram utilizados os seguintes tópicos estudados por nós nas aulas

  - MVVM
  - Data Bindings
  - Prism
  - SQLite
  - Consumo de Webservices através de interfaces genéricas
  - Gravação de dados e acesso através de repositório genérico
  - Injeção de dependência
  - Custom Renderers
  - Serviço de Dependência
  - Consumo de estilos através de AppConstants

Vocês deverão:
  - Corrigir o APP e torná-lo utilizável em ao menos uma plataforma (ideal tanto no iOS quanto no Android)
  - Apontar em qual arquivo e linha estava o erro e qual era
  - Apontar qual fora a solução aplicada

Após a conclusão do trabalho, por favor criem BRANCHS com os nomes das duplas, ex: Rodrigo&Thiago. Assim eu consiguirei pegar o código de cada um ou cada dupla. POR FAVOR ATENÇÃO AO ENVIAR, CRIAR UMA BRANCH NOVA NO REPOSITÓRIO SEGUINDO O PADRÃO DE NOME E FAZER O PUSH NESTA BRANCH

#######################################################

Aqueles que optarem por entregar um App "novo", seguir a especificação abaixo:

O App deve conter:

* De no mínimo 3 telas
* 1 tela de login, uma tela de lista com controle de lista, contendo evento de click, uma tela de exibição do selecionado na lista anterior
* Armazenamento de valores em banco de dados
* Consulta de dados de um webservices (use o mesmo utilizado no protótipo acima [https://randomuser.me]. Este webservice entrega uma lista de usuários
* Tanto banco de dados quanto serviços devem utilizar interfaces genéricas
* Utilizar o Prism MVVM
* Completa utilização do pattern MVVM
* Ao menos um 1 custom render
* Consumo de estilos via classe estática

Quais quer dúvidas ou problemas, me contactar no e-mail jbravo.br@gmail.com.

Entregas até o final do mês de novembro de 2016.

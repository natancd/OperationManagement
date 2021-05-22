# OperationManagement

Este projeto refere-se a parte 2 do Desafio Programação – Jornada Labs HAVAN.

1 - Linguagem

As linguages utilizadas são C# e SQL.
Projeto criado em Visual Studio 2019 - Windows Forms Apps (.NET Framework)


2 - O sistema

Consiste em um programa que tem duas principais funções ao iniciar o projeto: cadastro de operações (a - botão Cadastro) e relatórios (b - Relatórios).
a. Ao iniciar o projeto e clicar no botão Cadastro, uma nova tela onde alguns dados já virão pré preenchidos, mas alguns o usuário deve informar: nome e valor original.
Como parâmetro iniciais, a moeda de origem será o Dólar Canadense, a moeda de destino será o Real e a data será a data atual, sendo possível alterar os 3 como desejar.
Há algumas validaçõe:
- O nome não pode estar em branco e tem um limite de 100 caracteres;
- As moedas podem ser iguais para a conversão, mas não podem ser iguais para salvar no cadastro;
- O valor deve ser preenchido e somente aceita números.
- Se tudo estiver OK, uma mensagem de confirmação será exibida em um pop-up.

Há um botão Limpar na tela, que nada mais limpa os dados digitados e retorna os botões e campos para os valores iniciais.

b. Nesta tela somente há validação para o campo do nome do cliente: até 100 caracteres.
Há dois filtros de pesquisa que podem ou não ser preenchidos:
- Nome do cliente: caso esteja em branco, irá pesquisar todos os itens da database, seja por data ou não. A pesquisa será de forma independente, ou seja, poderá ser feita por um nome completo ou parte dele. 
Por exemplo: se pesquisar por "Ana" irá encontrar qualquer nome que esteja cadastrado com "ana" no nome, tais como Ana Paula, Eliana, Joana, Banana, etc.
- Data: por padrão a data não está liberada, mas há um checkbox que, se marcado, irá afetar a pesquisa e irá realizar a busca de acordo com as datas selecionadas. Por padrão a data inicial é a atual e a data final será o dia 29 de Maio.

Independente do filtro ser utilizado ou não, os três botões podem ser clicados a qualquer momento.

Botão Lista de Operações: realiza uma pesquisa na database de todas as operações e as lista no quadro da direita, na mesma sequencia.

Há dois botões radio num quadro de Valores: Origem e Convertidos, que irão definir o resultados das duas próximas pesquisas (foi feito este botão, pois a taxa pode ser considerada pelo valor de origem como do destino, explicado no ponto 4).

Botão Valor Total das Operações: realiza uma soma total dos valores de acordo com o filtro, se houver algum critério. Se o rádio Original estiver selecionado, irá realizar a pesquisa na database somente dos valores de origem cadastrados. Se for o Convertido, será somente os valores convertidos.

Botão Valor Total das Taxas Cobradas: realiza uma soma total dos valores de acordo com o filtro, se houver algum critério e cálcula 10% desse valor. Se o rádio Original estiver selecionado, irá realizar a pesquisa na database somente dos valores de origem cadastrados. Se for o Convertido, será somente os valores convertidos.

Para os dois botões de valores, somente um pop-up irá aparecer na tela informando o valor desejado de acordo com a pesquisa e seus respectivos filtros.

Há um botão Voltar, que retorna ao menu inicial.

3 - Configurações para uso

Há duas formas de testar o aplitativo:

A mais rápida:

1 - Baixar projeto em https://github.com/natancd/OperationManagement.git

2 - No diretório "OperationManagement\bin\Release" há o arquivo "OperationManagement.exe" que pode ser executado diretamente, desde que os demais arquivos da pasta estejam juntos.

Outra forma é dentro do compilador:

Abrir o projeto no mesmo link e executar no Visual Studio (eu utilizei a versão 2019, mas acredito que não deva ter problemas com a 2017).
Ao iniciar, é preciso conectar o arquivo mdf na database local da seguinte forma: "Data Connections > Adicionar Conexão". Mudar a Data Source para "Microsoft SQL Server Database File (SqlClient)" e pesquisar o arquivo "Database1.mdf" no diretório principal e testar a conexão.

Se estiver OK, basta confirmar a tela e rodar o projeto.

Pode haver problemas de conexão na database, sendo preciso alterar duas classes: frmRegister.cs e frmReports.cs. Logo no início do código há uma constante chamada "const string fileName". É preciso alterar este caminho para o local onde está salvo o arquivo "Database1.mdf". Uma forma de fazer isso sem pesquisar onde está o arquivo é clicar com o botão direito na Database1, no Server Explorer, e clicar em Propriedades. No Connection String haverá um caminho similar a este: "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\natan\Desktop\New folder\OperationManagement-main\Database1.mdf";Integrated Security=True". Basta somente copiar o valor do AttachDbFilename e substituir na constante das duas classes citadas anteriormente, mantendo o @.


4 - Considerações finais

Há alguns incrementos que poderiam afetar e melhorar o desempenho do programa:

1 - Um campo para alterar o valor da taxa, atualmente está fixa em 10% no código-fonte, mas é só alterar este valor na constante que os cálculos serão realizados corretamente.

2 - Um campo para adicionar os valores de conversão, como definido nas instruções do desafio. Atualmente estão definidos em constantes no código-fonte.

3 - A soma total dos valores ao pesquisar a Lista de Operações, na última linha ou em alguma label fora do listview.

4 - Validação para que sejam escritos pelo menos dois nomes no Nome Completo, ou dois campos para Primeiro Nome e Sobrenome.

5 - Pequenos detalhes que não estavam nos requisitos, mas que deixariam o uso do aplicativo mais suave tais como: data final automaticamente ajustada para uma data inicial fixa de acordo com a data inicial e filtros de pesquisa por valores de origem e de destino e data exibida somente no formato dd/mm/yyyy, sem a hora.

6 - O valor original e convertido ser pesquisado por filtros obrigatórios de moedas, para que não seja "errada" a pesquisa com valores diversos.

7 - Algumas pequenas redundancias de código, como strings definidas nas queries da database.

# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

+ ### Antônio Caetano

	<img src="https://get.pxhere.com/photo/man-person-portrait-senior-citizen-glasses-head-odyssey-plpconnectu-idaho-facial-hair-vision-care-military-officer-354914.jpg" alt="drawing" style="width:200px;"/>

	+ **Idade**: 61 anos

	+ **Ocupação**:  
	Serviços gerais

	+ **Aplicativos**:  
Whatsapp ; Google

	+ **Motivações**:
		+ Necessita de roupas que estão para doação

	+ **Frustrações**:  
		+ Dificuldade para encontrar roupas para doação
		+ Pouca facilidade no processo de retirada de roupas.
		
	+ **Expectativa**:  
		+ Interface intuitiva para facilidade na hora da escolha das roupas.
		+ Facilidade na navegação entre as janelas da aplicação.
      + Tornar o processo de retirada simples para aqueles que têm pouco 
      conhecimento de tecnologia.

+ ### Geovana Mendes

	<img src="https://images.pexels.com/photos/5255556/pexels-photo-5255556.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="drawing" style="width:200px;"/>

	+ **Idade**: 25 anos

	+ **Ocupação**:  
	Voluntária da ONG

	+ **Aplicativos**:  
Whatsapp ; Google ; YouTube; Intagram

	+ **Motivações**:
		+ Ajudar no proceso de distribuição de roupas para pessoas carentes.

	+ **Frustrações**:  
		+ Falta de uma platafoma que auxilie o processo.
		
	+ **Expectativa**:  
		+ Ambiente com capacidade de cadastro de qualquer peça, podendo categorizá-las em diversos tipos.
		+ O ambiente precisa possibilitar o cadastro de doadores atrelando as peças doadas por ele ao cadastro do mesmo.
      + A interface precisa ser simples para que qualquer colaborador tenha capacidade de gerenciar a aplicação.



## Histórias de Usuários

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|COLABORADOR DA ONG  | quero cadastrar doadores, tanto pessoas físicas quanto jurídicas | para ter controle de quem doou determinada peça e quanto doou de verba |
|COLABORADOR DA ONG  | quero cadastrar peças de roupas doadas | para deixá-las disponíveis aos beneficiados para que estes possam escolher conforme interesse |
|COLABORADOR DA ONG  | quero gerenciar o estoque de peças de roupas | para verificar a quem foram entregue e saber se o estoque está baixo |
|COLABORADOR DA ONG  | quero gerenciar o cadastro de candidatos | para selecionar novos colaboradores |
|COLABORADOR DA ONG  | quero inserir a logomarca de empresas parceiras na aplicação | para que os visitantes da aplicação saibam quais empresas apoiam a causa social da ONG |
|CANDIDATO À COLABORADOR DA ONG   | quero preencher meu cadastro de candidato | para participar como colaborador da ONG |
|INDIVÍDUO BENEFICIADO  | quero conseguir acessar a aplicação | para preencher meu cadastro e poder escolher roupas disponibilizadas pela ONG na aplicação |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| A aplicação deve possibilitar a navegação em seus diversos ambientes, conforme o objetivo do usuário. | ALTA | 
|RF-02| A aplicação deve apresentar informações gerais da ONG, colaboradores e patrocinadores.   | ALTA |
|RF-03| A aplicação deve disponibilizar um catálogo de todas as roupas disponíveis para doação. | ALTA | 
|RF-04| A aplicação deve possibilitar o filtro dos itens constantes no catálogo.   | ALTA |
|RF-05| A aplicação deve permitir que o usuário realize seu pedido. | ALTA | 
|RF-06| A aplicação deve permitir que os colaboradores cadastrem as informações no catálogo de itens.   | ALTA |
|RF-07| A aplicação deve ter uma área de login para colaboradores da ONG. | ALTA | 
|RF-08| A aplicação deve ser capaz de gravar informações de roupas, doadores e usuários.   | ALTA |
|RF-09| A aplicação deve conter uma área com um formulário para cadastro de candidatos para voluntariado.   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva sendo possível rodar em diversos tamanhos de tela. | ALTA | 
|RNF-002| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  ALTA | 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 04/07/2024.|
|RE-02| A aplicação deve se restringir às tecnologias básicas da Web no Frontend.|
|RE-03| A aplicação deve se restringir à linguagem de programação C#.|
|RE-04| A equipe não pode subcontratar o desenvolvimento do trabalho.|

## Diagrama de Casos de Uso

O diagrama de casos de uso utiliza um modelo gráfico dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos, conforme imagem a seguir:

![Diagrama de casos de uso - Cabide Solidário] (img/diagrama_de_casos_de_uso.png)

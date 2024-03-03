# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

+ ### Antônio Caetano

	<img src="https://get.pxhere.com/photo/man-person-black-and-white-white-street-photography-ebook-male-portrait-training-black-monochrome-facial-expression-smile-streetphotography-flickr-face-thomas-video-head-olympus-photograph-beauty-omd-fuji-leica-emotion-monochrom-leuthard-hcb-thomasleuthard-monochrome-photography-portrait-photography-film-noir-facial-hair-human-positions-321195.jpg" alt="drawing" style="width:200px;"/>

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



Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

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
|RF-01| A aplicação deve conter em sua página home uma área de navegação que interligue todas as áreas do site. | ALTA | 
|RF-02| A aplicação deve conter em sua página home informações gerais da ONG, colaboradores e patrocinadores.   | ALTA |
|RF-03| A aplicação deve conter em sua página home um botão que leve o usuário para área de catálogo de roupas. | ALTA | 
|RF-04| A aplicação deve conter uma página com um catálogo de todas as roupas disponíveis para doação, sendo possível filtrar as roupas por diversos tipos.   | ALTA |
|RF-05| A aplicação deve conter uma área onde o usuário poderá finalizar seu pedido. | ALTA | 
|RF-06| A aplicação deve permitir que o usuário cadastre suas informações.   | ALTA |
|RF-07| A aplicação deve ter uma área de gerenciamento para colaboradores da ONG. | ALTA | 
|RF-08| A aplicação deve ser capaz de gravar informações de roupas, doadores e usuário em tabelas no seu backend.   | ALTA |
|RF-09| A aplicação deve conter uma área com um formulário para cadastro de candidatos para voluntariado.   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva sendo possível rodar em diversos tamanhos de tela. | ALTA | 
|RNF-002| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  ALTA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 04/07/2024.|
|RE-02| A aplicação deve se restringir às tecnologias básicas da Web no Frontend.|
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho.|


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

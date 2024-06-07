# Plano de Testes de Software

Os requisitos para realização dos testes de software são:

* Navegador de internet: Google Chrome, Mozilla Firefox ou Microsoft Edge.
Os testes funcionais a serem realizados na aplicação são descritos a seguir.

Por exemplo:
 
| **Caso de Teste** 	| *CT-01 – Exibir informações do site*	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar informações gerais da ONG, colaboradores e patrocinadores. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar as informações de gerais da ONG, colaboradores e patrocinadores. |
| Passos 	| - Acessar a página home através do link da aplicação e rolar até o final da página para que possa visualizar todas a seções da aplicação. |
|Critério de Êxito | - A página home será acessada e as informações da aplicação estarão disponíveis para o usuário. |
|  	|  	|
| Caso de Teste 	| CT-02 – Acesso ao catálogo de roupas	|
|Requisito Associado | RF-002	- A aplicação deve disponibilizar um catálogo de todas as roupas disponíveis para doação. |
| Objetivo do Teste 	| Exibir para o usuário todos os itens disponíveis no catálogo. |
| Passos 	| - Acessar a página home através do link da aplicação <br> - Na página home, clicar em "ver todas as peças disponíveis" na seção "Roupas" da página e/ou clicar em "Catalogo" na barra de Menu <br> - Rolar a página para visualizar todas os itens disponíveis no catálogo <br> |
|Critério de Êxito | - Exibição na tela de todos os itens disponíveis no catálogo. |
|  	|  	|
| Caso de Teste 	| CT-03 – Filtros	|
|Requisito Associado | RF-003	- A aplicação deve possibilitar o filtro dos itens constantes no catálogo. |
| Objetivo do Teste 	| Verificar se os filtros estão aplicados conforme seleção do usuário. |
| Passos 	| - Acessar a página Catalogo através da barra de Menu da Home <br> - Na página Catalogo, Selecionar o Genero da peça de roupa ou inserir o codigo da mesma e clicar no botão "Filtrar" <br> - Utilizar os filtros disponíveis no Topo da aplicação. <br> |
|Critério de Êxito | - Serão exibidos para o usuário os itens conforme o filtro aplicado. |
|  	|  	|
| Caso de Teste 	| CT-04 – Cadastrar itens	|
|Requisito Associado | RF-005	- A aplicação deve permitir que os colaboradores cadastrem as informações no catálogo de itens. |
| Objetivo do Teste 	| Certificar que novos itens estão sendo cadastrados. |
| Passos 	| - Acessar a página home através do link da aplicação <br> - Na página home, clicar no icone de usuário na parte superior direita <br> - Realizar o login. <br> - Na página do "Dashboard", cadastrar novo item na seção "Cadastre um novo item". <br> |
|Critério de Êxito | - Será exibida na tela uma mensagem informando que o item foi cadastrado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-05 – Login	|
|Requisito Associado | RF-006	- A aplicação deve ter uma área de login para colaboradores da ONG. |
| Objetivo do Teste 	| Certificar que os voluntários conseguem logar. |
| Passos 	| - Acessar a página home através do link da aplicação <br> - Na página home, clicar em "sair" no Menu na parte superior direita <br> - Realizar o login. <br> |
|Critério de Êxito | - O voluntário terá acesso a área logada. |
|  	|  	|
| Caso de Teste 	| CT-06 – Armazenamento de informações 	|
|Requisito Associado | RF-007	- A aplicação deve ser capaz de gravar informações de roupas, doadores e usuários. |
| Objetivo do Teste 	| Verificar se as informações foram armazenadas. |
| Passos 	| - Acessar a página home através do link da aplicação <br> - Clicar em "sair" no Menu na parte superior direita e logar como valontário <br> - Na página home, clicar em "Dashboard" e em seguida "Cadastrar um novo item", preenchendo os dados de cadastro do item e clicando em "salvar" <br> Verificar se o ietm aparece listado no "Dashboard" e no Catalogo de itens <br> |
|Critério de Êxito | - As informações cadastradas poderão ser acessadas. |
|  	|  	|
| Caso de Teste 	| CT-07 – Cadastro de candidatos ao voluntariado |
|Requisito Associado | RF-008	- A aplicação deve conter uma área com um formulário para cadastro de candidatos para voluntariado. |
| Objetivo do Teste 	| Verificar se o candidato foi cadastrado. |
| Passos 	| - Acessar a página home através do link da aplicação <br> - Na página home, clicar em "Quero participar" da área "Seja um voluntário" <br> - Preencher os campos do formulário e clicar em "salvar" <br> |
|Critério de Êxito | - Cadastro do candidato aparecer listado para visualização do Admin. |

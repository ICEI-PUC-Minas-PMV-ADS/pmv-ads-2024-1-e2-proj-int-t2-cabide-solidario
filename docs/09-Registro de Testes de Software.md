# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT-01 – Exibir informações do site** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar informações gerais da ONG, colaboradores e patrocinadores. |
|Registro de evidência | [Screencast do teste de visualização das informações na página Home](https://drive.google.com/file/d/1chTPIPNJbQBA1nKHDWwdJK53E5UzfKYv/view?usp=sharing) |

| **Caso de Teste** 	| **CT-05 – Cadastrar itens** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir que os colaboradores cadastrem as informações no catálogo de itens. |
|Registro de evidência | [Screencast do teste do CRUD da tabela de roupas doadas](https://drive.google.com/file/d/1TlPXu1PD4IjaJwtTp3hg-D3xmQx3vuJI/view?usp=sharing) |

## Avaliação

O teste de exibição da página Home (CT-01) foi parcialmente bem-sucedida, pois apresenta as informações propostas, mas ainda falta vincular os links para as demais páginas da aplicação, assim como inclusão de logo e contraste da marca. É importante salientar que ainda não se encontra hospedado, tendo seu acesso local ainda.

O teste de Cadastro de intes (CT-05) foi bem sucedido apresentando todas as funcionalidades propostas, como criar, editar, visualizar e excluir itens, sendo armazenados no banco de dados SQL Server. Foi verificado que alguns campos de preenchimento do cadastro dos itens, como Tamanho e Gênero poderiam gerar dúvidas no preenchimento, sendo proposto a inclusão de enums para seleção pelo usuário. Embora não apareça no vídeo de teste, a sugestão foi acatada e corrigida, estando funcional.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)

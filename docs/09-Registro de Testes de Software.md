# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT-01 – Exibir informações do site** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar informações gerais da ONG, colaboradores e patrocinadores. |
|Registro de evidência | [Screencast do teste de visualização das informações na página Home](https://drive.google.com/file/d/1chTPIPNJbQBA1nKHDWwdJK53E5UzfKYv/view?usp=sharing) |

| **Caso de Teste** 	| **CT-02 – Acesso ao catálogo de roupas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve disponibilizar um catálogo de todas as roupas disponíveis para doação. |
|Registro de evidência | [Screencast do teste de visualização do catálogo de itens](https://drive.google.com/file/d/1czHKDv8ak72JvMAs6CC5mwd_7kbwbUVq/view?usp=sharing) |

| **Caso de Teste** 	| **CT-03 – Filtros** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve possibilitar o filtro dos itens constantes no catálogo. |
|Registro de evidência | [Screencast do teste de utilização dos filtros no catálogo de itens](https://drive.google.com/file/d/1WmhH73rwtPtEarcJ-73LgkiCbXuaEyKs/view?usp=sharing) |

| **Caso de Teste** 	| **CT-04 – Cadastrar itens** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve permitir que os colaboradores cadastrem as informações no catálogo de itens. |
|Registro de evidência | [Screencast do teste de cadastro de itens no catálogo](https://drive.google.com/file/d/1TlPXu1PD4IjaJwtTp3hg-D3xmQx3vuJI/view?usp=sharing) |

| **Caso de Teste** 	| **CT-05 – Login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve ter uma área de login para colaboradores da ONG. |
|Registro de evidência | [Screencast do teste de login de admin/voluntário na aplicação](https://drive.google.com/file/d/1SNuOhQ6NXLtOgDPjY9I0SL-ct72ORSGV/view?usp=sharing) |

| **Caso de Teste** 	| **CT-06 – Armazenamento de informações** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-006 - A aplicação deve ser capaz de gravar informações de roupas, doadores e usuários. |
|Registro de evidência | [Screencast do teste de armazenamento das informações no Banco de Dados](https://drive.google.com/file/d/18ogerPoMzV95OvdVqTnpZFCepa1dNIN4/view?usp=sharing) |

| **Caso de Teste** 	| **CT-07 – Cadastro de candidatos ao voluntariado** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-007 - A aplicação deve conter uma área com um formulário para cadastro de candidatos para voluntariado. |
|Registro de evidência | [Screencast do teste de cadastro de candidato a ser voluntário na aplicação](https://drive.google.com/file/d/1L9PsjU8wCbXATJxfpYXfRCc3E6AGkx4m/view?usp=sharing) |

## Avaliação

O teste de exibição da página Home (CT-01) foi bem sucedida, pois apresenta as informações propostas, com os links para as demais páginas da aplicação, assim como exibição de logo. Além de possibilitar o login para acesso a demais informações da aplicação. Da mesma forma o teste de visualização do catálogo de itens (CT-02) foi igualmente bem sucedido apresentando as informações dos itens disponíveis para doação. Na mesma página é possível realizar os filtros (CT-03) propostos para facilitar a localização de itens no catálogo. Essa funcionalidade oferece 3 possibilidades de filtro, a busca por gênero, por cor e por ID do produto. O teste de Cadastro de itens (CT-04) foi bem sucedido apresentando todas as funcionalidades propostas, como criar, editar, visualizar e excluir itens. Foi utilizado alguns enums em campos de preenchimento para facilitar o preenchimento do responsável. Já o teste de Login do Administrador/Voluntário no sistema (CT-05) teve sucesso com a apresentação de erro, caso o usuário utilize credenciais inválidas e dá acesso às informações propostas com o login bem sucedido. Quanto ao armazenamento das informações (CT-06) foi demonstrado de forma clara o cadastro de itens e exibição dos mesmos nas listas e catálogo, assim como o armazenamento no Banco de Dados MSSQL. Por fim, o teste de cadastro de candidatos ao voluntariado também teve sucesso demonstrando o acesso na página inicial e o armazenamento do cadastro realizado para validação do Administrador da aplicação.

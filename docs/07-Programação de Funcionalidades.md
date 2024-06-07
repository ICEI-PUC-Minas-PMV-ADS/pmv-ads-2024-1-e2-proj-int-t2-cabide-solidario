# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve apresentar informações gerais da ONG, colaboradores e patrocinadores. | Home: Index.cshtml / Privacy.cshtml | 
|RF-002| A aplicação deve disponibilizar um catálogo de todas as roupas disponíveis para doação. | RoupasDoadas: Index.cshtml / Catalogo.cshtml |
|RF-003| A aplicação deve permitir um filtro para facilitar as buscas de todas as roupas disponíveis para doação. | RoupasDoadas: Catalogo.cshtml |
|RF-004| A aplicação deve permitir que os colaboradores cadastrem as informações no catálogo de itens. | RoupasDoadas: Create.cshtml / Delete.cshtml / Details.cshtml / Edit.cshtml |
|RF-005| A aplicação deve ter uma área de login para colaboradores da ONG. | Usuarios: AccessDeneied.cshtml / Create.cshtml / Delete.cshtml / Details.cshtml / Edit.cshtml / Index.cshtml / Login.cshtml |
|RF-006| A aplicação deve ser capaz de gravar informações de roupas, doadores e usuários. | Migrations: 20240607100220_Initial.Designer.cs / 20240607100220_Initial.cs / AppDbContextModelSnapshot.cs |
|RF-007| A aplicação deve conter uma área com um formulário para cadastro de candidatos para voluntariado. | Candidatos: Create.cshtml / Index.cshtml |

# Instruções de acesso

A aplicação está disponível para acesso através da URL: http://clarenceaguiar-001-site1.gtempurl.com/.

A hospedagem utilizada SmarterASP.NET exige credenciais de acesso à  aplicação no período gratuito da plataforma. As credenciais de acesso à aplicação são: Nome de usuário: 11176862 / Senha: 60-dayfreetrial.

O usuário de teste possui as seguintes credenciais de acesso: usuário - ADMIN / senha - ADMIN.

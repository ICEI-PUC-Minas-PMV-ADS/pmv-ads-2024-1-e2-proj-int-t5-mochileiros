# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-004	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail é senha |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Criar itinerário	|
|Requisito Associado | RF-001	- A aplicação deve possuir opção de Criar itinerário, após clicar nessa opção sera aberto um Formulário para crição de um itinerário |
| Objetivo do Teste 	| Verificar se o usuário consegue criar itinerário. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br>  - Clicar no botão "Criar  itinerário" <br> - Preencher o fomulario de itinerário <br> - Clicar no botão "Criar" |
|Critério de Êxito | -  itinerário criado com sucesso |
|  	|  	|
| Caso de Teste 	| CT-04 – Editar itinerário	|
|Requisito Associado | RF-001	- A aplicação deve possuir opção itinerário criados, verificar itinerário criados é editalos. |
| Objetivo do Teste 	| Verificar se o usuário consegue  Editar itinerário |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar no botão itinerário <br> -  Clicar no botão editar itinerário <br> - modificar qualquer campo do formulario  - Clicar em "Login" |
|Critério de Êxito | - itinerário modificado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-05 – relatório de gastos 	|
|Requisito Associado | RF-002	- A aplicação deve possuir opção gerar relatorio de gastos |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar relatorio de gastos |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login"<br> - Clicar no botão Relatorios <br> -selecionar relatorio de gastos> emitir relatorio |
|Critério de Êxito | - O relatorio foi gerado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-06 –  roteiros.pdf	|
|Requisito Associado | RF-002	- A aplicação deve possuir opção gerar pdf dos roteiros programado |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar gerar pdf dos roteiros  |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login"<br> - Clicar no botão Relatorios <br> -selecionar relatorio de gastos> emitir relatorio |
|Critério de Êxito | - Pdf do roteiro foi gerado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-07 – 	|
|Requisito Associado | RF-00Y	-  |
| Objetivo do Teste 	| . |
| Passos 	|  |
|Critério de Êxito |  |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)

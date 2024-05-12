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
| Caso de Teste 	| CT-03 – Criar despesa	|
|Requisito Associado | RF-001	- A aplicação deve possuir opção de Criar despesa, após clicar nessa opção sera aberto um Formulário para crição de uma despesa |
| Objetivo do Teste 	| Verificar se o usuário consegue criar despesa. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br>  - Clicar no botão "Criar  despesa" <br> - Preencher o fomulario de despesa <br> - Clicar no botão "Criar" |
|Critério de Êxito | -  despesa criado com sucesso |
|  	|  	|
| Caso de Teste 	| CT-04 – Editar despesa	|
|Requisito Associado | RF-001	- A aplicação deve possuir opção despesa criados, verificar despesa criados é editalos. |
| Objetivo do Teste 	| Verificar se o usuário consegue  Editar despesa |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar no botão despesa <br> -  Clicar no botão editar despesa <br> - modificar qualquer campo do formulario |
|Critério de Êxito | - despesa modificado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-05 – relatório de gastos 	|
|Requisito Associado | RF-002\RF-008\RF-009\RF-010	- A aplicação deve possuir opção gerar relatorio de gastos |
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
| Caso de Teste 	| CT-07 – Grupos de viagem	|
|Requisito Associado | RF-005	- A aplicação deve possuir opção para criar grupo de viagem |
| Objetivo do Teste 	| .Verificar se o usuário consegue criar grupo de viagem |
| Passos 	|  Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login"<br> |Clicar no botão criar grupo de viagem é prencher os formularios
|Critério de Êxito | Grupos de viagem criado com sucesso |
|  	|  	|
| Caso de Teste 	| CT-08 – Copartilhar itinerário |
|Requisito Associado | RF-006	- A aplicação deve copartilhar itinerário para membros do grupo |
| Objetivo do Teste 	| .Verificar se o usuário consegue copartilhar  itinerário com o grupo |
| Passos 	|  Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login"<br> |Clicar no botão meus grupos de viagem <br> Clicar no botão copartilhar itinerário
|Critério de Êxito | Grupos de viagem criado com sucesso | 
|  	|  	|
| Caso de Teste 	| CT-09 – dividir gastos |
|Requisito Associado | RF-007	- A aplicação deve dividir gastos entre os membros do grupo |
| Objetivo do Teste 	| Realizar a divisão do gasto da viagem |
| Passos 	|  Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login"<br> |Clicar no botão meus grupos de viagem <br> Clicar no botão dividir gastos
|Critério de Êxito | Emição do relatorio de gastos dividido entre os menbros do grupo | 
|  	|  	|
| Caso de Teste 	| CT-10 – opções de hospedagem |
|Requisito Associado | RF-007	- A aplicação deve sugerir opções de hospedagem |
| Objetivo do Teste 	| mostrar sugestão para hospedagem|
| Passos 	|  Acessar o navegador <br> - Informar o endereço do site https://mochileiros.com/src/index.html <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login"<br> - Clicar no botão minhas viagens <br> - selecionar a aba de sugestão 
|Critério de Êxito | Exibição de sugestões de hospedagem | 
|  	|  	|


 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)

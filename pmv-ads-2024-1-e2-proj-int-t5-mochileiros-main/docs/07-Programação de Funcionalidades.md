# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) | Responsável(is) |
|------|-----------------------------------------|----| ----|
|RF-001| A aplicação deve permitir o autorregistro e gerenciamento do cadastro de usuários | User.cs / UsersController.cs | Victor e Mariana e Igor | 
|RF-002| A aplicação deve permitir que o usuário previamente cadastrado faça login | xxxxxx | Victor e Mariana e Igor| 
|RF-003| A aplicação deve permitir que o usuário gerencie viagens  | index.cshtml/ create.cshtml/ edit.cshtml/ delete.cshtml/ travel.cs/ TravelsController.cs | Luiz  | 
|RF-004| A aplicação deve permitir que o usuário vincule outros participantes a uma viagem criando um "grupo de viagem". Cada grupo de viagem poderá ter um ou mais participantes. Para cada participante, deve-se informar e-mail  | xxxxxx  | xxxxx  | 
|RF-005| 	A aplicação deve permitir que sejam registradas despesas a qualuqer tempo, mesmo que após a fase de planejamento.| create.cshtml  | João | 
|RF-006| A aplicação deve emitir um relatório do planejamento da viagem (os gastos programado da viagem)  | xxxxx | xxxxx  | 
|RF-007| A aplicação deve permitir que o usuário gerenciar despesa de viagem. Uma despesa deverá estar vinculado, obrigatoriamente, a uma viagem. |details.cshtml/ edit.cshtml/ delete.cshtml/ expense.cs/ ExpensesController.cs  | João  | 
|RF-008| A aplicação deve emitir um relatório do roteiros de viagem  | xxxxx |xxxxx  | 
|RF-009| Criação de cadastro e login dentro da plataforma      | xxxxx | xxxxx  | 
|RF-010| A aplicação deve permitir que o usuário crie grupos de viagem com outros usuários | xxxxx | xxxxx  | 
|RF-011| Nos grupos de viagem a aplicação deve permitir compartilhar o itinerário da  viagem com  integrante do grupo    | xxxxx | xxxxx  | 
|RF-012| Nos grupos de viagem a aplicação deve permitir fazer a divisão dos gastos entre os  integrante do grupo   | xxxxx | xxxxx  | 
|RF-013| a aplicação deve permitir o controle dos  gasto na viagem planejado e não planejado   | xxxxx | xxxxx  | 
|RF-014| a aplicação deve permitir o controle dos  gasto na viagem não planejado   | xxxxx | xxxxx | 
|RF-015|  a aplicação deve permitir realizar planejamento de gastos da viagem (hospedagem, alimentação, passeio entre outros possíveis gasto na viagem) | xxxxxx |  xxxxx  | 
|RF-016|  a aplicação deve sugerir opções de hospedagem para o planejamento| xxxxx | xxxx  | 

# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)

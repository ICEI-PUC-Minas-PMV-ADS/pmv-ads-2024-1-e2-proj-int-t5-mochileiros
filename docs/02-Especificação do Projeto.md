# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

![Mode=Light (7)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/assets/36000474/8c992dd6-a68f-4db2-ac15-09a79e29752a)

![Mode=Light (6)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/assets/36000474/e8a15a55-0146-4bc8-9e4b-df3cca9b2d8e)

![Mode=Light (5)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/assets/36000474/96e675d6-326d-4055-b8f6-f8cfb95c1ec2)


![Mode=Light (3)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/assets/36000474/94217b72-441c-45c2-9502-966757494836)

![Mode=Light (2)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/assets/36000474/74ba800d-d492-4ae8-8927-55812c5351c0)

![Mode=Light](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/assets/36000474/35db7444-c082-471e-a50e-abaee033ce60)


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Eu como Luiza  | quero poder criar e personalizar meu itinerário de viagem na aplicação  | para organizar minhas atividades durante a viagem.   |
|Eu como Andre | quero poder compartilhar o itinerário de viagem com os membros da minha família na aplicação | para coordenar nossas atividades durante as férias.|
|Eu, como Sofia, | quero poder pesquisar e comparar opções de hospedagem econômica na aplicação, |para encontrar as melhores ofertas e economizar dinheiro durante a viagem.|
|Eu, como Marcos,| quero ter a capacidade de criar e compartilhar listas de atividades e pontos de interesse com meus amigos na aplicação,| para planejar nossa agenda de viagem em grupo.|
|Eu, como Marcos,| quero poder registrar e dividir as despesas compartilhadas entre os membros do grupo na aplicação,| para facilitar o controle e a divisão dos custos da viagem.|
|Eu como Maria, | quero poder coordenar os meus itinerários, | para controlar o tempo durante o passeio.|
|Eu como Maria, | quero poder exportar meus roteiros em pdf,| para compartilhar com meus amigos e familiares.|
|Eu como Sarah, | quero poder controlar minhas despesas em tempo real,| para evitar surpresas desagradáveis.|
|Eu como Sarah,| quero poder ter um planejamento de viagem personalizado em relação a previsão de possiveis gastos, | para facilitar o controle de despesas.|


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário criar e personalizar   itinerário de viagem  | ALTA  | 
|RF-002| A aplicação deve emitir um relatório do planejamento da viagem (os gastos programado da viagem)  | MÉDIA |
|RF-003| Criação de cadastro e login dentro da plataforma                    | MÉDIA |
|RF-004| A aplicação deve permitir que o usuário crie grupos de viagem com outros usuários | baixa | 
|RF-005| Nos grupos de viagem a aplicação deve permitir compartilhar o itinerário da  viagem com  integrante do grupo    | MÉDIA | 
|RF-006| Nos grupos de viagem a aplicação deve permitir fazer a divisão dos gastos entre os  integrante do grupo   | MÉDIA | 
|RF-007| a aplicação deve permitir o controle dos  gasto na viagem planejado é não planejado   | MÉDIA | 
|RF-008|  a aplicação deve permitir realizaro planejamento de gastos da viagem (hospedagem, alimentação, passeio entre outros possíveis gasto na viagem) | MÉDIA |  




### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | ALTA  | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s  | BAIXA  | 
|RNF-003 | Deverá respeitar toda LGBD (Lei Geral de Proteção de Dados) para o maximo de segurança ao usuário final | ALTA   |
|RNF-004 | o sistema Deverá ser intuitivo/userfriendly | ALTA   |



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
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

![Mode=Light](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/blob/main/docs/img/CasodeUso.png)

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

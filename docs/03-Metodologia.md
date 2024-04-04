
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Nosso grupo utilizará as metodologias e ferramentas como Scrum e GitHub Projects, para organizar o trabalho em interações curtas (sprints) e priorizar o desenvolvimento de recursos com base nas tarefas propostas e no feedback contínuo dos stakeholders.
Realizaremos reuniões regulares de acompanhamento, e ferramentas de comunicação online (Whatsapp e Microsoft Teams), para facilitar e manter toda a equipe alinhada com os objetivos do projeto, discutir o progresso e identificar possíveis obstáculos. Isso garantirá uma comunicação eficaz e uma resposta rápida a quaisquer problemas que surjam. Será utilizado o GitHub como nosso sistema de controle de versão para gerenciar o código fonte do projeto e o Visual Studio Code será o principal ambiente de desenvolvimento para criação das linhas de código.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.
Ao criar um repositório no GitHub para hospedar o código-fonte e outros artefatos relacionados ao desenvolvimento do aplicativo móvel, o organizamos de forma lógica, com diretórios separados para código-fonte, documentação, recursos e outros elementos relevantes do projeto.

O projeto segue a seguinte convenção para o nome de branches:

* main: versão estável já testada do software
* unstable: versão já testada do software, porém instável
* testing: versão em testes do software
* dev: versão de desenvolvimento do software
  
Quanto à gerência de issues, serão usadas para rastrear bugs, solicitações de recursos e outras tarefas relacionadas ao desenvolvimento do projeto. Cada issue é cuidadosamente descrita, atribuída a um membro da equipe responsável e priorizada com base em sua importância e urgência. As issues são regularmente revisadas durante as tarefas e reuniões, e são atualizadas por cada membro da equipe. Após a conclusão de uma issue, ela será revisada, testada e fechada, garantindo que o progresso do projeto fosse documentado e que todas as tarefas fossem concluídas de forma satisfatória. O projeto adota a seguinte convenção para etiquetas:

* documentation: melhorias ou acréscimos à documentação
* bug: uma funcionalidade encontra-se com problemas
* enhancement: uma funcionalidade precisa ser melhorada
* feature: uma nova funcionalidade precisa ser introduzida

Para termos um melhor controle do projeto, definimos que utilizaremos as "Tags" listadas acima para marcar releases importantes do projeto. Cada tag recebeu um nome significativo e explicativo, facilitando a identificação e o acompanhamento da aplicação ao longo do tempo. Os "Merges" serão realizados regularmente para integrar o trabalho de diferentes membros da equipe ou ramificações do projeto. Cada merge será precedido por uma revisão detalhada, envolvendo a análise das alterações propostas e a identificação de possíveis conflitos ou problemas de integração. Os "Commits" irão ser feitos de forma individual e explicativa, com mensagens claras que descrevam as alterações realizadas. Isso permite que a equipe acompanhe o histórico de desenvolvimento do projeto e compreenda as mudanças implementadas em cada parte da documentação e código.
Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

> **Links Úteis**:
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

### Divisão de Papéis

A equipe adotou abordagens ágeis para o desenvolvimento do projeto, reconhecendo a necessidade de flexibilidade, colaboração e adaptação contínua aos requisitos em evolução. Como estrutura para direcionar esse processo ágil, optamos por utilizar o Scrum.

Dentro dessa estrutura, a equipe se organiza de acordo com os papéis tradicionais do Scrum:

• Scrum Master: Igor Fonseca;

• Product Owner: Luciano Carvalho;

• Equipe de Desenvolvimento: Igor Fonseca, João Pedro, Luciano Carvalho, Luiz Fernando, Mariana Rodrigues, Victor;

• Equipe de Design: Luciano Carvalho, João Pedro, Mariana Rodrigues;
### Processo
Para organização e distribuição das tarefas do projeto, a equipe está utilizando o Gitub Project, onde as tarefas são alocadas em sprints, classificadas de acordo com sua prioridade, listadas no backlog e dividas entre os integrantes da equipe para que sejam realizadas, testadas e finalizadas. O quadro de tarefas está estruturado da seguinte forma:

• Backlog: Esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos trabalhando e mostra as tarefas e metas a serem cumpridas e suas prioridades.

• In Progress: Lista que contém as tarefas que estão em andamento. É importante que a equipe atualize o status das tarefas para que o Scrum Master possa acompanhar o andamento do projeto e garantir que tudo esteja caminhando conforme o planejado.

• In Review: Esta lista engloba as tarefas que estão em fase de revisão e testes. Os testadores devem verificar as documentações, códigos e funcionalidades implementadas, garantindo que estão corretas, funcionando perfeitamente e identificando possíveis erros para correção.

• Done: nesta lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontos para ser entregues. Não há mais edições ou revisões necessárias, ele está agendado e pronto para a ação.

O quadro kanban do GitHub Project está demonstrado na imagem a seguir e disponível através da URL: https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/910/views/2?layout=board
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/assets/145329783/6351127e-193f-4013-8ff5-a642438ab0ec)

 
> **Links Úteis**:
> - [Project management, made simple](https://github.com/features/project-management/)
> - [Sobre quadros de projeto](https://docs.github.com/pt/github/managing-your-work-on-github/about-project-boards)
> - [Como criar Backlogs no Github](https://www.youtube.com/watch?v=RXEy6CFu9Hk)
> - [Tutorial Slack](https://slack.com/intl/en-br/)

### Ferramentas

As ferramentas utilizadas pela equipe foram selecionadas com base na sua eficácia, facilidade de uso e capacidade de atender às necessidades específicas do projeto. A seguir, apresentamos as ferramentas empregadas no projeto, cada uma com sua respectiva justificativa para sua escolha:

| AMBIENTE                            | PLATAFORMA                         | LINK DE ACESSO                         |
|-------------------------------------|------------------------------------|----------------------------------------|
| Repositório de código fonte         | GitHub                             | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/blob/main/src/README.md                      |
| Documentos do projeto               | GitHub                             | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t5-mochileiros/tree/main/docs                       |
| Projeto de Interface                | Figma                              |[ https://https://www.figma.com/](https://www.figma.com/)
| Gerenciamento do Projeto            | GitHub Projects                    | http://....                            |
| Hospedagem                          | GitHub Pages                       | http://....                            |
 


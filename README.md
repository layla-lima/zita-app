# Zita App
 Aplicativo de gerenciamento de estoque, registro de vendas e relatório com sistema de frente de caixa.

## Requisitos
- Visual Studio Community
- SQL Server
- Backup do banco de dados SQL (arquivo .bak)
  <br>
  <br>


## Tela Login
A tela de login verifica se os dados inseridos estão registrados no sistema. Caso esteja, o usuário será direcionado para o menu principal.

![zitaLogin](https://github.com/layla-lima/zita-app/assets/129623575/aa3498bd-025f-4f0e-a0a2-90fa1580346c)


## Tela de Cadastro
A tela de cadastro permite inserir no banco de dados as informações fornecidas pelo usuário, permitindo seu acesso na tela de login.

![zitaCadastro](https://github.com/layla-lima/zita-app/assets/129623575/0a712461-6d4e-4da9-8f02-9476fa8d2f02)


## Tela de Caixa
Ao clicar na aba "Caixa" do menu, o usuário será levado para a tela de caixa. Ao apertar no botão, será direcionado para a tela Caixa Aberto, onde permitirá a realização de vendas.
<br>
![zitaCaixa](https://github.com/layla-lima/zita-app/assets/129623575/fddffe27-f346-4e56-85b9-1a29deb20a71)
<br>
<br>
<br>
## Caixa Aberto
Na tela de Caixa Aberto, ao digitar o código do produto, ele coletará o nome e o valor unitário do produto e irá informar ao usuário. Ao realizar a venda, ela será registrada na no menu "Registros", no relatório das vendas no menu "Relatório" e também irá descontar do estoque os produtos que forem vendidos.
![zitaCaixaAberto](https://github.com/layla-lima/zita-app/assets/129623575/3f2fbe40-07e8-4f3a-9ac7-15b64e8b27c5)
<br>

## Tela de Estoque
Nessa tela irá ficar registrado todo o estoque de produtos. É possível adicionar, editar ou deletar produtos, as alterações realizadas nessa tela modificarão em tempo real a tabela de Estoque do banco de dados.
![zitaEstoque](https://github.com/layla-lima/zita-app/assets/129623575/44b5c14a-f2f3-4eb2-8e29-73d33cb832da)


## Tela de Registros
Nessa tela estará armazenada todas as vendas realizadas. É possível filtrar por dia, mês ou ano da venda e por forma de pagamento.
![zitaRegistros](https://github.com/layla-lima/zita-app/assets/129623575/7c62dbdb-e008-493d-b7cc-287060d1e243)

## Tela de Relatório
Aqui ficará o relatório de todas as vendas realizadas. Nessa tela é mostrado a quantidade de vendas realizadas, o lucro total e o lucro diário, com gráficos informando as categorias mais vendidas e as formas de pagamento mais utilizadas.
![zitaRelatorio](https://github.com/layla-lima/zita-app/assets/129623575/78b417e6-626a-4f94-8d60-149e2cad83c1)

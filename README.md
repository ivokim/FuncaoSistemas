# FuncaoSistemas
FEITO - O novo campo deverá seguir o padrão visual dos demais campos da tela
    Foi feito uma mudança na ordem dos campos para poder seguir um "Padrão"

FEITO - O cadastramento do CPF será obrigatório
FEITO - Deverá possuir a formatação padrão de CPF (999.999.999-99)
     O usuário poderá cadastrar o CPF com ou sem os separadores ".","-"
FEITO - Deverá consistir se o dado informado é um CPF válido (conforme o cálculo padrão de verificação do dígito verificador de CPF)
    A função de validar CPF está na tela Forms


FEITO - Não permitir o cadastramento de um CPF já existente no banco de dados, ou seja, não é permitida a existência de um CPF duplicado
    Foi utilizado a função "VerificarExistencia" da classe "BoCliente", antes de cadastrar o usuário valida o CPF, caso o cpf já foi usado retorna a mensagem "CPF já Cadastrado. Por favor utilizar um outro"


Não Foi criado a tela de cadastro de beneficário devido não estar familiarizado o suficiente com Razor.

Foi criado um botão que fica visível no momento em que clica em "SALVAR", mas não consegui fazer que fique 
visível somente quando o cadastro foi efetuado com sucesso

FEITO - Tabela que deverá armazenar os dados de beneficiário: “BENEFICIARIOS”
FEITO - O novos campos deverão ser nomeados como “ID”, “CPF”, “NOME”, “IDCLIENTE”

Foi criado uma chave estrnageira na tabela BENEFICIARIOS que faz referência à coluna "ID" da tabela "CLIENTES". 

Foi alterado as procedures de cadastro e de listar Clientes e procedure de cadastro de Beneficiario
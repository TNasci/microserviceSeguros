create database apoliceSeguros;

use apoliceSeguros;

create table apolice (
Id int identity(1, 1) primary key,
descricao VARCHAR(50),
cpf int,
situacao VARCHAR (10),
premio_total decimal(10, 2),
data_criacao_registro date,
data_alteracao_registro date,
usuario_criacao_registro int,
usuario_alteracao_registro int
)
create table parcelas (
Id int identity(1, 1) primary key,
apoliceId int,
premio decimal(10, 2),
forma_pagamento VARCHAR(50),
data_pagamento date,
data_pago date,
juros decimal(10, 2),
situacao VARCHAR (10),
data_criacao_registro date,
data_alteracao_registro date,
usuario_criacao_registro int,
usuario_alteracao_registro int,
CONSTRAINT FK_Parcelas_Apolice_apoliceId
 FOREIGN KEY (apoliceId)
 REFERENCES apolice (id)
)

select * from apolice a inner join parcelas p on a.id = p.apoliceId where a.id = 9;
select * from parcelas


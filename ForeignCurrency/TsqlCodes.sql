create database ForeignCurrency
go
use ForeignCurrency
go

create table Currency
(
ID uniqueidentifier primary key,
Name nvarchar(30), 
LimitAlert decimal
)
go
create table ExchangeRate
(
ID uniqueidentifier primary key,
CurrencyID uniqueidentifier, 
Buyying decimal, 
Selling decimal, 
CreationDate datetime
)
go
create table ExchangeRatePast 
(
ID uniqueidentifier primary key, 
ExchangeRateID uniqueidentifier,
CurrencyID uniqueidentifier, 
Buyying decimal, 
Selling decimal, 
CreationDate datetime
)
go
insert into Currency (ID, Name, LimitAlert) values (newid(), 'Dolar', 9.10) 
insert into Currency (ID, Name, LimitAlert) values (newid(), 'Euro', 0) 
insert into Currency (ID, Name, LimitAlert) values (newid(), 'İngiliz Sterlini', 0)
go
create proc ExchangeRateAddRecord
(
@ID uniqueidentifier,
@CurrencyID uniqueidentifier, 
@Buyying decimal, 
@Selling decimal, 
@CreationDate datetime
)
as
begin
if ((select count(*) from ExchangeRate where CurrencyID = @CurrencyID) > 0)
begin
insert into ExchangeRatePast(ID, ExchangeRateID, CurrencyID, Buyying, Selling, CreationDate) select newid(),ID,CurrencyID,Buyying,Selling,CreationDate 
from ExchangeRate where CurrencyID = @CurrencyID
update ExchangeRate set
Buyying = @Buyying,
Selling = @Selling
where CurrencyID = @CurrencyID
end
else
begin
insert into ExchangeRate(ID, CurrencyID, Buyying, Selling, CreationDate) values (@ID, @CurrencyID, @Buyying, @Selling, @CreationDate)
end
end
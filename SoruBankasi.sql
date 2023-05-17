create database soruBankasi default character set utf8 default collate utf8_turkish_ci;
use soruBankasi;


create table sorular(
soru_id int primary key,
soru_no int not null,
soru_metni text not null
);

create table cevaplar(
cevap_id int primary key,
dogruCevap varchar(2) not null,
soru_id int not null,
a text not null,
b text not null,
c text not null,
d text not null,
e text not null,
cevap text not null,
foreign key (soru_id) references sorular(soru_id)
);


delete from cevaplar;
delete from sorular;

select * from sorular;
select * from cevaplar;

select count(*) from sorular;
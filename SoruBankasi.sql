create database soruBankasi default character set utf8 default collate utf8_turkish_ci;
use soruBankasi;


create table kullanicilar(
kullanici_adi varchar(30) primary key not null,
kullanici_sifre varchar(24) not null
);

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

insert into kullanicilar(kullanici_adi,kullanici_sifre) values("admin","admin");

delete from cevaplar;
delete from sorular;
delete from kullanicilar;

select * from sorular;
select * from cevaplar;
select * from kullanicilar;

select count(*) from sorular;
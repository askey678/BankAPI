create database Bank;

use Bank;

create table Customer(
    id integer primary key,
    name varchar(50) not null,
    email varchar(20)  not null unique,
    address varchar(100) not null,
    PAN varchar(20) not null,
    mobile int(10) unique not null
);

create table Account(
    Account_no int(10) primary key,
    type varchar(10)  not null,
    branch varchar(20) not null,
    balance double not null default 0,
    cust_id integer,
    constraint cid_fk foreign key(cust_id) references Customer(id)
);
insert into Customer values(11, "akash gothri", "akash@gmail.com", "lacchmangarh, sikar", "DSIPG8101D", 7073806);
insert into Account values(1011, "Saving", "pune", 4000, 11);

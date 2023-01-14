create database Bank;

use Bank;

create table Customer(
    id integer primary key,
    name varchar(50) not null,
    email varchar(30)  not null unique,
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
insert into Customer values(11, "Akash Gothria", "akash@gmail.com", "pune, MH", "DSIPG8101D", 7073806);
insert into Customer values(12, "Sushil Joshi", "sushil@gmail.com", "pune, MH", "DSIPG8101D", 8073806);
insert into Customer values(13, "Kapil Sharam", "kapil@gmail.com", "lacchmangarh, Raj", "DSIPG8101D", 9073806);
insert into Customer values(14, "Ajay Pareek", "ajay@gmail.com", "lacchmangarh, Raj", "DSIPG8101D", 5073806);
insert into Customer values(15, "Rabiji Sbi", "rabiji@gmail.com", "gandhinagar, Guj", "DSIPG8101D", 7073806);
insert into Customer values(16, "Gaurav Khirwal", "gaurav@gmail.com", "jaipur, Raj", "DSIPG8101D", 6073806);
insert into Customer values(17, "Chetan Bhaiji", "chetan@gmail.com", "lacchmangarh, Raj", "DSIPG8101D", 4073806);
insert into Customer values(18, "Vishakha", "whisky@gmail.com", "lacchmangarh, Raj", "DSIPG8101D", 90073806);

insert into Account values(1011, "Saving", "pune", 4000, 11);
insert into Account values(1012, "Current", "pune", 5000, 13);
insert into Account values(1013, "Saving", "pune", 7000, 15);
insert into Account values(1014, "Demat", "pune", 34000, 17);
insert into Account values(1015, "Current", "pune", 12000, 12);
insert into Account values(1016, "Saving", "pune", 2000, 14);
insert into Account values(1017, "Demat", "pune", 2000, 16);
insert into Account values(1018, "Saving", "pune", 500000, 18);


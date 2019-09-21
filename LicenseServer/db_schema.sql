
create table accounts(
  id int not null,
  password varchar(245),
  account_info varchar(255),
  primary key (id)
);


create table licenses(
  id int not null auto_increment,
  account_id int not null,
  service_name varchar(256),
  limit_date date,
  primary key (id)
);


create table services(
  id int not null auto_increment,
  service_name varchar(256),
  last_version int,
  primary key (id)
);

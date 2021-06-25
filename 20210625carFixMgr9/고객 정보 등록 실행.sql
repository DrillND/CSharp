insert all
    into car_t values (car_t_seq.nextval, '그랜저','12가1234','2500cc이하','2020년식')
    into customer_t values (customer_t_seq.nextval,'홍길동','01012347890','19820520',car_t_seq.currval)
    
select*from dual;

insert into repair_item_t values (repair_item_t_seq.nextval,'4','엔진오일 교환','50000',car_t_seq.currval);
insert into repair_item_t values (repair_item_t_seq.nextval,'5','부동액 교환','40000',car_t_seq.currval);
insert into repair_item_t values (repair_item_t_seq.nextval,'6','와이퍼 교환','20000',car_t_seq.currval);

insert into receipt_t values (receipt_t_seq.nextval,customer_t_seq.currval,'2021년6월23일',(select staff_t.staff_id from staff_t where staff_t.name='김우치'),
car_t_seq.currval,'1500000');
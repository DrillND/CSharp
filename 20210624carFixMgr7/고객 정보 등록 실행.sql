insert all
    into car_t values (car_t_seq.nextval, '�׷���','12��1234','2500cc����','2020���')
    into customer_t values (customer_t_seq.nextval,'ȫ�浿','01012347890','19820520',car_t_seq.currval)
    
select*from dual;

insert into repair_item_t values (repair_item_t_seq.nextval,'4','�������� ��ȯ','50000',car_t_seq.currval);
insert into repair_item_t values (repair_item_t_seq.nextval,'5','�ε��� ��ȯ','40000',car_t_seq.currval);
insert into repair_item_t values (repair_item_t_seq.nextval,'6','������ ��ȯ','20000',car_t_seq.currval);

insert into receipt_t values (receipt_t_seq.nextval,customer_t_seq.currval,'2021��6��23��',(select staff_t.staff_id from staff_t where staff_t.name='���ġ'),
car_t_seq.currval,'1500000');
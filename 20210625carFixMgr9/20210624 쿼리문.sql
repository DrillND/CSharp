select indate as ������, total_price as �Ѱ����ݾ�,
(select customer_t.name from CUSTOMER_T where customer_t.cust_ID=RECEIPT_T.cust_ID) as ����,

(select staff_t.name from staff_t where staff_t.staff_ID=RECEIPT_T.staff_ID) as �����

from receipt_t;

select repair as �����׸�, price as ������ from repair_item_t 
where car_id=
(select customer_t.cust_id from customer_t where customer_t.name='������');
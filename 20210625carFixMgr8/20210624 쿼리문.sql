select indate as 접수일, total_price as 총결제금액,
(select customer_t.name from CUSTOMER_T where customer_t.cust_ID=RECEIPT_T.cust_ID) as 고객명,

(select staff_t.name from staff_t where staff_t.staff_ID=RECEIPT_T.staff_ID) as 담당자

from receipt_t;

select repair as 수리항목, price as 수리비 from repair_item_t 
where car_id=
(select customer_t.cust_id from customer_t where customer_t.name='가나다');
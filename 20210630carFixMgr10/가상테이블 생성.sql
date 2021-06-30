create or replace view receipt_view as 
select RECEIPT_ID as 접수ID,
                indate as 접수일,
                total_price as 총결제금액,
                (select customer_t.name from CUSTOMER_T where
                customer_t.cust_ID = RECEIPT_T.cust_ID) as 고객명,
                (select staff_t.name from staff_t where
                staff_t.staff_ID = RECEIPT_T.staff_ID) as 담당자
                from receipt_t order by RECEIPT_ID desc;
                
--가상 테이블 생성
select*from receipt_view where 고객명='박명수';
select*from receipt_view where 접수ID=1;
create or replace view receipt_view as 
select RECEIPT_ID as ����ID,
                indate as ������,
                total_price as �Ѱ����ݾ�,
                (select customer_t.name from CUSTOMER_T where
                customer_t.cust_ID = RECEIPT_T.cust_ID) as ����,
                (select staff_t.name from staff_t where
                staff_t.staff_ID = RECEIPT_T.staff_ID) as �����
                from receipt_t order by RECEIPT_ID desc;
                
--���� ���̺� ����
select*from receipt_view where ����='�ڸ��';
select*from receipt_view where ����ID=1;
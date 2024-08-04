begin
    for i in 1..100 loop
     insert into log(message) values(i);
    end loop;
end;
/

select u.column_id, u.data_scale,u.data_precision from user_tab_cols u order by u.column_id;

delete from log;



alter table log add(
num number(5,3)
);


insert into log(num) values(1);

select 0.1 + 0.2 from dual;


select * from log order by message desc;

delete from log where id between 11 and 99;

select 'a'||'b' from dual;

declare
    type log_rec is record(id number, log_ts timestamp, message varchar2(4000 char));
    v_log log_rec;
    v_str clob;
    type varchar_tab is table of varchar2(4000 char);
    v_tab varchar_tab;
begin
   -- for i in (select * from log order by id) loop
   -- v_str:= v_str|| i.message;
   -- end loop;
   
   -- select message into v_tab from log;
   execute immediate 'select message from log' bulk collect into v_tab;
   dbms_output.put_line(v_tab.first);
   dbms_output.put_line(v_tab.last);
   dbms_output.put_line(v_tab.count);
end;
/

select count(*) from log;


--házi:
--olyan tabla aminek van 
--egy id mezoje number 
--meg egy word nevu mezoje varchar2(4) 
--id sequence automatikusan primary key 
-- 
select * from hazi1005;

create sequence hazi_seq order;
create table hazi1005(id number default hazi_seq.nextval constraint hazi_pk primary key,
word varchar2(4));

select substr('ABCDE', 2,1) from dual;

begin
for i in hazi1005 

end;



create sequence tanora_seq order;


create table tanora(
  id number default tanora_seq.nextval constraint tanora_pk primary key,
  kurzus_id number,
  constraint tanora_kurzus_id_fk foreign key (kurzus_id) references kurzus(id),
  alkalom number,
  start_at timestamp(6) with time zone,
  end_at timestamp(6) with time zone
)


alter table tanora add constraint check_const check (start_at < end_at);
/

alter table tanora add constraint check_const check (start_at < end_at);
/


DECLARE 
  v_date DATE;
BEGIN
  v_date := TO_DATE('2022-09-14', 'YYYY-MM-DD');
  
  FOR i in 1..12 loop
  
    INSERT into tanora 
      (kurzus_id, alkalom, start_at, end_at)
    VALUES
    (
    1,
    I,
    TO_TIMESTAMP( v_date || ' 15:30:00.00000000', 'YYYY-MM-DD-HH24:MI:SS.FF' ),
    TO_TIMESTAMP( v_date || ' 17:30:00.00000000', 'YYYY-MM-DD HH24:MI:SS.FF' )
    );
    
    v_date := v_date + 7;
    
    END LOOP;

END;
/




CREATE OR REPLACE TRIGGER jelenlet_trg BEFORE INSERT ON jelenlet FOR EACH ROW 
declare
   v_tanora_id number; 
BEGIN
  select id into v_tanora_id from tanora where sysdate between start_at and end_at;
    :new.tanora_id := v_tanora_id;
end;
/



insert into jelenlet(hallgato_kod,tanora_id) values ('BL7VQV', 1);














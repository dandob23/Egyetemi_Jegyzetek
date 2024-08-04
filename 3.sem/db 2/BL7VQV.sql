CREATE TABLE ugyfelszamla(
	id NUMBER(4,0) NOT NULL PRIMARY KEY, 
	egyenleg NUMBER(20,0) NOT NULL, 
	aktiv CHAR(1) NOT NULL
);

INSERT INTO ugyfelszamla VALUES(1, 200000, 'A');
INSERT INTO ugyfelszamla VALUES(2, 50, 'I');
INSERT INTO ugyfelszamla VALUES(3, 0, 'I');
INSERT INTO ugyfelszamla VALUES(4, 386000, 'I');
INSERT INTO ugyfelszamla VALUES(5, 416000, 'I');
INSERT INTO ugyfelszamla VALUES(6, 212000, 'A');
INSERT INTO ugyfelszamla VALUES(7, 315000, 'A');
INSERT INTO ugyfelszamla VALUES(8, 20000000, 'A');
INSERT INTO ugyfelszamla VALUES(9, 200, 'I');
INSERT INTO ugyfelszamla VALUES(10, 20, 'I');
COMMIT;
/
--1 feladat
create table tranzakciok (tranzakcio_id NUMBER (19,0) not null enable,
terhelt_szamla number(4,0) not null enable, --ugyfelszamla.id%TYPE not null enable,
kedvezmenyezett_szamla number (4,0) not null enable, --ugyfelszamla.id%TYPE not null enable,
osszeg number(10,0) not null enable ,
letrehozva timestamp default sysdate not null enable,
konyveles_napja date,
statusz char(1),
CONSTRAINT "tranzakcio_pk" primary key(tranzakcio_id),
CONSTRAINT "tranzakcio_fkt" foreign key(terhelt_szamla) REFERENCES ugyfelszamla(id),
CONSTRAINT "tranzakcio_fkk" foreign key(kedvezmenyezett_szamla) REFERENCES ugyfelszamla(id),
CONSTRAINT "tranzakcio_check" CHECK(terhelt_szamla <> kedvezmenyezett_szamla),
CONSTRAINT "osszeg_check" CHECK(osszeg > 0),
CONSTRAINT "statusz_check" CHECK(statusz = 'E' or statusz = 'B')
)
/

--2 feladat
create or replace function getNextId (P_azon ugyfelszamla.id%TYPE,P_erteknap date) return char as
v_ugyfelek varchar2(8);
v_azon varchar2(4);
v_sorszam varchar2(5);
v_erteknap date;
v_tranzid number;
begin

    if (P_erteknap = 0) then
        P_erteknap := sysdate;
    end if;
    
    v_erteknap := to_char(format (P_erteknap, 'yyyyMMdd'));
    
    if LENGTH(P_azon < 4) then
        P_azon := rpad(P_azon,4,0);
    end if;
    
    v_azon := trim();
    
    select count(konyveles_napja) into v_tranzid where tranzakciok.konyveles_napja = sysdate;
    
    if(v_tranzid>99998) then
        raise hiba;
    end if;
    
    v_tranzid += tranzid + 1;
    
    if LENGTH(v_tranzid<5) then
        P_azon := rpad(v_tranzakcio,5,0);
    end if;
    
        v_azonosito:= trim();
end;
/

--3 feladat
create or replace trigger tranz_tr before insert on tranzakciok for each row
begin
    if inserting then 
        insert into tranzakciok(tranzakcio_id, terhelt_szamla,kedvezmenyezett_szamla,osszeg,letrehozva,konyveles_napja,statusz)
            values(:NEW."tranzakcio_id",:NEW."terhelt_szamla",:NEW."kedvezmenyezett_szamla",:NEW."osszeg",:NEW."letrehozva",:NEW."konyveles_napja",:NEW."statusz")
    if inserting then
        :NEW.statusz := null;
    end if;
end;

/
--4 fel
create or replace function tranzakcioVegrehajt(P_nap date, P_hibakod out number) return number as
declare
v_statusz char(1);
x number;
for x in select
    loop 
        
    end loop;
begin
    select tranzakciok.statusz into v_statusz;
    if(v_statusz = 'E') then
        
        
    end if;
    if(v_statusz = 'B') then
end tranzakcioVegrehajt;





/
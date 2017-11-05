select * from tb_world;
select * from tb_player;
select * from tb_shop_history;

insert into tb_world (name) select '6' from dual where not exists (select name from tb_world where name = '6');


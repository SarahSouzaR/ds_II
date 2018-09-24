select * from tb_estado

alter procedure sp_RetornarEstados
@nm_estado varchar(50) = null

as 
select * from tb_estado
where @nm_estado is null or nm_estado like '%' + @nm_estado + '%'

sp_RetornarEstados ''
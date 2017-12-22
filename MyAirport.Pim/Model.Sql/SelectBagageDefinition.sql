select b.ID_BAGAGE,  
b.compagnie, 
b.ligne, 
b.jour_exploitation,
 b.ESCALE,
 b.classe,
 b.CODE_IATA, b.continuation, 
iif(app.ID_PARTICULARITE is null, cast(0 as BIT), cast(1 as Bit)) as Rush
from BAGAGE b 
left outer join BAGAGE_A_POUR_PARTICULARITE app 
on app.ID_BAGAGE = b.ID_BAGAGE and app.ID_PARTICULARITE = 15
--left outer join BAGAGE_PARTICULARITE p 
--on p.ID_PART = app.ID_PARTICULARITE
where b.CODE_IATA = @code 
order by ID_BAGAGE desc


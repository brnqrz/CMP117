SELECT DISTINCT 
	p.cpf,
	p.nome
FROM pessoa AS p 
JOIN inscricao_c AS ic ON ic.candidato_cpf  = p.cpf
WHERE p.cpf NOT IN (SELECT ifis.fiscal_cpf FROM inscricao_f AS ifis)
ORDER BY p.nome, p.cpf;
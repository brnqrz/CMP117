SELECT DISTINCT 
	p.cpf,
	p.nome
FROM pessoa AS p 
JOIN inscricao_f AS ifis ON ifis.fiscal_cpf = p.cpf
WHERE p.cpf NOT IN (SELECT ic.candidato_cpf FROM inscricao_c AS ic)
ORDER BY p.nome, p.cpf;
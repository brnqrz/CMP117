SELECT DISTINCT 
	p.cpf,
	p.nome
FROM pessoa AS p
JOIN inscricao_c AS ic ON ic.candidato_cpf = p.cpf 
JOIN inscricao_f AS ifis ON ifis.fiscal_cpf = p.cpf
ORDER BY p.nome, p.cpf;
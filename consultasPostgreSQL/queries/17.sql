SELECT 
	ic.candidato_cpf,
	p.nome, 
	ic.num_insc, 
	ic.fiscal_cpf_des AS cpf_fiscal, 
	fc.nome AS nome_fiscal, 
	ic.motivo_des
FROM inscricao_c AS ic
JOIN pessoa AS p ON ic.candidato_cpf = p.cpf
JOIN pessoa AS fc ON ic.fiscal_cpf_des = fc.cpf
WHERE ic.concurso_numero = 8 AND ic.fiscal_cpf_des IS NOT NULL
ORDER BY p.nome, ic.candidato_cpf;

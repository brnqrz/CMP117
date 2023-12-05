SELECT 
    p.cpf, 
    p.nome,
    COUNT(ifis.fiscal_cpf) AS quantidade_concurso
FROM pessoa AS p
JOIN inscricao_f AS ifis ON p.cpf = ifis.fiscal_cpf
GROUP BY p.cpf, p.nome
ORDER BY COUNT(ifis.fiscal_cpf) DESC, p.data_nascimento
LIMIT 10;
SELECT 
    p.cpf,
    p.rg, 
    p.nome,
    COUNT(ic.candidato_cpf) AS quantidade_concurso
FROM pessoa AS p
JOIN inscricao_c AS ic ON p.cpf = ic.candidato_cpf 
GROUP BY p.cpf, p.nome
HAVING COUNT(ic.candidato_cpf) >= 10 
ORDER BY COUNT(ic.candidato_cpf) DESC, p.nome;
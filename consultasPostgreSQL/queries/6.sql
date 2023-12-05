SELECT 
	con.numero,
    con.data, 
    con.nome, 
    COUNT(ic.candidato_cpf) AS quantidade_candidatos
FROM concurso AS con
LEFT JOIN inscricao_c AS ic ON con.numero = ic.concurso_numero
GROUP BY con.numero, con.data, con.nome
ORDER BY con.data DESC;
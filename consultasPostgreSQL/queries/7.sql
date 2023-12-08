WITH QuestoesProva AS (	
	SELECT 
		aq.qp_num_conc_prov AS numero_concurso,
	   	aq.qp_cpf_prov AS cpf_prova,
	   	aq.qp_cod_ques AS cod_questao,
	   	aq.letra AS alternativa_correta,
	   	a.descricao as descricao
	FROM alternativa_qp AS aq 
	JOIN alternativa AS a ON a.questao_codigo = aq.alt_cod_ques AND a.sequencial = aq.alt_seq AND a.correta = TRUE
)

SELECT
    p.nome,
	SUM(CASE WHEN qp.alternativa_marcada = QTP.alternativa_correta THEN 1 ELSE 0 END) AS acertos,
    SUM(CASE WHEN qp.alternativa_marcada != QTP.alternativa_correta AND qp.alternativa_marcada IS NOT NULL THEN 1 ELSE 0 END) AS erros,
    SUM(CASE WHEN qp.alternativa_marcada IS NULL THEN 1 ELSE 0 END) AS em_branco
FROM inscricao_c AS ic
    JOIN pessoa AS p ON p.cpf = ic.candidato_cpf
    JOIN questao_p AS qp ON qp.prova_num_conc = ic.concurso_numero AND qp.prova_cpf = ic.candidato_cpf
    JOIN QuestoesProva AS QTP ON QTP.numero_concurso = qp.prova_num_conc AND QTP.cpf_prova = qp.prova_cpf AND QTP.cod_questao = qp.questao_codigo 
    WHERE ic.concurso_numero = 1
GROUP BY p.cpf
ORDER BY
    acertos DESC,
    em_branco DESC,
    erros;
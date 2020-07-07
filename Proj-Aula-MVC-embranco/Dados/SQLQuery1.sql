CREATE TABLE cidade (
    cid_cod INTEGER NOT NULL identity(1,1),
    cid_nome VARCHAR(40) NOT NULL,
    cid_uf CHAR(2) NOT NULL,
    PRIMARY KEY (cid_cod)
);


CREATE TABLE cliente (
    cli_cod INTEGER NOT NULL identity(1,1),
    cli_nome VARCHAR(30) NOT NULL,
    cli_datanasc DATETIME,
    cli_telefone VARCHAR(16),
    cli_cpf VARCHAR(14),
    cli_email VARCHAR(50),
    cid_cod INTEGER,
    PRIMARY KEY (cli_cod),
    FOREIGN KEY (cid_cod) REFERENCES cidade(cid_cod)
);
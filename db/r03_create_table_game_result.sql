CREATE TABLE ugaming.game_result
(
    id_game_result serial NOT NULL,
    cod_game bigint NOT NULL,
    cod_player bigint NOT NULL,
    win bigint NOT NULL,
    data_criacao timestamp without time zone NOT NULL,
    CONSTRAINT "pkey_Game_Result" PRIMARY KEY (id_game_result)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE ugaming.game_result
    OWNER to postgres;
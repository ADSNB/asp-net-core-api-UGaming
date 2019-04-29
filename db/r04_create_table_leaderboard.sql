CREATE TABLE ugaming.leaderboard
(
    cod_player bigint NOT NULL,
    balance bigint NOT NULL,
    last_update_date timestamp without time zone NOT NULL,
    CONSTRAINT "pkey_Leaderboard" PRIMARY KEY (cod_player)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE ugaming.leaderboard
    OWNER to postgres;
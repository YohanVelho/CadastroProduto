--
-- PostgreSQL database dump
--

-- Dumped from database version 9.2.24
-- Dumped by pg_dump version 9.3.1
-- Started on 2020-04-10 16:05:18

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 170 (class 3079 OID 11727)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 1935 (class 0 OID 0)
-- Dependencies: 170
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 168 (class 1259 OID 16429)
-- Name: produtos; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE produtos (
    pro_id integer NOT NULL,
    pro_nome character varying(80),
    pro_precocusto numeric,
    pro_precovenda numeric,
    pro_classificacao character varying(80) COLLATE pg_catalog."C",
    pro_icms integer,
    pro_pb_id integer
);


ALTER TABLE public.produtos OWNER TO postgres;

--
-- TOC entry 169 (class 1259 OID 16437)
-- Name: produtoscodigodebarra; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE produtoscodigodebarra (
    pb_id integer NOT NULL,
    pb_codigodebarra integer,
    id integer NOT NULL
);


ALTER TABLE public.produtoscodigodebarra OWNER TO postgres;

--
-- TOC entry 1926 (class 0 OID 16429)
-- Dependencies: 168
-- Data for Name: produtos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY produtos (pro_id, pro_nome, pro_precocusto, pro_precovenda, pro_classificacao, pro_icms, pro_pb_id) FROM stdin;
1	Cigarro Marlboro	3.5	4.5	Cigarros	25	1
2	Cigarro Winston	4.5	5.9	Cigarros	25	2
3	Cigarro Dunhil	5.5	6.5	Cigarros	25	3
4	Cigarro	6.5	7.5	Cigarros	25	4
5	Pao	2.5	5.5	Alimentos	18	5
6	Arroz	1.5	3.5	Alimentos	18	6
7	Feijão	1.5	2.5	Alimentos	18	7
8	Vodka	3.5	7.5	Bebidas	25	8
10	Whiskey	4.5	10.0	Bebidas	25	\N
9	Cerveja	1.0	5.5	Bebidas	25	\N
11	Energetico	3.5	4.5	Bebidas	25	\N
\.


--
-- TOC entry 1927 (class 0 OID 16437)
-- Dependencies: 169
-- Data for Name: produtoscodigodebarra; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY produtoscodigodebarra (pb_id, pb_codigodebarra, id) FROM stdin;
1	1234	1
1	4567	2
2	7894	3
2	4563	4
3	6541	5
4	3214	6
5	7895	7
6	6548	8
7	7845	9
8	3245	10
\.


--
-- TOC entry 1818 (class 2606 OID 16449)
-- Name: id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY produtoscodigodebarra
    ADD CONSTRAINT id PRIMARY KEY (id);


--
-- TOC entry 1815 (class 2606 OID 16436)
-- Name: produtos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY produtos
    ADD CONSTRAINT produtos_pkey PRIMARY KEY (pro_id);


--
-- TOC entry 1816 (class 1259 OID 16455)
-- Name: fki_pb_pro_id; Type: INDEX; Schema: public; Owner: postgres; Tablespace: 
--

CREATE INDEX fki_pb_pro_id ON produtoscodigodebarra USING btree (pb_id);


--
-- TOC entry 1813 (class 1259 OID 16447)
-- Name: fki_pro_codigodebarra; Type: INDEX; Schema: public; Owner: postgres; Tablespace: 
--

CREATE INDEX fki_pro_codigodebarra ON produtos USING btree (pro_pb_id);


--
-- TOC entry 1819 (class 2606 OID 16450)
-- Name: pb_pro_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY produtoscodigodebarra
    ADD CONSTRAINT pb_pro_id FOREIGN KEY (pb_id) REFERENCES produtos(pro_id);


--
-- TOC entry 1934 (class 0 OID 0)
-- Dependencies: 5
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2020-04-10 16:05:18

--
-- PostgreSQL database dump complete
--


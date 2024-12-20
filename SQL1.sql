CREATE DATABASE arabakiralama;
CREATE TABLE arabalar (
    plaka VARCHAR(20) PRIMARY KEY,
    marka VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    renk VARCHAR(30),
    yil SMALLINT,
    fiyat NUMERIC(12, 2)
);

INSERT INTO arabalar (plaka, marka, model, renk, yil, fiyat)
VALUES
('34XYZ123', 'Toyota', 'Corolla', 'Beyaz', 2020, 4500),
('35ABC678', 'Toyota', 'Camry', 'Siyah', 2019, 6200),
('06DEF456', 'Honda', 'Civic', 'Gri', 2021, 5700),
('41KLM789', 'Honda', 'Accord', 'Mavi', 2018, 4900),
('07NOP321', 'Ford', 'Focus', 'Kırmızı', 2020, 5100),
('16QRS654', 'Ford', 'Fiesta', 'Beyaz', 2019, 6300),
('55TUV987', 'Volkswagen', 'Golf', 'Siyah', 2018, 4100),
('22WXY012', 'Volkswagen', 'Passat', 'Gri', 2020, 6800),
('34ZAB345', 'BMW', '320i', 'Lacivert', 2019, 7000),
('26CDE678', 'BMW', 'X1', 'Beyaz', 2021, 5200),
('42FGH910', 'Mercedes', 'C180', 'Kırmızı', 2020, 4700),
('10IJK432', 'Mercedes', 'GLA', 'Yeşil', 2018, 6500),
('20LMN654', 'Audi', 'A3', 'Sarı', 2019, 5400),
('34OPQ876', 'Audi', 'Q2', 'Turuncu', 2021, 6000),
('43RST098', 'Fiat', 'Egea', 'Gri', 2018, 3000),
('44UVW123', 'Fiat', '500L', 'Beyaz', 2020, 3700),
('45XYZ456', 'Renault', 'Megane', 'Mavi', 2021, 4500),
('34ABC789', 'Renault', 'Clio', 'Yeşil', 2019, 3900),
('06DEF012', 'Hyundai', 'Elantra', 'Kırmızı', 2020, 4800),
('16GHI345', 'Hyundai', 'Tucson', 'Siyah', 2021, 5600);

CREATE TABLE musteriler (
    tc_no CHAR(11) PRIMARY KEY,
    ad VARCHAR(50) NOT NULL,
    soyad VARCHAR(50) NOT NULL,
    telefon_no CHAR(11) NOT NULL
);



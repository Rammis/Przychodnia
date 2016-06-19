USE [Przychodnia]
INSERT INTO [dbo].[User] VALUES
		  ('kwiatuszek23',
           'reksio',
           '20200101 00:00:00 AM',
           'Rejestratorka',
           'Kowalska',
           'Anna')
INSERT INTO [dbo].[User] VALUES
		  ('tulipan',
           'roza22',
           '20200101 00:00:00 AM',
           'Rejestratorka',
           'Nowak',
           'Barbara')
INSERT INTO [dbo].[User] VALUES
		  ('mirek23',
           'wypok',
           '20200101 00:00:00 AM',
           'Lekarz',
           'Tomasz',
           'Terka')
INSERT INTO [dbo].[User] VALUES
		  ('krolpomaranczy',
           'testo',
           '20200101 00:00:00 AM',
           'Lekarz',
           '£ukasz',
           'Stanis³awowski')
INSERT INTO [dbo].[User] VALUES
		  ('hadwao',
           'h20',
           '20200101 00:00:00 AM',
           'Laborant',
           'Adam',
           'Chemik')

INSERT INTO [dbo].[User] VALUES
		  ('curie',
           'rad',
           '20200101 00:00:00 AM',
           'Laborant',
           'Maria',
           'Duda')
INSERT INTO [dbo].[User] VALUES
		  ('szef55',
           'prezes',
           '20200101 00:00:00 AM',
           'Kierownik Lab',
           'Marek',
           'Lewandowski')
/*Lekarze*/
INSERT INTO [dbo].[Lekarz] (nr_uprawnienia,user_name) VALUES (2,'krolpomaranczy')
INSERT INTO [dbo].[Lekarz] (nr_uprawnienia,user_name) VALUES (2,'mirek23')
/*Rejestratorki*/
INSERT INTO [dbo].[Rejestracja] (user_name) VALUES ('kwiatuszek23')
INSERT INTO [dbo].[Rejestracja] (user_name) VALUES ('tulipan')
/*Laboranci*/
INSERT INTO [dbo].[Lab] (user_name) values ('hadwao')
INSERT INTO [dbo].[Lab] (user_name) values ('curie')
/*Szef laboratorium*/
INSERT INTO [dbo].[K_Lab] (user_name) values ('szef55')
/*Pacjenci*/
INSERT INTO [dbo].[Pacjent] (nazwisko,imie,PESEL) VALUES ('Nowak','Danuta','94012508933')
INSERT INTO [dbo].[Pacjent] (nazwisko,imie,PESEL) VALUES ('Staœko','Robert','96321508933')
INSERT INTO [dbo].[Pacjent] (nazwisko,imie,PESEL) VALUES ('Bratek','Ada','95245608933')

/*S³ownik badañ*/
INSERT INTO [dbo].[Slownik_badan] (typ,nazwa,opis) VALUES ('BF','Pomiar temperatury','Pomiar temperatury u pacjenta')
INSERT INTO [dbo].[Slownik_badan] (typ,nazwa,opis) VALUES ('BF','Pomiar ciœnienia','Pomiar ciœnienia u pacjenta')
INSERT INTO [dbo].[Slownik_badan] (typ,nazwa,opis) VALUES ('BL','Poziom cukru we krwi','Pomiar poziomu cukru we krwi pacjenta')
INSERT INTO [dbo].[Slownik_badan] (typ,nazwa,opis) VALUES ('BL','Iloœæ czerwonych krwinek','Pomiar poziomu czerwonych krwinek')

INSERT INTO [dbo].[Wizyta] (opis,diagnoza,stan,data_rej,data_wyk_wizyty,id_pac,id_rej,id_lekarza)
VALUES
('','','Oczekuj¹ca','2016-06-15 00:00:00.000','2016-06-16 00:00:00.000',1,1,1)
INSERT INTO [dbo].[Wizyta] (opis,diagnoza,stan,data_rej,data_wyk_wizyty,id_pac,id_rej,id_lekarza)
VALUES
('','','Zakoñczona','2016-06-15 00:00:00.000','2016-06-16 00:00:00.000',2,1,1)
INSERT INTO [dbo].[Wizyta] (opis,diagnoza,stan,data_rej,data_wyk_wizyty,id_pac,id_rej,id_lekarza)
VALUES
('','','Oczekuj¹ca','2016-06-15 00:00:00.000','2016-06-16 00:00:00.000',3,1,1)

INSERT INTO [dbo].[Wizyta] (opis,diagnoza,stan,data_rej,data_wyk_wizyty,id_pac,id_rej,id_lekarza)
VALUES
('','','Oczekuj¹ca','2016-06-16 00:00:00.000','2016-06-17 00:00:00.000',3,1,1)










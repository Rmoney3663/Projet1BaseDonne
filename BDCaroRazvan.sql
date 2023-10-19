-- ===========================================================================
-- fichier : DBCaroRazvan.sql				
-- Projet 1
-- ==-----------------------------------------------------------------------==
--  
--==-----------------------------------------------------------------------==
--   table cr��es :
--   client, invite, reservationChambre, chambre, typeChambre, planifSoin, soin, typeSoin, assistant, assistantSoin
-- ==-----------------------------------------------------------------------==


use B56Projet1Equipe7

Print  'Cr�ation de la base de donn�es de H�tel Plage Sant� Inc.'
print ''
Print  'destruction des tables...'
IF OBJECT_ID ('invite') is not null 
DROP TABLE invite;
IF OBJECT_ID ('reservationChambre') is not null 
DROP TABLE reservationChambre;
IF OBJECT_ID ('client') is not null 
DROP TABLE client;
IF OBJECT_ID ('chambre') is not null
DROP TABLE chambre;
IF OBJECT_ID ('typeChambre') is not null
DROP TABLE typeChambre;
IF OBJECT_ID ('assistantSoin') is not null
DROP TABLE assistantSoin;
IF OBJECT_ID ('planifSoin') is not null
DROP TABLE planifSoin;
IF OBJECT_ID ('assistant') is not null
DROP TABLE assistant;
IF OBJECT_ID ('soin') is not null
DROP TABLE soin;
IF OBJECT_ID ('typeSoin') is not null
DROP TABLE typeSoin;

IF OBJECT_ID ('utilisateur') is not null
DROP TABLE utilisateur;
IF OBJECT_ID ('typeUtilisateur') is not null
DROP TABLE typeUtilisateur;



print 'Cr�ation des tables ========================================================'
print ''
print  'Cr�ation de la TABLE typeChambre...'
CREATE TABLE typeChambre(
  noTypeChambre NUMERIC(5) NOT NULL ,
  description	VARCHAR(50),
  prixHaut		NUMERIC(5,2),
  prixBas		NUMERIC(5,2),
  prixMoyen	    NUMERIC(5,2),
  CONSTRAINT pk_typeChambre PRIMARY KEY(noTypeChambre),
 );

 print  'Cr�ation de la TABLE chambre...'
CREATE TABLE chambre(
  noChambre		NUMERIC(5) NOT NULL ,
  emplacement	VARCHAR(50),
  decorations	VARCHAR(50),
  noTypeChambre NUMERIC(5),
  CONSTRAINT pk_chambre PRIMARY KEY(noChambre),
  CONSTRAINT fk_noTypeChambre FOREIGN KEY (noTypeChambre) REFERENCES typeChambre(noTypeChambre)
 );

  print  'Cr�ation de la TABLE client...'
CREATE TABLE client(
  noClient			NUMERIC(5) NOT NULL ,
  nom				VARCHAR(50),
  prenom			VARCHAR(50),
  ville				VARCHAR(50),
  pays				VARCHAR(50),
  adresse			VARCHAR(50),
  codePostal		VARCHAR(50),
  dateInscription	DATETIME,
  CONSTRAINT pk_client PRIMARY KEY(noClient),
 );

   print  'Cr�ation de la TABLE invite...'
CREATE TABLE invite(
  noInvite			NUMERIC(5) NOT NULL ,
  nomPrenom			VARCHAR(50),
  noClient			NUMERIC(5),
  CONSTRAINT pk_invite PRIMARY KEY(noInvite),
  CONSTRAINT fk_noClientInvite FOREIGN KEY (noClient) REFERENCES client(noClient)
 );

    print  'Cr�ation de la TABLE reservationChambre...'
CREATE TABLE reservationChambre(
  noClient			NUMERIC(5),
  noChambre			NUMERIC(5),
  dateArrivee		DATETIME,
  dateDepart		DATETIME,
  NbPersonnes		NUMERIC(5),
  CONSTRAINT pk_reservationChambre PRIMARY KEY(noClient,noChambre,dateArrivee),
  CONSTRAINT fk_noClientReservation FOREIGN KEY (noClient) REFERENCES client(noClient),
  CONSTRAINT fk_noChambre FOREIGN KEY (noChambre) REFERENCES chambre(noChambre)
 );

Print  'Cr�ation de la TABLE typeSoin...' 
CREATE TABLE typeSoin (
   noTypeSoin		NUMERIC(1) NOT NULL ,
   description		VARCHAR(50),
   CONSTRAINT pk_typeSoin  PRIMARY KEY(noTypeSoin)
   );

print 'Cr�ation de la TABLE soin...'
CREATE TABLE soin (
  noSoin		NUMERIC(5) NOT NULL ,
  description	VARCHAR(50),
  duree			VARCHAR(50),
  noTypeSoin	NUMERIC(1),
  prix			NUMERIC(5,2), 
 CONSTRAINT pk_soin PRIMARY KEY(noSoin),
 CONSTRAINT fk_noTypeSoin FOREIGN KEY (noTypeSoin) REFERENCES typeSoin(noTypeSoin)
  );

Print  'Cr�ation de la TABLE assistant...'
CREATE TABLE assistant (
  noAssistant	NUMERIC(5) NOT NULL ,  
  prenom		VARCHAR(50),
  nom			VARCHAR(50), 
  specialites	VARCHAR(50),   
  remarques 	VARCHAR(50),
  CONSTRAINT pk_assistant PRIMARY KEY(noAssistant),
  
  );

Print  'Cr�ation de la TABLE planifSoin...'
CREATE TABLE planifSoin (
  noPersonne		NUMERIC(5) NOT NULL ,  
  noAssistant 		NUMERIC(5),
  dateHeure			DATETIME,
  noSoin			NUMERIC(5), 
  CONSTRAINT pk_planifSoin PRIMARY KEY(noPersonne, noAssistant, dateHeure),
  CONSTRAINT fk_noSoinPlanifSoin FOREIGN KEY(noSoin) references soin(noSoin),
  CONSTRAINT fk_noAssistantPlanifSoin FOREIGN KEY(noAssistant) references  assistant(noAssistant)

);

Print  'Cr�ation de la TABLE assistantSoin...'
CREATE TABLE assistantSoin (
  noAssistant		NUMERIC(5),    
  noSoin			NUMERIC(5),
 CONSTRAINT fk_noAssistantAssistantSoin FOREIGN KEY(noAssistant) REFERENCES assistant(noAssistant),
 CONSTRAINT fk_noSoinAssistantSoin FOREIGN KEY(noSoin) REFERENCES soin(noSoin)
);

print ''
print  'Cr�ation de la TABLE typeUtilisateur...'
CREATE TABLE typeUtilisateur (
  noTypeUtilisateur		NUMERIC(5) NOT NULL ,    
  identification		VARCHAR(50),
 CONSTRAINT pk_typeUtilisateur PRIMARY KEY(noTypeUtilisateur)
);

print ''
print  'Cr�ation de la TABLE utilisateur...'
CREATE TABLE utilisateur (
  noUtilisateur			NUMERIC(5) NOT NULL ,    
  nomUtilisateur		VARCHAR(50) NOT NULL UNIQUE,
  password				VARCHAR(50),
  noTypeUtilisateur		NUMERIC(5),
 CONSTRAINT pk_utilisateur PRIMARY KEY(noUtilisateur),
 CONSTRAINT fk_noTypeUtilisateur FOREIGN KEY(noTypeUtilisateur) REFERENCES typeUtilisateur(noTypeUtilisateur)
);
/*
print ''
print  'ajout info dans la TABLE typeUtilisateur...'
Insert into typeUtilisateur values (1, 'Admin'), (2, 'Prepose') ;

print ''
print  'ajout info dans la TABLE typeSoin...'
Insert into typeSoin values (1, 'Beauté'), (2, 'Santé') ;

print ''
print  'ajout info dans la TABLE typeSoin...'
Insert into utilisateur values (1, 'Admin', 'Password1', 1), (2, 'Prepose', 'Password1', 2) ;


*/













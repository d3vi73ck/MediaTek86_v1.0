-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 12 avr. 2021 à 23:44
-- Version du serveur :  8.0.21
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : mediatek86
--
CREATE DATABASE IF NOT EXISTS mediatek86 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;

CREATE USER 'mediatek86'@'%' IDENTIFIED BY 'dbuser';
GRANT USAGE ON *.* TO 'mediatek86'@'%';
GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'mediatek86'@'%';

USE mediatek86;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  IDPERSONNEL int NOT NULL,
  DATEDEBUT datetime NOT NULL,
  IDMOTIF int NOT NULL,
  DATEFIN datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;


-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  IDMOTIF int NOT NULL,
  LIBELLE varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (IDMOTIF, LIBELLE) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  IDPERSONNEL int NOT NULL,
  IDSERVICE int NOT NULL,
  NOM varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRENOM varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  TEL varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  MAIL varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (IDPERSONNEL, IDSERVICE, NOM, PRENOM, TEL, MAIL) VALUES
(1, 1, 'Natasha', 'Karen', '0603697562', 'karen.natasha@mediatek86.com');

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  pwd varchar(64) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('responsable', 'c1baa00c8d72d119c5518758c4716d43480c9826e2a51135b9c567660bf0f7e5');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE service (
  IDSERVICE int NOT NULL,
  NOM varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (IDSERVICE, NOM) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (IDPERSONNEL,DATEDEBUT),
  ADD KEY FK_ABSENCE_MOTIF (IDMOTIF);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (IDMOTIF);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (IDPERSONNEL),
  ADD KEY FK_PERSONNEL_SERVICE (IDSERVICE);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (IDSERVICE);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY IDMOTIF int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY IDPERSONNEL int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY IDSERVICE int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table absence
--
ALTER TABLE absence
  ADD CONSTRAINT absence_ibfk_1 FOREIGN KEY (IDMOTIF) REFERENCES motif (IDMOTIF),
  ADD CONSTRAINT absence_ibfk_2 FOREIGN KEY (IDPERSONNEL) REFERENCES personnel (IDPERSONNEL);

--
-- Contraintes pour la table personnel
--
ALTER TABLE personnel
  ADD CONSTRAINT personnel_ibfk_1 FOREIGN KEY (IDSERVICE) REFERENCES service (IDSERVICE);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

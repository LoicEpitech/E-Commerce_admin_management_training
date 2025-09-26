-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 20 avr. 2025 à 18:13
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;










CREATE DEFINER=`root`@`localhost` FUNCTION `_selectDateLastCommande` (`idUtilisateur` INT) RETURNS DATE DETERMINISTIC BEGIN
    DECLARE derniereDate DATE;

    SELECT MAX(dateCommande) INTO derniereDate
    FROM commande
    WHERE idUtilisateur = idUtilisateur;

    RETURN derniereDate;
END$$

DROP FUNCTION IF EXISTS `_selectNbCommandesByClient`$$
CREATE DEFINER=`root`@`localhost` FUNCTION `_selectNbCommandesByClient` (`paramIdClient` INT) RETURNS INT  BEGIN

DECLARE nbCommandes INT;

SET nbCommandes = (SELECT COUNT(idCommande) FROM commande WHERE commande.idUtilisateur = paramIdCLient);

RETURN nbCommandes;

END$$

DROP FUNCTION IF EXISTS `_selectStockProduit`$$
CREATE DEFINER=`root`@`localhost` FUNCTION `_selectStockProduit` (`idProduit` INT) RETURNS INT DETERMINISTIC BEGIN
    DECLARE stock INT;

    -- Récupère la quantité en stock pour le produit spécifié
    SELECT QteStockProduit INTO stock
    FROM produit
    WHERE idProduit = idProduit;

    RETURN COALESCE(stock, 0);
END$$

DROP FUNCTION IF EXISTS `_VerifUtilisateurImpayer`$$
CREATE DEFINER=`root`@`localhost` FUNCTION `_VerifUtilisateurImpayer` (`idUtilisateur` INT) RETURNS TINYINT(1) DETERMINISTIC BEGIN
    DECLARE impayes INT;

    -- Compte les commandes non soldées pour l'utilisateur
    SELECT COUNT(*) INTO impayes
    FROM commande
    WHERE idUtilisateur = idUtilisateur AND isNotSolde = 1;

    RETURN impayes > 0;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `idCategorie` int NOT NULL,
  `LibelleCategorie` varchar(45) DEFAULT NULL,
  `CaCategorie` float DEFAULT NULL,
  PRIMARY KEY (`idCategorie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`idCategorie`, `LibelleCategorie`, `CaCategorie`) VALUES
(1, 'Materiel', 2160),
(2, 'Ordinateur', 8250),
(4, 'Documentation', 2838.5);

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `idCommande` int NOT NULL,
  `DateCommande` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_mysql500_ci DEFAULT NULL,
  `idUtilisateur` int DEFAULT NULL,
  `isNotSolde` tinyint(1) NOT NULL DEFAULT '1',
  `attenteDeReglement` tinyint DEFAULT '0',
  PRIMARY KEY (`idCommande`),
  KEY `FKCli` (`idUtilisateur`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`idCommande`, `DateCommande`, `idUtilisateur`, `isNotSolde`, `attenteDeReglement`) VALUES
(1, '19/11/2021', 1, 0, 0),
(3, '26/11/2021', 1, 0, 0),
(5, '05/12/2024', 1, 1, 0),
(6, '05/12/2024', 1, 1, 0);

--
-- Déclencheurs `commande`
--
DROP TRIGGER IF EXISTS `_before_insert_COMMANDE_verifPaiement`;
DELIMITER $$
CREATE TRIGGER `_before_insert_COMMANDE_verifPaiement` BEFORE INSERT ON `commande` FOR EACH ROW BEGIN
    DECLARE myIdClient INTEGER;
    DECLARE myCompteur INTEGER;
    DECLARE myMessage VARCHAR(100);

    SET myIdClient = NEW.idUtilisateur;

    SET myCompteur = (SELECT COUNT(*) 
                      FROM commande 
                      WHERE idUtilisateur = myIdClient 
                        AND attenteDeReglement = 1);

    IF myCompteur > 0 THEN
        SET myMessage = 'Désolé, il faut d abord régler toutes les anciennes commandes';
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = myMessage;
    END IF;
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `_notifCommande`;
DELIMITER $$
CREATE TRIGGER `_notifCommande` AFTER INSERT ON `commande` FOR EACH ROW BEGIN
    DECLARE message VARCHAR(255);

    -- Créer le message de notification
    SET message = CONCAT('Merci pour votre commande n°', NEW.idCommande, ' ! Elle est en cours de traitement.');

    -- Insérer la notification dans la table notification
    INSERT INTO notification (idUtilisateur, message, dateNotification)
    VALUES (NEW.idUtilisateur, message, NOW());
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `favorisutilisateur`
--

DROP TABLE IF EXISTS `favorisutilisateur`;
CREATE TABLE IF NOT EXISTS `favorisutilisateur` (
  `idUtilisateur` int NOT NULL,
  `idProduit` int NOT NULL,
  PRIMARY KEY (`idUtilisateur`,`idProduit`),
  KEY `FK_PRODUIT` (`idProduit`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `favorisutilisateur`
--

INSERT INTO `favorisutilisateur` (`idUtilisateur`, `idProduit`) VALUES
(22, 10),
(22, 11),
(22, 12),
(26, 1);

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

DROP TABLE IF EXISTS `fournisseur`;
CREATE TABLE IF NOT EXISTS `fournisseur` (
  `idFournisseur` int NOT NULL,
  `NomFournisseur` varchar(100) DEFAULT NULL,
  `VilleFournisseur` varchar(100) DEFAULT NULL,
  `CPFournisseur` int DEFAULT NULL,
  PRIMARY KEY (`idFournisseur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `fournisseur`
--

INSERT INTO `fournisseur` (`idFournisseur`, `NomFournisseur`, `VilleFournisseur`, `CPFournisseur`) VALUES
(1, 'DELL Computers', 'Montpellier', 34000),
(2, 'IBM', 'Montpellier', 34000),
(3, 'RC Consulting', 'Sérignan', 34500);

-- --------------------------------------------------------

--
-- Structure de la table `lignedecommande`
--

DROP TABLE IF EXISTS `lignedecommande`;
CREATE TABLE IF NOT EXISTS `lignedecommande` (
  `idCommande` int NOT NULL,
  `idProduit` int NOT NULL,
  `QuantiteCom` int NOT NULL,
  PRIMARY KEY (`idCommande`,`idProduit`),
  KEY `FKCom` (`idCommande`),
  KEY `FKProd` (`idProduit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `lignedecommande`
--

INSERT INTO `lignedecommande` (`idCommande`, `idProduit`, `QuantiteCom`) VALUES
(1, 1, 2),
(1, 6, 5),
(3, 1, 3),
(5, 1, 2),
(6, 1, 2);

--
-- Déclencheurs `lignedecommande`
--
DROP TRIGGER IF EXISTS `_before_insert_LIGNEDECOMMANDE_updateQteStockProduit`;
DELIMITER $$
CREATE TRIGGER `_before_insert_LIGNEDECOMMANDE_updateQteStockProduit` BEFORE INSERT ON `lignedecommande` FOR EACH ROW BEGIN
    DECLARE myQteCom INT;
    DECLARE myIdProduit INT;

    -- Get the quantity and product ID from the new order line
    SET myQteCom = NEW.QuantiteCom;
    SET myIdProduit = NEW.idProduit;

    -- Update the stock in the product table
    UPDATE produit
    SET QteStockProduit = QteStockProduit - myQteCom
    WHERE idProduit = myIdProduit;
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `_verif_stock_before_achat`;
DELIMITER $$
CREATE TRIGGER `_verif_stock_before_achat` BEFORE INSERT ON `lignedecommande` FOR EACH ROW BEGIN
    DECLARE stockDisponible INT;
    DECLARE idProduit INT;

    SET idProduit = NEW.idProduit;

    -- Récupérer le stock disponible avec LIMIT 1
    SELECT QteStockProduit INTO stockDisponible
    FROM produit
    WHERE idProduit = NEW.idProduit
    LIMIT 1;

    -- Valider le stock
    IF stockDisponible < NEW.QuantiteCom THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Insufficient stock available';
    END IF;
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `tr_after_insert_lignedecommande`;
DELIMITER $$
CREATE TRIGGER `tr_after_insert_lignedecommande` AFTER INSERT ON `lignedecommande` FOR EACH ROW BEGIN
    -- Vérifier si le stock est suffisant
    IF (SELECT QteStockProduit FROM produit WHERE idProduit = NEW.idProduit) < NEW.QuantiteCom THEN
        -- Lever une erreur si le stock est insuffisant
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Stock insuffisant pour le produit';
    ELSE
        -- Sinon, mettre à jour le stock du produit
        UPDATE produit
        SET QteStockProduit = QteStockProduit - NEW.QuantiteCom
        WHERE idProduit = NEW.idProduit;
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `notification`
--

DROP TABLE IF EXISTS `notification`;
CREATE TABLE IF NOT EXISTS `notification` (
  `idNotification` int NOT NULL AUTO_INCREMENT,
  `idUtilisateur` int NOT NULL,
  `message` varchar(255) NOT NULL,
  `dateNotification` datetime NOT NULL,
  PRIMARY KEY (`idNotification`),
  KEY `idUtilisateur` (`idUtilisateur`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `notification`
--

INSERT INTO `notification` (`idNotification`, `idUtilisateur`, `message`, `dateNotification`) VALUES
(1, 1, 'Merci pour votre commande n°4 ! Elle est en cours de traitement.', '2024-11-28 09:07:54'),
(2, 1, 'Merci pour votre commande n°5 ! Elle est en cours de traitement.', '2024-11-28 09:08:18'),
(3, 1, 'Merci pour votre commande n°6 ! Elle est en cours de traitement.', '2024-11-28 09:12:06'),
(4, 1, 'Merci pour votre commande n°7 ! Elle est en cours de traitement.', '2024-11-28 09:18:04'),
(5, 1, 'Merci pour votre commande n°8 ! Elle est en cours de traitement.', '2024-11-28 09:25:15'),
(6, 1, 'Merci pour votre commande n°9 ! Elle est en cours de traitement.', '2024-11-28 09:30:41'),
(7, 1, 'Merci pour votre commande n°10 ! Elle est en cours de traitement.', '2024-11-28 09:32:37'),
(8, 1, 'Merci pour votre commande n°11 ! Elle est en cours de traitement.', '2024-11-28 09:37:27'),
(9, 1, 'Merci pour votre commande n°4 ! Elle est en cours de traitement.', '2024-11-28 09:53:33'),
(10, 1, 'Merci pour votre commande n°5 ! Elle est en cours de traitement.', '2024-11-28 10:00:47'),
(11, 1, 'Merci pour votre commande n°6 ! Elle est en cours de traitement.', '2024-11-28 10:01:11'),
(12, 1, 'Merci pour votre commande n°7 ! Elle est en cours de traitement.', '2024-11-28 10:10:16'),
(13, 1, 'Merci pour votre commande n°8 ! Elle est en cours de traitement.', '2024-11-28 10:10:34'),
(14, 101, 'Merci pour votre commande n°8 ! Elle est en cours de traitement.', '2024-11-28 12:17:20'),
(15, 1, 'Merci pour votre commande n°5 ! Elle est en cours de traitement.', '2024-12-05 09:23:00'),
(16, 1, 'Merci pour votre commande n°6 ! Elle est en cours de traitement.', '2024-12-05 09:47:42'),
(17, 1, 'Merci pour votre commande n°7 ! Elle est en cours de traitement.', '2024-12-05 11:26:17'),
(18, 1, 'Merci pour votre commande n°7 ! Elle est en cours de traitement.', '2024-12-05 11:31:08'),
(19, 1, 'Merci pour votre commande n°7 ! Elle est en cours de traitement.', '2024-12-05 12:00:24'),
(20, 1, 'Merci pour votre commande n°7 ! Elle est en cours de traitement.', '2024-12-05 12:02:09'),
(21, 1, 'Merci pour votre commande n°7 ! Elle est en cours de traitement.', '2024-12-05 12:02:53'),
(22, 1, 'Merci pour votre commande n°10 ! Elle est en cours de traitement.', '2024-12-05 12:17:39'),
(23, 1, 'Merci pour votre commande n°11 ! Elle est en cours de traitement.', '2024-12-05 12:21:20'),
(24, 1, 'Merci pour votre commande n°10 ! Elle est en cours de traitement.', '2024-12-05 12:23:44'),
(25, 1, 'Merci pour votre commande n°10 ! Elle est en cours de traitement.', '2024-12-10 16:42:27');

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `idProduit` int NOT NULL,
  `LibelleProduit` varchar(100) DEFAULT NULL,
  `PrixHTProduit` float(6,2) DEFAULT NULL,
  `QteStockProduit` int DEFAULT NULL,
  `idFourn` int DEFAULT NULL,
  `idCat` int DEFAULT NULL,
  `ImageProduit` varchar(50) DEFAULT NULL,
  `nbVenteProduit` int DEFAULT NULL,
  PRIMARY KEY (`idProduit`),
  KEY `FKFourn` (`idFourn`),
  KEY `FKCat` (`idCat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`idProduit`, `LibelleProduit`, `PrixHTProduit`, `QteStockProduit`, `idFourn`, `idCat`, `ImageProduit`, `nbVenteProduit`) VALUES
(1, 'Moniteur Acer EK241YHbi ', 350.00, 144, 1, 1, 'image_ecran.jpg', 1),
(2, 'Souris Logitech G PRO X ', 890.00, 4, 2, 1, 'image_souris.jpg', 139),
(5, 'Clavier Razer Huntsman V2', 150.00, 13, 1, 1, 'image_clavier.jpg', 69),
(6, 'Support User', 150.00, 5, 3, 4, 'img_produit_support.png', 12),
(7, 'Ordinateur Gamer INFOMAX', 1500.00, 17, 3, 2, 'image_ordinateurfixe.jpg', 6),
(8, 'Ordinateur Portable Acer Nitro', 1480.99, 14, 3, 2, 'image_ordinateurportable.jpg', 5),
(9, 'Clé win.11 Pro', 100.00, 8, 3, 4, 'img_win11.png', 13),
(10, 'Clé win.11 Famille', 125.50, 100, 3, 4, 'img_win11.png', 39),
(12, 'Casque Gaming HyperX Cloud II', 150.00, 8, 3, 1, 'image_casque.jpg', 55);

-- --------------------------------------------------------

--
-- Structure de la table `redirectename`
--

DROP TABLE IF EXISTS `redirectename`;
CREATE TABLE IF NOT EXISTS `redirectename` (
  `nameTable` varchar(80) NOT NULL,
  `nameOfAtribut` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`nameTable`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `redirectename`
--

INSERT INTO `redirectename` (`nameTable`, `nameOfAtribut`) VALUES
('categorie', 'LibelleCategorie'),
('produit', 'LibelleProduit'),
('', '');

-- --------------------------------------------------------

--
-- Structure de la table `statsutilisateur`
--

DROP TABLE IF EXISTS `statsutilisateur`;
CREATE TABLE IF NOT EXISTS `statsutilisateur` (
  `idUtilisateur` int DEFAULT NULL,
  `nbTotalCommande` int DEFAULT NULL,
  `idProduitPlusCommander` int DEFAULT NULL,
  `montantTotalDepense` float DEFAULT NULL,
  `motantMoyenneCommande` float DEFAULT NULL,
  `dateHistorique` varchar(50) DEFAULT NULL,
  KEY `FK_PRODUIT` (`idProduitPlusCommander`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `statsutilisateur`
--

INSERT INTO `statsutilisateur` (`idUtilisateur`, `nbTotalCommande`, `idProduitPlusCommander`, `montantTotalDepense`, `motantMoyenneCommande`, `dateHistorique`) VALUES
(1, 2, 3, 10184, 1273, '2021-11-28 21:36:25'),
(1, 2, 3, 10934, 1215, '2021-11-30 16:12:49');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `idUtilisateur` int NOT NULL AUTO_INCREMENT,
  `loginUtilisateur` varchar(50) DEFAULT NULL,
  `passUtilisateur` varchar(50) DEFAULT NULL,
  `nomUtilisateur` varchar(100) DEFAULT NULL,
  `prenomUtilisateur` varchar(100) DEFAULT NULL,
  `emailUtilisateur` varchar(150) DEFAULT NULL,
  `telUtilisateur` varchar(50) DEFAULT NULL,
  `adresseRueUtilisateur` varchar(100) DEFAULT NULL,
  `adresseCpUtilisateur` int DEFAULT NULL,
  `adresseVilleUtilisateur` varchar(100) DEFAULT NULL,
  `adresseIpUtilisateur` varchar(50) DEFAULT NULL,
  `isAdmin` bit(1) NOT NULL DEFAULT b'0',
  `otpCode` int DEFAULT '0',
  PRIMARY KEY (`idUtilisateur`)
) ENGINE=MyISAM AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`idUtilisateur`, `loginUtilisateur`, `passUtilisateur`, `nomUtilisateur`, `prenomUtilisateur`, `emailUtilisateur`, `telUtilisateur`, `adresseRueUtilisateur`, `adresseCpUtilisateur`, `adresseVilleUtilisateur`, `adresseIpUtilisateur`, `isAdmin`, `otpCode`) VALUES
(1, 'loicadmin', '8fcefc9c19389570dd38c4b90827f8ebead924c7', 'Noro', 'Loic', 'r.robin34500@gmail.com', '0606060606', '2 Rue De Pot', 77000, 'Béziers', '127.0.0.1', b'1', 0),
(21, 'Username', 'dc1af77d2e5ce67bbc5547b1bb56771c0b952c77', 'NAME', 'Lastname3', 'email@email.fr', '0617522577', 'Adresse', 34500, 'Béziers', '::1', b'0', 0),
(22, 'loicadmin', '8fcefc9c19389570dd38c4b90827f8ebead924c7', 'noro', 'loic', 'loico34noro@gmail.com', '06584484', 'fffdsf', 20500, 'sdfsdfs', '::1', b'1', 229873),
(23, 'loic17', '8fcefc9c19389570dd38c4b90827f8ebead924c7', 'noro', 'loic', 'loico34noro@gmail.com', '0620411670', '4 rue de l\'artois', 34500, 'béziers', '::1', b'0', 229873);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `lignedecommande`
--
ALTER TABLE `lignedecommande`
  ADD CONSTRAINT `FKProd` FOREIGN KEY (`idProduit`) REFERENCES `produit` (`idProduit`);

--
-- Contraintes pour la table `produit`
--
ALTER TABLE `produit`
  ADD CONSTRAINT `FKCat` FOREIGN KEY (`idCat`) REFERENCES `categorie` (`idCategorie`),
  ADD CONSTRAINT `FKFourn` FOREIGN KEY (`idFourn`) REFERENCES `fournisseur` (`idFournisseur`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

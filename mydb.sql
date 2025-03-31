-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`User` (
  `idUser` INT NOT NULL AUTO_INCREMENT,
  `Username` VARCHAR(45) NULL,
  `Password` VARCHAR(45) NULL,
  PRIMARY KEY (`idUser`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Admin`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Admin` (
  `idAdmin` INT NOT NULL AUTO_INCREMENT,
  `Username` VARCHAR(30) NULL,
  `Password` VARCHAR(20) NULL,
  PRIMARY KEY (`idAdmin`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Clothes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Clothes` (
  `idClothes` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `Category` VARCHAR(45) NULL,
  `Color` VARCHAR(45) NULL,
  `Season` VARCHAR(45) NULL,
  PRIMARY KEY (`idClothes`),
  CONSTRAINT `idUser`
    FOREIGN KEY ()
    REFERENCES `mydb`.`User` ()
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Outfit`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Outfit` (
  `idOutfit` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `Creation_date` DATETIME NULL,
  PRIMARY KEY (`idOutfit`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Complaints`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Complaints` (
  `idComplaints` INT NOT NULL AUTO_INCREMENT,
  `Subject` VARCHAR(45) NULL,
  `Text` VARCHAR(200) NULL,
  PRIMARY KEY (`idComplaints`),
  CONSTRAINT `idUser`
    FOREIGN KEY (`idComplaints`)
    REFERENCES `mydb`.`User` (`idUser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idAdmin`
    FOREIGN KEY (`idComplaints`)
    REFERENCES `mydb`.`Admin` (`idAdmin`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`OutfitClothes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`OutfitClothes` (
  `idOutfitClothes` INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idOutfitClothes`),
  CONSTRAINT `idClothes`
    FOREIGN KEY (`idOutfitClothes`)
    REFERENCES `mydb`.`Clothes` (`idClothes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idOutfit`
    FOREIGN KEY (`idOutfitClothes`)
    REFERENCES `mydb`.`Outfit` (`idOutfit`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Events`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Events` (
  `idEvents` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NULL,
  `Date` DATETIME NULL,
  PRIMARY KEY (`idEvents`),
  CONSTRAINT `idOutfit`
    FOREIGN KEY (`idEvents`)
    REFERENCES `mydb`.`Outfit` (`idOutfit`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

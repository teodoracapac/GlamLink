CREATE DATABASE GLAMLINK;
GO

USE GLAMLINK;
GO

-- User Table
CREATE TABLE Users (
  idUser INT IDENTITY(1,1) PRIMARY KEY,
  Username NVARCHAR(45) NULL,
  Password NVARCHAR(45) NULL
);

-- Admin Table
CREATE TABLE Admins (
  idAdmin INT IDENTITY(1,1) PRIMARY KEY,
  Username NVARCHAR(30) NULL,
  Password NVARCHAR(20) NULL
);

-- Clothes Table
CREATE TABLE Clothes (
  idClothes INT IDENTITY(1,1) PRIMARY KEY,
  Name NVARCHAR(45) NULL,
  Category NVARCHAR(45) NULL,
  Color NVARCHAR(45) NULL,
  Season NVARCHAR(45) NULL,
  idUser INT FOREIGN KEY REFERENCES Users(idUser)
);

-- Outfit Table
CREATE TABLE Outfit (
  idOutfit INT IDENTITY(1,1) PRIMARY KEY,
  Name NVARCHAR(45) NULL,
  Creation_date DATETIME NULL
);

-- Complaints Table
CREATE TABLE Complaints (
  idComplaints INT IDENTITY(1,1) PRIMARY KEY,
  Subject NVARCHAR(45) NULL,
  Text NVARCHAR(200) NULL,
  idUser INT FOREIGN KEY REFERENCES Users(idUser),
  idAdmin INT FOREIGN KEY REFERENCES Admins(idAdmin)
);

-- OutfitClothes Table
CREATE TABLE OutfitClothes (
  idOutfitClothes INT IDENTITY(1,1) PRIMARY KEY,
  idClothes INT FOREIGN KEY REFERENCES Clothes(idClothes),
  idOutfit INT FOREIGN KEY REFERENCES Outfit(idOutfit)
);

-- Events Table
CREATE TABLE Events (
  idEvents INT IDENTITY(1,1) PRIMARY KEY,
  Name NVARCHAR(45) NULL,
  Date DATETIME NULL,
  idOutfit INT FOREIGN KEY REFERENCES Outfit(idOutfit)
);

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `sdvcWebapp` DEFAULT CHARACTER SET utf8 ;
USE `sdvcWebapp` ;

-- -----------------------------------------------------
-- Table `beltexam`.`users`
-- -----------------------------------------------------


CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`keywords`(
    id INT NOT NULL AUTO_INCREMENT,
    kw VARCHAR(100) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`states`(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`donation_types`(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`statuses`(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    img VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`branches`(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    img VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`questions`(
    id INT NOT NULL AUTO_INCREMENT,
    q VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
)
ENGINE = InnoDB;

-- All tables without primary keys must be placed at the top of the SQL script

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`cities`(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    state_id INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (state_id) REFERENCES `sdvcWebapp`.`states`(id)
    -- state_id INT NOT NULL REFERENCES states(id),
    -- PRIMARY KEY (id, state_id),
    -- FOREIGN KEY(state_id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`zipcodes`(
    id INT NOT NULL AUTO_INCREMENT,
    code INT NOT NULL,
    code2 INT NULL,
    city_id INT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (city_id) REFERENCES `sdvcWebapp`.`cities`(id)
)
ENGINE = InnoDB;




CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`vets`(
    id INT NOT NULL AUTO_INCREMENT,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    phone VARCHAR(255) NULL,
    email VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    branch_id INT NOT NULL,
    service_start DATE NULL,
    service_end DATE NULL,
    show_info INT DEFAULT 0,
    admin INT DEFAULT 0,
    disability_rate INT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (branch_id) REFERENCES `sdvcWebapp`.`branches`(id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`vsos`(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    headline VARCHAR(255) NOT NULL,
    description TEXT NOT NULL,
    img VARCHAR(255) NULL,
    poc_name VARCHAR(255) NOT NULL,
    poc_phone VARCHAR(20) NOT NULL,
    poc_email VARCHAR(255) NOT NULL,
    address_1 VARCHAR(255) NOT NULL,
    address_2 VARCHAR(255) NULL,
    zip_id INT NOT NULL,
    disability_rate INT NULL,
    emer_phone VARCHAR(20) NULL,
    approved INT DEFAULT 0,
    approver_id INT NULL,
    verifier_name VARCHAR(255) NULL,
    verifier_email VARCHAR(255) NULL,
    password VARCHAR(255) NULL,
    website VARCHAR(255) NULL,
    status_id INT DEFAULT 1,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id, status_id),
    FOREIGN KEY (approver_id) REFERENCES `sdvcWebapp`.`vets`(id),
    FOREIGN KEY (zip_id) REFERENCES `sdvcWebapp`.`zipcodes`(id),
    FOREIGN KEY (status_id) REFERENCES `sdvcWebapp`.`statuses`(id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`reviews`(
    id  INT NOT NULL AUTO_INCREMENT,
    rating INT NOT NULL,
    review TEXT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    vet_id INT NOT NULL,
    vso_id INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (vet_id) REFERENCES `sdvcWebapp`.`vets`(id),
    FOREIGN KEY (vso_id) REFERENCES `sdvcWebapp`.`vsos`(id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`services`(
    id INT NOT NULL AUTO_INCREMENT,
    vet_id INT NOT NULL,
    vso_id INT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (vso_id) REFERENCES `sdvcWebapp`.`vsos`(id),
    FOREIGN KEY (vet_id) REFERENCES `sdvcWebapp`.`vets`(id)
)
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`donations`(
    id INT NOT NULL AUTO_INCREMENT,
    vso_id INT NULL,
    vet_id INT NULL,
    donor VARCHAR(255) NULL,
    donor_info VARCHAR(255) NULL,
    amount DECIMAL(8,2) NOT NULL,
    type_id INT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (type_id) REFERENCES `sdvcWebapp`.`donation_types`(id),
    FOREIGN KEY (vso_id) REFERENCES `sdvcWebapp`.`vsos`(id),
    FOREIGN KEY (vet_id) REFERENCES `sdvcWebapp`.`vets`(id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`logins`(
    id INT NOT NULL AUTO_INCREMENT,
    vet_id INT NULL,
    vso_id INT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (vso_id) REFERENCES `sdvcWebapp`.`vsos`(id),
    FOREIGN KEY (vet_id) REFERENCES `sdvcWebapp`.`vets`(id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`endorsements`(
    id INT NOT NULL AUTO_INCREMENT,
    kw_id INT NOT NULL,
    vso_id INT NOT NULL,
    vet_id INT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (vso_id) REFERENCES `sdvcWebapp`.`vsos`(id),
    FOREIGN KEY (vet_id) REFERENCES `sdvcWebapp`.`vets`(id),
    FOREIGN KEY (kw_id) REFERENCES `sdvcWebapp`.`keywords`(id)
)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`answers`(
    id INT NOT NULL AUTO_INCREMENT,
    vet_id INT NOT NULL,
    q_id INT NOT NULL,
    a VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY(vet_id) REFERENCES `sdvcWebapp`.`vets`(id),
    FOREIGN KEY(q_id) REFERENCES `sdvcWebapp`.`questions`(id)
)
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS `sdvcWebapp`.`comments`(
    id INT NOT NULL AUTO_INCREMENT,
    content TEXT NOT NULL,
    vet_id INT NULL,
    review_id INT NOT NULL,
    vso_id INT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY (review_id) REFERENCES `sdvcWebapp`.`reviews`(id),
    FOREIGN KEY (vet_id) REFERENCES `sdvcWebapp`.`vets`(id),
    FOREIGN KEY (vso_id) REFERENCES `sdvcWebapp`.`vsos`(id)
)
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

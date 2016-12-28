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
    name VARCHAR(2) NOT NULL,
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
    content TEXT NOT NULL,
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


INSERT INTO `sdvcWebapp`.`states` (name, created_at, updated_at) VALUES ("CA", NOW(), NOW());

INSERT INTO `sdvcWebapp`.`cities` (name, state_id, created_at, updated_at) VALUES ("San Diego", 1, NOW(), NOW());

INSERT INTO `sdvcWebapp`.`zipcodes` (code, city_id, created_at, updated_at) VALUES (92101 ,1, NOW(), NOW());
INSERT INTO `sdvcWebapp`.`zipcodes` (code, city_id, created_at, updated_at) VALUES (92102 ,1, NOW(), NOW());
INSERT INTO `sdvcWebapp`.`zipcodes` (code, city_id, created_at, updated_at) VALUES (92103 ,1, NOW(), NOW());
INSERT INTO `sdvcWebapp`.`zipcodes` (code, city_id, created_at, updated_at) VALUES (92104 ,1, NOW(), NOW());
INSERT INTO `sdvcWebapp`.`zipcodes` (code, city_id, created_at, updated_at) VALUES (92105 ,1, NOW(), NOW());

INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("health insurance", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("life insurance", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("tuition assistance", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("disabilties", NOW(), NOW());
 
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("religion", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("housing", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("transportation", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("legal aid", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("mental health", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("support group", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("funeral", NOW(), NOW());
INSERT INTO `sdvcWebapp`.`keywords` (kw, created_at, updated_at) VALUES ("family", NOW(), NOW());

-- SELECT zipcodes.code, cities.name, states.name FROM zipcodes INNER JOIN cities ON zipcodes.city_id=cities.id INNER JOIN states ON cities.state_id=states.id;

INSERT INTO branches (name, img, created_at, updated_at)
    VALUES ("United States Air Force", "./fake/path/usaf_logo.jpg", NOW(), NOW());
INSERT INTO branches (name, img, created_at, updated_at)
    VALUES ("United States Army", "./fake/path/army_logo.jpg", NOW(), NOW());
INSERT INTO branches (name, img, created_at, updated_at)
    VALUES ("United States Coast Guard", "./fake/path/coasties_logo.jpg", NOW(), NOW());
INSERT INTO branches (name, img, created_at, updated_at)
    VALUES ("United States Marine Corps", "./fake/path/corps_logo.jpg", NOW(), NOW());
INSERT INTO branches (name, img, created_at, updated_at)
    VALUES ("United States Navy", "./fake/path/navy_logo.jpg", NOW(), NOW());

INSERT INTO vets (first_name, last_name, phone, email, password, branch_id, created_at, updated_at)
	VALUES ("John", "Doe", "206-222-2222", "email@email.com", "hashedpw", 4, NOW(), NOW());

INSERT INTO vets (first_name, last_name, phone, email, password, branch_id, created_at, updated_at)
	VALUES ("John", "Dough", "206-222-2222", "email@email.com", "hashedpw", 1, NOW(), NOW());

INSERT INTO vets (first_name, last_name, phone, email, password, branch_id, created_at, updated_at)
	VALUES ("John", "Mattis", "206-222-2222", "email@email.com", "hashedpw", 4, NOW(), NOW());

-- Hash the pw, compare to sql query results if so, then add a logins entry for the user

INSERT INTO vets (first_name, last_name, phone, email, password, branch_id, created_at, updated_at, admin)
	VALUES ("Johnnie", "SDVC", "206-333-1111", "johnnie@sdvc.org", "hashedpw", 4, NOW(), NOW(), 1);

INSERT INTO statuses (name, img, created_at, updated_at) VALUES ("Bronze", "img", NOW(), NOW());

INSERT INTO vsos (name, headline, description, img, poc_name, poc_phone, poc_email, address_1, approved, approver_id, verifier_name, verifier_email, website, password, status_id, zip_id, created_at, updated_at) VALUES ("Name of VSO","VSO's Headline","VSO's description","./fake/path/img.jpeg","VSO Volunteer","444-444-4444","volunteer@vso.org","221B Baker Street",1,4,"Dana VSO","dana@VSO.org","https://nameofvso.org","hashedpw",1,1, NOW(), NOW());


-- Admin Queries

-- SELECT branches.name, COUNT(vets.branch_id) "Number of Vets per Branch" FROM vets INNER JOIN branches ON vets.branch_id=branches.id GROUP BY branches.name;

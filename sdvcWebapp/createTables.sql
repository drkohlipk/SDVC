CREATE TABLE cities(    --DONE--
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    state_id INT NOT NULL,
    PRIMARY KEY (id, state_id)
);

CREATE TABLE states(    --DONE--
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
)

CREATE TABLE zipcodes(  --DONE--
    id INT NOT NULL AUTO_INCREMENT,
    code INT NOT NULL,
    code2 INT NOT NULL,
    city_id INT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id, city_id)
)

CREATE TABLE reviews(   --DONE--
    id  INT NOT NULL AUTO_INCREMENT,
    rating INT NOT NULL, --need to  restrict to a certain range of numbers
    review TEXT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    vet_id INT NOT NULL,
    vso_id INT NOT NULL,
    PRIMARY KEY (id, vet_id, vso_id)

);

CREATE TABLE services(  --DONE--
    id INT NOT NULL AUTO_INCREMENT,
    vet_id INT NOT NULL,
    vso_id INT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id, vet_id, vso_id)
);

CREATE TABLE keywords(  --DONE--
    id INT NOT NULL AUTO_INCREMENT,
    kw VARCHAR(100) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE vets(  --DONE--
    id INT NOT NULL AUTO_INCREMENT,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    phone VARCHAR(255) NULL,
    email VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    branch_id INT NOT NULL,
    service_start DATE NULL,
    service_end DATE NULL,
    show_info INT DEFAULT 0,  --INT IN PLACE FOR TINYINT
    admin INT DEFAULT 0,  --INT IN PLACE FOR TINYINT
    disability_rate INT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id, branch_id)
);

CREATE TABLE vsos(
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
    PRIMARY KEY (id, status_id, zip_id, approver_id)
);

CREATE TABLE donations(
    id INT NOT NULL AUTO_INCREMENT,
    vso_id INT NULL,
    vet_id INT NULL,
    donor VARCHAR(255) NULL,
    donor_info VARCHAR(255) NULL,
    amount INT NOT NULL,
    type VARCHAR(40) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id, vso_id)
);

CREATE TABLE logins(
    id INT NOT NULL AUTO_INCREMENT,
    vet_id INT NULL,
    vso_id INT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE endorsements(
    id INT NOT NULL AUTO_INCREMENT,
    kw_id INT NOT NULL,
    vso_id INT NOT NULL,
    vet_id INT NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id, kw_id, vso_id, vet_id)
);

CREATE TABLE statuses(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    img VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE branches(
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    img VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
);

CREATE TABLE questions(
    id INT NOT NULL AUTO_INCREMENT,
    q VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id)
)

CREATE TABLE answers(
    id INT NOT NULL AUTO_INCREMENT,
    vet_id INT NOT NULL,
    q_id INT NOT NULL,
    a VARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY (id, q_id, vet_id)
);

CREATE TABLE comments(
    id INT NOT NULL AUTO_INCREMENT,
    content TEXT NOT NULL,
    vet_id INT NULL,
    review_id INT NOT NULL,
    vso_id INT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    PRIMARY KEY(id, vet_id, review_id, vso_id)
);

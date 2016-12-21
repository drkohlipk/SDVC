-- contains sql queries for direct usage and templates for the dapper queries
-- temporary log on changes to .cs models (see comments below)

INSERT INTO states (name, created_at, updated_at)
    VALUES ("California", NOW(), NOW());

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

-- SELECT * FROM vets;

SELECT * FROM vets
	JOIN branches ON branches.id = vets.branch_id;


-- Dapper queries:

-- vet creation:
-- query = "INSERT INTO vets (first_name, last_name, phone, email, password, branch_id, service_start, service_end, disability_rate, created_at, updated_at) VALUES (@first_name, @last_name, @phone, @email, @password, @branch_id, @service_start, @service_end, @disability_rating, NOW(), NOW());"

-- .cs model changes:

-- Added [table_name]_id int fields to the following models for db CRUD ops
-- answers, cities, comments, donation, endorsement, login
-- question, review, service, vets, vsos, zipcode

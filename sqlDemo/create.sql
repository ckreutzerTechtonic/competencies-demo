CREATE TABLE competencies_demo.pitBullFriendlyRentalCompanies (
  agency_id int NOT NULL AUTO_INCREMENT,
  agency_name VARCHAR(45) NOT NULL,
  breed_ban BOOLEAN,
  notes VARCHAR(100),
  PRIMARY KEY(agency_id)
);

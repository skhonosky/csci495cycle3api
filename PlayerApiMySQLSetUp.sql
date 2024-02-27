CREATE DATABASE csci495cycle3webapi;
USE csci495cycle3webapi;
CREATE USER 'csci495user'@'localhost' IDENTIFIED BY 'csci495pass';
GRANT ALL PRIVILEGES ON *.* TO 'csci495user'@'localhost' WITH GRANT OPTION;

DROP TABLE IF EXISTS Players;

CREATE TABLE Players (
 Name VARCHAR(100), 
 Age int, 
 Sport VARCHAR(100), 
 Team VARCHAR(50),
 Position VARCHAR(50),
 PRIMARY KEY (Name)
 );
 
  
INSERT INTO Players VALUES ("Travis Kelce", 34, "Football", "Kansas City Chiefs", "Tight End");
INSERT INTO Players VALUES ("Patrick Mahomes", 28, "Football", "Kansas City Chiefs", "Quarterback");
INSERT INTO Players VALUES ("Dak Prescott", 30, "Football", "Dallas Cowboys", "Quarterback");
INSERT INTO Players VALUES ("Rashee Rice", 23, "Football", "Kansas City Chiefs", "Wide Receiver");
INSERT INTO Players VALUES ("Isaiah Pacheco", 24, "Football", "Kansas City Chiefs", "Running Back");
INSERT INTO Players VALUES ("Tyreek Hill", 29, "Football", "Miami Dolphins", "Wide Receiver");

INSERT INTO Players VALUES ("Trevon Diggs", 25, "Football", "Dallas Cowboys", "Cornerback");
INSERT INTO Players VALUES ("CeeDee Lamb", 24, "Football", "Dallas Cowboys", "Wide Receiver");
INSERT INTO Players VALUES ("Tua Tagovailoa", 25, "Football", "Miami Dolphins", "Quarterback");
INSERT INTO Players VALUES ("Jalen Ramsey", 29, "Football", "Miami Dolphins", "Cornerback");
INSERT INTO Players VALUES ("Jalen Hurts", 25, "Football", "Philadelphia Eagles", "Quarterback");
INSERT INTO Players VALUES ("Ben VanSumeren", 23, "Football", "Philadelphia Eagles", "Linebacker");

INSERT INTO Players VALUES ("Lonzo Ball", 26, "Basketball", "Chicago Bulls", "Point Guard");
INSERT INTO Players VALUES ("Coby White", 24, "Basketball", "Chicago Bulls", "Point Guard");
INSERT INTO Players VALUES ("DeMar DeRozan", 34, "Basketball", "Chicago Bulls", "Small Forward");
INSERT INTO Players VALUES ("Jimmy Butler", 34, "Basketball", "Miami Heat", "Small Forward");
INSERT INTO Players VALUES ("Kyle Lowry", 37, "Basketball", "Miami Heat", "Point Gaurd");
INSERT INTO Players VALUES ("Jamal Cain", 24, "Basketball", "Miami Heat", "Small Forward");


Select * From Players;
 
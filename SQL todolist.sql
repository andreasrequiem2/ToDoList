USE ToDoList

CREATE TABLE category
(
	id_category int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	name_category varchar(150)  NOT NULL,
);

CREATE TABLE thing_to_do
(
	id int IDENTITY(1,1) NOT NULL,
	thing varchar(200) NOT NULL,
	due date,
	is_done bit NOT NULL,
	id_category int FOREIGN KEY(id) REFERENCES category(id_category)
);

INSERT INTO category (name_category)
VALUES ('sport'),
	   ('homework'),
	   ('hometask'),
	   ('to_buy')

SELECT* FROM category

INSERT INTO thing_to_do(thing, due, is_done, id_category)
VALUES ('buy 2kg of potato', '2023-04-05', 0, 4),
	   ('do 50 push-ups', '2023-04-05', 0, 1)
	   
SELECT* FROM thing_to_do



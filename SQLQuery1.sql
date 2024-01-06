create database Project

use Project

create table Cars (
    car_id int primary key identity (1, 1),
    brand nvarchar(100) not null unique check (brand is NOT NULL),
    model nvarchar(100) not null check (model is NOT NULL),
    year int not null check (year is NOT NULL),
    fuel_type_id int foreign key references FuelTypes(fuel_type_id),
    body_type_id int foreign key references BodyTypes(body_type_id),
    color_id int foreign key references Colors(color_id),
    image_link nvarchar(200)
);


create table Users (
    user_id int primary key identity (1, 1),
    username nvarchar(100) not null unique check (username is NOT NULL),
    password nvarchar(255) NOT NULL check (password is NOT NULL),
    email nvarchar(100) NOT NULL unique check (email is NOT NULL)
);


create table ProductList (
    product_id int primary key identity (1, 1),
    car_id INT,
    seller_id INT,
    price DECIMAL(10, 2),
    quantity INT,
    FOREIGN KEY (car_id) REFERENCES Cars(car_id),
    FOREIGN KEY (seller_id) REFERENCES Sellers(seller_id)
);


create table ManufacturingCountries (
    country_id INT PRIMARY KEY,
    country_name VARCHAR(255)
);


create table FuelTypes (
    fuel_type_id INT PRIMARY KEY,
    fuel_type VARCHAR(255)
);


create table BodyTypes (
    body_type_id INT PRIMARY KEY,
    body_type VARCHAR(255)
);


create table Colors (
    color_id INT PRIMARY KEY,
    color_name VARCHAR(255)
);

create table Sellers (
    seller_id INT PRIMARY KEY,
    user_id INT,
    company_name VARCHAR(255),
    contact_number VARCHAR(20),
    country_id INT,
    rating DECIMAL(3, 2),
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (country_id) REFERENCES ManufacturingCountries(country_id)
);

INSERT INTO FuelTypes (fuel_type_id, fuel_type)
VALUES
    (1, 'Бензин'),
    (2, 'Дизель'),
    (3, 'Электричество');

INSERT INTO BodyTypes (body_type_id, body_type)
VALUES
    (1, 'SUV'),
    (2, 'Седан'),
    (3, 'Хэтчбек');

INSERT INTO Colors (color_id, color_name)
VALUES
    (1, 'Красный'),
    (2, 'Синий'),
    (3, 'Черный');

INSERT INTO ManufacturingCountries (country_id, country_name)
VALUES
    (1, 'США'),
    (2, 'Германия'),
    (3, 'Япония');

INSERT INTO Sellers (seller_id, user_id, company_name, contact_number, country_id, rating)
VALUES
    (1, 1, 'AutoTrade', '+123456789', 1, 4.5),
    (2, 2, 'CarSales', '+987654321', 2, 4.2);

INSERT INTO Users (user_id, username, password, email)
VALUES
    (1, 'JohnDoe', 'password123', 'john@example.com'),
    (2, 'JaneSmith', 'securepass', 'jane@example.com');

INSERT INTO Cars (car_id, brand, model, year, fuel_type_id, body_type_id, color_id, image_link)
VALUES
    (1, 'Chevrolet', 'Equinox', 2020, 1, 1, 1, 'link_to_image1'),
    (2, 'Volkswagen', 'Passat', 2019, 2, 2, 2, 'link_to_image2');


INSERT INTO ProductList (product_id, car_id, seller_id, price, quantity)
VALUES
    (1, 1, 1, 25000.00, 5),
    (2, 2, 2, 30000.00, 3)
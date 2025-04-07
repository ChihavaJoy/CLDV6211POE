USE master
CREATE DATABASE EventEaseDB

USE EventEaseDB

CREATE TABLE Venue (
	VenueID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	VenueName VARCHAR (250) NOT NULL,
	Location VARCHAR (250) NOT NULL,
	Capacity INT NOT NULL,
	ImageURL VARCHAR (250) NOT NULL
);

CREATE TABLE Booking (
	BookingID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	EventID INT FOREIGN KEY (EventID) REFERENCES Event(EventID),
	VenueID INT FOREIGN KEY (VenueID) REFERENCES Venue(VenueID),
	BookingDate DATE
);

CREATE TABLE Event (
	EventID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	EventName VARCHAR (250) NOT NULL,
	EventDate DATE,
	Description VARCHAR (250) NOT NULL,
	VenueID INT FOREIGN KEY (VenueID) REFERENCES Venue(VenueID)
);

INSERT INTO Venue (VenueName, [Location], Capacity, ImageURL)
VALUES ('Menlyn','Pretoria',800,'Menlyn.jpg')

SELECT * FROM Venue

INSERT INTO Event (EventName, EventDate, Description, VenueID)
VALUES ('TED TALK','2025-03-21','TED Talk on pyschology',1)

SELECT * FROM Event

INSERT INTO Booking (EventID, VenueID, BookingDate)
VALUES (1,1,'2025-03-21')

SELECT * FROM Booking
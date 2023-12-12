create table account (
	accountID char(10) primary key,
	UserName nvarchar(30)not null,
	UserPassword nvarchar(15)not null,
	UserRole varchar(30)not null
	)
CREATE TABLE Book (
    BookID INT PRIMARY KEY,
    Title VARCHAR(255),
    Author VARCHAR(50),
    Genre VARCHAR(50),
);
CREATE TABLE Member (
    MemberID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Address VARCHAR(255),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(15),
);
create table BookReviews(
	ListID int ,
	MemberID int ,
	BookID int ,
	Rating char(10),
	Comments nvarchar(200),
	PRIMARY KEY (ListID),
    CONSTRAINT FK_B_M FOREIGN KEY (MemberID)
    REFERENCES Member(MemberID),
	CONSTRAINT FK_B_B FOREIGN KEY (BookID)
    REFERENCES Book(BookID)
);
CREATE TABLE Loan (
    LoanID INT,
    MemberID INT,
    BookID INT,
    LoanDate DATE,
    ReturnDate DATE,
	PRIMARY KEY (LoanID),
    CONSTRAINT FK_L_M FOREIGN KEY (MemberID)
    REFERENCES Member(MemberID),
	CONSTRAINT FK_L_B FOREIGN KEY (BookID)
    REFERENCES Book(BookID)
);

INSERT INTO Book (BookID, Title, Author, Genre)
VALUES
    (1, 'The Great Gatsby', 'F. Scott Fitzgerald', 'Classic'),
    (2, 'To Kill a Mockingbird', 'Harper Lee', 'Fiction'),
    (3, '1984', 'George Orwell', 'Dystopian'),
    (4, 'The Catcher in the Rye', 'J.D. Salinger', 'Coming of Age'),
    (5, 'Pride and Prejudice', 'Jane Austen', 'Romance');

INSERT INTO Member (MemberID, FirstName, LastName, Address, Email, PhoneNumber)
VALUES
    (1, 'John', 'Doe', '123 Main St', 'john.doe@email.com', '123-456-7890'),
    (2, 'Jane', 'Smith', '456 Oak St', 'jane.smith@email.com', '987-654-3210'),
    (3, 'David', 'Johnson', '789 Pine St', 'david.johnson@email.com', '111-222-3333'),
    (4, 'Emily', 'Brown', '101 Cedar St', 'emily.brown@email.com', '444-555-6666'),
    (5, 'Michael', 'Jones', '202 Elm St', 'michael.jones@email.com', '777-888-9999');

INSERT INTO BookReviews (ListID, MemberID, BookID, Rating, Comments)
VALUES
    (1, 1, 1, '5 stars', 'Great book!'),
    (2, 2, 2, '4 stars', 'Enjoyed the plot'),
    (3, 3, 3, '5 stars', 'Thought-provoking'),
    (4, 4, 4, '3 stars', 'Interesting characters'),
    (5, 5, 5, '4 stars', 'Classic romance');

INSERT INTO Loan (LoanID, MemberID, BookID, LoanDate, ReturnDate)
VALUES
    (1, 1, 1, '2023-01-01', '2023-01-15'),
    (2, 2, 2, '2023-02-05', '2023-02-20'),
    (3, 3, 3, '2023-03-10', '2023-03-25'),
    (4, 4, 4, '2023-04-15', '2023-04-30'),
    (5, 5, 5, '2023-05-20', '2023-06-05');

INSERT INTO account (accountID, UserName, UserPassword, UserRole)
VALUES 
('1','admin','admin','admin'),
('2','user','user','user');
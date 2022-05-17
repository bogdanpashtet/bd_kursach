-- БД
USE master;
GO
CREATE DATABASE RZ_db
ON
( NAME = RZ_dat,
    FILENAME = 'C:\MSSQL\DATA\RZ_dat.mdf',
    SIZE = 5MB,
    MAXSIZE = 10MB,
    FILEGROWTH = 20% )
LOG ON
( NAME = RZ_log,
    FILENAME = 'C:\MSSQL\DATA\RZ_log.ldf',
    SIZE = 2MB,
    MAXSIZE = 5MB,
    FILEGROWTH = 1MB );
GO

-- ТАБЛИЦЫ
USE RZ_db;
GO
CREATE TABLE Seller(
    id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    FIO NVARCHAR(100) NOT NULL,
    email NVARCHAR(50) NOT NULL,
    card_number NVARCHAR(16) NOT NULL,
    login NVARCHAR(50) NOT NULL,
    password NVARCHAR(50) NOT NULL,
    phone_number NVARCHAR(12) NOT NULL,
    count_of_products NVARCHAR(50) NOT NULL,
    rating FLOAT,
    status INT DEFAULT 0
);
GO
CREATE TABLE Client (
    id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    FIO NVARCHAR(100) NOT NULL,
    email NVARCHAR(50) NOT NULL,
    card_number NVARCHAR(16) NOT NULL,
    login NVARCHAR(50) NOT NULL,
    password NVARCHAR(50) NOT NULL,
    phone_number NVARCHAR(12) NOT NULL,
);
GO
CREATE TABLE Product (
    id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    name NVARCHAR(50) NOT NULL,
    price DECIMAL NOT NULL,
    category NVARCHAR(50) NOT NULL,
    seller_id INT NOT NULL REFERENCES Seller(id) ON DELETE CASCADE  ON UPDATE CASCADE,
    popularity INT
);
GO
CREATE TABLE Rating (
    id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    rate INT,
    client_id INT NOT NULL REFERENCES Client(id) ON DELETE CASCADE  ON UPDATE CASCADE,
    seller_id INT NOT NULL REFERENCES Seller(id) ON DELETE CASCADE  ON UPDATE CASCADE,
);
GO
CREATE TABLE Complaint (
    id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    seller_id INT NOT NULL REFERENCES Seller(id) ON DELETE CASCADE  ON UPDATE CASCADE,
    complaint_text NVARCHAR NOT NULL,
);
GO
CREATE TABLE Staff (
    id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    FIO NVARCHAR(100) NOT NULL,
    email NVARCHAR(50) NOT NULL,
    login NVARCHAR(50) NOT NULL,
    password NVARCHAR(50) NOT NULL,
    occupation NVARCHAR(50) NOT NULL
);
GO
CREATE TABLE _transaction (
    ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    seller_id INT NOT NULL REFERENCES Seller(id) ON DELETE NO ACTION  ON UPDATE NO ACTION,
    client_id INT NOT NULL REFERENCES Client(id) ON DELETE NO ACTION  ON UPDATE NO ACTION,
    product_id INT NOT NULL REFERENCES Product(id) ON DELETE NO ACTION  ON UPDATE NO ACTION,
    date_of_end DATE NOT NULL
);

-- ПРОЦЕДУРЫ
USE RZ_db;
GO

-- STAFF
CREATE PROCEDURE NEW_STAFF(@FIO VARCHAR(100),
                            @MAIL VARCHAR(50),
                            @LOGIN VARCHAR(50),
                            @PASSWORD VARCHAR(50),
                            @occupation VARCHAR(50))
    AS
    BEGIN
        INSERT INTO Staff
        (FIO, email, login, password, occupation)
        VALUES
        (@FIO, @MAIL, @LOGIN, @PASSWORD, @occupation)
    END
GO

CREATE PROCEDURE DELETE_STAFF (@id INT)
    AS
    DELETE FROM Staff
    WHERE @id = Staff.id
GO

-- PRODUCT
CREATE PROCEDURE NEW_PRODUCT(@NAME VARCHAR(100),
                            @PRICE DECIMAL,
                            @CATEGORY VARCHAR(50),
                            @SELLER_ID INT)
    AS
    BEGIN
        INSERT INTO Product
        (NAME, PRICE, CATEGORY, SELLER_ID)
        VALUES
        (@NAME, @PRICE, @CATEGORY, @SELLER_ID)
    END
GO

CREATE PROCEDURE DELETE_PRODUCT (@id INT)
    AS
    DELETE FROM Product
    WHERE @id = Product.id
GO

-- CLIENT
CREATE PROCEDURE NEW_CLIENT(@FIO VARCHAR(100),
                            @MAIL VARCHAR(50),
                            @PHONE_NUMBER VARCHAR(50),
                            @CARD_NUMBER VARCHAR(50),
                            @LOGIN VARCHAR(50),
                            @PASSWORD VARCHAR(50))
    AS
    BEGIN
        INSERT INTO Client
        (FIO, email, card_number, login, password, phone_number)
        VALUES
        (@FIO, @MAIL, @CARD_NUMBER, @LOGIN, @PASSWORD, @PHONE_NUMBER)
    END
GO

CREATE PROCEDURE DELETE_CLIENT (@id INT)
    AS
    DELETE FROM Client
    WHERE @id = Client.id
GO

-- SELLER
CREATE PROCEDURE NEW_SELLER(@FIO VARCHAR(100),
                            @MAIL VARCHAR(50),
                            @PHONE_NUMBER VARCHAR(50),
                            @CARD_NUMBER VARCHAR(50),
                            @LOGIN VARCHAR(50),
                            @PASSWORD VARCHAR(50))
    AS
    BEGIN
        INSERT INTO Seller
        (FIO, email, phone_number, card_number, login, password, count_of_products, rating)
        VALUES
        (@FIO, @MAIL, @PHONE_NUMBER, @CARD_NUMBER, @LOGIN, @PASSWORD, 0, 0)
    END
GO

CREATE PROCEDURE DELETE_SELLER (@id INT)
    AS
    DELETE FROM Seller
    WHERE @id = Seller.id
GO

CREATE PROCEDURE CHANGE_STATUS (@id INT)
    AS
    BEGIN
        IF (SELECT status FROM Seller WHERE id = @ID) = 0
            UPDATE Seller SET status = 1 WHERE id = @id
        ELSE
            UPDATE Seller SET status = 0 WHERE id = @id
    END
GO

-- COMPLAINT
CREATE PROCEDURE NEW_COMPLAINT(@ID INT,
                                @TEXT varchar(max))
    AS
    BEGIN
        INSERT INTO Complaint
        (SELLER_ID, COMPLAINT_TEXT)
        VALUES
        (@ID, @TEXT)
    END
GO

-- RATING
CREATE PROCEDURE NEW_RATING(@RATE SMALLINT,
                                @CL_ID INT,
                                @SL_ID INT)
    AS
    BEGIN
        INSERT INTO Rating
        (RATE, CLIENT_ID, SELLER_ID)
        VALUES
        (@RATE, @CL_ID, @SL_ID)
    END
GO

CREATE PROCEDURE ALTER_RATING(@RATE SMALLINT,
                              @CL_ID INT,
                              @SL_ID INT)
AS
BEGIN
    UPDATE Rating
        SET RATE = @RATE
    WHERE client_id = @CL_ID AND seller_id = @SL_ID
END
GO

-- ТРАНЗАКЦИЯ
CREATE PROCEDURE NEW_TRANSACTION(@CL_ID INT,
                                @PR_ID INT)
    AS
    BEGIN
        INSERT INTO _transaction
        (SELLER_ID, CLIENT_ID, PRODUCT_ID, DATE_OF_END)
        VALUES
        ((SELECT seller_id FROM Product WHERE id = @PR_ID), @CL_ID, @PR_ID, CURRENT_TIMESTAMP)
    END
GO


-- ПРЕДСТАВЛЕНИЯ

-- ПРЕДСТАВЛЕНИЕ ТОВАРОВ КУПЛИ-ПРОДАЖИ
CREATE VIEW t_ction AS
    SELECT
            T.seller_id,
            S.FIO AS "Имя продавца",
            C.id AS "ID клиента",
            C.FIO AS "Имя клиента",
            T.product_id,
            P.name AS "Товар",
            P.price AS "Цена",
            T.date_of_end AS "Время транзакции"
    FROM _transaction T
        INNER JOIN Seller S ON T.seller_id = S.id
        INNER JOIN Client C on T.client_id = C.id
        INNER JOIN Product P ON T.product_id = P.id

-- ПРЕДСТАВЛЕНИЕ ТОВАРОВ ДЛЯ ПОКУПАТЕЛЯ
CREATE VIEW prod_for_client AS
    SELECT
            P.id AS "ID товара",
            P.name AS "Название",
            P.category AS "Категория",
            S.FIO AS "Имя продавца",
            P.seller_id AS "id продавца",
            P.price AS "Цена",
            P.popularity AS "Популярность"
    FROM Product P
        INNER JOIN Seller S ON P.seller_id = S.id
    WHERE S.status = 0


-- СКАЛЯРНЫЕ ФУНКЦИИ

-- ВЫРУЧКА ПРОДАВЦА
GO
CREATE FUNCTION summary_cost_of_contracts(@id INT)
RETURNS INT AS
BEGIN
    DECLARE @cost INT;
    SELECT @cost = 0.95*SUM("Цена") FROM t_ction
    WHERE seller_id = @id;
    RETURN @cost
END;
GO

-- ВЫРУЧКА САЙТА
CREATE FUNCTION summary_cost_of_ANALYTIX()
RETURNS INT AS
BEGIN
    DECLARE @cost INT;
    SELECT @cost = 0.05*SUM("Цена") FROM t_ction
    RETURN @cost
END;
GO

-- ПОПУЛЯРНОСТЬ ТОВАРА
CREATE FUNCTION POPULARITY(@id INT)
RETURNS INT AS
BEGIN
    DECLARE @count INT;
    SELECT @count = COUNT(product_id) FROM _transaction
    WHERE product_id = @id;
    RETURN @count
END;

-- РЕЙТИНГ ПРОДАВЦА
CREATE FUNCTION RATE_SELLER(@id INT)
RETURNS INT AS
BEGIN
    DECLARE @rating FLOAT;
    SELECT @rating = SUM(rate)/COUNT(rate) FROM Rating
    WHERE seller_id = @id;
    RETURN @rating
END;
GO

-- КОЛИЧЕСТВО ТОВАРОВ ПРОДАВЦА
CREATE FUNCTION COUNT_OF_PRODUCTS(@id INT)
RETURNS INT AS
BEGIN
    DECLARE @count INT;
    SELECT @count = COUNT(seller_id) FROM Product
    WHERE seller_id = @id;
    RETURN @count
END;
GO

-- TRIGGERS

-- ОБНОВИТЬ КОЛИЧЕСТВО ТОВАРОВ ПРОДАВЦА
CREATE TRIGGER COUNT_OF_SELLERS_PRODUCT
    ON Product
    AFTER INSERT, UPDATE, DELETE
    AS
    UPDATE Seller
        SET count_of_products = COUNT_OF_PRODUCTS(id)
    WHERE id = (SELECT seller_id FROM inserted)
GO

-- ОБНОВИТЬ РЕЙТИНГ ПРОДАВЦА
CREATE TRIGGER UPDATE_RATING
    ON Rating
    AFTER INSERT, UPDATE
    AS
    UPDATE Seller
        SET rating = RATE_SELLER(id)
    WHERE id = (SELECT seller_id FROM inserted)
GO

-- ПОПУЛЯРНОСТЬ ТОВАРА
CREATE TRIGGER UPDATE_RATING
    ON _transaction
    AFTER INSERT, UPDATE
    AS
    UPDATE Product
        SET popularity = POPULARITY (id)
    WHERE id = (SELECT product_id FROM inserted)
GO

-- ТАБЛИЧНЫЕ ФУНКЦИИ

-- СОРТИРОВКА ТОВАРОВ ПО КАТЕГОРИИ
CREATE FUNCTION FIND_SELLER_PRODUCTS(@ID INT)
    RETURNS TABLE
    AS
    RETURN
        (SELECT id AS "id товара",
                NAME AS "Наименование товара",
                PRICE AS "Цена товара",
                CATEGORY AS "Категория товара",
                popularity as "Популярность"
        FROM Product
            WHERE seller_id = @id)
GO

-- ПРОДАЖИ ТОВАРОВ ПРОДАВЦА
CREATE FUNCTION FIND_SELLER_TRANSACTION(@ID INT)
    RETURNS TABLE
    AS
    RETURN
        (SELECT
                product_id AS "ID товара",
                "Имя продавца",
                "Имя клиента",
                "Товар",
                "Цена",
                "Время транзакции"
        FROM t_ction
            WHERE seller_id = @id)
GO

-- ЖАЛОБЫ НА ПРОДАВЦА
CREATE FUNCTION FIND_SELLER_COMPLAINT(@ID INT)
    RETURNS TABLE
    AS
    RETURN
        (SELECT complaint_text as "Жалоба"
        FROM Complaint
            WHERE seller_id = @id)
GO

-- ПОКУПКИ КЛИЕНИА
CREATE FUNCTION FIND_CLIENT_CART(@ID INT)
    RETURNS TABLE
    AS
    RETURN
        (SELECT *
        FROM t_ction
            WHERE "ID клиента" = @id)
GO

-- CLR
USE MASTER;
EXEC sp_configure 'clr enabled', 1
RECONFIGURE
USE RZ_db;
GO
ALTER DATABASE RZ_db SET TRUSTWORTHY ON
GO
CREATE ASSEMBLY lib1 FROM
'C:\Users\rusla\source\repos\ClassLibrary2\obj\Debug\ClassLibrary2.dll'
WITH PERMISSION_SET = UNSAFE;
GO
CREATE FUNCTION CheckEmail(@inp NVARCHAR(50))
	RETURNS INT
	AS
	EXTERNAL NAME Lib1.[ClassLibrary2.Class1].CheckEmail
	GO

USE RZ_db
go
SELECT dbo.CheckEmail('sdsdf@sdv.ru')
go
SELECT dbo.CheckEmail('sdsdfsdv.ru')
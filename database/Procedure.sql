
-- Shows all the Products form our Store
SELECT * FROM Product;

-- Selects All Cat Product
SELECT * FROM Product
WHERE pettype_id = "pettype_00";

--Show All Dog Products
SELECT * FROM Product
WHERE pettype_id = "pettype_01";


/***************** All Products Sort ********************/

--Sort All Product Price Lowest to Highest
SELECT * FROM Product
ORDER BY price ASC;

--Sort All Product Price Highest to Lowest
SELECT * FROM Product
ORDER BY price DESC;


--Sort All Product Name A to Z
SELECT * FROM Product
ORDER BY name ASC;

--Sort All Product Name Z to A
SELECT * FROM Product
ORDER BY name DESC;


/***************** Cat Food Products Sort ********************/

--Sort All Cat Food Product Price Lowest to Highest
SELECT * FROM Product 
WHERE pettype_id = "pettype_00"
ORDER BY price ASC;

/*Sort ALL Cat Food Product Price Highest to Lowest*/
SELECT * FROM Product
WHERE pettype_id = "pettype_00"
ORDER BY price DESC;

-- Sort All Cat Food Product Name A to Z
SELECT * FROM Product
WHERE pettype_id = "pettype_00"
ORDER BY name ASC;

-- Sort All Cat Food Product Name Z to A
SELECT * FROM Product
WHERE pettype_id = "pettype_00"
ORDER BY name DESC;


-- Sort Wet Cat Food Product Price Lowest to Highest
SELECT * FROM Product 
WHERE pettype_id = "pettype_00"
AND foodtype_id = "foodtype_00"
ORDER BY price ASC;

-- Sort Dry Cat Food Product Price Lowest to Highest
SELECT * FROM Product 
WHERE pettype_id = "pettype_00"
AND foodtype_id = "foodtype_01"
ORDER BY price ASC;

-- Sort Treats Cat Food Product Price Lowest to Highest
SELECT * FROM Product 
WHERE pettype_id = "pettype_00"
AND foodtype_id = "foodtype_02"
ORDER BY price ASC;

-- Sort Wet Cat Food Product Price Highest to Lowest
SELECT * FROM Product 
WHERE pettype_id = "pettype_00"
AND foodtype_id = "foodtype_00"
ORDER BY price DESC;

-- Sort Dry Cat Food Product Price Highest to Lowest
SELECT * FROM Product 
WHERE pettype_id = "pettype_00"
AND foodtype_id = "foodtype_01"
ORDER BY price DESC;

-- Sort Treats Cat Food Product Price Highest to Lowest*/
SELECT * FROM Product 
WHERE pettype_id = "pettype_00"
AND foodtype_id = "foodtype_02"
ORDER BY price DESC;

-- Sort ALL Dog Food Product Price Lowest To Highest
SELECT * FROM Product 
WHERE pettype_id = "pettype_01"
ORDER BY price ASC;


/***************** Dog Food Products Sort ********************/


-- Sort ALL Dog Food Product Price Highest to Lowest
SELECT * FROM Product
WHERE pettype_id = "pettype_01"
ORDER BY price DESC;


-- Sort All Cat Food Product Name A to Z
SELECT * FROM Product
WHERE pettype_id = "pettype_00"
ORDER BY name ASC;

-- Sort All Cat Food Product Name Z to A
SELECT * FROM Product
WHERE pettype_id = "pettype_00"
ORDER BY name DESC;

-- Sort Wet Dog Food Product Price Lowest to Highest
SELECT * FROM Product 
WHERE pettype_id = "pettype_01"
AND foodtype_id = "foodtype_00"
ORDER BY price ASC;

-- Sort Dry Dog Food Product Price Lowest to Highest
SELECT * FROM Product 
WHERE pettype_id = "pettype_01"
AND foodtype_id = "foodtype_01"
ORDER BY price ASC;

-- Sort Treats Dog Food Product Price Lowest to Highest
SELECT * FROM Product 
WHERE pettype_id = "pettype_01"
AND foodtype_id = "foodtype_02"
ORDER BY price ASC;

-- Sort Wet Dog Food Product Price Highest to Lowest
SELECT * FROM Product 
WHERE pettype_id = "pettype_01"
AND foodtype_id = "foodtype_00"
ORDER BY price DESC;

-- Sort Dry Dog Food Product Price Highest to Lowest
SELECT * FROM Product 
WHERE pettype_id = "pettype_01"
AND foodtype_id = "foodtype_01"
ORDER BY price DESC;

-- Sort Treats Dog Food Product Price Highest to Lowest
SELECT * FROM Product 
WHERE pettype_id = "pettype_01"
AND foodtype_id = "foodtype_02"
ORDER BY price DESC;

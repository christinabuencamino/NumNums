/***************** PetData Pet Food Pref ********************/



/* All Products based on PetData pet type*/
SELECT * FROM Product
INNER JOIN PetData
WHERE Product.ptype_id = PetData.ptype_id



/* All Products based on PetData pet type and food preference */
SELECT * FROM Product
INNER JOIN PetData
WHERE Product.ptype_id = PetData.ptype_id
AND Product.food_id = PetData.food_pref;



/***************** All Food Products SEARCH ********************/

/*Show All Products*/
SELECT * FROM Product;

/*Show All Cat Products*/
SELECT * FROM Product
WHERE ptype_id = "ptype_0000";

/*Show All Dog Products*/
SELECT * FROM Product
WHERE ptype_id = "ptype_0001";


/***************** All Food Products Sort ********************/

/*Sort All Product Price Lowest to Highest*/
SELECT * FROM Product
ORDER BY @food_price ASC;

/*Sort All Product Price Highest to Lowest*/
SELECT * FROM Product
ORDER BY food_price DESC;

/*Sort All Product Name A to Z*/
SELECT * FROM Product
ORDER BY prod_name ASC;

/*Sort All Product Name Z to A*/
SELECT * FROM Product
ORDER BY prod_name DESC;


/***************** Cat Food Products Sort ********************/

/*Sort All Cat Food Product Price Lowest to Highest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0000"
ORDER BY food_price ASC;

/*Sort ALL Cat Food Product Price Highest to Lowest*/
SELECT * FROM Product
WHERE ptype_id = "ptype_0000"
ORDER BY food_price DESC;


/*Sort All Cat Food Product Name A to Z*/
SELECT * FROM Product
WHERE ptype_id = "ptype_0000"
ORDER BY prod_name ASC;

/*Sort All Cat Food Product Name Z to A*/
SELECT * FROM Product
WHERE ptype_id = "ptype_0000"
ORDER BY prod_name DESC;


/*Sort Wet Cat Food Product Price Lowest to Highest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0000"
AND food_type = "food__0000"
ORDER BY food_price ASC;

/*Sort Dry Cat Food Product Price Lowest to Highest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0000"
AND food_type = "food__0001"
ORDER BY food_price ASC;

/*Sort Treats Cat Food Product Price Lowest to Highest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0000"
AND food_type = "food_0002"
ORDER BY food_price ASC;

/*Sort Wet Cat Food Product Price Highest to Lowest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0000"
AND food_type = "food__0000"
ORDER BY food_price DESC;

/*Sort Dry Cat Food Product Price Highest to Lowest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0000"
AND food_type = "food__0001"
ORDER BY food_price DESC;

/*Sort Treats Cat Food Product Price Highest to Lowest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0000"
AND food_type = "food_0002"
ORDER BY food_price DESC;


/***************** Dog Food Products Sort ********************/

/*Sort ALL Dog Food Product Price Highest to Lowest**/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0001"
ORDER BY food_price ASC;

/*Sort ALL Dog Food Product Price Highest to Lowest*/
SELECT * FROM Product
WHERE ptype_id = "ptype_0001"
ORDER BY food_price DESC;


/*Sort All Cat Food Product Name A to Z*/
SELECT * FROM Product
WHERE ptype_id = "ptype_0000"
ORDER BY prod_name ASC;

/*Sort All Cat Food Product Name Z to A*/
SELECT * FROM Product
WHERE ptype_id = "ptype_0000"
ORDER BY prod_name DESC;



/*Sort Wet Dog Food Product Price Lowest to Highest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0001"
AND food_type = "food__0000"
ORDER BY food_price ASC;

/*Sort Dry Dog Food Product Price Lowest to Highest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0001"
AND food_type = "food__0001"
ORDER BY food_price ASC;

/*Sort Treats Dog Food Product Price Lowest to Highest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0001"
AND food_type = "food_0002"
ORDER BY food_price ASC;

/*Sort Wet Dog Food Product Price Highest to Lowest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0001"
AND food_type = "food__0000"
ORDER BY food_price DESC;

/*Sort Dry Dog Food Product Price Highest to Lowest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0001"
AND food_type = "food__0001"
ORDER BY food_price DESC;

/*Sort Treats Dog Food Product Price Highest to Lowest*/
SELECT * FROM Product 
WHERE ptype_id = "ptype_0001"
AND food_type = "food_0002"
ORDER BY food_price DESC;
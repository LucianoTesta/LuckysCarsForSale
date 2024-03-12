SELECT 
    c.CarYear, 
    c.Make, 
    c.Model, 
    c.Submodel, 
    c.CarZipCode AS CarLocation,
    b.BuyerName AS CurrentBuyerName, 
    q.Amount AS CurrentQuote, 
    s.StatusName AS CurrentStatus, 
    sh.StatusDate
FROM 
    Cars c
LEFT JOIN 
    Quotes q ON c.CarId = q.CarId AND q.IsCurrent = 1
LEFT JOIN 
    Buyers b ON q.BuyerId = b.BuyerId
LEFT JOIN 
    StatusHistory sh ON c.CarId = sh.CarId
LEFT JOIN 
    Statuses s ON sh.StatusId = s.StatusId
WHERE 
    sh.StatusDate = (SELECT MAX(StatusDate) FROM StatusHistory WHERE CarId = c.CarId);
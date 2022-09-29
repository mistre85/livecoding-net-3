--6- Selezionare tutti gli id dei voli che hanno almeno un passeggero il cui cognome inizia con 'L' (966)
SELECT DISTINCT flight_passenger.flight_id
FROM flight_passenger
INNER JOIN passengers ON flight_passenger.passenger_id = passengers.id
WHERE passengers.name LIKE 'L%'
--Part 1
SELECT *
FROM jobs;

--Part 2
SELECT * FROM techjobs.employers WHERE Location = 'St. Louis City';


--Part 3

SELECT name, description 
FROM skills WHERE id IN (SELECT skillid FROM jobskills) ORDER BY name;